using Datos.Contexto;
using Entidades.Modelo;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Threading.Tasks;

namespace Negocios.Managers
{
    public class ConsecutivosMg
    {
        private readonly DbContextHd _context;
        //private readonly string _errorBase;
        private NpgsqlConnection _coneccion;

        public ConsecutivosMg(DbContextHd context)
        {
            _context = context;
            _coneccion = (NpgsqlConnection)_context.Database.GetDbConnection();
            _coneccion.Open();
        }

        public async Task<int> TraerConsecutivo(int tipo)
        {
            try
            {
                int consec;
                var modelo = await _context.ConsecutivoHds.FirstOrDefaultAsync(x => x.consecutivo_hd_id == tipo);                
                if (modelo == null)
                {
                    ConsecutivoHd consecutivohd = new ConsecutivoHd
                    {
                        consecutivo_hd_id = tipo,
                        consecutivo = 1
                    };

                    _context.ConsecutivoHds.Add(consecutivohd);
                    await _context.SaveChangesAsync();
                    return 1;

                }
                else
                {
                    bool buscar = true;
                    int regreso = 0;
                    consec = modelo.consecutivo;
                    int veces = 0;


                    while (buscar)
                    {
                        regreso = await ConsecutivoNew(tipo, consec);
                        if (regreso > 0)
                        {
                            buscar = false;
                        }
                        else
                        {
                            //consec = await TraerConsecutivo(tipo);
                            var reg = await _context.ConsecutivoHds.FirstOrDefaultAsync(x => x.consecutivo_hd_id == tipo);
                            consec = reg.consecutivo;
                        }
                        veces++;
                        if (veces > 100)
                        {
                            throw new Exception("La búsqueda de consecutivo en la función TraerConsecutivo excedio las 100 veces");
                        }
                    }
                    return regreso;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        private async Task<int> ConsecutivoNew(int tipo, int consec)
        {
            try
            {
                int consecutivo = consec + 1;
                string strCmd = @"UPDATE consecutivo_hd
                                    SET consecutivo = @Consecutivo 
                                    WHERE ( consecutivo_hd_id = @IdConsecutivo ) AND
                                          ( consecutivo       = @consecutivoanterior );";

                NpgsqlCommand miComando = new NpgsqlCommand(strCmd, _coneccion);

                miComando.Parameters.Add("@Consecutivo", NpgsqlTypes.NpgsqlDbType.Integer).Value = consecutivo;
                miComando.Parameters.Add("@consecutivoanterior", NpgsqlTypes.NpgsqlDbType.Integer).Value = consec;
                miComando.Parameters.Add("@IdConsecutivo", NpgsqlTypes.NpgsqlDbType.Integer).Value = tipo;

                long filaSavectadas = await miComando.ExecuteNonQueryAsync();

                if (filaSavectadas != 1)
                {
                    consecutivo = 0;
                }
                return consecutivo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

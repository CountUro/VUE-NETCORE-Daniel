using Entidades.Modelo;

using Negocios.Extensiones;
using Negocios.Funciones;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Negocios.Managers
{
    public class CiudadMg
    {
        private NpgsqlConnection _Coneccion;
        private NpgsqlTransaction _Transaccion;
        private string _errorMsg = "";
        private bool _BDMain;
       
        public CiudadMg(NpgsqlConnection Coneccion, NpgsqlTransaction Transaccion, bool BDmain)
        {
            _Coneccion = Coneccion;
            _Transaccion = Transaccion;
            _BDMain = BDmain;
        }
        async public Task deleteRegistro(long Id)
        {
            try
            {
                string strDelete = @"DELETE FROM ciudad WHERE ( ciudadid = @ciudadid );";

                NpgsqlCommand cmdDelete = new NpgsqlCommand(strDelete, _Coneccion, _Transaccion);

                cmdDelete.Parameters.Add("@ciudadid", NpgsqlTypes.NpgsqlDbType.Bigint).Value = Id;

                long filaSavectadas = await cmdDelete.ExecuteNonQueryAsync();

                //long filaSavectadas = NpgFunciones.GetRowSavected(_Coneccion, _Transaccion);

                if (filaSavectadas != 1)
                {
                    throw new Exception("No Eliminó el Registro en la Tabla Ciudad");
                }
                return;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async public Task<bool> existeRegistro(long Id)
        {
            try
            {
                NpgsqlCommand cmd = _Coneccion.CreateCommand();
                cmd.Transaction = _Transaccion;

                cmd.CommandText = @"SELECT COUNT(1) FROM ciudad WHERE ( ciudadid = @ciudadid );";
                cmd.Parameters.Add("@ciudadid", NpgsqlTypes.NpgsqlDbType.Bigint).Value = Id;

                var registrosSel = await cmd.ExecuteScalarAsync();

                //int registro = Convert.ToInt32(registrosSel);
                int registro = Convert.ToInt32(registrosSel);

                return (registro == 0 ? false : true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async public Task<Ciudad> Find(long Id)
        {
            try
            {
                Ciudad miObjecto = new Ciudad();

                int registros = 0;

                bool existe = await existeRegistro(Id);

                if (!existe)
                {
                    miObjecto = null;
                    return miObjecto;
                }

                NpgsqlCommand cmd = _Coneccion.CreateCommand();
                cmd.Transaction = _Transaccion;

                cmd.CommandText = @"SELECT  ciudadid, 
                                            estadoid, 
                                            nombre
                                    FROM ciudad
                                    WHERE ( ciudadid = @ciudadid );";

                cmd.Parameters.Add("@ciudadid", NpgsqlTypes.NpgsqlDbType.Bigint).Value = Id;

                var rd = await cmd.ExecuteReaderAsync();
                NpgsqlDataReader DbReader = (NpgsqlDataReader)rd;


                int colciudadid = DbReader.GetOrdinal("ciudadid");
                int colestadoid = DbReader.GetOrdinal("estadoid");
                int colnombre = DbReader.GetOrdinal("nombre");


                while (DbReader.Read())
                {

                    miObjecto.ciudad_id = (int)DbReader.SafeGetLongNpg(colciudadid, 0);
                    miObjecto.estado_id = (int)DbReader.SafeGetLongNpg(colestadoid, 0);
                    miObjecto.nombre = DbReader.SafeGetStringNpg(colnombre);

                    registros++;
                }

                DbReader.Close();

                if (registros == 0) miObjecto = null;

                return miObjecto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async public Task<Ciudad> Save(Ciudad miObjeto)
        {
            try
            {

                bool dataOk = CkeckData(ref miObjeto);

                if (!dataOk)
                {
                    throw new Exception(_errorMsg);
                }

                if (miObjeto.ciudad_id == 0)
                {
                    miObjeto = await InsertRecord(miObjeto);
                }
                else
                {
                    bool existeRecord = await existeRegistro(miObjeto.ciudad_id);

                    if (existeRecord)
                    {
                        miObjeto = await UpdateRecord(miObjeto);
                    }
                    else
                    {
                        miObjeto = await InsertRecord(miObjeto);
                    }

                }

                return miObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool CkeckData(ref Ciudad miObjeto)
        {

            bool regreso = true;

            if (miObjeto.estado_id == 0)
            {
                _errorMsg = "No Tiene valor la propiedad ESTADOID";
                return false;
            }

            if (miObjeto.nombre.EsNulaOVacia())
            {
                _errorMsg = "No Tiene valor La Propiedad nombre";
                return false;
            }

            return regreso;
        }

        async private Task<Ciudad> InsertRecord(Ciudad miObjeto)
        {
            try
            {
                long filaSavectadas;

                if (_BDMain)
                {
                    string strCmd = @"INSERT INTO ciudad
                                       (estadoid, 
                                        nombre)
                                VALUES (@estadoid, 
                                        @nombre);";

                    NpgsqlCommand miComando = new NpgsqlCommand(strCmd, _Coneccion, _Transaccion);

                    miComando.Parameters.Add("@estadoid", NpgsqlTypes.NpgsqlDbType.Bigint).Value = miObjeto.estado_id;
                    miComando.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar).Value = miObjeto.nombre;

                    filaSavectadas = await miComando.ExecuteNonQueryAsync();


                }
                else
                {
                    string strCmd = @"INSERT INTO ciudad
                                       (ciudadid,
                                        estadoid, 
                                        nombre)
                                VALUES (@ciudadid,
                                        @estadoid, 
                                        @nombre);";

                    NpgsqlCommand miComando = new NpgsqlCommand(strCmd, _Coneccion, _Transaccion);

                    miComando.Parameters.Add("@ciudadid", NpgsqlTypes.NpgsqlDbType.Bigint).Value = miObjeto.ciudad_id;
                    miComando.Parameters.Add("@estadoid", NpgsqlTypes.NpgsqlDbType.Bigint).Value = miObjeto.estado_id;
                    miComando.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar).Value = miObjeto.nombre;

                    filaSavectadas = await miComando.ExecuteNonQueryAsync();

                }


                if (filaSavectadas != 1)
                {
                    throw new Exception("No Inserto el Registro en la tabla Ciudad");
                }

                if (_BDMain) miObjeto.ciudad_id = NpgFunciones.GetSecuencia(_Coneccion, _Transaccion, "ciudad_ciudadid_seq");

                return miObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        async private Task<Ciudad> UpdateRecord(Ciudad miObjeto)
        {
            try
            {
                string strCmd = @"UPDATE ciudad
                                    SET estadoid    = @estadoid, 
                                        nombre = @nombre
                                    WHERE ( ciudadid = @ciudadid );";

                NpgsqlCommand miComando = new NpgsqlCommand(strCmd, _Coneccion, _Transaccion);

                miComando.Parameters.Add("@estadoid", NpgsqlTypes.NpgsqlDbType.Bigint).Value = miObjeto.estado_id;
                miComando.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar).Value = miObjeto.nombre;
                miComando.Parameters.Add("@ciudadid", NpgsqlTypes.NpgsqlDbType.Bigint).Value = miObjeto.ciudad_id;

                long filaSavectadas = await miComando.ExecuteNonQueryAsync();

                if (filaSavectadas != 1)
                {
                    throw new Exception("No Actualizó el Registro en la tabla Ciudad");
                }
                return miObjeto;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        async public Task<IEnumerable<Ciudad>> ListaCiudad(long estadoId)
        {

            try
            {

                NpgsqlCommand cmd = _Coneccion.CreateCommand();
                cmd.Transaction = _Transaccion;

                cmd.CommandText = @"SELECT  ciudadid, 
                                            estadoid, 
                                            nombre
                                    FROM ciudad 
                                    WHERE (estadoid = @estadoid)
                                    ORDER BY nombre ASC;";

                cmd.Parameters.Add("@estadoid", NpgsqlTypes.NpgsqlDbType.Bigint).Value = estadoId;


                var rd = await cmd.ExecuteReaderAsync();
                NpgsqlDataReader DbReader = (NpgsqlDataReader)rd;


                List<Ciudad> miLista = new List<Ciudad>();
                miLista = FuncionesJT.DataReaderMapToList<Ciudad>(DbReader);

                return miLista;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        async public Task<Direccion> FindDireccion(long ciudadid)
        {
            try
            {
                Direccion miObjecto = new Direccion();

                int registros = 0;

                NpgsqlCommand cmd = _Coneccion.CreateCommand();
                cmd.Transaction = _Transaccion;


                cmd.CommandText = @"SELECT   pais.nombre   as pais,
                                             pais.paisid        as paisid,                                               
                                             estado.nombre as estado, 
                                             estado.estadoid    as estadoid,                                                  
                                             ciudad.nombre as ciudad,
                                             ciudad.ciudadid    as ciudadid     
                                        FROM ciudad,   
                                             estado,   
                                             pais  
                                       WHERE ( estado.estadoid = ciudad.estadoid ) and  
                                             ( pais.paisid     = estado.paisid ) and  
                                             ( ( ciudad.ciudadid =  @ciudadid ) );";

                cmd.Parameters.Add("@ciudadid", NpgsqlTypes.NpgsqlDbType.Bigint).Value = ciudadid;

                var rd = await cmd.ExecuteReaderAsync();
                NpgsqlDataReader DbReader = (NpgsqlDataReader)rd;


                int colpais = DbReader.GetOrdinal("pais");
                int colpaisid = DbReader.GetOrdinal("paisid");
                int colestado = DbReader.GetOrdinal("estado");
                int colestadoid = DbReader.GetOrdinal("estadoid");
                int colciudad = DbReader.GetOrdinal("ciudad");
                int colciudadid = DbReader.GetOrdinal("ciudadid");


                while (DbReader.Read())
                {

                    miObjecto.ciudadid = (long)DbReader.SafeGetLongNpg(colciudadid, 0);
                    miObjecto.estadoid = (long)DbReader.SafeGetLongNpg(colestadoid, 0);
                    miObjecto.paisid = (long)DbReader.SafeGetLongNpg(colpaisid, 0);
                    miObjecto.ciudad = DbReader.SafeGetStringNpg(colciudad);
                    miObjecto.estado = DbReader.SafeGetStringNpg(colestado);
                    miObjecto.pais = DbReader.SafeGetStringNpg(colpais);

                    registros++;
                }

                DbReader.Close();

                if (registros == 0) miObjecto = null;

                return miObjecto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        async public Task<IEnumerable<Object>> ListaDirecciones()
        {
            try
            {
                NpgsqlCommand cmd = _Coneccion.CreateCommand();
                cmd.Transaction = _Transaccion;

                cmd.CommandText = @"SELECT   pais.nombre        as pais,
                                             pais.paisid        as paisid,                                         
                                             estado.nombre      as estado,
                                             estado.estadoid    as estadoid,                                         
                                             ciudad.nombre      as ciudad,
                                             ciudad.ciudadid    as ciudadid
                                        FROM ciudad,
                                             estado,
                                             pais
                                       WHERE ( estado.estadoid = ciudad.estadoid ) and
                                             ( pais.paisid     = estado.paisid ) 
                                        ORDER BY 1 ASC, 3 ASC, 5 ASC;";

                var rd = await cmd.ExecuteReaderAsync();

                NpgsqlDataReader DbReader;
                DbReader = (NpgsqlDataReader)rd;

                List<Direccion> miLista = new List<Direccion>();
                miLista = FuncionesJT.DataReaderMapToList<Direccion>(DbReader);

                return miLista;




            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        async public Task<ArrayList> ListaDireccionesObj()
        {
            try
            {



                NpgsqlCommand cmd = _Coneccion.CreateCommand();
                cmd.Transaction = _Transaccion;

                cmd.CommandText = @"SELECT   pais.nombre   as pais,
                                             pais.paisid        as paisid,                                         
                                             estado.nombre as estado,
                                             estado.estadoid    as estadoid,                                         
                                             ciudad.nombre as ciudad,
                                             ciudad.ciudadid    as ciudadid
                                        FROM ciudad,
                                             estado,
                                             pais
                                       WHERE ( estado.estadoid = ciudad.estadoid ) and
                                             ( pais.paisid     = estado.paisid ) 
                                        ORDER BY 1 ASC, 3 ASC, 5 ASC;";



                var rd = await cmd.ExecuteReaderAsync();

                NpgsqlDataReader DbReader;
                DbReader = (NpgsqlDataReader)rd;

                return DbReader.ToArrayList();



            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        async public Task<ArrayList> ListaDireccionFiltro(int paisid, int estadoid)
        {



            try
            {
                NpgsqlCommand cmd = _Coneccion.CreateCommand();
                cmd.Transaction = _Transaccion;

                cmd.CommandText = @"SELECT   pais.nombre        as pais,
                                             pais.paisid        as paisid,                                         
                                             estado.nombre      as estado,
                                             estado.estadoid    as estadoid,                                         
                                             ciudad.nombre      as ciudad,
                                             ciudad.ciudadid    as ciudadid
                                        FROM ciudad,
                                             estado,
                                             pais
                                       WHERE ( estado.estadoid = ciudad.estadoid ) and
                                             ( pais.paisid     = estado.paisid ) and
                                             (
                                               ( @paisid = 0 ) OR
                                               ( @paisid <> 0 AND pais.paisid = @paisid)
                                             ) AND
                                             (
                                               ( @estadoid = 0 ) OR
                                               ( @estadoid <> 0 AND estado.estadoid = @estadoid)
                                             ) 
                                        ORDER BY 1 ASC, 3 ASC, 5 ASC; ";


                cmd.Parameters.Add("@paisid", NpgsqlTypes.NpgsqlDbType.Integer).Value = paisid;
                cmd.Parameters.Add("@estadoid", NpgsqlTypes.NpgsqlDbType.Integer).Value = estadoid;


                var rd = await cmd.ExecuteReaderAsync();

                NpgsqlDataReader DbReader;
                DbReader = (NpgsqlDataReader)rd;

                return DbReader.ToArrayList();

                //List<Direccion> miLista = new List<Direccion>();
                //miLista = FuncionesJT.DataReaderMapToList<Direccion>(DbReader);

                //return miLista;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public class Direccion
        {

            public string pais { get; set; }
            public long paisid { get; set; }
            public string estado { get; set; }
            public long estadoid { get; set; }
            public string ciudad { get; set; }
            public long ciudadid { get; set; }

        }


    }
}

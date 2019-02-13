using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocios.Funciones
{
    public static class NpgFunciones
    {
        public static NpgsqlConnection CrearConeccionPostgreSql(int tipo)
        {
            string url;
            NpgsqlConnection dbconn = null;

            try
            {

                //switch (tipo)
                //{


                //    case 99:
                //        // Coneccion a la BD MedicalCenter

                //        //url = "server=localhost;port=5432;database=medicalcenter;user=postgres;password=p123"; // "DSN=medicalcenter;UID=postgres;PWD=p123";
                //        //url = "Host=myserver;Username=mylogin;Password=mypass;Database=mydatabase";
                //        url = "server=localhost;port=5432;database=medicalcenter;User Id=postgres;password=p123"; // "DSN=medicalcenter;UID=postgres;PWD=p123";
                //        break;

                //    case 0:
                //        // Coneccion a la BD Medical

                //        url = "server=localhost;port=5432;database=medical;User Id=postgres;password=p123";  //"DSN=medical;UID=postgres;PWD=p123";
                //                                                                                          // "server=127.0.0.1;port=5432;database=medical;user=postgres;password=p123";
                //        break;

                //    default:
                //        throw new Exception("No Existe este Tipo de Conección");

                //}

                url = "server=localhost;port=5432;database=pruebaef3;User Id=postgres;password=p123";

                dbconn = new NpgsqlConnection(url);
                dbconn.Open();

                //dbcmd = dbconn.CreateCommand(); 



            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex2)
            {
                throw ex2;
            }

            return dbconn;

        }

        public static NpgsqlTransaction CreaTransaccion(NpgsqlConnection dbconn)
        {
            NpgsqlTransaction miTransaccion;
            miTransaccion = dbconn.BeginTransaction();
            return miTransaccion;
        }

        public static int GetSecuencia(NpgsqlConnection coneccion, NpgsqlTransaction transaccion, string nombreSecuencia)
        {
            try
            {
                NpgsqlCommand cmd = coneccion.CreateCommand();
                cmd.Transaction = transaccion;

                cmd.CommandText = "SELECT currval('" + nombreSecuencia + "')";

                var secuenciaVar = cmd.ExecuteScalar();

                int secuenciaLong = (secuenciaVar != null ? Convert.ToInt32(secuenciaVar) : 0);

                return secuenciaLong;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static long GetRowsAfected(NpgsqlConnection coneccion, NpgsqlTransaction transaccion)
        {
            try
            {

                string sqlString = "GET DIAGNOSTICS rowcount = ROW_COUNT";

                NpgsqlCommand cmd = new NpgsqlCommand(sqlString, coneccion, transaccion);

                var ReturnVar = cmd.ExecuteScalar();

                long ReturnLong = (ReturnVar != null ? Convert.ToInt64(ReturnVar) : 0);

                return ReturnLong;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

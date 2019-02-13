using Entidades.ViewModels;
using Microsoft.AspNetCore.Http;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Negocios.Extensiones
{
     
    public enum idiomaMontoEscrito { Español, Ingles };
    public enum monedaMontoEscrito { Bs, USD, Pesos, Euros, Rec };

    public static class ExtensoresJt
    {

        static public string GetClaim(this HttpContext http, string claimName)
        {
            string claim = claimName.ToLower();
            return http.User.Claims.Where(c => c.Type.ToLower() == claim)
                                .Select(c => c.Value).SingleOrDefault();
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////        
        //                                      Extensores sql
        ////////////////////////////////////////////////////////////////////////////////////////////////////        

        public static SqlParameter AddWithNullable<T>(this SqlParameterCollection parms,
                string parameterName, T? nullable) where T : struct
        {
            if (nullable.HasValue)
                return parms.AddWithValue(parameterName, nullable.Value);
            else
                return parms.AddWithValue(parameterName, DBNull.Value);
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////        
        //                                      Extensores NpgDataReader
        ////////////////////////////////////////////////////////////////////////////////////////////////////        

        public static bool SafeGetBoolNpg(this NpgsqlDataReader rd, int col)
        {
            return rd.GetBoolean(col);
        }

        public static long? SafeGetLongNpg(this NpgsqlDataReader rd, int col, long? valorDefecto)
        {

            if (rd.IsDBNull(col)) return valorDefecto;

            string tipo = rd.GetDataTypeName(col);
            long? regreso = 0;

            switch (tipo.ToUpper())
            {
                case "INT2":
                    regreso = rd.GetInt16(col);
                    break;
                case "INT4":
                    regreso = rd.GetInt32(col);
                    break;
                case "INT8":
                    regreso = rd.GetInt64(col);
                    break;

                case "SERIAL":
                    regreso = rd.GetInt32(col);
                    break;

                default:
                    regreso = (long?)rd.GetDecimal(col);
                    break;
            }

            return regreso;

        }

        public static long SafeGetLongNotNullNpg(this NpgsqlDataReader rd, int col)
        {

            long regreso = 0;

            var valorColumna = rd.GetValue(col);

            if (rd.IsDBNull(col)) return regreso;

            string tipo = rd.GetDataTypeName(col);


            switch (tipo.ToUpper())
            {
                case "INT2":
                    regreso = rd.GetInt16(col);
                    break;
                case "INT4":
                    regreso = rd.GetInt32(col);
                    break;
                case "INT8":
                    regreso = rd.GetInt64(col);
                    break;

                case "SERIAL":
                    regreso = rd.GetInt32(col);
                    break;

                default:
                    long? regresoNull = (long?)rd.GetDecimal(col);
                    if (regresoNull != null)
                    {
                        regreso = (long)regresoNull;
                    }

                    break;
            }

            return regreso;



        }

        public static short SafeGetShorNotNullNpg(this NpgsqlDataReader rd, int col)
        {
            short regreso = rd.GetInt16(col);
            return regreso;
        }


        public static decimal? SafeGetDecimalNpg(this NpgsqlDataReader rd, int col, decimal? valorDefecto)
        {

            if (!rd.IsDBNull(col)) return valorDefecto;
            return rd.GetDecimal(col);
        }

        public static string SafeGetStringNpg(this NpgsqlDataReader rd, int col)
        {

            if (!rd.IsDBNull(col))
                return rd.GetString(col);
            else
                return string.Empty;
        }

        public static DateTime SafeGetDateTimeNotNullNpg(this NpgsqlDataReader rd, int col)
        {

            if (!rd.IsDBNull(col))
                return rd.GetDateTime(col);
            else
                throw new Exception("La Fecha es Nula");
        }
        public static DateTime? SafeGetDateTimeNpg(this NpgsqlDataReader rd, int col, DateTime? fecha)
        {

            if (!rd.IsDBNull(col))
            {
                //DateTime? regreso = rd.GetDateTime(col);
                return rd.GetDateTime(col);
            }

            else
                return fecha;
        }

        public static int GetColDataReader(this NpgsqlDataReader rd, string nameCol)
        {
            return rd.GetOrdinal(nameCol);
        }



        ////////////////////////////////////////////////////////////////////////////////////////////////////        
        //                                      Extensores NpgsqlDataReader
        ////////////////////////////////////////////////////////////////////////////////////////////////////        

        //public static List<object[]> GetDataReaderListObject(this NpgsqlDataReader reader)
        //{
        //    List<object[]> list = new List<object[]>();          

        //        int fieldCount = reader.FieldCount;

        //        while (reader.Read())
        //        {
        //            object[] row = new object[fieldCount];

        //            for (int i = 0; i < fieldCount; i++)
        //            {
        //                row[i] = reader[i];
        //            }
        //            list.Add(row);
        //        }

        //    return list;
        //}

        //public static List<string> GetDataReaderList(this NpgsqlDataReader reader)
        //{
        //    List<string> result = new List<string>();

        //    while (reader.Read())
        //    {
        //        result.Add(Convert.ToString(reader["Data Reader"]));
        //    }

        //    return result;
        //}
        //public static bool SafeGetBoolNpg(this NpgsqlDataReader rd, int col)
        //{
        //    var nombre = rd.GetName(col);

        //    bool regreso;

        //    if (rd.IsDBNull(col)) return false;

        //    var valorColumna = rd.GetValue(col);

        //    if (valorColumna == null) return false;

        //    string s = valorColumna.ToString();

        //    if (s == "1")
        //        regreso = true;
        //    else return false;

        //    return regreso;

        //}
        //public static long? SafeGetIntOdbc(this NpgsqlDataReader rd, int col, long? valorDefecto)
        //{

        //    string tipo = rd.GetDataTypeName(col - 1);

        //    if (rd.IsDBNull(col)) return valorDefecto;

        //    return rd.GetInt32(col);


        //}
        //public static long? SafeGetLongNpg(this NpgsqlDataReader rd, int col, long? valorDefecto)
        //{

        //    if (rd.IsDBNull(col)) return valorDefecto;

        //    string tipo = rd.GetDataTypeName(col);
        //    long? regreso = 0;

        //    switch (tipo.ToUpper())
        //    {
        //        case "INT2":
        //            regreso = rd.GetInt16(col);
        //            break;
        //        case "INT4":
        //            regreso = rd.GetInt32(col);
        //            break;
        //        case "INT8":
        //            regreso = rd.GetInt64(col);
        //            break;

        //        case "SERIAL":
        //            regreso = rd.GetInt32(col);
        //            break;

        //        default:
        //            regreso = (long?)rd.GetDecimal(col);
        //            break;
        //    }

        //    return regreso;

        //}

        //public static long SafeGetLongNotNullNpg(this NpgsqlDataReader rd, int col)
        //{

        //    long regreso = 0;

        //    var valorColumna = rd.GetValue(col);

        //    if (rd.IsDBNull(col)) return regreso;

        //    string tipo = rd.GetDataTypeName(col);


        //    switch (tipo.ToUpper())
        //    {
        //        case "INT2":
        //            regreso = rd.GetInt16(col);
        //            break;
        //        case "INT4":
        //            regreso = rd.GetInt32(col);
        //            break;
        //        case "INT8":
        //            regreso = rd.GetInt64(col);
        //            break;

        //        case "SERIAL":
        //            regreso = rd.GetInt32(col);
        //            break;

        //        default:
        //            long? regresoNull = (long?)rd.GetDecimal(col);
        //            if (regresoNull != null)
        //            {
        //                regreso = (long)regresoNull;
        //            }

        //            break;
        //    }

        //    return regreso;



        //}
        //public static decimal? SafeGetDecimalNpg(this NpgsqlDataReader rd, int col, decimal? valorDefecto)
        //{

        //    if (!rd.IsDBNull(col)) return valorDefecto;
        //    return rd.GetDecimal(col);           
        //}

        //public static string SafeGetStringNpg(this NpgsqlDataReader rd, int col)
        //{

        //    if (!rd.IsDBNull(col))
        //        return rd.GetString(col);
        //    else
        //        return string.Empty;
        //}

        //public static DateTime SafeGetDateTimeNotNullNpg(this NpgsqlDataReader rd, int col)
        //{

        //    if (!rd.IsDBNull(col))
        //        return rd.GetDateTime(col);
        //    else
        //        throw new Exception("La Fecha es Nula");
        //}
        //public static DateTime? SafeGetDateTimeNpg(this NpgsqlDataReader rd, int col, DateTime? fecha)
        //{

        //    if (!rd.IsDBNull(col))
        //    {
        //        //DateTime? regreso = rd.GetDateTime(col);
        //        return rd.GetDateTime(col);
        //    }

        //    else
        //        return fecha;
        //}

        //public static int GetColDataReader(this NpgsqlDataReader rd, string nameCol)
        //{
        //    return rd.GetOrdinal(nameCol);
        //}


        public static ArrayList ToArrayList(this NpgsqlDataReader rd)
        {
            ArrayList al = new ArrayList();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    string[] fields = new string[rd.FieldCount];
                    for (int i = 0; i < rd.FieldCount; ++i)
                        fields[i] = rd[i].ToString();
                    al.Add(fields);

                }
            }
            return al;
        }

        public static Array ToArray(this NpgsqlDataReader rd)
        {

            string[] fields = new string[rd.FieldCount];


            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    for (int i = 0; i < rd.FieldCount; ++i)
                        fields[i] = rd[i].ToString();
                }
            }
            return fields;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////        
        //                                      Extensores DateTime
        ////////////////////////////////////////////////////////////////////////////////////////////////////        


        public static bool CumpleYearRestoDelMes(this DateTime? dt)
        {
            return dt.HasValue && dt.Value.Month == DateTime.Today.Month && dt.Value.Day >= DateTime.Today.Day;
        }

        public static DateTime FinDelDia(this DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, 23, 59, 59);
        }
        public static DateTime InicioDelDia(this DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);
        }

        public static DateTime InicioDelMes(this DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, 1, 0, 0, 0);
        }
        public static DateTime FinDelMes(this DateTime dt)
        {
            DateTime proximoFechaMes, fechaRegreso;

            proximoFechaMes = (dt.Month == 12 ? new DateTime(dt.Year + 1, 1, 1, 0, 0, 0) : new DateTime(dt.Year, dt.Month + 1, 1, 0, 0, 0));
            fechaRegreso = proximoFechaMes.AddDays(-1);

            return new DateTime(fechaRegreso.Year, fechaRegreso.Month, fechaRegreso.Day, 23, 59, 59);

        }

        public static DateTime FinDelMesAnterior(this DateTime dt)
        {
            return FinDelMes((dt.Month == 1 ? new DateTime(dt.Year - 1, 12, 1, 0, 0, 0) : new DateTime(dt.Year, dt.Month - 1, 1, 0, 0, 0)));
        }
        public static DateTime FinDelMesSiguiente(this DateTime dt)
        {
            return FinDelMes(dt.Month == 12 ? new DateTime(dt.Year + 1, 1, 1, 0, 0, 0) : new DateTime(dt.Year, dt.Month + 1, 1, 0, 0, 0));
        }

        public static DateTime InicioDelMesSiguiente(this DateTime dt)
        {
            return (dt.Month == 12 ? new DateTime(dt.Year + 1, 1, 1, 0, 0, 0) : new DateTime(dt.Year, dt.Month + 1, 1, 0, 0, 0));
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////        
        //                                      Extensores String
        ////////////////////////////////////////////////////////////////////////////////////////////////////        

        public static bool ContainsSpecialChars(this string miCadena)
        {
            var list = new[] { "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "+", "=", "\"" };
            return list.Any(miCadena.Contains);
        }

        public static bool EsDireccionCorreo(this string s)
        {
            Regex regex = new Regex(
            @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(s);
        }
        public static bool EsNulaOVacia(this string s)
        {
            return (s == null || s.Trim().Length == 0);
        }
        public static string Inversa(this string s)
        {
            char[] rev = s.ToCharArray();
            Array.Reverse(rev);
            return (new string(rev));
        }

        public static string Left(this string s, int largo)
        {
            if (!s.EsNulaOVacia())
            {
                if (s.Length > largo) s = s.Substring(0, largo);
            }

            return s;
        }

        public static long TrueLong(this string s)
        {
            long regreso = 0;
            if (s.EsNulaOVacia())
            {
                regreso = 0;
            }
            else
            {
                bool result = long.TryParse(s, out regreso);
            }

            return regreso;
        }
        public static int TrueInt(this string s)
        {
            int regreso = 0;
            if (s.EsNulaOVacia())
            {
                regreso = 0;
            }
            else
            {
                bool result = int.TryParse(s, out regreso);
            }

            return regreso;
        }

        public static DateTime? TrueDateTime(this string s)
        {
            DateTime? regreso = null;
            DateTime dateValue;


            if (!s.EsNulaOVacia())
            {
                bool result = DateTime.TryParse(s, out dateValue);
                if (result) regreso = dateValue;
            }

            return regreso;
        }

        public static bool IsValidUrl(this string url)
        {
            string strRegex = "^(https?://)"
        + "?(([0-9a-z_!~*'().&=+$%-]+: )?[0-9a-z_!~*'().&=+$%-]+@)?" //user@
        + @"(([0-9]{1,3}\.){3}[0-9]{1,3}" // IP- 199.194.52.184
        + "|" // allows either IP or domain
        + @"([0-9a-z_!~*'()-]+\.)*" // tertiary domain(s)- www.
        + @"([0-9a-z][0-9a-z-]{0,61})?[0-9a-z]" // second level domain
        + @"(\.[a-z]{2,6})?)" // first level domain- .com or .museum is optional
        + "(:[0-9]{1,5})?" // port number- :80
        + "((/?)|" // a slash isn't required if there is no file name
        + "(/[0-9a-z_!~*'().;?:@&=+$,%#-]+)+/?)$";
            return new Regex(strRegex).IsMatch(url);
        }


        public static bool UrlAvailable(this string httpUrl)
        {
            if (!httpUrl.StartsWith("http://") || !httpUrl.StartsWith("https://"))
                httpUrl = "http://" + httpUrl;
            try
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(httpUrl);
                myRequest.Method = "GET";
                myRequest.ContentType = "application/x-www-form-urlencoded";
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myRequest.GetResponse();

                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>

        /// Reduce string to shorter preview which is optionally ended by some string (...).
        /// </summary>
        /// <param name="s">string to reduce</param>
        /// <param name="count">Length of returned string including endings.</param>
        /// <param name="endings">optional edings of reduced text</param>

        /// <example>
        /// string description = "This is very long description of something";
        /// string preview = description.Reduce(20,"...");
        /// produce -> "This is very long..."
        /// </example>
        /// <returns></returns>

        public static string Reduce(this string s, int count, string endings)
        {
            if (count < endings.Length)
                throw new Exception("Failed to reduce to less then endings length.");
            int sLength = s.Length;
            int len = sLength;
            if (endings != null)
                len += endings.Length;
            if (count > sLength)
                return s; //it's too short to reduce
            s = s.Substring(0, sLength - len + count);
            if (endings != null)
                s += endings;
            return s;
        }


        public static string RemoveSpaces(this string s)
        {
            return s.Replace(" ", "");
        }

        /// <summary>
        /// true, if the string can be parse as Double respective Int32
        /// Spaces are not considred.
        /// </summary>
        /// <param name="s">input string</param>

        /// <param name="floatpoint">true, if Double is considered,
        /// otherwhise Int32 is considered.</param>
        /// <returns>true, if the string contains only digits or float-point</returns>
        public static bool IsNumber(this string s, bool floatpoint)
        {
            int i;
            double d;
            string withoutWhiteSpace = s.RemoveSpaces();
            if (floatpoint)
                return double.TryParse(withoutWhiteSpace, NumberStyles.Any, Thread.CurrentThread.CurrentUICulture, out d);
            else
                return int.TryParse(withoutWhiteSpace, out i);
        }

        /// <summary>
        /// true, if the string contains only digits or float-point.
        /// Spaces are not considred.
        /// </summary>
        /// <param name="s">input string</param>

        /// <param name="floatpoint">true, if float-point is considered</param>
        /// <returns>true, if the string contains only digits or float-point</returns>
        public static bool IsNumberOnly(this string s, bool floatpoint)
        {
            s = s.Trim();
            if (s.Length == 0)
                return false;
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    if (floatpoint && (c == '.' || c == ','))
                        continue;
                    return false;
                }
            }
            return true;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////        
        //                                      Extensores Booleanos
        ////////////////////////////////////////////////////////////////////////////////////////////////////        
        public static short BooleantoShort(this Boolean miValor)
        {
            short regreso;

            if (miValor == true)
                regreso = 1;
            else
                regreso = 0;

            return regreso;
        }


        //        bool falseFlag = false;
        //        bool trueFlag = true;

        //        Console.WriteLine("{0} converts to {1}.", falseFlag,
        //                  Convert.ToInt32(falseFlag));
        //Console.WriteLine("{0} converts to {1}.", trueFlag,
        //                  Convert.ToInt32(trueFlag));

        ////////////////////////////////////////////////////////////////////////////////////////////////////        
        //                                      Extensores Decimal
        ////////////////////////////////////////////////////////////////////////////////////////////////////        

        public static decimal TruncateDecimal(this decimal value, int precision)
        {
            decimal step = (decimal)Math.Pow(10, precision);
            long tmp = (long)Math.Truncate(step * value);
            return tmp / step;
        }


        public static long ParteEntera(this decimal monto)
        {
            return (long)Math.Truncate(monto);
        }
        public static int ParteDecimal(this decimal monto, int precision)
        {
            decimal step = (decimal)Math.Pow(10, precision);
            decimal baseDecimal = Math.Truncate(step * monto);
            decimal baseMonto = Math.Truncate(monto) * step;

            return (int)(baseDecimal - baseMonto);
        }


        public static string MontoEscrito(this decimal monto, monedaMontoEscrito moneda, idiomaMontoEscrito idioma)
        {
            string regreso = "";

            if (moneda == monedaMontoEscrito.Rec)
            {
                return "Moneda No Definida Correctamente";
            }

            switch (idioma)
            {

                case idiomaMontoEscrito.Español:

                    regreso = monto.MontoEscritoEspanol(moneda);
                    break;

                case idiomaMontoEscrito.Ingles:
                    regreso = monto.MontoEscritoIngles(moneda);
                    break;

                default:
                    regreso = "Idioma No Definido";
                    break;
            }

            return regreso.ToUpper().Trim().Replace("  ", " ");
        }

        private static string MontoEscritoIngles(this decimal monto, monedaMontoEscrito moneda)
        {
            string regreso = "";
            string ls_cadena;
            string ls_aux = "";

            int li_terna = 0;
            int li_unidad;
            int li_decena;
            int li_centena;

            bool lb_todoCeros;
            bool lb_soloLaUnidad;

            string[] ls_unidades = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] ls_decenas = { "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] ls_decenas1 = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

            // Recogemos la parte entera y la fracción.

            decimal ldc_entero = Math.Truncate(monto);
            int li_fraccion = monto.ParteDecimal(2);

            while (ldc_entero > 0)
            {

                // Indicamos la terna actual.
                li_terna++;

                // Se recorre el número por ternas.

                ls_cadena = "";
                li_unidad = (int)Math.Truncate((ldc_entero % 10));
                ldc_entero = Math.Truncate(ldc_entero / 10);
                li_decena = (int)(ldc_entero % 10);
                ldc_entero = Math.Truncate(ldc_entero / 10);
                li_centena = (int)(ldc_entero % 10);
                ldc_entero = Math.Truncate(ldc_entero / 10);

                // Se analizan las unidades.
                if (li_unidad != 0)
                {
                    ls_cadena = ls_unidades[li_unidad - 1] + " ";
                }

                switch (li_decena)
                {
                    case 1:

                        switch (li_unidad)
                        {
                            case 0:
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                            case 6:
                            case 7:
                            case 8:
                            case 9:

                                ls_cadena = ls_decenas1[li_unidad] + " ";
                                break;

                        }

                        break;

                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:

                        ls_cadena = ls_decenas[li_decena - 1] + " " + ls_cadena;
                        break;


                } // Final del switch (li_decena)

                // Se analizan las centenas.

                switch (li_centena)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:

                        ls_cadena = ls_unidades[li_centena - 1] + " hundred " + ls_cadena;
                        break;
                }

                // Analizamos la terna.



                lb_todoCeros = ((li_unidad + li_decena + li_centena) == 0);
                lb_soloLaUnidad = ((li_unidad == 1) && ((li_decena + li_centena) == 0));

                switch (li_terna)
                {
                    case 2:
                        if (!lb_todoCeros)
                        {
                            if (lb_soloLaUnidad)
                            {
                                ls_cadena = "thousand ";
                            }
                            else
                            {
                                ls_cadena += "thousand ";
                            }
                        }

                        break;

                    case 3:
                        if (!lb_todoCeros)
                        {
                            if (lb_soloLaUnidad)
                            {
                                ls_cadena += "million ";
                            }
                            else
                            {
                                ls_cadena += "millions ";
                            }
                        }
                        break;

                    case 4:
                        if (lb_soloLaUnidad)
                        {
                            ls_cadena = "thousand millions ";
                        }
                        else
                        {
                            ls_cadena += "thousand millions ";
                        }
                        break;

                    default:
                        if (li_terna != 1)
                        {
                            ldc_entero = 0;
                            ls_cadena = "";
                        }
                        break;

                }

                // Se monta el sultado de la terna actual con el de las anteriores.
                regreso = ls_cadena + regreso;

            } // Final del while (ldc_entero > 0)

            // Utilizamos la recursividad para montar el literal de los decimales.

            if (li_fraccion != 0)
            {
                ls_aux = ((decimal)li_fraccion).MontoEscritoIngles(monedaMontoEscrito.Rec);    //("-RECURSIVIDAD-");

                if (li_fraccion == 1)
                {
                    ls_aux = "one cent";
                }
                else
                {
                    ls_aux += " cents";
                }
            }

            // Montamos la salida final según corresponda.


            if (li_terna == 0)
            {
                // Solo tiene parte decimal.
                regreso = ls_aux;
            }
            else
            {
                // Hay que añadir el modificar 'de' si es multiplo 
                // de 1000000.
                //If mod(truncate(adec_monto, 0), 1000000)= 0 Then ls_regreso+= 'DE '

                if ((Math.Truncate(monto)) % 1000000 == 0)
                {
                    regreso += "DE ";
                }

                // Añadimos la moneda a la parte entera.

                switch (moneda)
                {
                    case monedaMontoEscrito.Rec:

                        break;

                    case monedaMontoEscrito.Euros:

                        if (Math.Truncate(monto) == 1)
                        {
                            regreso = "ONE EURO";
                        }
                        else
                        {
                            regreso += "EUROS";
                        }
                        break;


                    case monedaMontoEscrito.Pesos:

                        if (Math.Truncate(monto) == 1)
                        {
                            regreso = "ONE PESO";
                        }
                        else
                        {
                            regreso += "PESOS";
                        }
                        break;

                    case monedaMontoEscrito.USD:


                        if (Math.Truncate(monto) == 1)
                        {
                            regreso = "ONE DOLLAR";
                        }
                        else
                        {
                            regreso += "DOLLARS";
                        }
                        break;


                    case monedaMontoEscrito.Bs:

                        if (Math.Truncate(monto) == 1)
                        {
                            regreso = "ONE BOLIVAR";
                        }
                        else
                        {
                            regreso += "BOLÍVARES";
                        }
                        break;

                    default:
                        if (Math.Truncate(monto) == 1)
                        {
                            regreso = "ONE BOLIVAR";
                        }
                        else
                        {
                            regreso += "BOLÍVARES";
                        }
                        break;

                } // final del switch (moneda.ToUpper().Trim())

                // Hay que añadir la parte decimal si la tiene.
                if (ls_aux != "")
                {
                    regreso = regreso.Trim() + " and " + ls_aux;
                }
            }

            return regreso;
        }


        private static string MontoEscritoEspanol(this decimal monto, monedaMontoEscrito moneda)
        {
            string[] ls_unidades = { "UN", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE" };
            string[] ls_decenas = { "", "", "TREINTA", "CUARENTA", "CINCUENTA", "SESENTA", "SETENTA", "OCHENTA", "NOVENTA" };
            string[] ls_centenas = { "", "DOSCIENTOS", "TRESCIENTOS", "CUATROCIENTOS", "QUINIENTOS", "SEISCIENTOS", "SETECIENTOS", "OCHOCIENTOS", "NOVECIENTOS" };
            string[] ls_decenas1 = { "DIEZ", "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE", "DIECISEÍS" };
            string[] ls_decenas2 = { "VEINTE", "VEINTIÚN", "VEINTIDÓS", "VEINTITRÉS", "", "", "VEINTISÉIS" };

            /////////////////////////////////////////////////////////////////////////////////////////////////////	  
            // 										Obtiene la parte entera y la fracción.										//
            /////////////////////////////////////////////////////////////////////////////////////////////////////	  

            decimal ldc_entero = Math.Truncate(monto);
            int li_fraccion = monto.ParteDecimal(2);

            int li_terna = 0;
            int li_unidad = 0;
            int li_decena = 0;
            int li_centena = 0;

            string ls_cadena;
            string ls_regreso = "";
            string ls_aux = "";

            bool lb_todoCeros, lb_soloLaUnidad;

            while (ldc_entero > 0)
            {

                // Indicamos la terna actual.
                li_terna++;

                // Se recorre el número por ternas.
                ls_cadena = "";
                li_unidad = (int)(ldc_entero % 10);
                ldc_entero = Math.Truncate(ldc_entero / 10);
                li_decena = (int)(ldc_entero % 10);
                ldc_entero = Math.Truncate(ldc_entero / 10);
                li_centena = (int)(ldc_entero % 10);
                ldc_entero = Math.Truncate(ldc_entero / 10);

                //// Se analizan las unidades.
                if (li_unidad != 0)
                {
                    ls_cadena = ls_unidades[li_unidad - 1] + " ";
                }

                // Se analizan las decenas.

                switch (li_decena)
                {
                    case 1:

                        switch (li_unidad)
                        {

                            case 0:
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                            case 6:
                                ls_cadena = ls_decenas1[li_unidad] + " ";
                                break;

                            default:
                                ls_cadena = "DIECI" + ls_cadena;
                                break;
                        }
                        break;

                    case 2:

                        switch (li_unidad)
                        {

                            case 0:
                            case 1:
                            case 2:
                            case 3:
                            case 6:

                                ls_cadena = ls_decenas2[li_unidad] + " ";
                                break;

                            default:
                                ls_cadena = "VEINTI" + ls_cadena;
                                break;
                        }
                        break;

                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:

                        if (li_unidad == 0)
                        {
                            ls_cadena = ls_decenas[li_decena - 1] + " " + ls_cadena;
                        }
                        else
                        {
                            ls_cadena = ls_decenas[li_decena - 1] + " Y " + ls_cadena;
                        }

                        break;
                }

                // Se analizan las centenas.
                switch (li_centena)
                {
                    case 1:

                        if (li_unidad == 0 && li_decena == 0)
                        {
                            ls_cadena = "CIEN ";
                        }
                        else
                        {
                            ls_cadena = "CIENTO " + ls_cadena;
                        }
                        break;

                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:

                        ls_cadena = ls_centenas[li_centena - 1] + " " + ls_cadena;
                        break;
                }

                // Analizamos la terna.

                lb_todoCeros = ((li_unidad + li_decena + li_centena) == 0);
                lb_soloLaUnidad = ((li_unidad == 1) && ((li_decena + li_centena) == 0));

                switch (li_terna)
                {

                    case 2:

                        if (!lb_todoCeros)
                        {
                            if (lb_soloLaUnidad)
                            {
                                ls_cadena = "MIL ";
                            }
                            else
                            {
                                ls_cadena += "MIL ";
                            }
                        }
                        break;

                    case 3:

                        if (!lb_todoCeros)
                        {
                            if (lb_soloLaUnidad)
                            {
                                ls_cadena += "MILLÓN ";
                            }
                            else
                            {
                                ls_cadena += "MILLONES ";
                            }
                        }
                        break;

                    case 4:

                        if (lb_soloLaUnidad)
                        {
                            ls_cadena = "MIL MILLONES ";
                        }
                        else
                        {
                            ls_cadena += "MIL MILLONES ";
                        }
                        break;

                    default:

                        if (li_terna != 1)
                        {
                            ldc_entero = 0;
                            ls_cadena = "";
                        }
                        break;

                }

                // Se monta el sultado de la terna actual con el de las anteriores.
                ls_regreso = ls_cadena + ls_regreso;

            } // Final de While

            // Utilizamos la recursividad para montar el literal de los decimales.

            if (li_fraccion != 0)
            {

                // Como se retorno como parte entera llega con EURO/EUROS y hay que quitarlo.

                //	choose case upper(trim(as_moneda))
                //		case "EUROS"
                //  	 		ls_aux = trim(left(ls_aux, len(ls_aux) - 5))                
                //		case else
                //  	 		ls_aux = trim(left(ls_aux, len(ls_aux) - LEN(as_moneda)))
                //	end choose

                ls_aux = ((decimal)li_fraccion).MontoEscritoEspanol(monedaMontoEscrito.Rec);    // ("-RECURSIVIDAD-");

                if (li_fraccion == 1)
                {
                    ls_aux = "UN CÉNTIMO";
                }
                else
                {
                    ls_aux += " CÉNTIMOS";
                }

            }

            // Montamos la salida final según corresponda.
            if (li_terna == 0)
            {
                // Solo tiene parte decimal.
                ls_regreso = ls_aux;


            }
            else
            {
                // Hay que añadir el modificar "de" si es multiplo 
                // de 1000000.

                if (((Math.Truncate(monto)) % 1000000) == 0)
                {
                    // Añadimos la moneda a la parte entera.
                    ls_regreso += "DE ";
                }


                switch (moneda)
                {

                    case monedaMontoEscrito.Rec:

                        break;

                    case monedaMontoEscrito.Euros:


                        if (Math.Truncate(monto) == 1)
                        {
                            ls_regreso = "UN EURO";
                        }
                        else
                        {
                            ls_regreso += "EUROS";
                        }

                        break;

                    case monedaMontoEscrito.Pesos:


                        if (Math.Truncate(monto) == 1)
                        {
                            ls_regreso = "UN PESO";
                        }
                        else
                        {
                            ls_regreso += "PESOS";
                        }
                        break;

                    case monedaMontoEscrito.USD:

                        if (Math.Truncate(monto) == 1)
                        {
                            ls_regreso = "UN DOLAR";
                        }
                        else
                        {
                            ls_regreso += "DÓLARES";
                        }

                        break;

                    case monedaMontoEscrito.Bs:

                        if (Math.Truncate(monto) == 1)
                        {
                            ls_regreso = "UN BOLIVAR";
                        }
                        else
                        {
                            ls_regreso += "BOLÍVARES";
                        }
                        break;


                    default:

                        if (Math.Truncate(monto) == 1)
                        {
                            ls_regreso = "UN BOLIVAR";
                        }
                        else
                        {
                            ls_regreso += "BOLÍVARES";
                        }
                        break;
                } // final switch (moneda)

                if (ls_aux != "")
                {
                    ls_regreso = ls_regreso.Trim() + " CON " + ls_aux;
                }
            }


            return ls_regreso;
        }


        public static ErrorJt jtException(this Exception ex)
        {
            string msgEx = ex.ToString();
            string interna = ex.StackTrace;
            int indice = ex.StackTrace.IndexOf("at Microsoft.AspNetCore.");
            string msgFull = (indice < 0 ? ex.StackTrace : ex.StackTrace.Left(indice));

            ErrorJt regreso = new ErrorJt
            {
                msg = ex.Message,
                trace = msgFull.Trim()

            };

            return regreso;
        }

        public static ErrorJt jtExceptionOld(this Exception ex)
        {
            int index = ex.StackTrace.LastIndexOf("at ");
            string msgFull = (index < 0 ? "" : ex.StackTrace.Substring(index + 3));

            ErrorJt regreso = new ErrorJt
            {
                msg = ex.Message,
                trace = ex.StackTrace.Trim()
                //ex.StackTrace.Trim()
            };
            //string miError = ex.Message + " - " + msgFull;
            return regreso;
        }

        public static string jtExceptionMsg(this Exception ex)
        {
            int index = ex.StackTrace.LastIndexOf("at ");
            string msgFull = (index < 0 ? "" : ex.StackTrace.Substring(index + 3));

            //ErrorJt regreso = new ErrorJt
            //{
            //    msg = ex.Message,
            //    trace = ex.StackTrace
            //};
            //string miError = ex.Message + " - " + msgFull;

            string regreso = ex.Message + " " + ex.StackTrace;
            return regreso;
        }

    }
}

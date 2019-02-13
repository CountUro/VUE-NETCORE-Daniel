using Negocios.Extensiones;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Negocios.Funciones
{

    public class ReturnCheckPassword
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }

    public static class FuncionesJT
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////        
        //                                      Funciones DataReader
        ////////////////////////////////////////////////////////////////////////////////////////////////////        
        public static List<T> DataReaderMapToList<T>(IDataReader dr)
        {
            try
            {
                List<T> list = new List<T>();
                T obj = default(T);
                while (dr.Read())
                {
                    obj = Activator.CreateInstance<T>();
                    foreach (PropertyInfo prop in obj.GetType().GetProperties())
                    {
                        //if (ColumnExists(dr, prop.Name))
                        ////if (true)
                        //{
                        //    if (!object.Equals(dr[prop.Name], DBNull.Value))
                        //    {
                        //        prop.SetValue(obj, dr[prop.Name], null);
                        //    }
                        //}
                        try
                        {
                            if (!object.Equals(dr[prop.Name], DBNull.Value))
                            {
                                prop.SetValue(obj, dr[prop.Name], null);
                            }
                        }
                        catch
                        {
                            prop.SetValue(obj, null, null);
                        }


                    }
                    list.Add(obj);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static bool ColumnExists(IDataReader reader, string columnName)
        {

            return reader.GetSchemaTable()
                         .Rows
                         .OfType<DataRow>()
                         .Any(row => row["ColumnName"].ToString() == columnName);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////        
        //                                      SErializacion
        ////////////////////////////////////////////////////////////////////////////////////////////////////       

        public static string Serialize<T>(T obj)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            MemoryStream ms = new MemoryStream();
            serializer.WriteObject(ms, obj);
            string retVal = Encoding.UTF8.GetString(ms.ToArray());
            return retVal;
        }

        public static T Deserialize<T>(string json)
        {
            T obj = Activator.CreateInstance<T>();
            MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(json));
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            obj = (T)serializer.ReadObject(ms);
            //ms.Close();
            return obj;
        }



        ////////////////////////////////////////////////////////////////////////////////////////////////////        
        //                                      convert from NpgsqlDataReader to JSON
        ////////////////////////////////////////////////////////////////////////////////////////////////////   

        //And then use the NewtonSoft.Json JsonConvert object to get your JSON:

        //var r = Serialize(reader);
        //string json = JsonConvert.SerializeObject(r, Formatting.Indented);

        //UPDATE: If you just want to use built-in methods, and you happen to be using MVC, 
        //you can use the built in Json helper method on your newly serialized :

        //JsonResult Index(int id)
        //{
        //    var r = Serialize(reader);
        //    return Json(r, JsonRequestBehavior.AllowGet);
        //}
        //////////////////////////////////////////////////////////////////////////////////////////////////// 

        public static IEnumerable<Dictionary<string, object>> Serialize(NpgsqlDataReader reader)
        {
            var results = new List<Dictionary<string, object>>();
            var cols = new List<string>();
            for (var i = 0; i < reader.FieldCount; i++)
                cols.Add(reader.GetName(i));

            while (reader.Read())
                results.Add(SerializeRow(cols, reader));

            return results;
        }
        private static Dictionary<string, object> SerializeRow(IEnumerable<string> cols, NpgsqlDataReader reader)
        {
            var result = new Dictionary<string, object>();
            foreach (var col in cols)
                result.Add(col, reader[col]);
            return result;
        }

        public static bool IsValidPassword(string password)
        {
            return Regex.Match(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{8,}").Success;
        }

        public static bool CheckSymbol(UnicodeCategory uc)
        {
            switch (uc)
            {
                case UnicodeCategory.MathSymbol:
                case UnicodeCategory.CurrencySymbol:
                case UnicodeCategory.ModifierSymbol:
                case UnicodeCategory.OtherSymbol:
                    return true;
                default:
                    return false;
            }
        }
        public static ReturnCheckPassword CheckQualityPassword(string password, short largo)
        {
            ReturnCheckPassword rch = new ReturnCheckPassword();

            string _password = password.Trim();

            bool chk = true;

            if (chk)
            {
                rch.Success = true;
                rch.Message = "El pasword cumple con los requisitos";
                return rch;
            }
            else
            {


                if (_password.Length < largo)
                {
                    rch.Success = false;
                    rch.Message = "Debe Tener al menos " + largo.ToString() + " caracteres";
                    return rch;
                }

                bool tieneMayusculas = _password.Any(c => char.IsUpper(c));
                bool tieneMinusculas = _password.Any(c => char.IsLower(c));
                bool tieneNumeros = _password.Any(c => char.IsDigit(c));



                bool tieneCharEsp = _password.ContainsSpecialChars();

                //tieneCharEsp  = oc.Any(c => char.IsSymbol(c));
                //tieneCharEsp = oc.Any(c => char.IsControl(c));
                //tieneCharEsp = oc.Any(c => char.IsPunctuation(c));
                //tieneCharEsp = oc.Any(c => char.IsSeparator(c));

                if (!tieneMayusculas)
                {
                    rch.Success = false;
                    rch.Message = "Debe Tener al menos un caracter en Mayúscula";
                    return rch;
                }

                if (!tieneMinusculas)
                {
                    rch.Success = false;
                    rch.Message = "Debe Tener al menos un caracter en minúscula";
                    return rch;
                }


                if (!tieneNumeros)
                {
                    rch.Success = false;
                    rch.Message = "Debe Tener al menos un Número";
                    return rch;
                }


                if (!tieneCharEsp)
                {
                    rch.Success = false;
                    rch.Message = "Debe Tener al menos un caracter especial";
                    return rch;
                }

                rch.Success = true;
                rch.Message = "El pasword cumple con los requisitos";
                return rch;

                //Boolean regresoBoolMin = Regex.Match(_password, @"/[a-z]/", RegexOptions.ECMAScript).Success;
                //Boolean regresoBoolMay = Regex.Match(_password, @"/[A-Z]/", RegexOptions.ECMAScript).Success;
                //Boolean regresoBoolEsp = Regex.Match(_password, @"/.[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]/", RegexOptions.ECMAScript).Success;


                //if (Regex.Match(_password, @"/[a-z]/", RegexOptions.ECMAScript).Success == false)
                //{
                //    rch.Success = false;
                //    rch.Message = "Debe Tener al menos un caracter en minúscula";
                //    return rch;
                //}



                //if (Regex.Match(_password, @"/[A-Z]/", RegexOptions.ECMAScript).Success == false)
                //{
                //    rch.Success = false;
                //    rch.Message = "Debe Tener al menos un caracter en Mayúscula";
                //    return rch;
                //}

                //if (Regex.Match(_password, @"/.[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]/", RegexOptions.ECMAScript).Success == false)
                //{
                //    rch.Success = false;
                //    rch.Message = "Debe Tener al menos un caracter especial";
                //    return rch;
                //}

                //rch.Success = true;
                //rch.Message = "El pasword cumple con los requisitos";
                //return rch;
            }





        }

        ////////////////////////////////////////////////////////////////////////////////////////

        public static string EncryptString(string text)

        {

            //String keyString = "E546C8DF278CD5931069B522E695D4F2";
            String keyString = "F146C8DF278CD5931069B522E695D499";


            var key = Encoding.UTF8.GetBytes(keyString);

            using (var aesAlg = Aes.Create())
            {
                using (var encryptor = aesAlg.CreateEncryptor(key, aesAlg.IV))
                {
                    using (var msEncrypt = new MemoryStream())
                    {
                        using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(text);
                        }

                        var iv = aesAlg.IV;

                        var decryptedContent = msEncrypt.ToArray();

                        var result = new byte[iv.Length + decryptedContent.Length];

                        Buffer.BlockCopy(iv, 0, result, 0, iv.Length);
                        Buffer.BlockCopy(decryptedContent, 0, result, iv.Length, decryptedContent.Length);

                        return Convert.ToBase64String(result);
                    }
                }
            }
        }

        public static string DecryptString(string cipherText)
        {
            String keyString = "F146C8DF278CD5931069B522E695D499";


            var fullCipher = Convert.FromBase64String(cipherText);

            var iv = new byte[16];
            var cipher = new byte[16];

            Buffer.BlockCopy(fullCipher, 0, iv, 0, iv.Length);
            Buffer.BlockCopy(fullCipher, iv.Length, cipher, 0, iv.Length);
            var key = Encoding.UTF8.GetBytes(keyString);

            using (var aesAlg = Aes.Create())
            {
                using (var decryptor = aesAlg.CreateDecryptor(key, iv))
                {
                    string result;
                    using (var msDecrypt = new MemoryStream(cipher))
                    {
                        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (var srDecrypt = new StreamReader(csDecrypt))
                            {
                                result = srDecrypt.ReadToEnd();
                            }
                        }
                    }

                    return result;
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////

        public static string MensajeDeError(Exception ex)
        {
            //int index = ex.StackTrace.LastIndexOf("line");
            //string errorLinea = (index < 0 ? "" : " - En la Línea: " + ex.StackTrace.Substring(index + 4));

            int index = ex.StackTrace.LastIndexOf("at ");
            string msgFull = (index < 0 ? "" : ex.StackTrace.Substring(index + 3));

            string miError = ex.Message + " - " + msgFull;
            return miError;
        }

            public static string HashPassword(string password)
        {
            return EncryptString(password);
        }

        //// Verify the password hash against the given password
        public static bool VerifyPassword(string hash, string password)
        {

            String descryp = DecryptString(hash);

            if (descryp == password) return true;

            return false;


        }

    }
}

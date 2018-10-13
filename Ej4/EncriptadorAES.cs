using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Ej4
{
    public class EncriptadorAES : Encriptador
    {

        private Aes aes;//Referencia al AES a usar
        //Constructor
        public EncriptadorAES() : base("AES")
        {
            aes = Aes.Create();
        }
        //Metodos
        public override string Encriptar(string pCadena)
        {
            byte[] encrypted;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = aes.Key;
                aesAlg.IV = aes.IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(pCadena);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            char[] caracteres = new char[encrypted.Length];
            for (int i = 0; i < encrypted.Length; i++)
            {
                caracteres[i] = Convert.ToChar(encrypted[i]);
            }
            return new string(caracteres);
        }
        public override string Desencriptar(string pCadena)
        {
            byte[] bytes = new byte[pCadena.Length];
            for (int i = 0; i < pCadena.Length; i++)
            {
                bytes[i] = Convert.ToByte(pCadena[i]);
            }

            string plainText = null;
            // Create a decryptor to perform the stream transform.

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = aes.Key;
                aesAlg.IV = aes.IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(bytes))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plainText = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plainText;
        }
    }
}

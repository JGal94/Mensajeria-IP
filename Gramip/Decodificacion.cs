using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Gramip
{
    internal class Decodificacion
    {


        public string Decode(byte[] cipherText, string clave)
        {
            byte[] bytesClave = Encoding.UTF8.GetBytes(clave);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = bytesClave;
                aesAlg.Mode = CipherMode.CBC; // Modo de cifrado: CBC
                aesAlg.Padding = PaddingMode.PKCS7; // Modo de relleno: PKCS7

                // El IV debería ser el mismo utilizado en la codificación
                byte[] iv = new byte[aesAlg.BlockSize / 8]; // Tamaño del IV en bytes
                Array.Copy(cipherText, 0, iv, 0, iv.Length);
                aesAlg.IV = iv;

                // El texto cifrado comienza después del IV
                byte[] cipherData = new byte[cipherText.Length - iv.Length];
                Array.Copy(cipherText, iv.Length, cipherData, 0, cipherData.Length);

                // Crear un descifrador con la clave y el IV
                using (ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV))
                {
                    // Descifrar el texto cifrado
                    byte[] decryptedData = decryptor.TransformFinalBlock(cipherData, 0, cipherData.Length);

                    // Convertir los bytes descifrados a una cadena
                    string plainText = Encoding.UTF8.GetString(decryptedData);

                    return plainText;
                }
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gramip
{

    internal class Codificacion
    {
        

        public byte[] codificacion(String mensajeacod, String clave)
        {

            byte[] bytesTextoOriginal = Encoding.UTF8.GetBytes(mensajeacod);
            byte[] bytesClave = Encoding.UTF8.GetBytes(clave);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = bytesClave;
                aesAlg.Mode = CipherMode.CBC; // Modo de cifrado: CBC
                aesAlg.Padding = PaddingMode.PKCS7; // Modo de relleno: PKCS7

                // Generar un vector de inicialización (IV) aleatorio
                aesAlg.GenerateIV();
                byte[] iv = aesAlg.IV;

                using (ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, iv))
                {
                    // Cifrar el texto original
                    byte[] textoCifrado = encryptor.TransformFinalBlock(bytesTextoOriginal, 0, bytesTextoOriginal.Length);
                    return textoCifrado;

                }
            }

        }
        
    }
}
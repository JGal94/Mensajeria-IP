using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gramip
{

    internal class Codificacion
    {
        

        public String[,] codificacion(String mensajeacod)
        {
            StringBuilder asciif = new StringBuilder();
            foreach (char caracter in mensajeacod)
            {
                int ascii = Convert.ToInt32(caracter);
                asciif.Append(ascii).Append(" ");



            }


            String resultado = asciif.ToString();
            int len = resultado.Length;
            String[,] resultMatrix = new string[2, 2];

            if (len % 4 != 0)
            {
                resultado += " 32";
            }

            

                int control = 0;
                int div = len / 4;

                

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        resultMatrix[i, j] = resultado.Substring(control, div);
                        control += div;
                    }
                }


            


            


            return resultMatrix;




        }
        
    }
}
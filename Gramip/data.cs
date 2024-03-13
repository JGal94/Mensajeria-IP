using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gramip
{
    internal class data
    {
        private int puerto = 0;
        private String ip = "";
        private int clave = 0;

        public int Puerto
        {
            get { return puerto; }
            set { puerto = value;}
        }

        public String Ip
        {
            get { return ip; }
            set { ip = value; }
        }

        public int Clave
        {
            get { return clave; }
            set { clave = value; }
        }
    }
}

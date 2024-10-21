using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOYECTO_DE_CATEDRA
{
    internal class Conexión
    {
        public string servidor, db;
        public string cadena;

        public void conexion()
        {
            servidor = "localhost";
            db = "PupuseriaDB";
            cadena = "Data Source= " + servidor + "; Initial Catalog= " + db + "; Integrated Security = yes";
        }
    }
}

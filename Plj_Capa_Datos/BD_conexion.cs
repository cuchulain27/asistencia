using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plj_Capa_Datos
{
   public class BD_conexion
    {
        public string Conectar()
        {
            return @"Data Source=DESKTOP-DTE3BG8\SQLEXPRESS; Initial Catalog=MicroSisPlani;uid=sa;pwd=admin";
            //return @"Data Source=PC-ADMIN\SQLEXPRESS; Initial Catalog=MicroSisPlani;uid=sa;pwd=admin"; ;
        }
    }
}

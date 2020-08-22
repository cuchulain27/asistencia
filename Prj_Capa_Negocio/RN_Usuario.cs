using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Plj_Capa_Entidad;
using Plj_Capa_Datos;
using System.Data.SqlClient;


namespace Prj_Capa_Negocio
{
    public class RN_Usuario
    {
        public bool RN_Verificar_Acceso(string Usuario, string Contraseña)
        {
            BD_Usuario obj = new BD_Usuario();
            return obj.BD_Verificar_Acceso(Usuario, Contraseña);
        }

        public DataTable RN_Leer_Datos_Usuario(string usuario)
        {
            BD_Usuario obj = new BD_Usuario();
            return obj.BD_Leer_Datos_Usuario(usuario);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plj_Capa_Datos;
using System.Data;

namespace Prj_Capa_Negocio
{
  public   class RN_Asistencia
    {
        public DataTable RN_Ver_Todas_asistencia()
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Ver_Todas_asistencia();

        }

        public DataTable RN_Ver_Todas_asistencia_DelDia(DateTime xfecha)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Ver_Todas_asistencia_DelDia(xfecha);
        }

        public DataTable RN_Ver_Todas_asistencia_DelMes(DateTime xfecha)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Ver_Todas_asistencia_DelMes(xfecha);
        }

        public DataTable RN_Ver_Todas_asistencia_ParaExplorador(string xvalor)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Ver_Todas_asistencia_ParaExplorador(xvalor);
        }

    }
}

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

        public void RN_Registrar_Entrada_Personal(string idAsis, string idPerso, string HoIngreso, double Tarde, int TotalHora, string justificado)
        {
            BD_Asistencia obj = new BD_Asistencia();
            obj.BD_Registrar_Entrada_Personal(idAsis,idPerso,HoIngreso,Tarde,TotalHora,justificado);
        }

        public void RN_Registrar_Salida_Personal(string idAsis, string idPerso, string HoSalida, double Totalhora)
        {
            BD_Asistencia obj = new BD_Asistencia();
            obj.BD_Registrar_Salida_Personal(idAsis, idPerso, HoSalida, Totalhora);
        }

        public bool RN_Checar_SiPersonal_YaMarco_Asistencia(string xidperson)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Checar_SiPersonal_YaMarco_Asistencia(xidperson);
        }

        public bool RN_Checar_SiPersonal_YaMarco_suEntrada(string xidperson)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Checar_SiPersonal_YaMarco_suEntrada(xidperson);
        }


        public bool RN_Verificar_Justificacion_Aprobada(string idpers)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Verificar_Justificacion_Aprobada(idpers);
        }

        public DataTable RN_Buscar_Asistencia_deEntrada(string idperso)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Buscar_Asistencia_deEntrada(idperso);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Plj_Capa_Datos;
using Prj_Capa_Entidad;
using System.Data;

namespace Prj_Capa_Negocio
{
  public   class RN_Justificacion
    {

        public void RN_REgistrar_Justificacion(EN_Justificacion jus)
        {
            BD_Justificacion obj = new BD_Justificacion();
            obj.BD_REgistrar_Justificacion(jus);
        }

        public void RN_Editar_Justificacion(EN_Justificacion jus)
        {
            BD_Justificacion obj = new BD_Justificacion();
            obj.BD_Editar_Justificacion(jus);
        }

        public void RN_Aprobar_Justificacion(string idjusti, string idperson)
        {
            BD_Justificacion obj = new BD_Justificacion();
            obj.BD_Aprobar_Justificacion(idjusti, idperson);
        }

        public void RN_Desaprobar_Justificacion(string idjusti, string idperson)
        {
            BD_Justificacion obj = new BD_Justificacion();
            obj.BD_Desaprobar_Justificacion(idjusti, idperson);
        }

        public DataTable RN_Cargar_todos_Justificacion()
        {
            BD_Justificacion obj = new BD_Justificacion();
            return obj.BD_Cargar_todos_Justificacion();
        }

        public DataTable RN_BuscarJustificacio_porValor(string xdato)
        {
            BD_Justificacion obj = new BD_Justificacion();
            return obj.BD_BuscarJustificacio_porValor(xdato);
        }

        public void RN_Eliminar_Justificacion(string idjusti)
        {
            BD_Justificacion obj = new BD_Justificacion();
            obj.BD_Eliminar_Justificacion(idjusti);
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Plj_Capa_Datos;

namespace Prj_Capa_Negocio
{
  public  class RN_Utilitario
    {


        public static string RN_NroDoc(int Id_Tipo)
        {
            return BD_Utilitario.BD_NroDoc(Id_Tipo);
        }

        public static void RN_Actualizar_Tipo_Doc(int Id_Tipo)
        {
            BD_Utilitario.BD_Actualizar_Tipo_Doc(Id_Tipo);
        }

        public static string RN_Listar_TipoFalta(int Id_Tipo)
        {
            return BD_Utilitario.BD_Listar_TipoFalta(Id_Tipo);
            

        }

        public void RN_Actualizar_RobotFalta(int IdTipo, string serie)
        {
            BD_Utilitario obj = new BD_Utilitario();
            obj.BD_Actualizar_RobotFalta(IdTipo, serie);
        }
    }
}

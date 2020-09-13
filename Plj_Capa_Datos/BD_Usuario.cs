﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Plj_Capa_Entidad;
using System.Windows.Forms;

namespace Plj_Capa_Datos
{
   public class BD_Usuario : BD_conexion
   {
        public bool BD_Verificar_Acceso(string Usuario, string Contraseña)
        {
            bool functionReturnValue = false;
            Int32 xfil = 0;

            SqlConnection Cn = new SqlConnection();
            SqlCommand Cmd = new SqlCommand();
            Cn.ConnectionString = Conectar();

            var _with1 = Cmd;
            _with1.CommandText = "Sp_Login";
            _with1.Connection = Cn;
            _with1.CommandTimeout = 20;
            _with1.CommandType = CommandType.StoredProcedure;
            _with1.Parameters.AddWithValue("@Usuario", Usuario);
            _with1.Parameters.AddWithValue("@Contraseña", Contraseña);
            try
            {
                Cn.Open();
                xfil = (Int32)Cmd.ExecuteScalar();
                if(xfil > 0)
                {
                    functionReturnValue = true;
                }
                else
                {
                    functionReturnValue = false;
                }

                Cmd.Parameters.Clear();
                Cmd.Dispose();
                Cmd = null;
                Cn.Close();
                Cn = null;


            }
            catch (Exception ex)
            {
                if (Cn.State == ConnectionState.Open)
                    Cn.Close();
                Cmd.Dispose();
                Cmd = null;
                Cn.Close();
                Cn = null;
                MessageBox.Show("Algo salio mal: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);


                //throw;
            }
            return functionReturnValue;
                 
        }// fin verificar 1:


        public DataTable BD_Leer_Datos_Usuario(string usuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Usuario_Login", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Usuario", usuario);
                DataTable datos = new DataTable();

                da.Fill(datos);
                da = null;
                return datos;


            }
            catch (Exception ex)
            {

                if (cn.State == ConnectionState.Open)
                    cn.Close();
                cn.Close();
                cn = null;
                MessageBox.Show("algo salio mal: " + ex.Message, "Advertencia del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                
            }

            return null;
        }
   }
}

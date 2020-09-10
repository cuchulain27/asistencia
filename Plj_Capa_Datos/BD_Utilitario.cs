using System;
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
    public class BD_Utilitario: BD_conexion
    {


        public static string BD_NroDoc(int Id_Tipo)
        {
            SqlConnection Cn = new SqlConnection();

            try
            {
                Cn.ConnectionString = Conectar2();
                SqlCommand cmd = new SqlCommand("Sp_Listado_TIpo", Cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Tipo", Id_Tipo);
                string NroDoc;

                Cn.Open();
                NroDoc = Convert.ToString(cmd.ExecuteScalar());
                Cn.Close();
                return NroDoc;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Advertencia del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (Cn.State == ConnectionState.Open) Cn.Close();
                Cn.Dispose();
                Cn = null;
                return null;
            }
        }


        public static void BD_Actualizar_Tipo_Doc(int Id_Tipo)
        {
            SqlConnection Cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand("Sp_Actualiza_Tipo_Doc", Cn);

            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Tipo", Id_Tipo);
                Cn.Open();
                cmd.ExecuteNonQuery();
                Cn.Close();
               

            }
            catch (Exception ex)
            {

               
                if (Cn.State == ConnectionState.Open) Cn.Close();
                cmd.Dispose();
                cmd = null;
                MessageBox.Show("Error: " + ex.Message, "Advertencia del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // listar tipo  robot automatico    
        public static string BD_Listar_TipoFalta(int Id_Tipo)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar2();
                SqlCommand cmd = new SqlCommand("Sp_Listado_TipoFalta",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Tipo", Id_Tipo);
                string TipoFalta;

                cn.Open();
                TipoFalta = Convert.ToString(cmd.ExecuteScalar());
                cn.Close();
                return TipoFalta;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Advertencia del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (cn.State == ConnectionState.Open) cn.Close();
                cn.Dispose();
                cn = null;
                return null;
            }
        }


        public static bool falta = false;

        public void BD_Actualizar_RobotFalta(int IdTipo, string serie)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Activar_Desac_RobotFalta",cn);

            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipo", IdTipo);
                cmd.Parameters.AddWithValue("@serie", serie);

                // codigo ejecucion conexion slq

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                falta = true;

            }
            catch (Exception ex)
            {

                falta = false;
                MessageBox.Show("Algo salio mal: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if(cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

        }






    }
}

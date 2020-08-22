using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Plj_Capa_Entidad;
using Prj_Capa_Entidad;



namespace Plj_Capa_Datos
{
    public class BD_Horario : BD_conexion
    {
        public static bool saved = false;

        public void BD_Actualizar_Horario(EN_Horario p)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = Conectar();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Update_Horario";
                cmd.Connection = cn;
                cmd.CommandTimeout = 20;
                // parametros
                cmd.Parameters.AddWithValue("@Idhor", p.Idhora);
                cmd.Parameters.AddWithValue("@HoEntrada", p.HoEntrada);
                cmd.Parameters.AddWithValue("@HoTolere", p.HoTole);
                cmd.Parameters.AddWithValue("@Holimite", p.HoLimite);
                cmd.Parameters.AddWithValue("@HoraSalida", p.HoSalida);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                cmd.Dispose();
                cn = null;

                saved = true;


            }
            catch (Exception ex)
            {
                saved = false;
                MessageBox.Show("hay un error al editar" + ex.Message, "Informe de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (cn.State == ConnectionState.Open) cn.Close();
                cmd.Dispose();
                cmd = null;
                cn.Dispose();
                cn = null;

            }
        }


        public DataTable BD_Leer_Horarios()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter Da = new SqlDataAdapter("Sp_Buscar_Todos_Horarios", cn);
                Da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable Datos = new DataTable();
                Da.Fill(Datos);
                Da = null;
                return Datos;


            }
            catch (Exception ex)
            {

                MessageBox.Show("hay un error  al consultar horario" + ex.Message, "informe de sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (cn.State == ConnectionState.Open) cn.Close();
                cn.Dispose();
                cn = null;
                return null;
            }
        }
    }
}

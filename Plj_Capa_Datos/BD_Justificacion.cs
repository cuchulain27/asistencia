using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plj_Capa_Entidad;
using System.Data.SqlClient;
using System.Windows.Forms;
using Prj_Capa_Entidad;
using System.Data;

namespace Plj_Capa_Datos
{
    public class BD_Justificacion : BD_conexion
    {
        public static bool saved = false;
        public static bool edited = false;
        public static bool tryed = false;
        public static bool supresed = false;

        public void BD_REgistrar_Justificacion(EN_Justificacion jus)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Insert_Justification", cn);

            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                //parametros
                cmd.Parameters.AddWithValue("@Id_Justi", jus.IdJusti);
                cmd.Parameters.AddWithValue("@Id_Personal", jus.Id_Personal);
                cmd.Parameters.AddWithValue("@Principalmoti", jus.PrincipalMotivo);
                cmd.Parameters.AddWithValue("@Detalle", jus.Detalle);
                cmd.Parameters.AddWithValue("@FechaJusti", jus.Fecha);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                saved = true;
            }
            catch (Exception ex)
            {

                saved = false;
                if(cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo malo ocurre: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        public void BD_Editar_Justificacion(EN_Justificacion jus)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Modificar_Justificacion", cn);

            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                //parametros
                cmd.Parameters.AddWithValue("@Id_Justi", jus.IdJusti);
                cmd.Parameters.AddWithValue("@Id_Personal", jus.Id_Personal);
                cmd.Parameters.AddWithValue("@Principalmoti", jus.PrincipalMotivo);
                cmd.Parameters.AddWithValue("@Detalle", jus.Detalle);
                cmd.Parameters.AddWithValue("@FechaJusti", jus.Fecha);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                edited = true;
            }
            catch (Exception ex)
            {

                edited = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo malo ocurre: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        public void BD_Aprobar_Justificacion(string idjusti, string idperson)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Aprobar_Justificacion", cn);

            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                //parametros
                cmd.Parameters.AddWithValue("@IdJusti", idjusti);
                cmd.Parameters.AddWithValue("@Id_Personal", idperson);
             

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                tryed = true;
            }
            catch (Exception ex)
            {

                tryed = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo malo ocurre: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }


        public void BD_Desaprobar_Justificacion(string idjusti, string idperson)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Desaprobar_Justification", cn);

            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                //parametros
                cmd.Parameters.AddWithValue("@IdJusti", idjusti);
                cmd.Parameters.AddWithValue("@Id_Personal", idperson);


                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                saved = true;
            }
            catch (Exception ex)
            {

                saved = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo malo ocurre: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        public DataTable BD_Cargar_todos_Justificacion()
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_Todas_Justificaciones", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dato = new DataTable();
                da.Fill(dato);
                da = null;
                return dato;

            }
            catch (Exception ex)
            {

                if (xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                }
                MessageBox.Show("Algo malo ocurre: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }


        public DataTable BD_BuscarJustificacio_porValor(string  xdato)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_Justificacion_xDni", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Id_Personal", xdato);
                DataTable dato = new DataTable();

                da.Fill(dato);
                da = null;
                return dato;

            }
            catch (Exception ex)
            {

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo malo ocurre: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public void BD_Eliminar_Justificacion(string idjusti)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Delete_Justificacion", cn);

            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                //parametros
                cmd.Parameters.AddWithValue("@IdJusti", idjusti);
       


                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                supresed = true;
            }
            catch (Exception ex)
            {

                supresed = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo malo ocurre: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}

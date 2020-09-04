using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Prj_Capa_Entidad;
using Plj_Capa_Entidad;
using System.Windows.Forms;

namespace Plj_Capa_Datos
{
    public class BD_Asistencia : BD_conexion
    {

        public DataTable BD_Ver_Todas_asistencia()
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_Asistencias", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //da.SelectCommand.Parameters.AddWithValue("@fecha", xdia);
                DataTable dato = new DataTable();
                da.Fill(dato);
                da = null;
                return dato;

            }
            catch (Exception ex)
            {

                if(xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                    throw new Exception("error" + ex.Message, ex);

                }
            }

            return null;
        }


        public DataTable BD_Ver_Todas_asistencia_DelDia(DateTime xfecha)
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_Asistencia_deldia", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fecha", xfecha);
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
                    throw new Exception("error" + ex.Message, ex);

                }
            }

            return null;
        }


        public DataTable BD_Ver_Todas_asistencia_DelMes(DateTime xfecha)
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_Asistencia_xfecha", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fecha", xfecha);
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
                    throw new Exception("error" + ex.Message, ex);

                }
            }

            return null;
        }


        public DataTable BD_Ver_Todas_asistencia_ParaExplorador(string xvalor)
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_Asistencia_paraExplorador", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Id_Asis", xvalor);
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
                    throw new Exception("error" + ex.Message, ex);

                }
            }

            return null;
        }

        // registro
        public static bool Entrada = false;
        public static bool Salida = false;

        public void BD_Registrar_Entrada_Personal(string idAsis, string idPerso, string HoIngreso, double Tarde, int TotalHora, string justificado)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Registrar_Entrada", cn);

            try
            {


                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                // parametros
                cmd.Parameters.AddWithValue("@IdAsis", idAsis);
                cmd.Parameters.AddWithValue("@Id_Persol", idPerso);
                cmd.Parameters.AddWithValue("@HoIngre", HoIngreso);
                cmd.Parameters.AddWithValue("@tardanza", Tarde);
                cmd.Parameters.AddWithValue("@TotalHora", TotalHora);
                cmd.Parameters.AddWithValue("@justificado", justificado);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                Entrada = true;
            }
            catch (Exception ex)
            {

                Entrada = false;
                if(cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                throw new Exception("Error al Guardar" + ex.Message, ex);
            }

        }


        public void BD_Registrar_Salida_Personal(string idAsis, string idPerso, string HoSalida, double Totalhora)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand("Sp_Registrar_Salida", cn);

            try
            {
                cmd.CommandTimeout = 10;
                cmd.CommandType = CommandType.StoredProcedure;

                // AGREGAR PARAMETROS
                cmd.Parameters.AddWithValue("@IdAsis", idAsis);
                cmd.Parameters.AddWithValue("@Id_Persol", idPerso);
                cmd.Parameters.AddWithValue("@HoSalida", HoSalida);
                cmd.Parameters.AddWithValue("@TotalHora", Totalhora);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                Salida = true;

            }
            catch (Exception ex)
            {


                Entrada = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                throw new Exception("Error al Guardar" + ex.Message, ex);
            }
        }

        // verificar
        public bool BD_Checar_SiPersonal_YaMarco_Asistencia(string xidperson)
        {
            bool functionReturnValue = false;
            Int32 xfil = 0;

            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = Conectar();

            var _with1 = cmd;
            _with1.CommandText = "Sp_Validar_RegistroAsistencia";
            _with1.Connection = cn;
            _with1.CommandTimeout = 20;
            _with1.CommandType = CommandType.StoredProcedure;
            _with1.Parameters.AddWithValue("@Id_Personal",xidperson);

            try
            {
                cn.Open();
                xfil = (Int32)cmd.ExecuteScalar();
                if (xfil > 0)
                {
                    functionReturnValue = true;
                }
                else
                {
                    functionReturnValue = false;
                }


                cmd.Parameters.Clear();
                cmd.Dispose();
                cmd = null;
                cn.Close();
                cn = null;

            }
            catch (Exception ex)
            {

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                    cmd.Dispose();
                    cmd = null;
                    cn.Close();
                    cn = null;
                    MessageBox.Show("Ocurrio un Error" + ex.Message, "Advertenci de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }

            return functionReturnValue;


        }// fin verificar


        public bool BD_Checar_SiPersonal_YaMarco_suEntrada(string xidperson)
        {
            bool functionReturnValue = false;
            Int32 xfil = 0;

            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = Conectar();

            var _with1 = cmd;
            _with1.CommandText = "Sp_Verificar_IngresoAsis";
            _with1.Connection = cn;
            _with1.CommandTimeout = 20;
            _with1.CommandType = CommandType.StoredProcedure;
            _with1.Parameters.AddWithValue("@Id_Personal", xidperson);

            try
            {
                cn.Open();
                xfil = (Int32)cmd.ExecuteScalar();
                if (xfil > 0)
                {
                    functionReturnValue = true;
                }
                else
                {
                    functionReturnValue = false;
                }


                cmd.Parameters.Clear();
                cmd.Dispose();
                cmd = null;
                cn.Close();
                cn = null;

            }
            catch (Exception ex)
            {

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                    cmd.Dispose();
                    cmd = null;
                    cn.Close();
                    cn = null;
                    MessageBox.Show("Ocurrio un Error" + ex.Message, "Advertenci de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

            return functionReturnValue;

        }// fin entrada


        public bool BD_Verificar_Justificacion_Aprobada(string idpers)
        {
            bool functionReturnValue = false;
            Int32 xfil = 0;

            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString = Conectar();

            var _with1 = cmd;
            _with1.CommandText = "Sp_VerificarJustificacion_Aprobada";
            _with1.Connection = cn;
            _with1.CommandTimeout = 20;
            _with1.CommandType = CommandType.StoredProcedure;
            _with1.Parameters.AddWithValue("@Id_Personal", idpers);

            try
            {
                cn.Open();
                xfil = (Int32)cmd.ExecuteScalar();
                if (xfil > 0)
                {
                    functionReturnValue = true;
                }
                else
                {
                    functionReturnValue = false;
                }


                cmd.Parameters.Clear();
                cmd.Dispose();
                cmd = null;
                cn.Close();
                cn = null;

            }
            catch (Exception ex)
            {

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                    cmd.Dispose();
                    cmd = null;
                    cn.Close();
                    cn = null;
                    MessageBox.Show("Ocurrio un Error" + ex.Message, "Advertenci de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

            return functionReturnValue;
        }// justificacion aprobada


        
        public DataTable BD_Buscar_Asistencia_deEntrada(string idperso)
        {
            SqlConnection xcn = new SqlConnection();

            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Leer_asistencia_reciente", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@idper", idperso);
                DataTable dato = new DataTable();
                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {

                if(xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                }
                MessageBox.Show("Algo Salio Mal: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            return null;
        }




    }
}

using MicroSisPlani;
using Prj_Capa_Negocio;
using Plj_Capa_Datos;
using Plj_Capa_Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSistemaAsistencia.Msm_Forms;
using MSistemaAsistencia.Personal;
using Prj_Capa_Entidad;
using System.IO;
using MSistemaAsistencia.Informes;

namespace MSistemaAsistencia
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void elTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void elButton1_Click(object sender, EventArgs e)
        {

        }

       

        private void elButton4_Click(object sender, EventArgs e)
        {
            elTabPage7.Visible = true;
            elTab1.SelectedTabPageIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            elTabPage7.Visible = false;
            elTab1.SelectedTabPageIndex = 0;
        }

        private void pnl_titu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

        #region persona

        private void ConfigurarListView()
        {
            var lis = lsv_person;
            lis.Columns.Clear();
            lis.Items.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;
            lis.Columns.Add("Id Persona",0, HorizontalAlignment.Left);
            lis.Columns.Add("Dni", 95, HorizontalAlignment.Left);
            lis.Columns.Add("Nombre del Socio", 316, HorizontalAlignment.Left);
            lis.Columns.Add("Direccion", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Correo", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Sex", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Fe Nacim.", 110, HorizontalAlignment.Left);
            lis.Columns.Add("Nro Celular", 120, HorizontalAlignment.Left);
            lis.Columns.Add("Rol", 100, HorizontalAlignment.Left);
            lis.Columns.Add("Distrito", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Estado", 100, HorizontalAlignment.Left);


        }


        private void Cargar_todo_Personal()
        {
            RN_Personal obj = new RN_Personal();
            DataTable dt = new DataTable();

            dt = obj.RN_Leer_todoPersona();
            if(dt.Rows.Count >0)
            {
                LlenarListView(dt);
            }
        }


        private void Buscar_Personal_PorValor(string xvalor)
        {
            RN_Personal obj = new RN_Personal();
            DataTable dt = new DataTable();

            dt = obj.RN_Buscar_Personal_xValor(xvalor);
            if (dt.Rows.Count>0)
            {
                LlenarListView(dt);
            }
            else
            {
                lsv_person.Items.Clear();
            }
        }

        private void LlenarListView(DataTable data)
        {
            lsv_person.Items.Clear();

            for(int i = 0; i > data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_Person"].ToString()); // cabezera de listview
                list.SubItems.Add(dr["DNIPR"].ToString());
                list.SubItems.Add(dr["Nombre_Completo"].ToString());
                list.SubItems.Add(dr["Domicilio"].ToString());
                list.SubItems.Add(dr["Correo"].ToString());
                list.SubItems.Add(dr["Sexo"].ToString());
                list.SubItems.Add(dr["Fec_Naci"].ToString());
                list.SubItems.Add(dr["Celular"].ToString());
                list.SubItems.Add(dr["NomRol"].ToString());

                list.SubItems.Add(dr["Distrito"].ToString());
                list.SubItems.Add(dr["Estado_Per"].ToString());
                lsv_person.Items.Add(list); // list se llenara

            }
            label10.Text = Convert.ToString(lsv_person.Items.Count);
        }


        private void txt_Buscar_OnValueChanged(object sender, EventArgs e)
        {
            if(txt_Buscar.Text.Trim().Length > 2)
            {
                Buscar_Personal_PorValor(txt_Buscar.Text.Trim());
            }
        }

        private void txt_Buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar_Personal_PorValor(txt_Buscar.Text.Trim());
            }
        }

        private void bt_mostrarTodoElPersonal_Click(object sender, EventArgs e)
        {
            Cargar_todo_Personal();
        }
        #endregion

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            ConfigurarListView();
            ConfiguraListview_Asis();
        }

        private void bt_copiarNroDNI_Click(object sender, EventArgs e)
        {
            Frm_Advertencia adver = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();

            if (lsv_person.SelectedIndices.Count == 0)
            {
                fil.Show();
                adver.Lbl_Msm1.Text = "Seleccione el Item que desea Copiar";
                adver.ShowDialog();
                fil.Hide(); return;
            }
            else
            {
                var lsv = lsv_person.SelectedItems[0];
                string xdin = lsv.SubItems[1].Text;

                Clipboard.Clear();
                Clipboard.SetText(xdin.Trim());
            }
        }

        private void bt_nuevoPersonal_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Registro_Personal per = new Frm_Registro_Personal();

            fil.Show();
            per.xedit = false;
            per.ShowDialog();

            fil.Hide();
            if (Convert.ToString(per.Tag) == "")
                return;
            {
                Cargar_todo_Personal();
            }
        }

        private void bt_editarPersonal_Click(object sender, EventArgs e)
        {
            
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Registro_Personal per = new Frm_Registro_Personal();

            if (lsv_person.SelectedIndices.Count == 0)
            {
                // mostrar mensaje 
                
            }
            else
            {
                var lsv = lsv_person.SelectedItems[0];
                string Idpersona = lsv.SubItems[0].Text;

                fil.Show();
                per.saveeditar = true;
                per.Buscar_Personal_ParaEditar(Idpersona);
                per.ShowDialog();
                fil.Hide();

                if (Convert.ToString(per.Tag)== "B")
                {
                    Cargar_todo_Personal();
                }
            }

             
        }

        private void btn_SaveHorario_Click(object sender, EventArgs e)
        {
            try
            {
                RN_Horario hor = new RN_Horario();
                EN_Horario por = new EN_Horario();
                Frm_Filtro fil = new Frm_Filtro();
                Msm_Bueno ok = new Msm_Bueno();
                Frm_Advertencia adver = new Frm_Advertencia();

                por.Idhora = lbl_idHorario.Text;
                por.HoEntrada = dtp_horaIngre.Value;
                por.HoTole = dtp_hora_tolercia.Value;
                por.HoLimite = Dtp_Hora_Limite.Value;
                por.HoSalida = dtp_horaSalida.Value;

                hor.RN_Actualizar_Horario(por);

                if (BD_Horario.saved ==true)
                {
                    fil.Show();
                    ok.Lbl_msm1.Text = "El horario Fue actualizado";
                    ok.ShowDialog();
                    fil.Hide();

                    elTabPage9.Visible = false;
                    elTab1.SelectedTabPageIndex = 0;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        private void CargarHorario()
        {
            RN_Horario obj = new RN_Horario();
            DataTable data = new DataTable();

            data = obj.RN_Leer_Horarios();
            if (data.Rows.Count == 0) return;

            lbl_idHorario.Text = Convert.ToString(data.Rows[0]["Id_hor"]);
            dtp_horaIngre.Value  = Convert.ToDateTime(data.Rows[0]["HoEntrada"]);
            dtp_horaSalida. Value  = Convert.ToDateTime(data.Rows[0]["HoSalida"]);
            dtp_hora_tolercia.Value  = Convert.ToDateTime(data.Rows[0]["MiTolrncia"]);
            Dtp_Hora_Limite.Value =  Convert.ToDateTime(data.Rows[0]["HoLimite"]);


        }

       public   void Cargar_Datos_Usuario()
        {
            try
            {
                Frm_Filtro xfil = new Frm_Filtro();


                xfil.Show();
                MessageBox.Show("Bienvenido SR: "+ Cls_Libreria.Apellidos, "Bienvenido al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xfil.Hide();

                Lbl_NomUsu.Text = Cls_Libreria.Apellidos;
                lbl_rolNom.Text = Cls_Libreria.Rol;

                if (Cls_Libreria.Foto.Trim().Length == 0 | Cls_Libreria.Foto == null) return;

                if(File.Exists(Cls_Libreria.Foto)== true)
                {
                    picuser.Load(Cls_Libreria.Foto);
                }
                else
                {
                    picuser.Image = Properties.Resources.user;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        #region "asistencia"

        private void ConfiguraListview_Asis()
        {
            var lis = lsv_asis;
            lis.Columns.Clear();
            lis.Items.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;
            lis.Columns.Add("Id Asis",0, HorizontalAlignment.Left);
            lis.Columns.Add("Dni", 80, HorizontalAlignment.Left);
            lis.Columns.Add("Nombres del Personal", 316, HorizontalAlignment.Left);
            lis.Columns.Add("Fecha", 90, HorizontalAlignment.Left);
            lis.Columns.Add("Dia", 80, HorizontalAlignment.Left);
            lis.Columns.Add("Ho Ingreso", 90, HorizontalAlignment.Left);
            lis.Columns.Add("Tardnza", 70, HorizontalAlignment.Left);
            lis.Columns.Add("Ho Salida", 90, HorizontalAlignment.Left);
            lis.Columns.Add("Adelanto", 90, HorizontalAlignment.Left);
            lis.Columns.Add("Justificacion", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Estado", 100, HorizontalAlignment.Left);

        }



        private void LlenarListView_Asis(DataTable data)
        {
            lsv_asis.Items.Clear();

            for (int i = 0; i > data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_Person"].ToString()); // cabezera de listview
                list.SubItems.Add(dr["DNIPR"].ToString());
                list.SubItems.Add(dr["Nombre_Completo"].ToString());
                list.SubItems.Add(dr["FechaAsis"].ToString());
                list.SubItems.Add(dr["Nombre_dia"].ToString());
                list.SubItems.Add(dr["Tardanzas"].ToString());
                list.SubItems.Add(dr["HoSalida"].ToString());
                list.SubItems.Add(dr["Adelanto"].ToString());

                list.SubItems.Add(dr["Justificacion"].ToString());
                list.SubItems.Add(dr["EstadoAsis"].ToString());
                lsv_asis.Items.Add(list); // list se llenara

            }
            label10.Text = Convert.ToString(lsv_asis.Items.Count);
        }



        private void Carga_todas_Asistencias()
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dt = new DataTable();

            dt = obj.RN_Ver_Todas_asistencia();
            if (dt.Rows.Count > 0)
            {
                //llamamos al metodo
                LlenarListView_Asis(dt);
            }
        }



        private void Carga_todas_Asistencias_delDia(DateTime fechas)
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dt = new DataTable();

            dt = obj.RN_Ver_Todas_asistencia_DelDia(fechas);
            if (dt.Rows.Count > 0)
            {
                //llamamos al metodo
                LlenarListView_Asis(dt);
            }
        }

        private void Carga_todas_Asistencias_delMes(DateTime fechas)
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dt = new DataTable();

            dt = obj.RN_Ver_Todas_asistencia_DelMes(fechas);
            if (dt.Rows.Count > 0)
            {
                //llamamos al metodo
                LlenarListView_Asis(dt);
            }
        }


        private void Carga_todas_Asistencias_porValor(string xvalor)
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dt = new DataTable();

            dt = obj.RN_Ver_Todas_asistencia_ParaExplorador(xvalor);
            if (dt.Rows.Count > 0)
            {
                //llamamos al metodo
                LlenarListView_Asis(dt);
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Carga_todas_Asistencias();
        }


        private void txt_buscarAsis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Carga_todas_Asistencias_porValor(txt_Buscar.Text);
            }
        }


        private void lbl_lupaAsis_Click(object sender, EventArgs e)
        {
            Carga_todas_Asistencias();
        }

        private void verAsistenciasDelDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Solo_Fecha solo = new Frm_Solo_Fecha();

            fil.Show();
            solo.ShowDialog();
            fil.Hide();


            if (Convert.ToString(solo.Tag) == "") return;

            DateTime xfecha = solo.dtp_fecha.Value;

            Carga_todas_Asistencias_delDia(xfecha);

        }
        #endregion


        #region "Botones"

        private void elButton1_Click_1(object sender, EventArgs e)
        {
            elTabPage9.Visible = true;
            elTab1.SelectedTabPageIndex = 3;
            CargarHorario();

            
            

        }

        private void elButton2_Click(object sender, EventArgs e)
        {

        }

        private void elButton3_Click(object sender, EventArgs e)
        {
            elTabPage8.Visible = true;
            elTab1.SelectedTabPageIndex = 2;
            Carga_todas_Asistencias_delDia(dtp_fechadeldia.Value);
        }

        private void elTabPage9_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Sino sino = new Frm_Sino();

            fil.Show();
            sino.Lbl_msm1.Text = "¿Estas seguro de salir del sistema?";
            sino.ShowDialog();
            fil.Hide();

            if (Convert.ToString(sino.Tag)=="Si")
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

       
    }
}

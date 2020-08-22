﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plj_Capa_Datos;
using Plj_Capa_Entidad;
using Prj_Capa_Negocio;
using MSistemaAsistencia.Msm_Forms;
using Prj_Capa_Entidad;
using MicroSisPlani;

namespace MSistemaAsistencia.Personal
{
    public partial class Frm_Registro_Personal : Form
    {
        public Frm_Registro_Personal()
        {
            InitializeComponent();
        }

        public bool saveeditar = false;

        // public bool  editperson = false;

        private void Frm_Registro_Personal_Load(object sender, EventArgs e)
        {
            if(saveeditar== false)
            {
                Cargar_rol();
                Cargar_Distrito();
            }
             
        }

        private void Cargar_rol()
        {
            RN_Rol obj = new RN_Rol();
            DataTable dt = new DataTable();

            try
            {
                dt = obj.RN_Buscar_Todos_Roles();
                if (dt.Rows.Count > 0)
                {
                    var cbo = cbo_rol;
                    cbo.DataSource = dt;
                    cbo.DisplayMember = "NomRol";
                    cbo.ValueMember = "Id_Rol";
                }

                cbo_rol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private void Cargar_Distrito()
        {
            RN_Distrito obj = new RN_Distrito();
            DataTable dt = new DataTable();

            try
            {
                dt = obj.RN_Buscar_Todos_Distrito();
                if (dt.Rows.Count > 0)
                {
                    var cbo = cbo_Distrito;
                    cbo.DataSource = dt;
                    cbo.DisplayMember = "Distrito";
                    cbo.ValueMember = "Id_Distrito";
                }

                cbo_Distrito.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private bool ValidarCajasTexto()
        {
            Frm_Advertencia ver = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();
            if(txt_Dni.Text.Trim().Length < 8) { fil.Show(); ver.Lbl_Msm1.Text = "El numero  de DNI no es valido"; ver.ShowDialog(); fil.Hide(); txt_Dni.Focus(); return false; }
            if (txt_nombres.Text.Trim().Length < 8) { fil.Show(); ver.Lbl_Msm1.Text = "Ingrese el nombre del personal"; ver.ShowDialog(); fil.Hide(); txt_Dni.Focus(); return false; }
            if (txt_direccion.Text.Trim().Length < 4) { fil.Show(); ver.Lbl_Msm1.Text = "Ingrese la Direcion del Personal"; ver.ShowDialog(); fil.Hide(); txt_Dni.Focus(); return false; }
            if (txt_correo.Text.Trim().Length < 4) { fil.Show(); ver.Lbl_Msm1.Text = "El numero  de DNI no es valido"; ver.ShowDialog(); fil.Hide(); txt_Dni.Focus(); return false; }
            if (txt_NroCelular.Text.Trim().Length < 4) { fil.Show(); ver.Lbl_Msm1.Text = "El numero  de DNI no es valido"; ver.ShowDialog(); fil.Hide(); txt_Dni.Focus(); return false; }
            if (txt_IdPersona.Text.Trim().Length < 8) { fil.Show(); ver.Lbl_Msm1.Text = "Id no generado"; ver.ShowDialog(); fil.Hide(); txt_Dni.Focus(); return false; }
            if (txt_Dni.Text.Trim().Length < 8) { fil.Show(); ver.Lbl_Msm1.Text = "El numero  de DNI no es valido"; ver.ShowDialog(); fil.Hide(); txt_Dni.Focus(); return false; }
            
            if(cbo_sexo.SelectedIndex == -1) { fil.Show(); ver.Lbl_Msm1.Text = "seleccione el sexo del personal"; ver.ShowDialog(); fil.Hide(); cbo_sexo.Focus(); return false; }
            if (cbo_rol.SelectedIndex == -1) { fil.Show(); ver.Lbl_Msm1.Text = "seleccione el rol del personal"; ver.ShowDialog(); fil.Hide(); cbo_sexo.Focus(); return false; }
            if (cbo_Distrito.SelectedIndex == -1) { fil.Show(); ver.Lbl_Msm1.Text = "seleccione el distrito del personal"; ver.ShowDialog(); fil.Hide(); cbo_sexo.Focus(); return false; }
            return true;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            Frm_Advertencia ok = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();
            RN_Personal objper = new RN_Personal();

            if (ValidarCajasTexto() == false) return;


            if(xedit == false)
            {
                if (objper.RN_Verificar_DniPersonal(txt_Dni.Text) == true)
                {
                    MessageBox.Show("El numero de Dni YA EXISTE", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                    Guardar_Personal();
                   
                }
                else
                {
                    Editar_Personal();
                }
            }
            
        }

        private void Guardar_Personal()
        {
            Msm_Bueno ok = new Msm_Bueno();
            Frm_Filtro fil = new Frm_Filtro();
            RN_Personal obj = new RN_Personal();
            EN_Persona per = new EN_Persona();

            try
            {
                per.Idpersonal = txt_IdPersona.Text;
                per.Dni = txt_Dni.Text;
                per.Nombres = txt_nombres.Text;
                per.anoNacimiento = dtp_fechaNaci.Value;
                per.Sexo = cbo_sexo.Text;
                per.Direccion = txt_direccion.Text;
                per.Correo = txt_correo.Text;
                per.Celular = Convert.ToInt32(txt_NroCelular.Text);
                per.IdRol = Convert.ToString(cbo_rol.SelectedValue);
                per.xImagen = xfotoruta;
                per.IdDistrito = Convert.ToString(cbo_Distrito.SelectedValue);

                obj.RN_Registral_Personal(per);


                if(BD_Personal.saved == true)
                {
                    fil.Show();
                    ok.Lbl_msm1.Text = "Los datos del Personal se han guardado correctamente";
                    ok.ShowDialog();
                    fil.Hide();


                    this.Tag = "A";
                    this.Close();

                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }


        // editar

        private void Editar_Personal()
        {
            Msm_Bueno ok = new Msm_Bueno();
            Frm_Filtro fil = new Frm_Filtro();
            RN_Personal obj = new RN_Personal();
            EN_Persona per = new EN_Persona();

            try
            {
                per.Idpersonal = txt_IdPersona.Text;
                per.Dni = txt_Dni.Text;
                per.Nombres = txt_nombres.Text;
                per.anoNacimiento = dtp_fechaNaci.Value;
                per.Sexo = cbo_sexo.Text;
                per.Direccion = txt_direccion.Text;
                per.Correo = txt_correo.Text;
                per.Celular = Convert.ToInt32(txt_NroCelular.Text);
                per.IdRol = Convert.ToString(cbo_rol.SelectedValue);
                per.xImagen = xfotoruta;
                per.IdDistrito = Convert.ToString(cbo_Distrito.SelectedValue);

                obj.RN_Editar_Personal(per);


                if (BD_Personal.edited == true)
                {
                    fil.Show();
                    ok.Lbl_msm1.Text = "Los datos del Personal se han editado correctamente";
                    ok.ShowDialog();
                    fil.Hide();


                    this.Tag = "B";
                    this.Close();

                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        string xfotoruta;

        private void Pic_persona_Click(object sender, EventArgs e)
        {
            var filepath = string.Empty;

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    xfotoruta = openFileDialog1.FileName;
                    Pic_persona.Load(xfotoruta);
                }
            }
            catch (Exception ex)
            {

                xfotoruta = Application.StartupPath + @"\user.png";
                Pic_persona.Load(Application.StartupPath + @"\user.png");
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void pnl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

        public bool xedit = false;

        private void txt_NroCelular_OnValueChanged(object sender, EventArgs e)
        {
            string xcar1;
            string xcar2;

            if (xedit == false)
            {
                if (txt_Dni.Text.Length == 0) return;
                if (txt_nombres.Text.Length == 0) return;

                xcar1 = Convert.ToString(txt_Dni.Text).Substring(3, 5);
                xcar2 = Convert.ToString(txt_nombres).Substring(1, 4);
                txt_IdPersona.Text = xcar1 + "-" + xcar2;
            }
        }


        public void Buscar_Personal_ParaEditar(string  idpersonal)
        {
            try
            {
                RN_Personal obj = new RN_Personal();
                DataTable dt = new DataTable();

                Cargar_rol();
                Cargar_Distrito();

                dt = obj.RN_Buscar_Personal_xValor(idpersonal);
                if (dt.Rows.Count == 0) return;
                {
                    txt_Dni.Text = Convert.ToString(dt.Rows[0]["DNIPR"]);
                    txt_nombres.Text = Convert.ToString(dt.Rows[0]["Nombre_Completo"]);
                    txt_direccion.Text = Convert.ToString(dt.Rows[0]["Domicilio"]);
                    txt_correo.Text = Convert.ToString(dt.Rows[0]["Correo"]);
                    txt_NroCelular.Text = Convert.ToString(dt.Rows[0]["Celular"]);
                    dtp_fechaNaci.Text = Convert.ToString(dt.Rows[0]["Fec_Naci"]);
                    cbo_sexo.Text = Convert.ToString(dt.Rows[0]["Sexo"]);
                    cbo_rol.SelectedValue = Convert.ToString(dt.Rows[0]["Id_rol"]);
                    cbo_Distrito.SelectedValue = Convert.ToString(dt.Rows[0]["Id_Distrito"]);
                    txt_IdPersona.Text = Convert.ToString(dt.Rows[0]["Id_Pernl"]);
                    xfotoruta = Convert.ToString(dt.Rows[0]["Foto"]);
                }

                xedit = true;
                btn_aceptar.Enabled = true;
                Pic_persona.Load(xfotoruta);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al buscar datos" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

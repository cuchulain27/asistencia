using MicroSisPlani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Capa_Negocio;

namespace MSistemaAsistencia
{
    public partial class Fmr_Login : Form
    {
        public Fmr_Login()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool ValidarTexBox()
        {
            if(BoxUser.Text.Trim().Length ==0) { MessageBox.Show("ingresa Usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); BoxUser.Focus(); return false; }
            if (BoxPass.Text.Trim().Length == 0) { MessageBox.Show("ingresa Contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); BoxPass.Focus(); return false; }

            return true;
        }

        private void AccederSistema()
        {
            RN_Usuario obj = new RN_Usuario();
            DataTable dt = new DataTable();

            int veces = 0;

            if (ValidarTexBox() == false) return;

            string usu, pass;
            usu = BoxUser.Text.Trim();
            pass = BoxPass.Text.Trim();

            if(obj.RN_Verificar_Acceso(usu,pass) == true)
            {
                // los datos son correctos
                MessageBox.Show("Bienvenido al Sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Cls_Libreria.Usuario = usu;
                
                dt= obj.RN_Leer_Datos_Usuario(usu);
                if(dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    Cls_Libreria.IdUsu = Convert.ToString(dr["Id_Usu"]);
                    Cls_Libreria.Apellidos = dr["Nombre_Completo"].ToString();
                    Cls_Libreria.IdRol = Convert.ToString(dr["Id_Rol"]);
                    Cls_Libreria.Rol = dr["NomRol"].ToString();
                    Cls_Libreria.Foto = dr["Avatar"].ToString();


                }

                this.Hide();
                Frm_Principal xmenuprincipal = new Frm_Principal();
                xmenuprincipal.Show();
                xmenuprincipal.Cargar_Datos_Usuario();

            }
            else
            {

                // si no son corractos
                MessageBox.Show("Usuario o contraseña no son validos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BoxUser.Text = "";
                BoxPass.Text = "";

                BoxUser.Focus();
                veces += 1;

                if(veces == 3)
                {
                    MessageBox.Show("El numero maximo de intentos fue superado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
            }


        }

        private void paneltitu_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button ==MouseButtons.Left)
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

        private void BoxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BoxPass.Focus();
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            AccederSistema();
        }

        private void BoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_Aceptar.Focus();
            }
        }
    }
}

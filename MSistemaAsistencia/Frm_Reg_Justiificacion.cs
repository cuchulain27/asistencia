﻿using MicroSisPlani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plj_Capa_Datos;
using Prj_Capa_Negocio;
using MSistemaAsistencia.Msm_Forms;
using Prj_Capa_Entidad;

namespace MSistemaAsistencia
{
    public partial class Frm_Reg_Justiificacion : Form
    {
        public Frm_Reg_Justiificacion()
        {
            InitializeComponent();
        }

        public bool xedit = false;


        private void Frm_Reg_Justiificacion_Load(object sender, EventArgs e)
        {

        }

        private void lbl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

        private void pnl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private bool ValidarDatos()
        {
            Frm_Advertencia adv = new Frm_Advertencia();
            Frm_Filtro fil = new Frm_Filtro();

            if(txt_IdPersona.Text.Length < 8) { fil.Show(); adv.Lbl_Msm1.Text = "el id personal no fue escrito"; adv.ShowDialog(); fil.Hide(); txt_IdPersona.Focus(); return false;  }
            if (txt_idjusti.Text.Length < 8) { fil.Show(); adv.Lbl_Msm1.Text = "el id justificacion no fue escrito"; adv.ShowDialog(); fil.Hide(); txt_idjusti.Focus(); return false; }

            if (cbo_motivJusti.SelectedIndex == -1) { fil.Show(); adv.Lbl_Msm1.Text = "Selecione el motivo de la justificacion"; adv.ShowDialog(); fil.Hide(); cbo_motivJusti.Focus(); return false; }
            if (txt_DetalleJusti.Text.Trim().Length < 5) { fil.Show(); adv.Lbl_Msm1.Text = "Ingrese un breve descripcion de la justificacion"; adv.ShowDialog(); fil.Hide(); txt_DetalleJusti.Focus(); return false; }

            return true;

        }

        private void LimpiarPiso()
        {
            txt_DetalleJusti.Text = "";
            txt_idjusti.Text = "";
            txt_IdPersona.Text = "";
            txt_nompersona.Text = "";
            cbo_motivJusti.Text = "";
        }


        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if(xedit == true)
                {
                    Editar_Justificacion();
                }
                else
                {
                    Registrar_Justificacion();
                }
            }
        }

        private void Registrar_Justificacion()
        {
            RN_Justificacion obj = new RN_Justificacion();
            EN_Justificacion jus = new EN_Justificacion();

            Frm_Filtro fil = new Frm_Filtro();
            Msm_Bueno ok = new Msm_Bueno();

            try
            {
                jus.IdJusti = txt_idjusti.Text.Trim();
                jus.Id_Personal = txt_IdPersona.Text;
                jus.PrincipalMotivo = cbo_motivJusti.Text;
                jus.Detalle = txt_DetalleJusti.Text;
                jus.Fecha = Dtp_FechaJusti.Value;

                obj.RN_REgistrar_Justificacion(jus);

                if(BD_Justificacion.saved == true)
                {
                    RN_Utilitario.RN_Actualizar_Tipo_Doc(4);

                    fil.Show();
                    ok.Lbl_msm1.Text = "La solicitud de la justificacion fue registrada con exito";
                    ok.ShowDialog();
                    fil.Hide();

                    LimpiarPiso();
                    this.Tag = "A";
                    this.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Revisa el erro: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void Editar_Justificacion()
        {
            RN_Justificacion obj = new RN_Justificacion();
            EN_Justificacion jus = new EN_Justificacion();

            Frm_Filtro fil = new Frm_Filtro();
            Msm_Bueno ok = new Msm_Bueno();

            try
            {
                jus.IdJusti = txt_idjusti.Text.Trim();
                jus.Id_Personal = txt_IdPersona.Text;
                jus.PrincipalMotivo = cbo_motivJusti.Text;
                jus.Detalle = txt_DetalleJusti.Text;
                jus.Fecha = Dtp_FechaJusti.Value;

                obj.RN_Editar_Justificacion(jus);

                if (BD_Justificacion.edited == true)
                {
                    RN_Utilitario.RN_Actualizar_Tipo_Doc(4);

                    fil.Show();
                    ok.Lbl_msm1.Text = "La solicitud de la justificacion fue registrada con exito";
                    ok.ShowDialog();
                    fil.Hide();

                    LimpiarPiso();
                    this.Tag = "A";
                    this.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Revisa el erro: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        public void BuscarJustificacion(string idjusti)
        {
            try
            {
                RN_Justificacion obj = new RN_Justificacion();
                DataTable data = new DataTable();

                data = obj.RN_BuscarJustificacio_porValor(idjusti.Trim());
                if (data.Rows.Count == 0) return;
                {
                    Dtp_FechaJusti.Value = Convert.ToDateTime(data.Rows[0]["FechaJusti"]);
                    cbo_motivJusti.Text = Convert.ToString(data.Rows[0]["PrincipalMotivo"]);
                    txt_DetalleJusti.Text = Convert.ToString(data.Rows[0]["Detalle_Justi"]);


                }

                xedit = true;
                btn_aceptar.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al buscar los datos: " +ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}

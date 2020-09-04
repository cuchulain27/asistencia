﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Capa_Entidad;
using Prj_Capa_Negocio;
using Plj_Capa_Datos;
using System.IO;

namespace MicroSisPlani.Personal
{
    public partial class Frm_Regis_Huella : Form
    {
        public Frm_Regis_Huella()
        {
            InitializeComponent();
        }

        private void Frm_Regis_Huella_Load(object sender, EventArgs e)
        {

        }

        private void pnl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button ==MouseButtons.Left )
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
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

        public void Buscar_Personal_ParaEditar(string dni)
        {
            string xFotoRuta;
            try
            {
                RN_Personal obj = new RN_Personal();
                DataTable data = new DataTable();

                data = obj.RN_Buscar_Personal_xValor(dni);
                if (data.Rows.Count == 0) return;
                {
                    lbl_nroDni.Text = Convert.ToString(data.Rows[0]["DNIPR"]);
                    lbl_nomPersona.Text = Convert.ToString(data.Rows[0]["Nombre_Completo"]);
                    xFotoRuta = Convert.ToString(data.Rows[0]["Foto"]);
                    lbl_idperso.Text = dni;
                }

                if (File.Exists(xFotoRuta)== true)
                {
                    picFoto.Load(xFotoRuta);
                }
                else
                {
                    picFoto.Load(Application.StartupPath + @"\user.png");
                }

            }
            catch (Exception ex)
            {

                picFoto.Load(Application.StartupPath + @"\user.png");
                MessageBox.Show("Error al Buscar los Datos: "+ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void EnrollmentControl_Load(object sender, EventArgs e)
        {

        }

        private void EnrollmentControl_OnStartEnroll(object Control, string ReaderSerialNumber, int Finger)
        {
            ListEvents.Items.Insert(0, String.Format("OnStartEnroll: {0}, finger {1}", ReaderSerialNumber, Finger));
        }

        private void EnrollmentControl_OnSampleQuality(object Control, string ReaderSerialNumber, int Finger, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            ListEvents.Items.Insert(0, String.Format("OnSampleQuality: {0}, finger {1}, {2}", ReaderSerialNumber, Finger, CaptureFeedback));
        }

        private void EnrollmentControl_OnReaderDisconnect(object Control, string ReaderSerialNumber, int Finger)
        {
            ListEvents.Items.Insert(0, String.Format("OnReaderDisconnect: {0}, finger {1}", ReaderSerialNumber, Finger));
        }

        private void EnrollmentControl_OnReaderConnect(object Control, string ReaderSerialNumber, int Finger)
        {
            ListEvents.Items.Insert(0, String.Format("OnReaderConnect: {0}, finger {1}", ReaderSerialNumber, Finger));
        }

        private void EnrollmentControl_OnFingerTouch(object Control, string ReaderSerialNumber, int Finger)
        {
            ListEvents.Items.Insert(0, String.Format("OnFingerTouch: {0}, finger {1}", ReaderSerialNumber, Finger));
        }

        private void EnrollmentControl_OnFingerRemove(object Control, string ReaderSerialNumber, int Finger)
        {
            ListEvents.Items.Insert(0, String.Format("OnFingerRemove: {0}, finger {1}", ReaderSerialNumber, Finger));
        }

        private void EnrollmentControl_OnEnroll(object Control, int FingerMask, DPFP.Template Template, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            byte[] bytes = null;
            RN_Personal obj = new RN_Personal();
            if (Template is null)
            {
                Template.Serialize(ref bytes);
                MessageBox.Show("No se puede Realizar la Operacion", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl_idperso.Text = "";
                lbl_nomPersona.Text = "";
                lbl_nroDni.Text = "";
                picFoto.Image = null;
                this.Tag = "";
                this.Close();


            }
            else
            {
                Template.Serialize(ref bytes);
                obj.RN_Registrar_Huella_Personal(lbl_idperso.Text, bytes);
                lbl_idperso.Text = "";
                lbl_nomPersona.Text = "";
                lbl_nroDni.Text = "";
                picFoto.Image = null;

                if (BD_Personal.Huella == true)
                {
                    MessageBox.Show("la Huella Dactilar del Personal, Fue Registrada con Exito", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Tag = "A";
                    this.Close();
                }
               
            }
        }
    }
}

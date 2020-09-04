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
using System.Windows.Forms.Layout;
using DPFP;
using Prj_Capa_Negocio;
using Plj_Capa_Datos;
using MSistemaAsistencia.Msm_Forms;
using System.IO;

namespace MSistemaAsistencia
{
    public partial class Frm_Marcar_Asistencia : Form
    {
        public Frm_Marcar_Asistencia()
        {
            InitializeComponent();
        }

        private void pnl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitarios move = new Utilitarios();
            if (e.Button == MouseButtons.Left)
            {
                move.Mover_formulario(this);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DPFP.Verification.Verification verificar;
        private DPFP.Verification.Verification.Result resultado;

        private void Frm_Marcar_Asistencia_Load(object sender, EventArgs e)
        {
            verificar = new DPFP.Verification.Verification();
            resultado = new DPFP.Verification.Verification.Result();
            CargarHorario();
        }


        private void CargarHorario()
        {
            RN_Horario obj = new RN_Horario();
            DataTable data = new DataTable();

            data = obj.RN_Leer_Horarios();
            if (data.Rows.Count == 0) return;
            dtp_horaIngre.Value = Convert.ToDateTime(data.Rows[0]["HoEntrada"]);
            Lbl_HoraEntrada.Text = dtp_horaIngre.Value.Hour.ToString() + ":" + dtp_horaIngre.Value.Minute.ToString();
            dtp_horaSalida.Value = Convert.ToDateTime(data.Rows[0]["HoEntrda"]);
            dtp_hora_tolercia.Value = Convert.ToDateTime(data.Rows[0]["MiTolrncia"]);
            Dtp_Hora_Limite.Value = Convert.ToDateTime(data.Rows[0]["HoLimite"]);

        }

        private void xVerificationControl_OnComplete(object Control, FeatureSet FeatureSet, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            DPFP.Template TemplateBD = new DPFP.Template();
            RN_Personal obj = new RN_Personal();
            RN_Asistencia objas = new RN_Asistencia();
            DataTable datospers = new DataTable();
            DataTable dataasis = new DataTable();

            string NroIDPersona = "";
            int xint = 1;
            byte[] finguerByte;
            string rutaFoto;
            bool TerminarBucle = false;
            int TotalFila = 0;


            Frm_Filtro fil = new Frm_Filtro();

            int HoLimite = Dtp_Hora_Limite.Value.Hour;
            int MiLimite = Dtp_Hora_Limite.Value.Minute;

            int horaCaptu = DateTime.Now.Hour;
            int minutoCaptu = DateTime.Now.Minute;

            try
            {
                datospers = obj.RN_Leer_todoPersona();
                TotalFila = datospers.Rows.Count;

                if (datospers.Rows.Count <=0) return;

                var DatoPe = datospers.Rows[0];
                foreach (DataRow xitem in datospers.Rows)
                {
                    finguerByte = (byte[])xitem["FinguerPrint"];
                    NroIDPersona = Convert.ToString(xitem["Id_Pernl"]);

                    TemplateBD.DeSerialize(finguerByte);

                    verificar.Verify(FeatureSet, TemplateBD, ref resultado);

                    if(resultado.Verified == true)
                    {
                        rutaFoto = Convert.ToString(xitem["Foto"]);
                        lbl_nombresocio.Text = Convert.ToString(xitem["Nombre_Completo"]);
                        Lbl_Idperso.Text = Convert.ToString(xitem["Id_Pernl"]);
                        lbl_Dni.Text = Convert.ToString(xitem["DNIPR"]);

                        if(File.Exists(rutaFoto)== true) { picSocio.Load(rutaFoto.Trim()); } else { picSocio.Load(Application.StartupPath + @"\user.png"); }


                        if (objas.RN_Checar_SiPersonal_YaMarco_Asistencia(Lbl_Idperso.Text.Trim())== true)
                        {
                            lbl_msm.BackColor = Color.MistyRose;
                            lbl_msm.ForeColor = Color.Red;
                            lbl_msm.Text = "El Sistema Verifico, Marco Asistencia";
                            tocar_timbre();
                            lbl_Cont.Text = "10";
                            xVerificationControl.Enabled = true;
                            pnl_Msm.Visible = true;
                            tmr_Conta.Enabled = true;
                            return;
                        }


                        if (objas.RN_Checar_SiPersonal_YaMarco_suEntrada(Lbl_Idperso.Text.Trim()) == true)
                        {
                            Frm_sinox sinox = new Frm_sinox();
                            TerminarBucle = true;
                            fil.Show();
                            sinox.Lbl_msm1.Text = "El Usuario ya tiene registro de Entrada, ¿Quieres Marcar su Salida?";
                            sinox.ShowDialog();
                            fil.Hide();

                            if (Convert.ToString(sinox.Tag) == "Si")
                            {
                                dataasis = objas.RN_Buscar_Asistencia_deEntrada(Lbl_Idperso.Text);
                                if (dataasis.Rows.Count < 1) return;
                                lbl_IdAsis.Text = Convert.ToString(dataasis.Rows[0]["Id_asis"]);
                                objas.RN_Registrar_Salida_Personal(lbl_IdAsis.Text, Lbl_Idperso.Text, lbl_hora.Text, 8);

                                if(BD_Asistencia.Salida == true)
                                {

                                    lbl_msm.BackColor = Color.YellowGreen;
                                    lbl_msm.ForeColor = Color.White;
                                    lbl_msm.Text = "La Salida del Personal fue Registrada";
                                    tocar_timbreok();
                                    xVerificationControl.Enabled = false;
                                    pnl_Msm.Visible = true;
                                    lbl_Cont.Text = "10";
                                    tmr_Conta.Enabled = true;

                                    TerminarBucle = true;
                                    
                                }

                                
                            }
                        }
                        else
                        {
                            // marcar su entrada:
                            if (horaCaptu >= HoLimite)
                            {
                                lbl_msm.BackColor = Color.MistyRose;
                                lbl_msm.ForeColor = Color.Red;
                                lbl_msm.Text = "Estimado Usuario, Su Hora de Entrada ya caduco";
                                tocar_timbre();
                                pnl_Msm.Visible = true;
                                tmr_Conta.Enabled = true;
                                lbl_Cont.Text = "10";
                                xVerificationControl.Enabled = false;
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }


        }























        private void Calcular_Minutos_Tardanza()
        {
            RN_Asistencia obj = new RN_Asistencia();

            int HoraCaptu = DateTime.Now.Hour;
            int minutoCaptu = DateTime.Now.Minute;

            int horaIn = dtp_horaIngre.Value.Hour;
            int minuIn = dtp_horaIngre.Value.Minute;

            int Mntotole = dtp_hora_tolercia.Value.Minute;

            int totalminutofijo;
            int totaltardnza;

            if (obj.RN_Verificar_Justificacion_Aprobada(Lbl_Idperso.Text)== true)
            {
                lbl_justifi.Text = "Tardanza justificada";
            }
            else
            {
                lbl_justifi.Text = "Tardanza no justificada";
                totalminutofijo = minuIn + Mntotole;

                if (HoraCaptu == horaIn & minutoCaptu > totalminutofijo)
                {
                    totaltardnza = minutoCaptu - totalminutofijo;
                    lbl_totaltarde.Text = Convert.ToString(totaltardnza);
                }
                else if (HoraCaptu > horaIn)
                {
                    int horatarde;
                    horatarde = HoraCaptu - horaIn;
                    int horaenminuto;
                    horaenminuto = horatarde * 60;
                    int totaltardexx = horaenminuto - totalminutofijo;

                    totaltardnza = minutoCaptu + totaltardexx;
                    lbl_totaltarde.Text = Convert.ToString(totaltardnza);
                }
            }
        }





        private void tocar_timbre()
        {
            string ruta;
            ruta = Application.StartupPath;
            System.Media.SoundPlayer son;
            son = new System.Media.SoundPlayer(ruta + @"\timbre1.wav");
            son.Play();

        }


        private void tocar_timbreok()
        {
            string ruta;
            ruta = Application.StartupPath;
            System.Media.SoundPlayer son;
            son = new System.Media.SoundPlayer(ruta + @"\SD_ALERT_43.wav");
            son.Play();

        }


        private int sec = 10;

        private void tmr_Conta_Tick(object sender, EventArgs e)
        {
            sec -= 1;
            lbl_Cont.Text = sec.ToString();
            lbl_Cont.Refresh();

            if (sec == 0)
            {
                LimpiarFormulario();
                sec = 10;
                tmr_Conta.Stop();
                pnl_Msm.Visible = false;
                xVerificationControl.Enabled = true;
                lbl_Cont.Text = "10";
            }
        }


        private void LimpiarFormulario()
        {
            lbl_nombresocio.Text = "";
            lbl_totaltarde.Text = "0";
            lbl_TotalHotrabajda.Text = "0";
            lbl_Dni.Text = "";
            lbl_Cont.Text = "0";
            lbl_IdAsis.Text = "";
            Lbl_Idperso.Text = "";
            lbl_justifi.Text = "";
            lbl_msm.BackColor = Color.Transparent;
            lbl_msm.Text = "";
            picSocio.Image = null;
            xVerificationControl.Enabled = true;


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroSisPlani;
using Prj_Capa_Negocio;

namespace MSistemaAsistencia.Informes
{
    public partial class Frm_PrintAsis_DelDia : Form
    {
        public Frm_PrintAsis_DelDia()
        {
            InitializeComponent();
        }

        public string tipoinfo = "";

        private void Frm_PrintAsis_DelDia_Load(object sender, EventArgs e)
        {
            if(tipoinfo == "deldia")
            {
                Generar_InformedelDia();

            }else if (tipoinfo == "delmes")
            {

            }


        }

        private void Generar_InformedelDia()
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable data = new DataTable();

            data = obj.RN_Ver_Todas_asistencia_DelDia(Convert.ToDateTime(this.Tag));
            if(data.Rows.Count > 0)
            {
                Rpt_AsistenciasDelDia rpte = new Rpt_AsistenciasDelDia();
                vsr_InfoDia.ReportSource = rpte;
                rpte.Refresh();
                vsr_InfoDia.ReportSource = rpte;


            }

        }

        private void pnl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            vsr_InfoDia.PrintReport();
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            vsr_InfoDia.ExportReport();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            vsr_InfoDia.RefreshReport();
        }
    }
}

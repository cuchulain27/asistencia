﻿namespace MSistemaAsistencia.Msm_Forms
{
    partial class Frm_sinox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Lbl_msm1 = new System.Windows.Forms.Label();
            this.btn_si = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btn_no = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.lbl_Nomalgo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_si)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_no)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Lbl_msm1
            // 
            this.Lbl_msm1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_msm1.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_msm1.Location = new System.Drawing.Point(16, 76);
            this.Lbl_msm1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_msm1.Name = "Lbl_msm1";
            this.Lbl_msm1.Size = new System.Drawing.Size(644, 76);
            this.Lbl_msm1.TabIndex = 33;
            this.Lbl_msm1.Text = "¿Quieres Quitarlo del Carrito?";
            this.Lbl_msm1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_si
            // 
            this.btn_si.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_si.BackgroundStyle.GradientAngle = 0F;
            this.btn_si.BackgroundStyle.GradientEndColor = System.Drawing.Color.OrangeRed;
            this.btn_si.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_si.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_si.BackgroundStyle.SolidColor = System.Drawing.Color.WhiteSmoke;
            this.btn_si.BorderStyle.SolidColor = System.Drawing.Color.Teal;
            this.btn_si.DropDownArrowColor = System.Drawing.Color.White;
            this.btn_si.EnableThemes = false;
            this.btn_si.FlashStyle.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_si.FlashStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_si.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_si.FlashStyle.SolidColor = System.Drawing.Color.OrangeRed;
            this.btn_si.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_si.Location = new System.Drawing.Point(572, 156);
            this.btn_si.Margin = new System.Windows.Forms.Padding(4);
            this.btn_si.Name = "btn_si";
            this.btn_si.Size = new System.Drawing.Size(88, 46);
            this.btn_si.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.YellowGreen;
            this.btn_si.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.YellowGreen;
            this.btn_si.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.YellowGreen;
            this.btn_si.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.YellowGreen;
            this.btn_si.TabIndex = 32;
            this.btn_si.TextStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_si.TextStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_si.TextStyle.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_si.TextStyle.Text = "Sí";
            this.btn_si.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_si.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_si.Click += new System.EventHandler(this.btn_si_Click);
            // 
            // btn_no
            // 
            this.btn_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_no.BackgroundStyle.GradientAngle = 0F;
            this.btn_no.BackgroundStyle.GradientEndColor = System.Drawing.Color.OrangeRed;
            this.btn_no.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_no.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_no.BackgroundStyle.SolidColor = System.Drawing.Color.DarkCyan;
            this.btn_no.BorderStyle.SolidColor = System.Drawing.Color.Teal;
            this.btn_no.DropDownArrowColor = System.Drawing.Color.White;
            this.btn_no.EnableThemes = false;
            this.btn_no.FlashStyle.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_no.FlashStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_no.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_no.FlashStyle.SolidColor = System.Drawing.Color.OrangeRed;
            this.btn_no.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_no.Location = new System.Drawing.Point(491, 156);
            this.btn_no.Margin = new System.Windows.Forms.Padding(4);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(73, 46);
            this.btn_no.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.OrangeRed;
            this.btn_no.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.OrangeRed;
            this.btn_no.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.OrangeRed;
            this.btn_no.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.OrangeRed;
            this.btn_no.TabIndex = 31;
            this.btn_no.TextStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_no.TextStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no.TextStyle.ForeColor = System.Drawing.Color.White;
            this.btn_no.TextStyle.Text = "No";
            this.btn_no.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_no.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // lbl_Nomalgo
            // 
            this.lbl_Nomalgo.AutoSize = true;
            this.lbl_Nomalgo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nomalgo.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Nomalgo.Location = new System.Drawing.Point(188, 11);
            this.lbl_Nomalgo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nomalgo.Name = "lbl_Nomalgo";
            this.lbl_Nomalgo.Size = new System.Drawing.Size(259, 44);
            this.lbl_Nomalgo.TabIndex = 30;
            this.lbl_Nomalgo.Text = "¿Seguro (a) ?";
            this.lbl_Nomalgo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_Nomalgo_MouseMove);
            // 
            // Frm_sinox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 213);
            this.Controls.Add(this.Lbl_msm1);
            this.Controls.Add(this.btn_si);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.lbl_Nomalgo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_sinox";
            this.Text = "Frm_sinox";
            ((System.ComponentModel.ISupportInitialize)(this.btn_si)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_no)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        internal System.Windows.Forms.Label Lbl_msm1;
        internal Klik.Windows.Forms.v1.EntryLib.ELButton btn_si;
        internal Klik.Windows.Forms.v1.EntryLib.ELButton btn_no;
        internal System.Windows.Forms.Label lbl_Nomalgo;
    }
}
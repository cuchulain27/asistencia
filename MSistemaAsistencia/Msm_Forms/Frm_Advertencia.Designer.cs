﻿namespace MSistemaAsistencia.Msm_Forms
{
    partial class Frm_Advertencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Advertencia));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_titles = new Klik.Windows.Forms.v1.EntryLib.ELPanel();
            this.btn_acept = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.Lbl_Msm1 = new System.Windows.Forms.Label();
            this.lbl_Nomalgo = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_titles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_acept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnl_titles
            // 
            this.pnl_titles.BackgroundStyle.GradientAngle = 45F;
            this.pnl_titles.BackgroundStyle.GradientEndColor = System.Drawing.Color.White;
            this.pnl_titles.BackgroundStyle.GradientStartColor = System.Drawing.Color.White;
            this.pnl_titles.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.pnl_titles.BackgroundStyle.SolidColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_titles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titles.Location = new System.Drawing.Point(0, 0);
            this.pnl_titles.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_titles.Name = "pnl_titles";
            this.pnl_titles.Size = new System.Drawing.Size(564, 52);
            this.pnl_titles.TabIndex = 26;
            this.pnl_titles.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // btn_acept
            // 
            this.btn_acept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_acept.BackgroundStyle.GradientAngle = 0F;
            this.btn_acept.BackgroundStyle.GradientEndColor = System.Drawing.Color.OrangeRed;
            this.btn_acept.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_acept.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_acept.BackgroundStyle.SolidColor = System.Drawing.Color.DarkCyan;
            this.btn_acept.BorderStyle.SolidColor = System.Drawing.Color.Teal;
            this.btn_acept.DropDownArrowColor = System.Drawing.Color.White;
            this.btn_acept.EnableThemes = false;
            this.btn_acept.FlashStyle.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_acept.FlashStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_acept.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_acept.FlashStyle.SolidColor = System.Drawing.Color.OrangeRed;
            this.btn_acept.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_acept.Location = new System.Drawing.Point(121, 261);
            this.btn_acept.Margin = new System.Windows.Forms.Padding(4);
            this.btn_acept.Name = "btn_acept";
            this.btn_acept.Size = new System.Drawing.Size(303, 53);
            this.btn_acept.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.Teal;
            this.btn_acept.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.Teal;
            this.btn_acept.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Teal;
            this.btn_acept.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.Teal;
            this.btn_acept.TabIndex = 32;
            this.btn_acept.TextStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_acept.TextStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acept.TextStyle.ForeColor = System.Drawing.Color.White;
            this.btn_acept.TextStyle.Text = "Aceptar";
            this.btn_acept.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_acept.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_acept.Click += new System.EventHandler(this.btn_acept_Click);
            // 
            // Lbl_Msm1
            // 
            this.Lbl_Msm1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Msm1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Msm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbl_Msm1.Location = new System.Drawing.Point(95, 139);
            this.Lbl_Msm1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Msm1.Name = "Lbl_Msm1";
            this.Lbl_Msm1.Size = new System.Drawing.Size(361, 118);
            this.Lbl_Msm1.TabIndex = 31;
            this.Lbl_Msm1.Text = "¿Estas seguro de \r\nCerrar el Sistema?\r\n o no lo estas";
            this.Lbl_Msm1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Nomalgo
            // 
            this.lbl_Nomalgo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nomalgo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nomalgo.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_Nomalgo.Location = new System.Drawing.Point(21, 91);
            this.lbl_Nomalgo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nomalgo.Name = "lbl_Nomalgo";
            this.lbl_Nomalgo.Size = new System.Drawing.Size(518, 44);
            this.lbl_Nomalgo.TabIndex = 30;
            this.lbl_Nomalgo.Text = "Advertencia";
            this.lbl_Nomalgo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(246, 23);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(63, 64);
            this.PictureBox1.TabIndex = 33;
            this.PictureBox1.TabStop = false;
            // 
            // Frm_Advertencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 394);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.btn_acept);
            this.Controls.Add(this.Lbl_Msm1);
            this.Controls.Add(this.lbl_Nomalgo);
            this.Controls.Add(this.pnl_titles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Advertencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Advertencia";
            this.Load += new System.EventHandler(this.Frm_Advertencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnl_titles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_acept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal Klik.Windows.Forms.v1.EntryLib.ELButton btn_acept;
        internal System.Windows.Forms.Label Lbl_Msm1;
        internal System.Windows.Forms.Label lbl_Nomalgo;
        internal Klik.Windows.Forms.v1.EntryLib.ELPanel pnl_titles;
    }
}
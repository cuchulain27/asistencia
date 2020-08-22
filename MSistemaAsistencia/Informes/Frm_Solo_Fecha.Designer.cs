﻿namespace MSistemaAsistencia.Informes
{
    partial class Frm_Solo_Fecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Solo_Fecha));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_cancelar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btn_no = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_cancelar.BackgroundStyle.SolidColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancelar.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_cancelar.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_cancelar.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_cancelar.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_cancelar.BorderStyle.SolidColor = System.Drawing.Color.DimGray;
            this.btn_cancelar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_cancelar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_cancelar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancelar.Location = new System.Drawing.Point(188, 212);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(152, 38);
            this.btn_cancelar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.White;
            this.btn_cancelar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.White;
            this.btn_cancelar.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.White;
            this.btn_cancelar.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.White;
            this.btn_cancelar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.White;
            this.btn_cancelar.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.DimGray;
            this.btn_cancelar.StateStyles.HoverStyle.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.TabIndex = 448;
            this.btn_cancelar.TextStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.TextStyle.ForeColor = System.Drawing.Color.DimGray;
            this.btn_cancelar.TextStyle.Text = "Cancelar";
            this.btn_cancelar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancelar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_no
            // 
            this.btn_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_no.BackgroundStyle.GradientAngle = 0F;
            this.btn_no.BackgroundStyle.GradientEndColor = System.Drawing.Color.OrangeRed;
            this.btn_no.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_no.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_no.BackgroundStyle.SolidColor = System.Drawing.Color.DarkCyan;
            this.btn_no.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_no.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_no.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_no.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle;
            this.btn_no.BorderStyle.SolidColor = System.Drawing.Color.Teal;
            this.btn_no.DropDownArrowColor = System.Drawing.Color.White;
            this.btn_no.EnableThemes = false;
            this.btn_no.FlashStyle.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_no.FlashStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_no.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_no.FlashStyle.SolidColor = System.Drawing.Color.OrangeRed;
            this.btn_no.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_no.Location = new System.Drawing.Point(364, 212);
            this.btn_no.Margin = new System.Windows.Forms.Padding(4);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(168, 38);
            this.btn_no.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.OrangeRed;
            this.btn_no.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.OrangeRed;
            this.btn_no.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.OrangeRed;
            this.btn_no.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.OrangeRed;
            this.btn_no.TabIndex = 447;
            this.btn_no.TextStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_no.TextStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no.TextStyle.ForeColor = System.Drawing.Color.White;
            this.btn_no.TextStyle.Text = "Aceptar";
            this.btn_no.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_no.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(240, 132);
            this.dtp_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(193, 37);
            this.dtp_fecha.TabIndex = 445;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_titulo.Location = new System.Drawing.Point(237, 25);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(193, 44);
            this.lbl_titulo.TabIndex = 443;
            this.lbl_titulo.Text = "Consultas";
            this.lbl_titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_titulo_MouseMove);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(240, 99);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 30);
            this.label9.TabIndex = 446;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 444;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Solo_Fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 274);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Solo_Fecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Solo_Fecha";
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Klik.Windows.Forms.v1.EntryLib.ELButton btn_cancelar;
        internal Klik.Windows.Forms.v1.EntryLib.ELButton btn_no;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label lbl_titulo;
    }
}
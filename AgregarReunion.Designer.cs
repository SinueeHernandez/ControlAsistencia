namespace Enrollment
{
    partial class AgregarReunion
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
            this.lblReunion = new System.Windows.Forms.Label();
            this.txtReunionID = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.lblFechaIn = new System.Windows.Forms.Label();
            this.dtpickerInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpickerFin = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReunion
            // 
            this.lblReunion.AutoSize = true;
            this.lblReunion.Location = new System.Drawing.Point(13, 13);
            this.lblReunion.Name = "lblReunion";
            this.lblReunion.Size = new System.Drawing.Size(58, 13);
            this.lblReunion.TabIndex = 0;
            this.lblReunion.Text = "ReunionID";
            // 
            // txtReunionID
            // 
            this.txtReunionID.Location = new System.Drawing.Point(84, 10);
            this.txtReunionID.Name = "txtReunionID";
            this.txtReunionID.Size = new System.Drawing.Size(132, 20);
            this.txtReunionID.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(13, 83);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(34, 13);
            this.lblLugar.TabIndex = 4;
            this.lblLugar.Text = "Lugar";
            this.lblLugar.Click += new System.EventHandler(this.lblLugar_Click);
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(84, 80);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(132, 20);
            this.txtLugar.TabIndex = 5;
            // 
            // lblFechaIn
            // 
            this.lblFechaIn.AutoSize = true;
            this.lblFechaIn.Location = new System.Drawing.Point(13, 117);
            this.lblFechaIn.Name = "lblFechaIn";
            this.lblFechaIn.Size = new System.Drawing.Size(65, 13);
            this.lblFechaIn.TabIndex = 6;
            this.lblFechaIn.Text = "Fecha Inicia";
            // 
            // dtpickerInicio
            // 
            this.dtpickerInicio.CustomFormat = "MMM/dd/yyyy HH:mm";
            this.dtpickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickerInicio.Location = new System.Drawing.Point(84, 111);
            this.dtpickerInicio.Name = "dtpickerInicio";
            this.dtpickerInicio.Size = new System.Drawing.Size(150, 20);
            this.dtpickerInicio.TabIndex = 7;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(16, 149);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(51, 13);
            this.lblFechaFin.TabIndex = 8;
            this.lblFechaFin.Text = "Fecha fin";
            // 
            // dtpickerFin
            // 
            this.dtpickerFin.CustomFormat = "MMM/dd/yyyy HH:mm";
            this.dtpickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickerFin.Location = new System.Drawing.Point(84, 143);
            this.dtpickerFin.Name = "dtpickerFin";
            this.dtpickerFin.Size = new System.Drawing.Size(150, 20);
            this.dtpickerFin.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(84, 187);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(166, 187);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // AgregarReunion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 223);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtpickerFin);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.dtpickerInicio);
            this.Controls.Add(this.lblFechaIn);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtReunionID);
            this.Controls.Add(this.lblReunion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarReunion";
            this.Text = "Agregar Reunion";
            this.Load += new System.EventHandler(this.AgregarReunion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReunion;
        private System.Windows.Forms.TextBox txtReunionID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lblFechaIn;
        private System.Windows.Forms.DateTimePicker dtpickerInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpickerFin;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
    }
}
namespace Enrollment
{
    partial class TomarAsistencia
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
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblNumeroControl = new System.Windows.Forms.Label();
            this.txtNumeroControl = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblReunion = new System.Windows.Forms.Label();
            this.cmbReuniones = new System.Windows.Forms.ComboBox();
            this.btnNuevaReunion = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Location = new System.Drawing.Point(169, 9);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(103, 13);
            this.lblFechaHora.TabIndex = 0;
            this.lblFechaHora.Text = "Fecha y Hora actual";
            // 
            // lblNumeroControl
            // 
            this.lblNumeroControl.AutoSize = true;
            this.lblNumeroControl.Location = new System.Drawing.Point(13, 80);
            this.lblNumeroControl.Name = "lblNumeroControl";
            this.lblNumeroControl.Size = new System.Drawing.Size(94, 13);
            this.lblNumeroControl.TabIndex = 1;
            this.lblNumeroControl.Text = "Número de control";
            // 
            // txtNumeroControl
            // 
            this.txtNumeroControl.Location = new System.Drawing.Point(113, 77);
            this.txtNumeroControl.Name = "txtNumeroControl";
            this.txtNumeroControl.Size = new System.Drawing.Size(159, 20);
            this.txtNumeroControl.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(278, 75);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 112);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(113, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(16, 146);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(40, 13);
            this.lblPuesto.TabIndex = 6;
            this.lblPuesto.Text = "Puesto";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Enabled = false;
            this.txtPuesto.Location = new System.Drawing.Point(113, 143);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(159, 20);
            this.txtPuesto.TabIndex = 7;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(101, 199);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(183, 23);
            this.btnVerificar.TabIndex = 8;
            this.btnVerificar.Text = "Verifique su huella";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(249, 228);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblReunion
            // 
            this.lblReunion.AutoSize = true;
            this.lblReunion.Location = new System.Drawing.Point(19, 45);
            this.lblReunion.Name = "lblReunion";
            this.lblReunion.Size = new System.Drawing.Size(47, 13);
            this.lblReunion.TabIndex = 10;
            this.lblReunion.Text = "Reunion";
            // 
            // cmbReuniones
            // 
            this.cmbReuniones.FormattingEnabled = true;
            this.cmbReuniones.Location = new System.Drawing.Point(113, 42);
            this.cmbReuniones.Name = "cmbReuniones";
            this.cmbReuniones.Size = new System.Drawing.Size(159, 21);
            this.cmbReuniones.TabIndex = 11;
            // 
            // btnNuevaReunion
            // 
            this.btnNuevaReunion.Location = new System.Drawing.Point(278, 40);
            this.btnNuevaReunion.Name = "btnNuevaReunion";
            this.btnNuevaReunion.Size = new System.Drawing.Size(75, 23);
            this.btnNuevaReunion.TabIndex = 12;
            this.btnNuevaReunion.Text = "Agregar";
            this.btnNuevaReunion.UseVisualStyleBackColor = true;
            this.btnNuevaReunion.Click += new System.EventHandler(this.btnNuevaReunion_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TomarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 261);
            this.Controls.Add(this.btnNuevaReunion);
            this.Controls.Add(this.cmbReuniones);
            this.Controls.Add(this.lblReunion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNumeroControl);
            this.Controls.Add(this.lblNumeroControl);
            this.Controls.Add(this.lblFechaHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TomarAsistencia";
            this.Text = "TomarAsistencia";
            this.Load += new System.EventHandler(this.TomarAsistencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lblNumeroControl;
        private System.Windows.Forms.TextBox txtNumeroControl;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblReunion;
        private System.Windows.Forms.ComboBox cmbReuniones;
        private System.Windows.Forms.Button btnNuevaReunion;
        private System.Windows.Forms.Timer timer1;
    }
}
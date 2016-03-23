namespace Enrollment
{
    partial class CapturaDatos
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
            this.txtNumeroControl = new System.Windows.Forms.TextBox();
            this.lblNumeroControl = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxHuella = new System.Windows.Forms.PictureBox();
            this.btnRegistrarDatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCapturarHuella = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHuella)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumeroControl
            // 
            this.txtNumeroControl.Location = new System.Drawing.Point(121, 12);
            this.txtNumeroControl.Name = "txtNumeroControl";
            this.txtNumeroControl.Size = new System.Drawing.Size(123, 20);
            this.txtNumeroControl.TabIndex = 0;
            // 
            // lblNumeroControl
            // 
            this.lblNumeroControl.AutoSize = true;
            this.lblNumeroControl.Location = new System.Drawing.Point(12, 15);
            this.lblNumeroControl.Name = "lblNumeroControl";
            this.lblNumeroControl.Size = new System.Drawing.Size(80, 13);
            this.lblNumeroControl.TabIndex = 1;
            this.lblNumeroControl.Text = "Número Control";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(123, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(15, 82);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(40, 13);
            this.lblPuesto.TabIndex = 4;
            this.lblPuesto.Text = "Puesto";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(121, 79);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(123, 20);
            this.txtPuesto.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // picBoxHuella
            // 
            this.picBoxHuella.Location = new System.Drawing.Point(34, 140);
            this.picBoxHuella.Name = "picBoxHuella";
            this.picBoxHuella.Size = new System.Drawing.Size(210, 126);
            this.picBoxHuella.TabIndex = 7;
            this.picBoxHuella.TabStop = false;
            // 
            // btnRegistrarDatos
            // 
            this.btnRegistrarDatos.Location = new System.Drawing.Point(76, 272);
            this.btnRegistrarDatos.Name = "btnRegistrarDatos";
            this.btnRegistrarDatos.Size = new System.Drawing.Size(111, 32);
            this.btnRegistrarDatos.TabIndex = 8;
            this.btnRegistrarDatos.Text = "Registrar Datos";
            this.btnRegistrarDatos.UseVisualStyleBackColor = true;
            this.btnRegistrarDatos.Click += new System.EventHandler(this.btnRegistrarDatos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(197, 273);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 31);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCapturarHuella
            // 
            this.btnCapturarHuella.Location = new System.Drawing.Point(60, 111);
            this.btnCapturarHuella.Name = "btnCapturarHuella";
            this.btnCapturarHuella.Size = new System.Drawing.Size(161, 23);
            this.btnCapturarHuella.TabIndex = 10;
            this.btnCapturarHuella.Text = "Capturar Huella";
            this.btnCapturarHuella.UseVisualStyleBackColor = true;
            this.btnCapturarHuella.Click += new System.EventHandler(this.btnCapturarHuella_Click);
            // 
            // CapturaDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 310);
            this.Controls.Add(this.btnCapturarHuella);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrarDatos);
            this.Controls.Add(this.picBoxHuella);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNumeroControl);
            this.Controls.Add(this.txtNumeroControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CapturaDatos";
            this.Text = "CapturaDatos";
            this.Load += new System.EventHandler(this.CapturaDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHuella)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroControl;
        private System.Windows.Forms.Label lblNumeroControl;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxHuella;
        private System.Windows.Forms.Button btnRegistrarDatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCapturarHuella;
    }
}
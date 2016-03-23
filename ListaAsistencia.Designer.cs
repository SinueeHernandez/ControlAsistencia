namespace Enrollment
{
    partial class ListaAsistencia
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbReuniones = new System.Windows.Forms.ComboBox();
            this.lblReunion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(740, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(677, 368);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbReuniones
            // 
            this.cmbReuniones.FormattingEnabled = true;
            this.cmbReuniones.Location = new System.Drawing.Point(110, 21);
            this.cmbReuniones.Name = "cmbReuniones";
            this.cmbReuniones.Size = new System.Drawing.Size(159, 21);
            this.cmbReuniones.TabIndex = 13;
            this.cmbReuniones.SelectedIndexChanged += new System.EventHandler(this.cmbReuniones_SelectedIndexChanged);
            this.cmbReuniones.SelectionChangeCommitted += new System.EventHandler(this.cmbReuniones_SelectionChangeCommitted);
            // 
            // lblReunion
            // 
            this.lblReunion.AutoSize = true;
            this.lblReunion.Location = new System.Drawing.Point(16, 24);
            this.lblReunion.Name = "lblReunion";
            this.lblReunion.Size = new System.Drawing.Size(47, 13);
            this.lblReunion.TabIndex = 12;
            this.lblReunion.Text = "Reunion";
            // 
            // ListaAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 403);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbReuniones);
            this.Controls.Add(this.lblReunion);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaAsistencia";
            this.Text = "Listar Asistencia";
            this.Load += new System.EventHandler(this.ListaAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbReuniones;
        private System.Windows.Forms.Label lblReunion;
    }
}
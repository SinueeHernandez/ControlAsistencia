using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Enrollment
{
    public partial class ListaAsistencia : Form
    {
        public ListaAsistencia()
        {
            InitializeComponent();
        }
        private void LlenarGrid(int ReunionID)
        {
            List<ListaDeAsistencia> Asistencia = new List<ListaDeAsistencia>();
            ListaDeAsistencia Elemento;
            using (var conn = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                var cmd = new System.Data.SqlClient.SqlCommand(
                    @"select P.NumeroControl, p.Nombre, p.Puestos, a.TomaAsistencia from Asistencia A
join Personas P on A.PersonaID = P.NumeroControl
where
A.ReunionID = @ReunionID "
                    , conn);
                try
                {
                    cmd.Parameters.AddWithValue("@ReunionID", ReunionID);
                    conn.Open();
                    SqlDataReader Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        Elemento = new ListaDeAsistencia();
                        Elemento.NumeroControl = Reader.GetInt32(0);
                        Elemento.Nombre = Reader.GetString(1);
                        Elemento.puesto = Reader.GetString(2);
                        Elemento.Fecha = Reader.GetDateTime(3);
                        Asistencia.Add(Elemento);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cmd.Dispose();
                    conn.Close();
                    return;
                }
                cmd.Dispose();
                conn.Close();
            }//using
            dataGridView1.DataSource = Asistencia;
        }
        private void cmbReuniones_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void cargarReuniones()
        {
            List<Reunion> reuniones = Utilities.cargarReuniones();
           
            cmbReuniones.DataSource = reuniones;
            cmbReuniones.DisplayMember = "Nombre";
            cmbReuniones.ValueMember = "ReunionID";
        }

        private void ListaAsistencia_Load(object sender, EventArgs e)
        {
            cargarReuniones();
            if (cmbReuniones.Items.Count > 0)
            {
                LlenarGrid(int.Parse(cmbReuniones.SelectedValue.ToString()));
            }
        }

        private void cmbReuniones_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenarGrid(int.Parse(cmbReuniones.SelectedValue.ToString()));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

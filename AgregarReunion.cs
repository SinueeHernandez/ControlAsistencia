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
    public partial class AgregarReunion : Form
    {
        public AgregarReunion()
        {
            InitializeComponent();
        }

        private void lblLugar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var conn = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                var cmd = new System.Data.SqlClient.SqlCommand(
                    " insert into Reuniones (ReunionID, Nombre, Lugar, FechaInicio, FecharTermino ) values ( @ReunionID, @Nombre, @Lugar, @FechaInicio, @FechaTermino)"
                    , conn);
                try
                {
                    cmd.Parameters.AddWithValue("@ReunionID", txtReunionID.Text);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Lugar", txtLugar.Text);
                    cmd.Parameters.Add("@FechaInicio", SqlDbType.DateTime).Value = dtpickerInicio.Value;
                    cmd.Parameters.Add("@FechaTermino", SqlDbType.DateTime).Value = dtpickerFin.Value;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cmd.Dispose();
                    conn.Close();
                }
                cmd.Dispose();
                conn.Close();
            }
            MessageBox.Show("Reunion Agregada");
            Close();
        }

        private void AgregarReunion_Load(object sender, EventArgs e)
        {
            using (var conn = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                var cmd = new System.Data.SqlClient.SqlCommand(
                    "select max(ReunionID) + 1 from Reuniones "
                    , conn);
                try
                {
                    conn.Open();
                    SqlDataReader Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        txtReunionID.Text = Reader.GetInt32(0).ToString();
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

        }
    }
}

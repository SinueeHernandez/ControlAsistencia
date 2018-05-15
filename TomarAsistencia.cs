using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Enrollment
{
    public partial class TomarAsistencia : Form
    {
        public TomarAsistencia()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[8000];
            using (var conn = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                var cmd = new System.Data.SqlClient.SqlCommand(
                    "select nombre, puestos, huella from Personas where NumeroControl = @NumeroControl"
                    , conn);
                try
                {
                    cmd.Parameters.AddWithValue("@NumeroControl", int.Parse(txtNumeroControl.Text));
                    conn.Open();
                    SqlDataReader Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        txtNombre.Text = Reader.GetString(0);
                        txtPuesto.Text = Reader.GetString(1);
                        Reader.GetBytes(2, 0, buffer, 0, 8000);
                        DPFP.Template template = new DPFP.Template(new MemoryStream(buffer));
                        OnTemplate(template);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }//using 
        }

        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                btnVerificar.Enabled = (Template != null);
                if (Template != null)
                    MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment");
                else
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
            }));
        }

        private DPFP.Template Template;

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            VerificationForm Verifier = new VerificationForm();
            if (Verifier.Verify(Template))
            {
                if (!ExisteRegistro(int.Parse(txtNumeroControl.Text), int.Parse(cmbReuniones.SelectedValue.ToString())))
                {
                    if (RegistrarAsistencia())
                    {
                        MessageBox.Show("Asistencia Registrada");
                    }
                    else
                        MessageBox.Show("Error al guardar los datos contacte al administrador de sistemas");
                }
                else
                    MessageBox.Show("Ya existe una asistencia registrada para esta persona en esta reunion");
            }
            else
            {
                MessageBox.Show("Error al validar la huella intente nuevamente");
            }            
        }

        private bool RegistrarAsistencia()
        {
            using (var conn = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                var cmd = new System.Data.SqlClient.SqlCommand(
                    " insert into Asistencia (PersonaID,ReunionID,TomaAsistencia) values (@NumeroControl, @ReunionID, sysdatetime())"
                    , conn);
                try
                {
                    cmd.Parameters.AddWithValue("@NumeroControl", txtNumeroControl.Text);
                    cmd.Parameters.AddWithValue("@ReunionID", cmbReuniones.SelectedValue);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cmd.Dispose();
                    conn.Close();
                    return false;
                }
                cmd.Dispose();
                conn.Close();
            }
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        private void cargarReuniones()
        {
            List<Reunion> Reuniones = new List<Reunion>();
            Reunion Elemento = new Reunion();
            using (var conn = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                var cmd = new System.Data.SqlClient.SqlCommand(
                    "select ReunionID, Nombre, Lugar, FechaInicio, FecharTermino from Reuniones order by fechaInicio"
                    , conn);
                try
                {
                    conn.Open();
                    SqlDataReader Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        Elemento = new Reunion();
                        Elemento.ReunionID = Reader.GetInt32(0);
                        Elemento.Nombre = Reader.GetString(1);
                        Elemento.Lugar = Reader.GetString(2);
                        Elemento.FechaInicio = Reader.GetDateTime(3);
                        Elemento.FechaTermino = Reader.GetDateTime(4);
                        Reuniones.Add(Elemento);
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
            
            cmbReuniones.DataSource = Reuniones;
            cmbReuniones.DisplayMember = "Nombre";
            cmbReuniones.ValueMember = "ReunionID";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TomarAsistencia_Load(object sender, EventArgs e)
        {
            cargarReuniones();
            lblFechaHora.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        private void btnNuevaReunion_Click(object sender, EventArgs e)
        {
            AgregarReunion Pantalla = new AgregarReunion();
            Pantalla.StartPosition = FormStartPosition.CenterParent;
            Pantalla.ShowDialog(this);
            cargarReuniones();
        }
        private bool ExisteRegistro(int NumeroControl, int Reunion)
        {
            int Contador = 0;
            using (var conn = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                var cmd = new System.Data.SqlClient.SqlCommand(
                    " select count (NumeroControl) as Cuantos from Asistencia where PersonaID = @NumeroControl and ReunionID = @ReunionID "
                    , conn);
                try
                {
                    cmd.Parameters.AddWithValue("@NumeroControl", NumeroControl);
                    cmd.Parameters.AddWithValue("@ReunionID", Reunion);
                    contador = Utilities.checkCount(conn, cmd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cmd.Dispose();
                    conn.Close();
                    return false;
                }
                cmd.Dispose();
                conn.Close();
            }//using

            if (Contador > 0)
                return true;
            else
                return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Enrollment
{
    public partial class CapturaDatos : Form
    {
        public CapturaDatos()
        {
            InitializeComponent();
        }

        private void CapturaDatos_Load(object sender, EventArgs e)
        {

        }

        private void btnCapturarHuella_Click(object sender, EventArgs e)
        {
            EnrollmentForm Enroller = new EnrollmentForm();
            Enroller.OnTemplate += this.OnTemplate;
            Enroller.ShowDialog();
        }

        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                //VerifyButton.Enabled = SaveButton.Enabled = (Template != null);
                if (Template != null)
                    MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment");
                else
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
            }));
        }

        private DPFP.Template Template;

        private void btnRegistrarDatos_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                using (var conn = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    var cmd = new System.Data.SqlClient.SqlCommand(
                        "Insert into Personas (NumeroControl, Nombre, Puestos, Huella) values (@NumeroControl, @Nombre, @Puesto, @Huella)"
                        , conn);
                    try
                    {
                        cmd.Parameters.AddWithValue("@NumeroControl", int.Parse(txtNumeroControl.Text));
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Puesto", txtPuesto.Text);
                        cmd.Parameters.Add("@Huella", SqlDbType.Binary, Template.Size).Value = Template.Bytes;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        cmd.Dispose();
                        conn.Close();
                    }
                }//Using
            }
            else
            {
                MessageBox.Show("Información incompleta favor de llenar");
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool ValidaCampos()
        {
            return !(string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtNumeroControl.Text) || string.IsNullOrEmpty(txtPuesto.Text) || Template == null);
        }
    }
}

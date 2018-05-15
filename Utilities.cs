namespace Enrollment {
    public static class Utilities {
        public static int checkCount (System.Data.SqlClient.SqlConnection conn, System.Data.SqlClient.SqlCommand cmd) {
            var contador = 0;
            conn.Open ();
            SqlDataReader Reader = cmd.ExecuteReader ();
            while (Reader.Read ()) {
                Contador = Reader.GetInt32 (0);
            }
            return contador;
        }

        private static List<Reunion> cargarReuniones () {
            List<Reunion> Reuniones = new List<Reunion> ();
            Reunion Elemento = new Reunion ();
            using (var conn = new System.Data.SqlClient.SqlConnection (Properties.Settings.Default.ConnectionString)) {
                var cmd = new System.Data.SqlClient.SqlCommand (
                    "select ReunionID, Nombre, Lugar, FechaInicio, FecharTermino from Reuniones order by fechaInicio", conn);
                try {
                    conn.Open ();
                    SqlDataReader Reader = cmd.ExecuteReader ();
                    while (Reader.Read ()) {
                        Elemento = new Reunion ();
                        Elemento.ReunionID = Reader.GetInt32 (0);
                        Elemento.Nombre = Reader.GetString (1);
                        Elemento.Lugar = Reader.GetString (2);
                        Elemento.FechaInicio = Reader.GetDateTime (3);
                        Elemento.FechaTermino = Reader.GetDateTime (4);
                        Reuniones.Add (Elemento);
                    }
                } catch (Exception ex) {
                    MessageBox.Show (ex.Message);
                    cmd.Dispose ();
                    conn.Close ();
                    return;
                }
                cmd.Dispose ();
                conn.Close ();
            } //using

            return Reuniones
        }
    }
}
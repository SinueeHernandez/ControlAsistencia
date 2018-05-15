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
    }
}
using System;
using System.Data;
using System.Data.SqlClient;

namespace KioskoDatos
{
    public class Conexion
    {
        public Conexion()
        {
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = AsignarCadenaConexion();
                    con.Open();
                    if (con.State != ConnectionState.Open)
                        throw new Exception("Error al conectar");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string AsignarCadenaConexion()
        {
            return "Server=DESKTOP-MMLHIU2;Database=Kiosko;User Id=parroAdmin;Password=Parro9512$$; Trusted_Connection=True; MultipleActiveResultSets=true;";
        }
    }
}

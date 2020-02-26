using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class BDExtRiesgo
    {
        public class BDExtRiesgoE {
            public string Cedula { get; set; }
            public Int32 RangoRiesgo { get; set; }
        }

        public void ObtenerRangoRiesgo(BDExtRiesgoE entidad)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand("BDExterna..Obtener_RangoRiesgo", con);
            command.Parameters.AddWithValue("@Cedula", entidad.Cedula);

            command.Parameters.Add("@IDRangoRiesgo", SqlDbType.Int).Direction = ParameterDirection.Output;
            command.CommandType = CommandType.StoredProcedure;
            con.Open();
            command.ExecuteNonQuery();
            entidad.RangoRiesgo = Convert.ToInt32(command.Parameters["@IDRangoRiesgo"].Value);
        }
    }
}

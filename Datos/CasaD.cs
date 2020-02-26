using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos
{
    public class CasaD
    {
        public class CasaE {
            public Int64 CasaID { get; set; }
            public decimal Valor { get; set; }
            public int RangoRiesgo { get; set; }
            public string EstadoCasa { get; set; }
        }

        public DataSet Seleccionar()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand("Obtener_Casa", con);
            command.CommandType = CommandType.StoredProcedure;
            DataSet wea = new DataSet();
            con.Open();
            command.ExecuteNonQuery();
            SqlDataAdapter Adapter = new SqlDataAdapter();

            Adapter.SelectCommand = command;
            Adapter.Fill(wea);
            return wea;
        }

        public Int32 Modificar(CasaE entidad)
        {
            Int32 wea = 0;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand("Modificar_Casa", con);
            command.Parameters.AddWithValue("@CasaID", entidad.CasaID);
            command.Parameters.AddWithValue("@Valor", entidad.Valor);
            command.CommandType = CommandType.StoredProcedure;
            con.Open();
            wea = Convert.ToInt32(command.ExecuteScalar());
            con.Close();
            return wea;
        }
    }
}

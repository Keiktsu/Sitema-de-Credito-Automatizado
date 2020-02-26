using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class HijosD
    {
        public class HijosE {
            public Int64 HijosID { get; set; }
            public Decimal Valor { get; set; }
        }

        public DataSet Seleccionar()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand("Obtener_Hijo", con);
            command.CommandType = CommandType.StoredProcedure;
            DataSet wea = new DataSet();
            con.Open();
            command.ExecuteNonQuery();
            SqlDataAdapter Adapter = new SqlDataAdapter();

            Adapter.SelectCommand = command;
            Adapter.Fill(wea);
            return wea;
        }

        public Int32 Modificar(HijosE entidad)
        {
            Int32 wea = 0;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand("Modificar_Hijo", con);
            command.Parameters.AddWithValue("@HijoID", entidad.HijosID);
            command.Parameters.AddWithValue("@Valor", entidad.Valor);
            command.CommandType = CommandType.StoredProcedure;
            con.Open();
            wea = Convert.ToInt32(command.ExecuteScalar());
            con.Close();
            return wea;
        }
    }
}

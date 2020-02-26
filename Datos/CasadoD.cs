using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class CasadoD
    {
        public class CasadoE {
            public Int32 CasadoID { get; set; }
            public Decimal Valor { get; set; }
        }

        public DataSet Seleccionar()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand("Obtener_Casado", con);
            command.CommandType = CommandType.StoredProcedure;
            DataSet wea = new DataSet();
            con.Open();
            command.ExecuteNonQuery();
            SqlDataAdapter Adapter = new SqlDataAdapter();

            Adapter.SelectCommand = command;
            Adapter.Fill(wea);
            return wea;
        }

        public Int32 Modificar(CasadoE entidad)
        {
            Int32 wea = 0;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand("Modificar_Casado", con);
            command.Parameters.AddWithValue("@CasadoID", entidad.CasadoID);
            command.Parameters.AddWithValue("@Valor", entidad.Valor);
            command.CommandType = CommandType.StoredProcedure;
            con.Open();
            wea = Convert.ToInt32(command.ExecuteScalar());
            con.Close();
            return wea;
        }
    }
}

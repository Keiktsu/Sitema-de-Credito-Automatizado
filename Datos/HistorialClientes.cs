using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
   public class HistorialClientes
    {
        public class HistorialE
        {

            public String IDCliente { get; set; }
            public String IDVehiculo { get; set; }
            public String IDCasa { get; set; }
            public String IDCasado { get; set; }
            public Int64 HijosID { get; set; }
        }

        public Int32 GuardarHistorial(HistorialE historial)
        {
            Int32 x = 0;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand("[Insertar_Historial]", con);
            //command.Parameters.AddWithValue("@IDCliente", historial.IDCliente);
            command.Parameters.AddWithValue("@Casado", historial.IDCasado);
            command.Parameters.AddWithValue("@CantHijos", historial.HijosID);
            command.Parameters.AddWithValue("@EstadoCasa", historial.IDCasa);
            command.Parameters.AddWithValue("@EstadoVehiculo", historial.IDVehiculo);

            command.CommandType = CommandType.StoredProcedure;
            con.Open();
            x = Convert.ToInt32(command.ExecuteScalar());
            con.Close();
            return x;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Rangos
    {
        public class RangosE
        {
            public String Nombre { get; set; }
            public Decimal Prestamo { get; set; }
            public Decimal Tasa { get; set; }
            public Decimal Comision { get; set; }
            public Decimal Mora { get; set; }
            public Decimal Seguro { get; set; }
        }


        public void ObtenerRangosClientes(RangosE entidad)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand("Obtener_RangosPrestamos", con);
     
            command.Parameters.Add("@Nombre", SqlDbType.VarChar,80).Direction = ParameterDirection.Output;
            command.Parameters.Add("@Prestamo", SqlDbType.Decimal).Direction = ParameterDirection.Output;
            command.Parameters.Add("@Tasa", SqlDbType.Decimal).Direction = ParameterDirection.Output;
            command.Parameters.Add("@Comision", SqlDbType.Decimal).Direction = ParameterDirection.Output;
            command.Parameters.Add("@Mora", SqlDbType.Decimal).Direction = ParameterDirection.Output;
            command.Parameters.Add("@Seguro", SqlDbType.Decimal).Direction = ParameterDirection.Output;
            command.CommandType = CommandType.StoredProcedure;
            con.Open();
            command.ExecuteNonQuery();

            entidad.Nombre = command.Parameters["@Nombre"].Value.ToString();
            entidad.Prestamo = Convert.ToDecimal(command.Parameters["@Prestamo"].Value);
            entidad.Tasa = Convert.ToDecimal(command.Parameters["@Tasa"].Value);
            entidad.Comision = Convert.ToDecimal(command.Parameters["@Comision"].Value);
            entidad.Mora = Convert.ToDecimal(command.Parameters["@Mora"].Value);
            entidad.Seguro = Convert.ToDecimal(command.Parameters["@Seguro"].Value);

        }
    }
}

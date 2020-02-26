using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class RangoD
    {
        public class RangoE {
            public int RangoID { get; set; }
            public decimal TasaInteres { get; set; }
            public decimal Comision { get; set; }
            public decimal Mora { get; set; }
            public decimal Seguro { get; set; }
            public int MesMin { get; set; }
            public decimal Prestamo { get; set; }
            public int MesMax { get; set; }
        }

        public DataSet Seleccionar()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand("Obtener_Rango", con);
            command.CommandType = CommandType.StoredProcedure;
            DataSet wea = new DataSet();
            con.Open();
            command.ExecuteNonQuery();
            SqlDataAdapter Adapter = new SqlDataAdapter();

            Adapter.SelectCommand = command;
            Adapter.Fill(wea);
            return wea;
        }

        public Int32 Modificar(RangoE entidad)
        {
            Int32 wea = 0;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand("Modificar_Rango", con);
            command.Parameters.AddWithValue("@RangoID", entidad.RangoID);
            command.Parameters.AddWithValue("@TasaInteres", entidad.TasaInteres);
            command.Parameters.AddWithValue("@Comision", entidad.Comision);
            command.Parameters.AddWithValue("@Mora", entidad.Mora);
            command.Parameters.AddWithValue("@Seguro", entidad.Seguro);
            command.CommandType = CommandType.StoredProcedure;
            con.Open();
            wea = Convert.ToInt32(command.ExecuteScalar());
            con.Close();
            return wea;
        }

        public void ObtenerRango(RangoE entidad)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand("Rango_Seleccionar", con);
            command.Parameters.AddWithValue("@Prestamo", entidad.Prestamo);

            command.Parameters.Add("@MesMin", SqlDbType.Int).Direction = ParameterDirection.Output;
            command.Parameters.Add("@MesMax", SqlDbType.Int).Direction = ParameterDirection.Output;
            command.Parameters.Add("@Comision", SqlDbType.Decimal).Direction = ParameterDirection.Output;
            command.Parameters.Add("@TasaInteres", SqlDbType.Decimal).Direction = ParameterDirection.Output;
            command.Parameters.Add("@Mora", SqlDbType.Decimal).Direction = ParameterDirection.Output;
            command.Parameters.Add("@Seguro", SqlDbType.Decimal).Direction = ParameterDirection.Output;
            command.Parameters.Add("@Rango", SqlDbType.Int).Direction = ParameterDirection.Output;

            //Estableciendo escala a 4
            command.Parameters["@Comision"].Precision = 4;
            command.Parameters["@TasaInteres"].Precision = 4;
            command.Parameters["@Seguro"].Precision = 4;
            command.Parameters["@Comision"].Scale = 4;
            command.Parameters["@TasaInteres"].Scale = 4;
            command.Parameters["@Seguro"].Scale = 4;

            command.CommandType = CommandType.StoredProcedure;
            con.Open();
            command.ExecuteNonQuery();

            entidad.RangoID = Convert.ToInt32(command.Parameters["@Rango"].Value);
            entidad.MesMin = Convert.ToInt32(command.Parameters["@MesMin"].Value);
            entidad.MesMax = Convert.ToInt32(command.Parameters["@MesMax"].Value);
            entidad.Comision = Convert.ToDecimal(command.Parameters["@Comision"].Value);
            entidad.TasaInteres = Convert.ToDecimal(command.Parameters["@TasaInteres"].Value);
            entidad.Mora = Convert.ToInt32(command.Parameters["@Mora"].Value);
            entidad.Seguro = Convert.ToDecimal(command.Parameters["@Seguro"].Value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Prestamo
    {
        public class PrestamoE
        {
            public int CantHijos { get; set; }
            public bool Casado { get; set; }
            public string Vehiculo { get; set; }
            public string Casa { get; set; }
            public int IDRangoRiesgo { get; set; }
            public bool INSS { get; set; }
            public decimal Salario { get; set; }

            public decimal prestamoMaximo { get; set; }
            public decimal ValorProcentual { get; set; }

            public int CasadoID { get; set; }
            public int HijosID { get; set; }
            public int CasaID { get; set; }
            public int VehiculoID { get; set; }

            public int ClienteID { get; set; }
            public Decimal Prestamo { get; set; }
            public int Meses { get; set; }
            public decimal Comision { get; set; }
            public decimal PagoxMes { get; set; }
        }

        public void Insertar_Prestamo(PrestamoE entidad)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand("Insertar_Prestamo", con);
            command.Parameters.AddWithValue("@ClienteID", entidad.ClienteID);
            command.Parameters.AddWithValue("@Prestamo", entidad.Prestamo);
            command.Parameters.AddWithValue("@IntervaloMeses", entidad.Meses);
            command.Parameters.AddWithValue("@Comision", entidad.Comision);
            command.Parameters.AddWithValue("@PagoxMes", entidad.PagoxMes);
            command.CommandType = CommandType.StoredProcedure;
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }
        public void ObtenerDatos_Prestamo(PrestamoE entidad)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand("ObtenerDatos_PrestamoMaximo", con);
            command.Parameters.AddWithValue("@CantHijos", entidad.CantHijos);
            command.Parameters.AddWithValue("@Casado", entidad.Casado);
            command.Parameters.AddWithValue("@Vehiculo", entidad.Vehiculo);
            command.Parameters.AddWithValue("@Casa", entidad.Casa);
            command.Parameters.AddWithValue("@IDRangoRiesgo", entidad.IDRangoRiesgo);
            command.Parameters.AddWithValue("@INSS", entidad.INSS);
            command.Parameters.AddWithValue("@Salario", entidad.Salario);

            command.Parameters.Add("@PrestamoMaximo", SqlDbType.Decimal).Direction = ParameterDirection.Output;
            command.Parameters.Add("@ValorPorcentual", SqlDbType.Decimal).Direction = ParameterDirection.Output;
            // Variables para Historial Cliente
            command.Parameters.Add("@VehiculoID", SqlDbType.Int).Direction = ParameterDirection.Output;
            command.Parameters.Add("@CasaID", SqlDbType.Int).Direction = ParameterDirection.Output;
            command.Parameters.Add("@HijosID", SqlDbType.Int).Direction = ParameterDirection.Output;
            command.Parameters.Add("@CasadoID", SqlDbType.Int).Direction = ParameterDirection.Output;
            command.CommandType = CommandType.StoredProcedure;
            con.Open();
            command.ExecuteNonQuery();

            entidad.prestamoMaximo = Convert.ToDecimal(command.Parameters["@PrestamoMaximo"].Value);
            entidad.ValorProcentual = Convert.ToDecimal(command.Parameters["@ValorPorcentual"].Value);

            //Variables para Historial Cliente
            entidad.HijosID = Convert.ToInt32(command.Parameters["@HijosID"].Value);
            entidad.CasadoID = Convert.ToInt32(command.Parameters["@CasadoID"].Value);
            entidad.CasaID = Convert.ToInt32(command.Parameters["@CasaID"].Value);
            entidad.VehiculoID = Convert.ToInt32(command.Parameters["@VehiculoID"].Value);
            con.Close();
        }
    }
}

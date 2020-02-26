using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Clientes
    {
        public class ClientesE { 
            public Int64 IDCliente { get; set; }
            public Int32 Rango { get; set; }
            public Int32 RangoRiesgo { get; set; }
            public String Nombre { get; set; }
            public String Apellidos { get; set; }
            public Int32 Telefono { get; set; }
            public String Email { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public String Sexo { get; set; }
            public String Nacionalidad { get; set; }
            public String Cedula { get; set; }
            public Decimal PromedioSalario { get; set; }
            public Boolean CotizaINSS { get; set; }
            public Decimal Prestamo { get; set; }
            public Int64 Intervalo { get; set; }
            public String NombreEmpresa { get; set; }
            public Int32 MesesLaborando { get; set; }

            public int VehiculoID { get; set; }
            public int CasaID { get; set; }
            public int CasadoID { get; set; }
            public int HijosID { get; set; }
        }

        public Int32 Guardar(ClientesE clientes)
        {
            Int32 x = 0;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand("Cliente_Insertar", con);
            command.Parameters.AddWithValue("@Rango", clientes.Rango);
            command.Parameters.AddWithValue("@RangosRiesgos", clientes.RangoRiesgo);
            command.Parameters.AddWithValue("@Nombres", clientes.Nombre);
            command.Parameters.AddWithValue("@Apellidos", clientes.Apellidos);
            command.Parameters.AddWithValue("@Telefono", clientes.Telefono);
            command.Parameters.AddWithValue("@Email", clientes.Email);
            command.Parameters.AddWithValue("@FechaNacimiento", clientes.FechaNacimiento);
            command.Parameters.AddWithValue("@Sexo", clientes.Sexo);
            command.Parameters.AddWithValue("@Cedula", clientes.Cedula);
            command.Parameters.AddWithValue("@PromedioSalario", clientes.PromedioSalario);
            command.Parameters.AddWithValue("@CotizaINSS", clientes.CotizaINSS);
            command.Parameters.AddWithValue("@NombreEmpresa", clientes.NombreEmpresa);
            command.Parameters.AddWithValue("@MesesLaborando", clientes.MesesLaborando);

            //Insertar Cliente Historial
            command.Parameters.AddWithValue("@VehiculoID", clientes.VehiculoID);
            command.Parameters.AddWithValue("@CasaID", clientes.CasaID);
            command.Parameters.AddWithValue("@CasadoID", clientes.CasadoID);
            command.Parameters.AddWithValue("@HijosID", clientes.HijosID);

            command.Parameters.Add("@ClienteID", SqlDbType.Int).Direction = ParameterDirection.Output;

            command.CommandType = CommandType.StoredProcedure;
            con.Open();
            x = Convert.ToInt32(command.ExecuteScalar());

            clientes.IDCliente = Convert.ToInt32(command.Parameters["@ClienteID"].Value);
            con.Close();
            return x;
        }
    }
}

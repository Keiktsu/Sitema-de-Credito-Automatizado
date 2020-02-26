using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class UsuarioD
    {
        public class UsuarioE {
            public int UsuarioID { get; set; }
            public string UserName { get; set; }
            public string Pass { get; set; }
            public int Rol { get; set; }
            public string Cedula { get; set; }
        }

        public Int32 Autentificacion(UsuarioE entidad)
        {
            int resultado = -1;

            SqlConnection con = new SqlConnection(Properties.Settings.Default.Conexion);

            SqlCommand command = new SqlCommand("Usuario_Autentificar", con);
            command.Parameters.AddWithValue("@Username", entidad.UserName);
            command.Parameters.AddWithValue("@Password", entidad.Pass);
            command.Parameters.Add("@Rol", SqlDbType.Int).Direction = ParameterDirection.Output;
            command.CommandType = CommandType.StoredProcedure;
            con.Open();

            resultado = Convert.ToInt32(command.ExecuteScalar());
            if (resultado == 0)
            {
                entidad.Rol = 0;
            }
            else {
                entidad.Rol = Convert.ToInt32(command.Parameters["@Rol"].Value);
            }
            
            con.Close();
            return resultado;
        }
    }
}

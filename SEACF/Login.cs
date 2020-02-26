using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace SEACF
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lnkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NuevoUsuario user = new NuevoUsuario();
            user.Show();
            this.Hide();
                
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autentificacion();
        }

        private void Autentificacion()
        {
            UsuarioD obj = new UsuarioD();
            UsuarioD.UsuarioE entidad = new UsuarioD.UsuarioE();

            entidad.UserName = txtUser.Text;
            entidad.Pass = txtPassword.Text;

            int resultado = obj.Autentificacion(entidad);
            Program.Rol = entidad.Rol;
            if (resultado > 0)
            {
                if (Program.Rol == 1)
                {
                    Panel panel = new Panel();
                    panel.Show();
                    this.Hide();
                }
                else if (Program.Rol == 2)
                {
                    Form1 Solicitud = new Form1();
                    Solicitud.Show();
                    this.Hide();
                }
            }
            else
            {
                lblResultado.Visible = true;
                lblResultado.Text = "Contraseña incorrecta.";
                txtPassword.Clear();
                txtUser.Clear();
            }
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Autentificacion();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEACF
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorUsuario.SetError(txtNombre, "Ingrese su Nombre");
                return;
            }
            else
            {
                errorUsuario.SetError(txtNombre, "");
            }

            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                errorUsuario.SetError(txtCedula, "Ingrese su Cedula");
                return;
            }
            else
            {
                errorUsuario.SetError(txtCedula, "");
            }

            if (string.IsNullOrEmpty(txtUser.Text))
            {
                errorUsuario.SetError(txtUser, "Ingrese un Nombre de Usuario");
                return;
            }
            else
            {
                errorUsuario.SetError(txtUser, "");
            }

            if (string.IsNullOrEmpty(txtContra.Text))
            {
                errorUsuario.SetError(txtContra, "Ingrese una contraseña");
                return;
            }
            else
            {
                errorUsuario.SetError(txtContra, "");
            }

            if (string.IsNullOrEmpty(txtConfirmar.Text))
            {
                errorUsuario.SetError(txtConfirmar, "Confirme su contraseña");
                return;
            }
            else
            {
                errorUsuario.SetError(txtConfirmar, "");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }
    }
}

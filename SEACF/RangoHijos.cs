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
    public partial class RangoHijos : Form
    {
        int IDHijos = 0;
        public RangoHijos(int ID,string RangoRiesgo,int CantHijos, Decimal Valor)
        {
            InitializeComponent();
            txtHijos.Text = CantHijos.ToString();
            txtRango.Text = RangoRiesgo;
            txtValor.Text = Valor.ToString();
            IDHijos = ID;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                errorHijos.SetError(txtValor, "Ingrese el Valor");
                return;
            }
            else
            {
                errorHijos.SetError(txtValor, "");
            }

            HijosD obj = new HijosD();
            HijosD.HijosE entidad = new HijosD.HijosE();
            entidad.HijosID = IDHijos;
            entidad.Valor = Convert.ToDecimal(txtValor.Text);
            int resultado = obj.Modificar(entidad);

            if (resultado == 1)
            {
                ControlHijos hijo = new ControlHijos();
                hijo.Show();
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ControlHijos hijos = new ControlHijos();
            hijos.Show();
            this.Close();
        }

        private void RangoHijos_Load(object sender, EventArgs e)
        {

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtValor.Text.Contains(".") == true)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !txtValor.Text.Contains("-"))
                {
                    e.Handled = true;
                }
            }
        }
    }
}

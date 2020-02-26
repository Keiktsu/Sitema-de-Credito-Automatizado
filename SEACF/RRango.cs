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
    public partial class RRango : Form
    {
        int IDRango = 0;
        public RRango(int ID, decimal RangoMin, decimal RangoMax,decimal Seguro,decimal Mora, decimal Comision,decimal TasaInteres)
        {
            InitializeComponent();
            IDRango = ID;
            lblRMin.Text = RangoMin.ToString();
            lblRMax.Text = RangoMax.ToString();
            txtComision.Text = Comision.ToString();
            txtMora.Text = Mora.ToString();
            txtSeguro.Text = Seguro.ToString();
            txtTasaInteres.Text = TasaInteres.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ControlRango rango = new ControlRango();
            rango.Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtComision.Text))
            {
                Error.SetError(txtComision, "Ingrese el Valor");
                return;
            }
            else
            {
                Error.SetError(txtComision, "");
            }

            if (string.IsNullOrEmpty(txtMora.Text))
            {
                Error.SetError(txtMora, "Ingrese el Valor");
                return;
            }
            else
            {
                Error.SetError(txtMora, "");
            }

            if (string.IsNullOrEmpty(txtSeguro.Text))
            {
                Error.SetError(txtSeguro, "Ingrese el Valor");
                return;
            }
            else
            {
                Error.SetError(txtSeguro, "");
            }
            if (string.IsNullOrEmpty(txtTasaInteres.Text))
            {
                Error.SetError(txtTasaInteres, "Ingrese el Valor");
                return;
            }
            else
            {
                Error.SetError(txtTasaInteres, "");
            }

            RangoD obj = new RangoD();
            RangoD.RangoE entidad = new RangoD.RangoE();
            entidad.RangoID = IDRango;
            entidad.Comision = Convert.ToDecimal(txtComision.Text);
            entidad.Mora = Convert.ToDecimal(txtMora.Text);
            entidad.Seguro = Convert.ToDecimal(txtSeguro.Text);
            entidad.TasaInteres = Convert.ToDecimal(txtTasaInteres.Text);

            int resultado = obj.Modificar(entidad);

            if (resultado == 1)
            {
                ControlRango rango = new ControlRango();
                rango.Show();
                this.Close();
            }
        }

        private void txtTasaInteres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtTasaInteres.Text.Contains(".") == true)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !txtTasaInteres.Text.Contains("-"))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtComision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtComision.Text.Contains(".") == true)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !txtComision.Text.Contains("-"))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtMora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtMora.Text.Contains(".") == true)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !txtMora.Text.Contains("-"))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtSeguro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txtSeguro.Text.Contains(".") == true)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !txtSeguro.Text.Contains("-"))
                {
                    e.Handled = true;
                }
            }
        }
    }
}

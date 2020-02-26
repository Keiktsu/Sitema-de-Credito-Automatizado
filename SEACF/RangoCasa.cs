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
    public partial class RangoCasa : Form
    {
        int IDCasa = 0;
        public RangoCasa(string RangoRiesgo, string EstadoCasa, decimal Valor,int ID)
        {
            InitializeComponent();
            txtRango.Text = RangoRiesgo;
            txtValor.Text = Convert.ToString(Valor);
            txtCasa.Text = EstadoCasa;
            IDCasa = ID;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                errorCasa.SetError(txtValor, "Ingrese el Valor de Casa");
                return;
            }
            else
            {
                errorCasa.SetError(txtValor, "");
            }

            CasaD obj = new CasaD();
            CasaD.CasaE entidad = new CasaD.CasaE();
            entidad.CasaID = IDCasa;
            entidad.Valor = Convert.ToDecimal(txtValor.Text);
            int resultado = obj.Modificar(entidad);

            if (resultado == 1)
            {
                ControlCasa casa = new ControlCasa();
                casa.Show();
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ControlCasa casa = new ControlCasa();
            casa.Show();
            this.Close();
        }
        private void RangoCasa_Load(object sender, EventArgs e)
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

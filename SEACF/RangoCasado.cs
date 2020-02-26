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
    public partial class RangoCasado : Form
    {
        int IDCasado = 0;
        public RangoCasado(int ID, string RangoRiesgo, string Estado, Decimal Valor)
        {
            InitializeComponent();
            txtCasado.Text = Estado.ToString();
            txtRango.Text = RangoRiesgo;
            txtValor.Text = Valor.ToString();
            IDCasado = ID;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                errorCasado.SetError(txtValor, "Ingrese el Valor del Estado");
                return;
            }
            else
            {
                errorCasado.SetError(txtValor, "");
            }

            CasadoD obj = new CasadoD();
            CasadoD.CasadoE entidad = new CasadoD.CasadoE();
            entidad.CasadoID = IDCasado;
            entidad.Valor = Convert.ToDecimal(txtValor.Text);
            int resultado = obj.Modificar(entidad);

            if (resultado == 1)
            {
                ControlCasado hijo = new ControlCasado();
                hijo.Show();
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ControlCasado casado = new ControlCasado();
            casado.Show();
            this.Close();
        }

        private void RangoCasado_Load(object sender, EventArgs e)
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

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
    public partial class RangoVehiculo : Form
    {
        int IDVehiculo = 0;
        public RangoVehiculo(int ID, string RangoRiesgo, String Estado, Decimal Valor)
        {
            InitializeComponent();
            txtVehiculo.Text = Estado.ToString();
            txtRango.Text = RangoRiesgo;
            txtValor.Text = Valor.ToString();
            IDVehiculo = ID;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                errorVehiculo.SetError(txtValor, "Ingrese el Valor del Estado en Vehiculo");
                return;
            }
            else
            {
                errorVehiculo.SetError(txtValor, "");
            }
            VehiculoD obj = new VehiculoD();
            VehiculoD.VehiculoE entidad = new VehiculoD.VehiculoE();
            entidad.VehiculoID = IDVehiculo;
            entidad.Valor = Convert.ToDecimal(txtValor.Text);
            int resultado = obj.Modificar(entidad);

            if (resultado == 1)
            {
                ControlVehiculos vehiculo = new ControlVehiculos();
                vehiculo.Show();
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            ControlVehiculos veh = new ControlVehiculos();
            veh.Show();
            this.Close();
        }

        private void RangoVehiculo_Load(object sender, EventArgs e)
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

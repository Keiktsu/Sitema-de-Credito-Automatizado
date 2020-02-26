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
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void rangoHijosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlHijos hijos = new ControlHijos();
            hijos.Show();
            this.Hide();
        }

        private void rangoCasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlCasa casa = new ControlCasa();
            casa.Show();
            this.Hide();
        }

        private void rangoCasadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlCasado casado = new ControlCasado();
            casado.Show();
            this.Hide();
        }

        private void rangoVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlVehiculos veh = new ControlVehiculos();
            veh.Show();
            this.Hide();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
            
        }

        private void rangoPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlRango rango = new ControlRango();
            rango.Show();
            this.Hide();
        }
    }
}

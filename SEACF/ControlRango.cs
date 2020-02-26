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
    public partial class ControlRango : Form
    {
        public ControlRango()
        {
            InitializeComponent();
        }
        decimal RangoMin = 0;
        decimal RangoMax = 0;
        decimal Seguro = 0;
        decimal Mora = 0;
        decimal Comision = 0;
        decimal TasaInteres = 0;
        int ID = 0;
        private void ControlRango_Load(object sender, EventArgs e)
        {
            Obtener();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.Show();
            this.Close();
        }
        public void VerDatos()
        {
            ID = Convert.ToInt32(GridView.SelectedRows[0].Cells["No"].Value.ToString());
            RangoMin = Convert.ToDecimal(GridView.SelectedRows[0].Cells["Rango min."].Value.ToString());
            RangoMax = Convert.ToDecimal(GridView.SelectedRows[0].Cells["Rango Max."].Value.ToString());
            TasaInteres = Convert.ToDecimal(GridView.SelectedRows[0].Cells["TasaInteres"].Value);
            Comision = Convert.ToDecimal(GridView.SelectedRows[0].Cells["Comision"].Value);
            Mora = Convert.ToDecimal(GridView.SelectedRows[0].Cells["Mora"].Value);
            Seguro = Convert.ToDecimal(GridView.SelectedRows[0].Cells["Seguro"].Value);
        }

        private void Obtener()
        {
            DataSet ds;

            RangoD obj = new RangoD();

            ds = obj.Seleccionar();
            GridView.DataSource = ds.Tables[0];
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            RRango rango = new RRango(ID, RangoMin, RangoMax, Seguro, Mora, Comision, TasaInteres);
            rango.Show();
            this.Close();
        }

        private void GridView_Click(object sender, EventArgs e)
        {
            if (GridView.RowCount > 0)
            {
                int fila = GridView.CurrentRow.Index;
                DataGridViewRow nuevafila = GridView.Rows[fila];
                GridView.CurrentCell = nuevafila.Cells[1];
                nuevafila.Selected = true;
                VerDatos();
                btnModificar.Enabled = true;

            }
        }
    }
}
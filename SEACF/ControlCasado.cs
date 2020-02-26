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
    public partial class ControlCasado : Form
    {
        public ControlCasado()
        {
            InitializeComponent();
        }
        string RangoRiesgo = "";
        decimal Valor = 0;
        string Estado = "";
        int ID = 0;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.Show();
            this.Close();
        }
        public void VerDatos()
        {
            RangoRiesgo = GridView.SelectedRows[0].Cells["RangoRiesgo"].Value.ToString();
            Estado = GridView.SelectedRows[0].Cells["Estado Casado"].Value.ToString();
            Valor = Convert.ToDecimal(GridView.SelectedRows[0].Cells["Valor"].Value);
            ID = Convert.ToInt32(GridView.SelectedRows[0].Cells["No"].Value);
        }
        private void Obtener()
        {
            DataSet ds;

            CasadoD obj = new CasadoD();

            ds = obj.Seleccionar();
            GridView.DataSource = ds.Tables[0];
        }
        private void ControlCasado_Load(object sender, EventArgs e)
        {
            Obtener();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            RangoCasado casado = new RangoCasado(ID, RangoRiesgo, Estado, Valor);
            casado.Show();
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

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
using System.Globalization;

namespace SEACF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int flag = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(TabInfoLaboral);
            tabControl1.TabPages.Remove(TabInfoPersonal);
            tabControl1.TabPages.Remove(TabResultado);
            tabControl1.TabPages.Remove(TabRango);
            tabControl1.TabPages.Remove(TabResumen);
        }

        private void TabInfoPersonal_Click(object sender, EventArgs e)
        {

        }

        private void VerDatos()
        {
            lblMPrestamo.Enabled = true;
            lblMora.Enabled = true;
            lblTasa.Enabled = true;
            lblComision.Enabled = true;
            lblSeguro.Enabled = true;
            lblMeses.Enabled = true;

            lblMPrestamo.Text = "Prestamo: US$" + GridView.SelectedRows[0].Cells["Prestamo"].Value.ToString();
            lblMora.Text = "Mora: US$" + GridView.SelectedRows[0].Cells[4].Value.ToString();

            lblTasa.Text = "Tasa Int: " + (Convert.ToDecimal(GridView.SelectedRows[0].Cells[3].Value) * 100).ToString("N2") + "%";
            lblComision.Text = "Comision: " + (Convert.ToDecimal(GridView.SelectedRows[0].Cells[2].Value) * 100).ToString("N2") + "%";
            lblSeguro.Text = "Seguro: " + (Convert.ToDecimal(GridView.SelectedRows[0].Cells[5].Value) * 100).ToString("N2") + "%";
            lblMeses.Text = Convert.ToInt32(GridView.SelectedRows[0].Cells[1].Value).ToString() + " Meses";
            MesesPlazo = Convert.ToInt32(GridView.SelectedRows[0].Cells[1].Value);
        }

        public Decimal PagoxMes = 0;
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Clientes.ClientesE clientes = new Clientes.ClientesE();
            Prestamo.PrestamoE prestamos = new Prestamo.PrestamoE();

            HistorialClientes.HistorialE historial = new HistorialClientes.HistorialE();
            Prestamo objPrestamo = new Prestamo();
            Clientes objClientes = new Clientes();
            HistorialClientes objHistorial = new HistorialClientes();

            if (flag == -1)
            {
                Application.Exit();
            }

            if (flag == 5)
            {
                tabControl1.TabPages.Add(TabResumen);
                tabControl1.SelectedTab = TabResumen;
                PagoxMes = (PrestamoSolicitado / MesesPlazo) * (1 + TasaInteres);
                lblHola.Text = "Hola " + Nombre + " " + Apellido;
                lblRPrestamo.Text = "Tu prestamo por US$" + PrestamoSolicitado.ToString("N2") + " durante " + MesesPlazo + " Meses";
                lblCuota.Text = "Con una cuota mensual de US$" + PagoxMes.ToString("N2");
                lblRComision.Text = "Comision: " + (Comision * 100).ToString("N2") + "%";
                lblRTasaInteres.Text = "Tasa Interes: " + (TasaInteres * 100).ToString("N2") + "%";
                lblRSeguro.Text = "Seguro: " + (Seguro * 100).ToString("N2") + "%";
                lblRMora.Text = "Mora : US$" + Mora.ToString("N2");
                flag = 6;
                return;
            }
            if (flag == 6)
            {       
                //Cliente
                clientes.Nombre = Nombre;
                clientes.Apellidos = Apellido;
                clientes.Rango = Rango;
                clientes.RangoRiesgo = RangoRiesg;
                clientes.Telefono = Telefono;
                clientes.Email = Email;
                clientes.FechaNacimiento = FechaNac;
                clientes.Sexo = Sexo;
                clientes.Cedula = Cedula;
                clientes.PromedioSalario = Salario;
                clientes.CotizaINSS = INSS;
                clientes.NombreEmpresa = Empresa;
                clientes.MesesLaborando = MesesTrabajados;

                //Datos Historial Cliente
                clientes.HijosID = HijosID;
                clientes.VehiculoID = VehiculoID;
                clientes.CasadoID = CasadoID;
                clientes.CasaID = CasaID;

                objClientes.Guardar(clientes);

                //Prestamo
                prestamos.ClienteID = Convert.ToInt32(clientes.IDCliente);
                prestamos.Prestamo = PrestamoSolicitado;
                prestamos.Meses = MesesPlazo;
                prestamos.Comision = (Comision * PrestamoSolicitado);
                prestamos.PagoxMes = PagoxMes;
                objPrestamo.Insertar_Prestamo(prestamos);

                flag = -1;
                btnSiguiente.Text = "Salir";
                lblCuota.Text = "¡Prestamo aplicado, correctamente!"+ "\n" + "Clic en Salir para cerrar SEACF";
                lblCuota.ForeColor = Color.Green;
                lblHola.Visible = false;
                label11.Visible = false;
                lblRPrestamo.Visible = false;
                lblRTasaInteres.Visible = false;
                lblRComision.Visible = false;
                lblRMora.Visible = false;
                lblRSeguro.Visible = false;
                return;
            }
            if (flag == 4)
            {
                if (Convert.ToDecimal(txtMontoPrestamo.Text) > PrestamosMaximo)
                {
                    errorProvider1.SetError(txtMontoPrestamo, "El monto solicitado no puede ser mayor a " + "US$" + PrestamosMaximo);
                    return;
                }

                else
                {
                    errorProvider1.SetError(txtMontoPrestamo, "");
                    tabControl1.TabPages.Add(TabRango);
                    tabControl1.SelectedTab = TabRango;

                    PrestamoSolicitado = Convert.ToDecimal(txtMontoPrestamo.Text);
                    lblCliente.Text = Nombre + " " + Apellido;

                    RangoD obj = new RangoD();
                    RangoD.RangoE entidad = new RangoD.RangoE();
                    entidad.Prestamo = PrestamoSolicitado;
                    obj.ObtenerRango(entidad);

                    MesMin = entidad.MesMin;
                    MesMax = entidad.MesMax;
                    Rango = entidad.RangoID;
                    TasaInteres = entidad.TasaInteres;
                    Comision = entidad.Comision;
                    Seguro = entidad.Seguro;
                    Mora = entidad.Mora;
                    for (int i = MesMin; i <= MesMax;)
                    {
                        GridView.Rows.Add(PrestamoSolicitado, i, Comision, TasaInteres, Mora, Seguro);
                        i += 6;
                    }
                }
            }

            if (flag == 1)
            {
                txtHijos.Visible = false;
                if (string.IsNullOrEmpty(txtNombres.Text))
                {
                    errorProvider1.SetError(txtNombres, "Ingrese el nombre");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtNombres, "");
                }

                if (string.IsNullOrEmpty(txtApellidos.Text))
                {
                    errorProvider1.SetError(txtApellidos, "Ingrese el Apellido");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtApellidos, "");
                }

                if (string.IsNullOrEmpty(txtTelefono.Text))
                {
                    errorProvider1.SetError(txtTelefono, "Ingrese el Telefono");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtTelefono, "");
                }

                if (string.IsNullOrEmpty(txtCedula.Text))
                {
                    errorProvider1.SetError(txtCedula, "Ingrese la Cedula");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtCedula, "");
                }

                if (string.IsNullOrEmpty(Convert.ToString(cbSexo.SelectedItem)))
                {
                    errorProvider1.SetError(cbSexo, "Seleccione su Sexo");
                    return;
                }
                else
                {
                    errorProvider1.SetError(cbSexo, "");
                }

                tabControl1.TabPages.Add(TabInfoPersonal);
                tabControl1.SelectedTab = TabInfoPersonal;
                return;
            }
            if (flag == 2)
            {
                if (string.IsNullOrEmpty(Convert.ToString(cbVehiculo.SelectedItem)))
                {
                    errorProvider1.SetError(cbVehiculo, "Seleccione si posee vehiculo");
                    return;
                }
                else
                {
                    errorProvider1.SetError(cbVehiculo, "");
                }


                if (string.IsNullOrEmpty(Convert.ToString(cbCasa.SelectedItem)))
                {
                    errorProvider1.SetError(cbCasa, "Seleccione si posee casa");
                    return;
                }
                else
                {
                    errorProvider1.SetError(cbCasa, "");
                }
                tabControl1.TabPages.Add(TabInfoLaboral);
                tabControl1.SelectedTab = TabInfoLaboral;
                return;
            }

            if (flag == 3)
            {
                if (string.IsNullOrEmpty(txtNombreEmpresa.Text))
                {
                    errorProvider1.SetError(txtNombreEmpresa, "Ingrese el nombre de la empresa");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtNombreEmpresa, "");
                }

                if (string.IsNullOrEmpty(txtSalario.Text))
                {
                    errorProvider1.SetError(txtSalario, "Ingrese su salario");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtSalario, "");
                }

                if (string.IsNullOrEmpty(txtMesesLaborando.Text))
                {
                    errorProvider1.SetError(txtMesesLaborando, "Ingrese la cantidad de meses de laborar");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtMesesLaborando, "");
                }

                tabControl1.TabPages.Add(TabResultado);
                tabControl1.SelectedTab = TabResultado;

                if (cbHijos.Checked == true)
                {
                    Hijos = Convert.ToInt32(txtHijos.Text);
                    if (Hijos > 5)
                    {
                        Hijos = 5;
                    }
                }
                else if (cbHijos.Checked == false)
                {
                    Hijos = 0;
                }

                if (cbCasado.Checked == true)
                {
                    Casado = true;
                }
                else if (cbCasado.Checked == false)
                {
                    Casado = false;
                }

                if (cbVehiculo.Text == "Sí")
                {
                    Vehiculo = "Si";
                }
                else if (cbVehiculo.Text == "No")
                {
                    Vehiculo = "No";
                }
                else if (cbVehiculo.Text == "Si, Aún pagando")
                {
                    Vehiculo = "Pagando";
                }

                if (cbCasa.Text == "Casa Propia")
                {
                    Casa = "Propia";
                }
                else if (cbCasa.Text == "Alquilo Casa")
                {
                    Casa = "Alquila";
                }
                else if (cbCasa.Text == "Pagando Casa")
                {
                    Casa = "Pagando";
                }

                if (cbINSS.Checked == true)
                {
                    INSS = true;
                }
                else if (cbINSS.Checked == false)
                {
                    INSS = false;
                }

                MesesTrabajados = Convert.ToInt32(txtMesesLaborando.Text);
                Salario = Convert.ToDecimal(txtSalario.Text);
                Nombre = txtNombres.Text;
                Apellido = txtApellidos.Text;
                Telefono = Convert.ToInt32(txtTelefono.Text);
                Email = txtEmail.Text;
                FechaNac = Convert.ToDateTime(dtFechaNac.Value);
                Sexo = cbSexo.Text;
                Cedula = txtCedula.Text;
                INSS = cbINSS.Checked;
                MesesTrabajados = Convert.ToInt32(txtMesesLaborando.Text);
                Empresa = txtNombreEmpresa.Text;

                if ((Salario == 0) || (Salario < 200))
                {
                    lblResultado.Text = "Lo sentimos, usted no puede aplicar a un prestamo con nosotros";
                    lblResultado.Location = new Point(49, 44);
                    lblResultado.ForeColor = Color.Red;
                    flag = -1;
                    btnSiguiente.Text = "Salir";
                    return;
                }

                BDExtRiesgo.BDExtRiesgoE BDEXTRiesgo = new BDExtRiesgo.BDExtRiesgoE();
                BDExtRiesgo obj = new BDExtRiesgo();
                BDEXTRiesgo.Cedula = txtCedula.Text;
                obj.ObtenerRangoRiesgo(BDEXTRiesgo);
                RangoRiesg = BDEXTRiesgo.RangoRiesgo;

                if (RangoRiesg == 5)
                {
                    lblResultado.Text = "Lo sentimos, usted no puede aplicar a un prestamo con nosotros";
                    lblResultado.ForeColor = Color.Red;
                    lblResultado.Location = new Point(49, 44);
                    flag = -1;
                    btnSiguiente.Text = "Salir";
                }
                else if (MesesTrabajados < 6)//No cumple los meses
                {
                    lblResultado.Text = "Lo sentimos, usted no puede aplicar a un prestamo con nosotros";
                    lblResultado.ForeColor = Color.Red;
                    lblResultado.Location = new Point(49, 44);
                    flag = -1;
                    btnSiguiente.Text = "Salir";
                }
                else // Aplica al Prestamo
                {
                    prestamos.CantHijos = Hijos;
                    prestamos.Casado = Casado;
                    prestamos.Vehiculo = Vehiculo;
                    prestamos.Casa = Casa;
                    prestamos.IDRangoRiesgo = RangoRiesg;
                    prestamos.INSS = INSS;
                    prestamos.Salario = Salario;

                    objPrestamo.ObtenerDatos_Prestamo(prestamos);

                    PrestamosMaximo = prestamos.prestamoMaximo;
                    HijosID = prestamos.HijosID;
                    CasadoID = prestamos.CasadoID;
                    CasaID = prestamos.CasaID;
                    VehiculoID = prestamos.VehiculoID;
                    
                    lblResultado.Text = "Felicidades, cumple requisitos para " + "\n" + "un prestamo Maximo por: US$" + PrestamosMaximo;
                    lblResultado.ForeColor = Color.Green;
                    lblResultado.Location = new Point(195, 40);

                    lblPrestamoMax.Visible = true;
                    txtMontoPrestamo.Visible = true;
                }
                return;
            }
        }
        //Variables para el Historial
        public int HijosID = 0;
        public int CasadoID = 0;
        public int CasaID = 0;
        public int VehiculoID = 0;
        public int RangoRiesg = 0;
        public int ClienteID = 0;
        //***//
        public int Hijos = 0;
        public bool Casado = false;
        public string Vehiculo = "";
        public string Casa = "";
        public decimal Salario = 0;
        public bool INSS = false;    
        public int MesesTrabajados = 0;
        public decimal PrestamosMaximo = 0;
        public decimal PrestamoSolicitado = 0;
        public int MesesPlazo = 0;
        public string Nombre = "";
        public string Apellido = "";
        public int Telefono = 0;
        public string Email = "";
        public DateTime FechaNac;
        public string Sexo = "";
        public string Cedula = "";
        public int Intervalo = 0;
        public string Empresa = "";
        public int Rango = 0;
        public decimal TasaInteres = 0;
        public decimal Comision = 0;
        public decimal Mora = 0;
        public decimal Seguro = 0;
        public int MesMin = 0;
        public int MesMax = 0;

        private void TabDatosPersonales_Enter(object sender, EventArgs e)
        {
            if (flag >= 1 ||  flag == -1)
            {
                return;
            }
            else
            {
                flag = 1;
            }

        }

        private void TabInfoPersonal_Enter(object sender, EventArgs e)
        {
            if (flag >= 2 ||flag == -1)
            {
                return;
            }
            else
            {
                flag = 2;
            }
        }

        private void TabInfoLaboral_Enter(object sender, EventArgs e)
        {
            if (flag >= 3 ||  flag == -1)
            {
                return;
            }
            else
            {
                flag = 3;
            }
        }

        private void TabResultado_Enter(object sender, EventArgs e)
        {
            if (flag >= 4 ||flag == -1)
            {
                return;
            }
            flag = 4;
        }

        private void txtNombres_Validating(object sender, CancelEventArgs e)
        {

        }

        private void cbHijos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHijos.Checked == true)
            {
                txtHijos.Visible = true;
                lblcuantosH.Visible = true;
                lblcuantosH.Location = new Point(321, 43);
                txtHijos.Location = new Point(309, 71);

                cbCasado.Location = new Point(285, 105);
                lblvehiculo.Location = new Point(300, 137);
                cbVehiculo.Location = new Point(293, 167);
                lblcasa.Location = new Point(310, 207);
                cbCasa.Location = new Point(296, 237);
            }
            else if (cbHijos.Checked == false)
            {
                txtHijos.Visible = false;
                lblcuantosH.Visible = false;
                cbCasado.Location = new Point(285, 52);
                lblvehiculo.Location = new Point(300, 84);
                cbVehiculo.Location = new Point(293, 114);
                lblcasa.Location = new Point(310, 154);
                cbCasa.Location = new Point(296, 184);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtHijos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtMesesLaborando_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombreEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtMontoPrestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
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
                btnSiguiente.Enabled = true;
            }
        }

        private void TabRango_Enter(object sender, EventArgs e)
        {
            if (flag == -1 || flag >= 5)
            {
                return;
            }
            btnSiguiente.Enabled = false;
            flag = 5;
        }

        private void TabResumen_Enter(object sender, EventArgs e)
        {
            if (flag == -1 || flag >= 6)
            {
                return;
            }
            btnSiguiente.Text = "Enviar";
        }
    }
}

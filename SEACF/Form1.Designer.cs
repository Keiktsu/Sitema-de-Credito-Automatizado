namespace SEACF
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabDatosPersonales = new System.Windows.Forms.TabPage();
            this.dtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabInfoPersonal = new System.Windows.Forms.TabPage();
            this.lblcuantosH = new System.Windows.Forms.Label();
            this.cbCasado = new System.Windows.Forms.CheckBox();
            this.cbHijos = new System.Windows.Forms.CheckBox();
            this.lblcasa = new System.Windows.Forms.Label();
            this.cbCasa = new System.Windows.Forms.ComboBox();
            this.lblvehiculo = new System.Windows.Forms.Label();
            this.cbVehiculo = new System.Windows.Forms.ComboBox();
            this.txtHijos = new System.Windows.Forms.TextBox();
            this.TabInfoLaboral = new System.Windows.Forms.TabPage();
            this.cbINSS = new System.Windows.Forms.CheckBox();
            this.txtMesesLaborando = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TabResultado = new System.Windows.Forms.TabPage();
            this.lblPrestamoMax = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtMontoPrestamo = new System.Windows.Forms.TextBox();
            this.TabRango = new System.Windows.Forms.TabPage();
            this.lblMeses = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.Prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComisionC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TasaInteresC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoraC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeguroC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.lblMora = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblTasa = new System.Windows.Forms.Label();
            this.lblMPrestamo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TabResumen = new System.Windows.Forms.TabPage();
            this.lblHola = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRSeguro = new System.Windows.Forms.Label();
            this.lblRMora = new System.Windows.Forms.Label();
            this.lblRComision = new System.Windows.Forms.Label();
            this.lblRTasaInteres = new System.Windows.Forms.Label();
            this.lblRPrestamo = new System.Windows.Forms.Label();
            this.lblCuota = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1.SuspendLayout();
            this.TabDatosPersonales.SuspendLayout();
            this.TabInfoPersonal.SuspendLayout();
            this.TabInfoLaboral.SuspendLayout();
            this.TabResultado.SuspendLayout();
            this.TabRango.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.TabResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabDatosPersonales);
            this.tabControl1.Controls.Add(this.TabInfoPersonal);
            this.tabControl1.Controls.Add(this.TabInfoLaboral);
            this.tabControl1.Controls.Add(this.TabResultado);
            this.tabControl1.Controls.Add(this.TabRango);
            this.tabControl1.Controls.Add(this.TabResumen);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 315);
            this.tabControl1.TabIndex = 0;
            // 
            // TabDatosPersonales
            // 
            this.TabDatosPersonales.Controls.Add(this.txtCedula);
            this.TabDatosPersonales.Controls.Add(this.dtFechaNac);
            this.TabDatosPersonales.Controls.Add(this.label7);
            this.TabDatosPersonales.Controls.Add(this.cbSexo);
            this.TabDatosPersonales.Controls.Add(this.label6);
            this.TabDatosPersonales.Controls.Add(this.label5);
            this.TabDatosPersonales.Controls.Add(this.txtEmail);
            this.TabDatosPersonales.Controls.Add(this.label4);
            this.TabDatosPersonales.Controls.Add(this.txtTelefono);
            this.TabDatosPersonales.Controls.Add(this.label3);
            this.TabDatosPersonales.Controls.Add(this.txtApellidos);
            this.TabDatosPersonales.Controls.Add(this.label2);
            this.TabDatosPersonales.Controls.Add(this.txtNombres);
            this.TabDatosPersonales.Controls.Add(this.label1);
            this.TabDatosPersonales.Location = new System.Drawing.Point(4, 22);
            this.TabDatosPersonales.Name = "TabDatosPersonales";
            this.TabDatosPersonales.Padding = new System.Windows.Forms.Padding(3);
            this.TabDatosPersonales.Size = new System.Drawing.Size(704, 289);
            this.TabDatosPersonales.TabIndex = 0;
            this.TabDatosPersonales.Text = "Datos Personales";
            this.TabDatosPersonales.UseVisualStyleBackColor = true;
            this.TabDatosPersonales.Enter += new System.EventHandler(this.TabDatosPersonales_Enter);
            // 
            // dtFechaNac
            // 
            this.dtFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaNac.Location = new System.Drawing.Point(152, 183);
            this.dtFechaNac.Name = "dtFechaNac";
            this.dtFechaNac.Size = new System.Drawing.Size(123, 22);
            this.dtFechaNac.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(374, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cedula:";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbSexo.Location = new System.Drawing.Point(443, 64);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 24);
            this.cbSexo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(374, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(26, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Nacimiento:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(152, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(123, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(26, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-mail:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(152, 103);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(123, 22);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(26, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefono:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(152, 61);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(207, 22);
            this.txtApellidos.TabIndex = 3;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(26, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos:";
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(152, 18);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(207, 22);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            this.txtNombres.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombres_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // TabInfoPersonal
            // 
            this.TabInfoPersonal.Controls.Add(this.lblcuantosH);
            this.TabInfoPersonal.Controls.Add(this.cbCasado);
            this.TabInfoPersonal.Controls.Add(this.cbHijos);
            this.TabInfoPersonal.Controls.Add(this.lblcasa);
            this.TabInfoPersonal.Controls.Add(this.cbCasa);
            this.TabInfoPersonal.Controls.Add(this.lblvehiculo);
            this.TabInfoPersonal.Controls.Add(this.cbVehiculo);
            this.TabInfoPersonal.Controls.Add(this.txtHijos);
            this.TabInfoPersonal.Location = new System.Drawing.Point(4, 22);
            this.TabInfoPersonal.Name = "TabInfoPersonal";
            this.TabInfoPersonal.Size = new System.Drawing.Size(704, 289);
            this.TabInfoPersonal.TabIndex = 2;
            this.TabInfoPersonal.Text = "Info. Personal";
            this.TabInfoPersonal.UseVisualStyleBackColor = true;
            this.TabInfoPersonal.Click += new System.EventHandler(this.TabInfoPersonal_Click);
            this.TabInfoPersonal.Enter += new System.EventHandler(this.TabInfoPersonal_Enter);
            // 
            // lblcuantosH
            // 
            this.lblcuantosH.AutoSize = true;
            this.lblcuantosH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuantosH.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblcuantosH.Location = new System.Drawing.Point(569, 32);
            this.lblcuantosH.Name = "lblcuantosH";
            this.lblcuantosH.Size = new System.Drawing.Size(71, 16);
            this.lblcuantosH.TabIndex = 18;
            this.lblcuantosH.Text = "¿Cuantos?";
            this.lblcuantosH.Visible = false;
            // 
            // cbCasado
            // 
            this.cbCasado.AutoSize = true;
            this.cbCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbCasado.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cbCasado.Location = new System.Drawing.Point(285, 52);
            this.cbCasado.Name = "cbCasado";
            this.cbCasado.Size = new System.Drawing.Size(142, 20);
            this.cbCasado.TabIndex = 17;
            this.cbCasado.Text = "¿Es usted casado?";
            this.cbCasado.UseVisualStyleBackColor = true;
            // 
            // cbHijos
            // 
            this.cbHijos.AutoSize = true;
            this.cbHijos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbHijos.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cbHijos.Location = new System.Drawing.Point(301, 15);
            this.cbHijos.Name = "cbHijos";
            this.cbHijos.Size = new System.Drawing.Size(110, 20);
            this.cbHijos.TabIndex = 16;
            this.cbHijos.Text = "¿Tiene Hijos?";
            this.cbHijos.UseVisualStyleBackColor = true;
            this.cbHijos.CheckedChanged += new System.EventHandler(this.cbHijos_CheckedChanged);
            // 
            // lblcasa
            // 
            this.lblcasa.AutoSize = true;
            this.lblcasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcasa.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblcasa.Location = new System.Drawing.Point(310, 154);
            this.lblcasa.Name = "lblcasa";
            this.lblcasa.Size = new System.Drawing.Size(92, 16);
            this.lblcasa.TabIndex = 15;
            this.lblcasa.Text = "¿Tiene Casa?";
            // 
            // cbCasa
            // 
            this.cbCasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbCasa.FormattingEnabled = true;
            this.cbCasa.Items.AddRange(new object[] {
            "Casa Propia",
            "Alquilo Casa",
            "Pagando Casa"});
            this.cbCasa.Location = new System.Drawing.Point(296, 184);
            this.cbCasa.Name = "cbCasa";
            this.cbCasa.Size = new System.Drawing.Size(121, 24);
            this.cbCasa.TabIndex = 14;
            // 
            // lblvehiculo
            // 
            this.lblvehiculo.AutoSize = true;
            this.lblvehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvehiculo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblvehiculo.Location = new System.Drawing.Point(300, 84);
            this.lblvehiculo.Name = "lblvehiculo";
            this.lblvehiculo.Size = new System.Drawing.Size(112, 16);
            this.lblvehiculo.TabIndex = 13;
            this.lblvehiculo.Text = "¿Tiene Vehiculo?";
            // 
            // cbVehiculo
            // 
            this.cbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbVehiculo.FormattingEnabled = true;
            this.cbVehiculo.Items.AddRange(new object[] {
            "Sí",
            "No",
            "Si, Aún pagando"});
            this.cbVehiculo.Location = new System.Drawing.Point(296, 114);
            this.cbVehiculo.Name = "cbVehiculo";
            this.cbVehiculo.Size = new System.Drawing.Size(121, 24);
            this.cbVehiculo.TabIndex = 12;
            // 
            // txtHijos
            // 
            this.txtHijos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHijos.Location = new System.Drawing.Point(557, 60);
            this.txtHijos.Name = "txtHijos";
            this.txtHijos.Size = new System.Drawing.Size(94, 22);
            this.txtHijos.TabIndex = 6;
            this.txtHijos.Visible = false;
            this.txtHijos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHijos_KeyPress);
            // 
            // TabInfoLaboral
            // 
            this.TabInfoLaboral.Controls.Add(this.cbINSS);
            this.TabInfoLaboral.Controls.Add(this.txtMesesLaborando);
            this.TabInfoLaboral.Controls.Add(this.label13);
            this.TabInfoLaboral.Controls.Add(this.txtNombreEmpresa);
            this.TabInfoLaboral.Controls.Add(this.label9);
            this.TabInfoLaboral.Controls.Add(this.txtSalario);
            this.TabInfoLaboral.Controls.Add(this.label8);
            this.TabInfoLaboral.Location = new System.Drawing.Point(4, 22);
            this.TabInfoLaboral.Name = "TabInfoLaboral";
            this.TabInfoLaboral.Size = new System.Drawing.Size(704, 289);
            this.TabInfoLaboral.TabIndex = 1;
            this.TabInfoLaboral.Text = "Info. Laboral";
            this.TabInfoLaboral.UseVisualStyleBackColor = true;
            this.TabInfoLaboral.Enter += new System.EventHandler(this.TabInfoLaboral_Enter);
            // 
            // cbINSS
            // 
            this.cbINSS.AutoSize = true;
            this.cbINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbINSS.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cbINSS.Location = new System.Drawing.Point(294, 197);
            this.cbINSS.Name = "cbINSS";
            this.cbINSS.Size = new System.Drawing.Size(112, 20);
            this.cbINSS.TabIndex = 17;
            this.cbINSS.Text = "¿Cotiza INSS?";
            this.cbINSS.UseVisualStyleBackColor = true;
            // 
            // txtMesesLaborando
            // 
            this.txtMesesLaborando.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesesLaborando.Location = new System.Drawing.Point(313, 131);
            this.txtMesesLaborando.Name = "txtMesesLaborando";
            this.txtMesesLaborando.Size = new System.Drawing.Size(124, 22);
            this.txtMesesLaborando.TabIndex = 3;
            this.txtMesesLaborando.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMesesLaborando_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label13.Location = new System.Drawing.Point(182, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "Meses Laborando:";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpresa.Location = new System.Drawing.Point(313, 33);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(226, 22);
            this.txtNombreEmpresa.TabIndex = 1;
            this.txtNombreEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEmpresa_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Location = new System.Drawing.Point(182, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nombre Empresa:";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(313, 84);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(124, 22);
            this.txtSalario.TabIndex = 2;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(182, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Salario US$:";
            // 
            // TabResultado
            // 
            this.TabResultado.Controls.Add(this.lblPrestamoMax);
            this.TabResultado.Controls.Add(this.lblResultado);
            this.TabResultado.Controls.Add(this.txtMontoPrestamo);
            this.TabResultado.Location = new System.Drawing.Point(4, 22);
            this.TabResultado.Name = "TabResultado";
            this.TabResultado.Size = new System.Drawing.Size(704, 289);
            this.TabResultado.TabIndex = 3;
            this.TabResultado.Text = "Monto";
            this.TabResultado.UseVisualStyleBackColor = true;
            this.TabResultado.Enter += new System.EventHandler(this.TabResultado_Enter);
            // 
            // lblPrestamoMax
            // 
            this.lblPrestamoMax.AutoSize = true;
            this.lblPrestamoMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamoMax.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblPrestamoMax.Location = new System.Drawing.Point(276, 103);
            this.lblPrestamoMax.Name = "lblPrestamoMax";
            this.lblPrestamoMax.Size = new System.Drawing.Size(130, 20);
            this.lblPrestamoMax.TabIndex = 9;
            this.lblPrestamoMax.Text = "Monto Prestamo:";
            this.lblPrestamoMax.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(286, 44);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(109, 25);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado";
            // 
            // txtMontoPrestamo
            // 
            this.txtMontoPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoPrestamo.Location = new System.Drawing.Point(271, 136);
            this.txtMontoPrestamo.Name = "txtMontoPrestamo";
            this.txtMontoPrestamo.Size = new System.Drawing.Size(140, 22);
            this.txtMontoPrestamo.TabIndex = 7;
            this.txtMontoPrestamo.Visible = false;
            this.txtMontoPrestamo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoPrestamo_KeyPress);
            // 
            // TabRango
            // 
            this.TabRango.Controls.Add(this.lblMeses);
            this.TabRango.Controls.Add(this.label10);
            this.TabRango.Controls.Add(this.GridView);
            this.TabRango.Controls.Add(this.lblSeguro);
            this.TabRango.Controls.Add(this.lblMora);
            this.TabRango.Controls.Add(this.lblComision);
            this.TabRango.Controls.Add(this.lblTasa);
            this.TabRango.Controls.Add(this.lblMPrestamo);
            this.TabRango.Controls.Add(this.lblCliente);
            this.TabRango.Location = new System.Drawing.Point(4, 22);
            this.TabRango.Name = "TabRango";
            this.TabRango.Padding = new System.Windows.Forms.Padding(3);
            this.TabRango.Size = new System.Drawing.Size(704, 289);
            this.TabRango.TabIndex = 4;
            this.TabRango.Text = "Prestamo";
            this.TabRango.UseVisualStyleBackColor = true;
            this.TabRango.Enter += new System.EventHandler(this.TabRango_Enter);
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeses.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblMeses.Location = new System.Drawing.Point(3, 258);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(54, 16);
            this.lblMeses.TabIndex = 8;
            this.lblMeses.Text = "Meses";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(254, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(413, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Seleccione el lapso de Tiempo a Pagar, de su preferencia";
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeColumns = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prestamo,
            this.Meses,
            this.ComisionC,
            this.TasaInteresC,
            this.MoraC,
            this.SeguroC});
            this.GridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridView.Location = new System.Drawing.Point(179, 69);
            this.GridView.MultiSelect = false;
            this.GridView.Name = "GridView";
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(519, 205);
            this.GridView.TabIndex = 6;
            this.GridView.Click += new System.EventHandler(this.GridView_Click);
            // 
            // Prestamo
            // 
            this.Prestamo.HeaderText = "Prestamo";
            this.Prestamo.Name = "Prestamo";
            // 
            // Meses
            // 
            this.Meses.HeaderText = "Meses";
            this.Meses.Name = "Meses";
            this.Meses.Width = 60;
            // 
            // ComisionC
            // 
            this.ComisionC.HeaderText = "Comision";
            this.ComisionC.Name = "ComisionC";
            this.ComisionC.Width = 70;
            // 
            // TasaInteresC
            // 
            this.TasaInteresC.HeaderText = "Tasa Interes";
            this.TasaInteresC.Name = "TasaInteresC";
            this.TasaInteresC.Width = 90;
            // 
            // MoraC
            // 
            this.MoraC.HeaderText = "Mora";
            this.MoraC.Name = "MoraC";
            this.MoraC.Width = 60;
            // 
            // SeguroC
            // 
            this.SeguroC.HeaderText = "Seguro";
            this.SeguroC.Name = "SeguroC";
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguro.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblSeguro.Location = new System.Drawing.Point(3, 223);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(58, 16);
            this.lblSeguro.TabIndex = 5;
            this.lblSeguro.Text = "Seguro";
            // 
            // lblMora
            // 
            this.lblMora.AutoSize = true;
            this.lblMora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMora.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblMora.Location = new System.Drawing.Point(3, 184);
            this.lblMora.Name = "lblMora";
            this.lblMora.Size = new System.Drawing.Size(43, 16);
            this.lblMora.TabIndex = 4;
            this.lblMora.Text = "Mora";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComision.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblComision.Location = new System.Drawing.Point(3, 149);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(72, 16);
            this.lblComision.TabIndex = 3;
            this.lblComision.Text = "Comision";
            // 
            // lblTasa
            // 
            this.lblTasa.AutoSize = true;
            this.lblTasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasa.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTasa.Location = new System.Drawing.Point(3, 109);
            this.lblTasa.Name = "lblTasa";
            this.lblTasa.Size = new System.Drawing.Size(44, 16);
            this.lblTasa.TabIndex = 2;
            this.lblTasa.Text = "Tasa";
            // 
            // lblMPrestamo
            // 
            this.lblMPrestamo.AutoSize = true;
            this.lblMPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPrestamo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblMPrestamo.Location = new System.Drawing.Point(3, 69);
            this.lblMPrestamo.Name = "lblMPrestamo";
            this.lblMPrestamo.Size = new System.Drawing.Size(74, 16);
            this.lblMPrestamo.TabIndex = 1;
            this.lblMPrestamo.Text = "Prestamo";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCliente.Location = new System.Drawing.Point(58, 27);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(111, 16);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "NombreCliente";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(290, 333);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(132, 38);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TabResumen
            // 
            this.TabResumen.Controls.Add(this.lblCuota);
            this.TabResumen.Controls.Add(this.lblRSeguro);
            this.TabResumen.Controls.Add(this.lblRMora);
            this.TabResumen.Controls.Add(this.lblRComision);
            this.TabResumen.Controls.Add(this.lblRTasaInteres);
            this.TabResumen.Controls.Add(this.lblRPrestamo);
            this.TabResumen.Controls.Add(this.label11);
            this.TabResumen.Controls.Add(this.lblHola);
            this.TabResumen.Location = new System.Drawing.Point(4, 22);
            this.TabResumen.Name = "TabResumen";
            this.TabResumen.Size = new System.Drawing.Size(704, 289);
            this.TabResumen.TabIndex = 5;
            this.TabResumen.Text = "Resumen";
            this.TabResumen.UseVisualStyleBackColor = true;
            this.TabResumen.Enter += new System.EventHandler(this.TabResumen_Enter);
            // 
            // lblHola
            // 
            this.lblHola.AutoSize = true;
            this.lblHola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHola.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblHola.Location = new System.Drawing.Point(299, 15);
            this.lblHola.Name = "lblHola";
            this.lblHola.Size = new System.Drawing.Size(57, 16);
            this.lblHola.TabIndex = 1;
            this.lblHola.Text = "Saludo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label11.Location = new System.Drawing.Point(149, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(395, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Aqui te mostramos un Resumen del Prestamo a Solicitar";
            // 
            // lblRSeguro
            // 
            this.lblRSeguro.AutoSize = true;
            this.lblRSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRSeguro.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblRSeguro.Location = new System.Drawing.Point(15, 255);
            this.lblRSeguro.Name = "lblRSeguro";
            this.lblRSeguro.Size = new System.Drawing.Size(58, 16);
            this.lblRSeguro.TabIndex = 13;
            this.lblRSeguro.Text = "Seguro";
            // 
            // lblRMora
            // 
            this.lblRMora.AutoSize = true;
            this.lblRMora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMora.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblRMora.Location = new System.Drawing.Point(15, 217);
            this.lblRMora.Name = "lblRMora";
            this.lblRMora.Size = new System.Drawing.Size(43, 16);
            this.lblRMora.TabIndex = 12;
            this.lblRMora.Text = "Mora";
            // 
            // lblRComision
            // 
            this.lblRComision.AutoSize = true;
            this.lblRComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRComision.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblRComision.Location = new System.Drawing.Point(15, 181);
            this.lblRComision.Name = "lblRComision";
            this.lblRComision.Size = new System.Drawing.Size(72, 16);
            this.lblRComision.TabIndex = 11;
            this.lblRComision.Text = "Comision";
            // 
            // lblRTasaInteres
            // 
            this.lblRTasaInteres.AutoSize = true;
            this.lblRTasaInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRTasaInteres.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblRTasaInteres.Location = new System.Drawing.Point(15, 149);
            this.lblRTasaInteres.Name = "lblRTasaInteres";
            this.lblRTasaInteres.Size = new System.Drawing.Size(44, 16);
            this.lblRTasaInteres.TabIndex = 10;
            this.lblRTasaInteres.Text = "Tasa";
            // 
            // lblRPrestamo
            // 
            this.lblRPrestamo.AutoSize = true;
            this.lblRPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPrestamo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblRPrestamo.Location = new System.Drawing.Point(189, 72);
            this.lblRPrestamo.Name = "lblRPrestamo";
            this.lblRPrestamo.Size = new System.Drawing.Size(277, 16);
            this.lblRPrestamo.TabIndex = 9;
            this.lblRPrestamo.Text = "Tu Prestamo por 0000 durante 9 meses";
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuota.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCuota.Location = new System.Drawing.Point(213, 109);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(230, 16);
            this.lblCuota.TabIndex = 15;
            this.lblCuota.Text = "Con una cuota mensual de 0000 ";
            // 
            // txtCedula
            // 
            this.txtCedula.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCedula.Location = new System.Drawing.Point(443, 18);
            this.txtCedula.Mask = "000-000000-0AAAA";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(121, 22);
            this.txtCedula.TabIndex = 49;
            this.txtCedula.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 383);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEACF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabDatosPersonales.ResumeLayout(false);
            this.TabDatosPersonales.PerformLayout();
            this.TabInfoPersonal.ResumeLayout(false);
            this.TabInfoPersonal.PerformLayout();
            this.TabInfoLaboral.ResumeLayout(false);
            this.TabInfoLaboral.PerformLayout();
            this.TabResultado.ResumeLayout(false);
            this.TabResultado.PerformLayout();
            this.TabRango.ResumeLayout(false);
            this.TabRango.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.TabResumen.ResumeLayout(false);
            this.TabResumen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabDatosPersonales;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage TabInfoLaboral;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage TabInfoPersonal;
        private System.Windows.Forms.TextBox txtHijos;
        private System.Windows.Forms.Label lblcasa;
        private System.Windows.Forms.ComboBox cbCasa;
        private System.Windows.Forms.Label lblvehiculo;
        private System.Windows.Forms.ComboBox cbVehiculo;
        private System.Windows.Forms.TabPage TabResultado;
        private System.Windows.Forms.Label lblPrestamoMax;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtMontoPrestamo;
        private System.Windows.Forms.TextBox txtMesesLaborando;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtFechaNac;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox cbCasado;
        private System.Windows.Forms.CheckBox cbHijos;
        private System.Windows.Forms.CheckBox cbINSS;
        private System.Windows.Forms.Label lblcuantosH;
        private System.Windows.Forms.TabPage TabRango;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.Label lblMora;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblTasa;
        private System.Windows.Forms.Label lblMPrestamo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meses;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComisionC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TasaInteresC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoraC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeguroC;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.TabPage TabResumen;
        private System.Windows.Forms.Label lblHola;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblRSeguro;
        private System.Windows.Forms.Label lblRMora;
        private System.Windows.Forms.Label lblRComision;
        private System.Windows.Forms.Label lblRTasaInteres;
        private System.Windows.Forms.Label lblRPrestamo;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.MaskedTextBox txtCedula;
    }
}


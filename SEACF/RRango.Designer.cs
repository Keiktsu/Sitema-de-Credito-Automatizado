namespace SEACF
{
    partial class RRango
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblCantHijos = new System.Windows.Forms.Label();
            this.lblRango = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRMin = new System.Windows.Forms.Label();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.lblRMax = new System.Windows.Forms.Label();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(121, 286);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(226, 38);
            this.btnCerrar.TabIndex = 41;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(122, 242);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(226, 38);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(59, 164);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(81, 17);
            this.lblValor.TabIndex = 36;
            this.lblValor.Text = "Tasa Interes:";
            // 
            // lblCantHijos
            // 
            this.lblCantHijos.AutoSize = true;
            this.lblCantHijos.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantHijos.Location = new System.Drawing.Point(77, 55);
            this.lblCantHijos.Name = "lblCantHijos";
            this.lblCantHijos.Size = new System.Drawing.Size(78, 17);
            this.lblCantHijos.TabIndex = 35;
            this.lblCantHijos.Text = "Rango Max:";
            // 
            // lblRango
            // 
            this.lblRango.AutoSize = true;
            this.lblRango.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRango.Location = new System.Drawing.Point(76, 20);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(76, 16);
            this.lblRango.TabIndex = 34;
            this.lblRango.Text = "Rango Min:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Rangos de Prestamos";
            // 
            // lblRMin
            // 
            this.lblRMin.AutoSize = true;
            this.lblRMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMin.ForeColor = System.Drawing.Color.DimGray;
            this.lblRMin.Location = new System.Drawing.Point(158, 20);
            this.lblRMin.Name = "lblRMin";
            this.lblRMin.Size = new System.Drawing.Size(76, 16);
            this.lblRMin.TabIndex = 42;
            this.lblRMin.Text = "Rango Min:";
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.Location = new System.Drawing.Point(146, 164);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(69, 20);
            this.txtTasaInteres.TabIndex = 39;
            this.txtTasaInteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTasaInteres_KeyPress);
            // 
            // lblRMax
            // 
            this.lblRMax.AutoSize = true;
            this.lblRMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMax.ForeColor = System.Drawing.Color.DimGray;
            this.lblRMax.Location = new System.Drawing.Point(159, 56);
            this.lblRMax.Name = "lblRMax";
            this.lblRMax.Size = new System.Drawing.Size(76, 16);
            this.lblRMax.TabIndex = 43;
            this.lblRMax.Text = "Rango Min:";
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(146, 199);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(69, 20);
            this.txtComision.TabIndex = 45;
            this.txtComision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComision_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Comision:";
            // 
            // txtMora
            // 
            this.txtMora.Location = new System.Drawing.Point(310, 164);
            this.txtMora.Name = "txtMora";
            this.txtMora.Size = new System.Drawing.Size(83, 20);
            this.txtMora.TabIndex = 47;
            this.txtMora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMora_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Mora:";
            // 
            // txtSeguro
            // 
            this.txtSeguro.Location = new System.Drawing.Point(310, 199);
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.Size = new System.Drawing.Size(83, 20);
            this.txtSeguro.TabIndex = 49;
            this.txtSeguro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeguro_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Seguro:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRango);
            this.panel1.Controls.Add(this.lblCantHijos);
            this.panel1.Controls.Add(this.lblRMin);
            this.panel1.Controls.Add(this.lblRMax);
            this.panel1.Location = new System.Drawing.Point(66, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 94);
            this.panel1.TabIndex = 50;
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // RRango
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 356);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSeguro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtComision);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTasaInteres);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RRango";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RRango";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblCantHijos;
        private System.Windows.Forms.Label lblRango;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRMin;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.Label lblRMax;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSeguro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider Error;
    }
}
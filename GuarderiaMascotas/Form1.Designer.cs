namespace GuarderiaMascotas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDuenio = new System.Windows.Forms.TabPage();
            this.btnModificarDuenio = new System.Windows.Forms.Button();
            this.btnCargarDuenio = new System.Windows.Forms.Button();
            this.txtDniDuenio = new System.Windows.Forms.TextBox();
            this.txtTelDuenio = new System.Windows.Forms.TextBox();
            this.txtApellidoDuenio = new System.Windows.Forms.TextBox();
            this.txtNombreDuenio = new System.Windows.Forms.TextBox();
            this.lblDniDuenio = new System.Windows.Forms.Label();
            this.lblTelDuenio = new System.Windows.Forms.Label();
            this.lblApellidoDuenio = new System.Windows.Forms.Label();
            this.lblNombreDuenio = new System.Windows.Forms.Label();
            this.tabMascota = new System.Windows.Forms.TabPage();
            this.btnModificarMascota = new System.Windows.Forms.Button();
            this.cbDueniosMascota = new System.Windows.Forms.ComboBox();
            this.lblDuenioMascota = new System.Windows.Forms.Label();
            this.cbRetirado = new System.Windows.Forms.CheckBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnCargaMascota = new System.Windows.Forms.Button();
            this.txtObsMascota = new System.Windows.Forms.TextBox();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.lblFechaNacMascota = new System.Windows.Forms.Label();
            this.lblObsMascota = new System.Windows.Forms.Label();
            this.lblTipoMascota = new System.Windows.Forms.Label();
            this.lblNombreMascota = new System.Windows.Forms.Label();
            this.dgvDuenios = new System.Windows.Forms.DataGridView();
            this.dgvMascotas = new System.Windows.Forms.DataGridView();
            this.btnCancelarMascota = new System.Windows.Forms.Button();
            this.btnCancelarDuenio = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabDuenio.SuspendLayout();
            this.tabMascota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuenios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDuenio);
            this.tabControl1.Controls.Add(this.tabMascota);
            this.tabControl1.Location = new System.Drawing.Point(281, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 264);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDuenio
            // 
            this.tabDuenio.Controls.Add(this.btnCancelarDuenio);
            this.tabDuenio.Controls.Add(this.btnModificarDuenio);
            this.tabDuenio.Controls.Add(this.btnCargarDuenio);
            this.tabDuenio.Controls.Add(this.txtDniDuenio);
            this.tabDuenio.Controls.Add(this.txtTelDuenio);
            this.tabDuenio.Controls.Add(this.txtApellidoDuenio);
            this.tabDuenio.Controls.Add(this.txtNombreDuenio);
            this.tabDuenio.Controls.Add(this.lblDniDuenio);
            this.tabDuenio.Controls.Add(this.lblTelDuenio);
            this.tabDuenio.Controls.Add(this.lblApellidoDuenio);
            this.tabDuenio.Controls.Add(this.lblNombreDuenio);
            this.tabDuenio.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDuenio.Location = new System.Drawing.Point(4, 27);
            this.tabDuenio.Margin = new System.Windows.Forms.Padding(4);
            this.tabDuenio.Name = "tabDuenio";
            this.tabDuenio.Padding = new System.Windows.Forms.Padding(4);
            this.tabDuenio.Size = new System.Drawing.Size(531, 233);
            this.tabDuenio.TabIndex = 0;
            this.tabDuenio.Text = "Dueño";
            this.tabDuenio.UseVisualStyleBackColor = true;
            // 
            // btnModificarDuenio
            // 
            this.btnModificarDuenio.Location = new System.Drawing.Point(419, 200);
            this.btnModificarDuenio.Name = "btnModificarDuenio";
            this.btnModificarDuenio.Size = new System.Drawing.Size(84, 26);
            this.btnModificarDuenio.TabIndex = 24;
            this.btnModificarDuenio.Text = "Modificar";
            this.btnModificarDuenio.UseVisualStyleBackColor = true;
            this.btnModificarDuenio.Visible = false;
            this.btnModificarDuenio.Click += new System.EventHandler(this.btnModificarDuenio_Click);
            // 
            // btnCargarDuenio
            // 
            this.btnCargarDuenio.Location = new System.Drawing.Point(419, 200);
            this.btnCargarDuenio.Name = "btnCargarDuenio";
            this.btnCargarDuenio.Size = new System.Drawing.Size(84, 26);
            this.btnCargarDuenio.TabIndex = 8;
            this.btnCargarDuenio.Text = "Cargar";
            this.btnCargarDuenio.UseVisualStyleBackColor = true;
            this.btnCargarDuenio.Click += new System.EventHandler(this.btnCargarDuenio_Click);
            // 
            // txtDniDuenio
            // 
            this.txtDniDuenio.Location = new System.Drawing.Point(144, 158);
            this.txtDniDuenio.Margin = new System.Windows.Forms.Padding(4);
            this.txtDniDuenio.Name = "txtDniDuenio";
            this.txtDniDuenio.Size = new System.Drawing.Size(132, 26);
            this.txtDniDuenio.TabIndex = 7;
            this.txtDniDuenio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniDuenio_KeyPress);
            // 
            // txtTelDuenio
            // 
            this.txtTelDuenio.Location = new System.Drawing.Point(144, 110);
            this.txtTelDuenio.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelDuenio.Name = "txtTelDuenio";
            this.txtTelDuenio.Size = new System.Drawing.Size(132, 26);
            this.txtTelDuenio.TabIndex = 6;
            this.txtTelDuenio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelDuenio_KeyPress);
            // 
            // txtApellidoDuenio
            // 
            this.txtApellidoDuenio.Location = new System.Drawing.Point(144, 63);
            this.txtApellidoDuenio.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoDuenio.Name = "txtApellidoDuenio";
            this.txtApellidoDuenio.Size = new System.Drawing.Size(132, 26);
            this.txtApellidoDuenio.TabIndex = 5;
            this.txtApellidoDuenio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoDuenio_KeyPress);
            // 
            // txtNombreDuenio
            // 
            this.txtNombreDuenio.Location = new System.Drawing.Point(144, 18);
            this.txtNombreDuenio.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreDuenio.Name = "txtNombreDuenio";
            this.txtNombreDuenio.Size = new System.Drawing.Size(132, 26);
            this.txtNombreDuenio.TabIndex = 4;
            this.txtNombreDuenio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreDuenio_KeyPress);
            // 
            // lblDniDuenio
            // 
            this.lblDniDuenio.AutoSize = true;
            this.lblDniDuenio.Location = new System.Drawing.Point(24, 161);
            this.lblDniDuenio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDniDuenio.Name = "lblDniDuenio";
            this.lblDniDuenio.Size = new System.Drawing.Size(32, 18);
            this.lblDniDuenio.TabIndex = 3;
            this.lblDniDuenio.Text = "DNI";
            // 
            // lblTelDuenio
            // 
            this.lblTelDuenio.AutoSize = true;
            this.lblTelDuenio.Location = new System.Drawing.Point(24, 113);
            this.lblTelDuenio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelDuenio.Name = "lblTelDuenio";
            this.lblTelDuenio.Size = new System.Drawing.Size(61, 18);
            this.lblTelDuenio.TabIndex = 2;
            this.lblTelDuenio.Text = "Teléfono";
            // 
            // lblApellidoDuenio
            // 
            this.lblApellidoDuenio.AutoSize = true;
            this.lblApellidoDuenio.Location = new System.Drawing.Point(24, 66);
            this.lblApellidoDuenio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoDuenio.Name = "lblApellidoDuenio";
            this.lblApellidoDuenio.Size = new System.Drawing.Size(58, 18);
            this.lblApellidoDuenio.TabIndex = 1;
            this.lblApellidoDuenio.Text = "Apellido";
            // 
            // lblNombreDuenio
            // 
            this.lblNombreDuenio.AutoSize = true;
            this.lblNombreDuenio.Location = new System.Drawing.Point(22, 21);
            this.lblNombreDuenio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreDuenio.Name = "lblNombreDuenio";
            this.lblNombreDuenio.Size = new System.Drawing.Size(58, 18);
            this.lblNombreDuenio.TabIndex = 0;
            this.lblNombreDuenio.Text = "Nombre";
            // 
            // tabMascota
            // 
            this.tabMascota.Controls.Add(this.btnCancelarMascota);
            this.tabMascota.Controls.Add(this.btnModificarMascota);
            this.tabMascota.Controls.Add(this.cbDueniosMascota);
            this.tabMascota.Controls.Add(this.lblDuenioMascota);
            this.tabMascota.Controls.Add(this.cbRetirado);
            this.tabMascota.Controls.Add(this.dtpFechaNac);
            this.tabMascota.Controls.Add(this.cmbTipo);
            this.tabMascota.Controls.Add(this.btnCargaMascota);
            this.tabMascota.Controls.Add(this.txtObsMascota);
            this.tabMascota.Controls.Add(this.txtNombreMascota);
            this.tabMascota.Controls.Add(this.lblFechaNacMascota);
            this.tabMascota.Controls.Add(this.lblObsMascota);
            this.tabMascota.Controls.Add(this.lblTipoMascota);
            this.tabMascota.Controls.Add(this.lblNombreMascota);
            this.tabMascota.Location = new System.Drawing.Point(4, 27);
            this.tabMascota.Margin = new System.Windows.Forms.Padding(4);
            this.tabMascota.Name = "tabMascota";
            this.tabMascota.Padding = new System.Windows.Forms.Padding(4);
            this.tabMascota.Size = new System.Drawing.Size(531, 233);
            this.tabMascota.TabIndex = 1;
            this.tabMascota.Text = "Mascota";
            this.tabMascota.UseVisualStyleBackColor = true;
            // 
            // btnModificarMascota
            // 
            this.btnModificarMascota.Location = new System.Drawing.Point(419, 200);
            this.btnModificarMascota.Name = "btnModificarMascota";
            this.btnModificarMascota.Size = new System.Drawing.Size(84, 26);
            this.btnModificarMascota.TabIndex = 25;
            this.btnModificarMascota.Text = "Modificar";
            this.btnModificarMascota.UseVisualStyleBackColor = true;
            this.btnModificarMascota.Visible = false;
            this.btnModificarMascota.Click += new System.EventHandler(this.btnModificarMascota_Click);
            // 
            // cbDueniosMascota
            // 
            this.cbDueniosMascota.FormattingEnabled = true;
            this.cbDueniosMascota.Location = new System.Drawing.Point(107, 113);
            this.cbDueniosMascota.Name = "cbDueniosMascota";
            this.cbDueniosMascota.Size = new System.Drawing.Size(132, 26);
            this.cbDueniosMascota.TabIndex = 23;
            this.cbDueniosMascota.Text = "Dueños";
            // 
            // lblDuenioMascota
            // 
            this.lblDuenioMascota.AutoSize = true;
            this.lblDuenioMascota.Location = new System.Drawing.Point(8, 116);
            this.lblDuenioMascota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuenioMascota.Name = "lblDuenioMascota";
            this.lblDuenioMascota.Size = new System.Drawing.Size(49, 18);
            this.lblDuenioMascota.TabIndex = 22;
            this.lblDuenioMascota.Text = "Dueño";
            // 
            // cbRetirado
            // 
            this.cbRetirado.AutoSize = true;
            this.cbRetirado.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRetirado.Location = new System.Drawing.Point(301, 115);
            this.cbRetirado.Name = "cbRetirado";
            this.cbRetirado.Size = new System.Drawing.Size(79, 22);
            this.cbRetirado.TabIndex = 21;
            this.cbRetirado.Text = "Retirado";
            this.cbRetirado.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNac.Location = new System.Drawing.Point(287, 70);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(237, 23);
            this.dtpFechaNac.TabIndex = 20;
            this.dtpFechaNac.Value = new System.DateTime(2022, 10, 30, 0, 0, 0, 0);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Perro",
            "Gato",
            "Roedor",
            "Ave",
            "Reptil",
            "Insecto"});
            this.cmbTipo.Location = new System.Drawing.Point(107, 67);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(132, 26);
            this.cmbTipo.TabIndex = 19;
            this.cmbTipo.Text = "Tipo";
            // 
            // btnCargaMascota
            // 
            this.btnCargaMascota.Location = new System.Drawing.Point(419, 200);
            this.btnCargaMascota.Name = "btnCargaMascota";
            this.btnCargaMascota.Size = new System.Drawing.Size(84, 26);
            this.btnCargaMascota.TabIndex = 17;
            this.btnCargaMascota.Text = "Cargar";
            this.btnCargaMascota.UseVisualStyleBackColor = true;
            this.btnCargaMascota.Click += new System.EventHandler(this.btnCargaMascota_Click);
            // 
            // txtObsMascota
            // 
            this.txtObsMascota.Location = new System.Drawing.Point(107, 161);
            this.txtObsMascota.Margin = new System.Windows.Forms.Padding(4);
            this.txtObsMascota.Name = "txtObsMascota";
            this.txtObsMascota.Size = new System.Drawing.Size(284, 26);
            this.txtObsMascota.TabIndex = 14;
            this.txtObsMascota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObsMascota_KeyPress);
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Location = new System.Drawing.Point(107, 21);
            this.txtNombreMascota.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(132, 26);
            this.txtNombreMascota.TabIndex = 13;
            this.txtNombreMascota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreMascota_KeyPress);
            // 
            // lblFechaNacMascota
            // 
            this.lblFechaNacMascota.AutoSize = true;
            this.lblFechaNacMascota.Location = new System.Drawing.Point(284, 29);
            this.lblFechaNacMascota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacMascota.Name = "lblFechaNacMascota";
            this.lblFechaNacMascota.Size = new System.Drawing.Size(134, 18);
            this.lblFechaNacMascota.TabIndex = 12;
            this.lblFechaNacMascota.Text = "Fecha de nacimiento";
            // 
            // lblObsMascota
            // 
            this.lblObsMascota.AutoSize = true;
            this.lblObsMascota.Location = new System.Drawing.Point(8, 161);
            this.lblObsMascota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObsMascota.Name = "lblObsMascota";
            this.lblObsMascota.Size = new System.Drawing.Size(85, 18);
            this.lblObsMascota.TabIndex = 11;
            this.lblObsMascota.Text = "Observación";
            // 
            // lblTipoMascota
            // 
            this.lblTipoMascota.AutoSize = true;
            this.lblTipoMascota.Location = new System.Drawing.Point(8, 70);
            this.lblTipoMascota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoMascota.Name = "lblTipoMascota";
            this.lblTipoMascota.Size = new System.Drawing.Size(35, 18);
            this.lblTipoMascota.TabIndex = 10;
            this.lblTipoMascota.Text = "Tipo";
            // 
            // lblNombreMascota
            // 
            this.lblNombreMascota.AutoSize = true;
            this.lblNombreMascota.Location = new System.Drawing.Point(8, 24);
            this.lblNombreMascota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMascota.Name = "lblNombreMascota";
            this.lblNombreMascota.Size = new System.Drawing.Size(58, 18);
            this.lblNombreMascota.TabIndex = 9;
            this.lblNombreMascota.Text = "Nombre";
            // 
            // dgvDuenios
            // 
            this.dgvDuenios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuenios.Location = new System.Drawing.Point(281, 300);
            this.dgvDuenios.Name = "dgvDuenios";
            this.dgvDuenios.Size = new System.Drawing.Size(539, 251);
            this.dgvDuenios.TabIndex = 2;
            this.dgvDuenios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDuenios_CellClick_1);
            // 
            // dgvMascotas
            // 
            this.dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotas.Location = new System.Drawing.Point(186, 569);
            this.dgvMascotas.Name = "dgvMascotas";
            this.dgvMascotas.Size = new System.Drawing.Size(744, 251);
            this.dgvMascotas.TabIndex = 3;
            this.dgvMascotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMascotas_CellClick);
            // 
            // btnCancelarMascota
            // 
            this.btnCancelarMascota.Location = new System.Drawing.Point(334, 200);
            this.btnCancelarMascota.Name = "btnCancelarMascota";
            this.btnCancelarMascota.Size = new System.Drawing.Size(79, 26);
            this.btnCancelarMascota.TabIndex = 26;
            this.btnCancelarMascota.Text = "Cancelar";
            this.btnCancelarMascota.UseVisualStyleBackColor = true;
            this.btnCancelarMascota.Visible = false;
            this.btnCancelarMascota.Click += new System.EventHandler(this.btnCancelarMascota_Click);
            // 
            // btnCancelarDuenio
            // 
            this.btnCancelarDuenio.Location = new System.Drawing.Point(334, 200);
            this.btnCancelarDuenio.Name = "btnCancelarDuenio";
            this.btnCancelarDuenio.Size = new System.Drawing.Size(79, 26);
            this.btnCancelarDuenio.TabIndex = 27;
            this.btnCancelarDuenio.Text = "Cancelar";
            this.btnCancelarDuenio.UseVisualStyleBackColor = true;
            this.btnCancelarDuenio.Visible = false;
            this.btnCancelarDuenio.Click += new System.EventHandler(this.btnCancelarDuenio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 832);
            this.Controls.Add(this.dgvMascotas);
            this.Controls.Add(this.dgvDuenios);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabDuenio.ResumeLayout(false);
            this.tabDuenio.PerformLayout();
            this.tabMascota.ResumeLayout(false);
            this.tabMascota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuenios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDuenio;
        private System.Windows.Forms.Button btnCargarDuenio;
        private System.Windows.Forms.TextBox txtDniDuenio;
        private System.Windows.Forms.TextBox txtTelDuenio;
        private System.Windows.Forms.TextBox txtApellidoDuenio;
        private System.Windows.Forms.TextBox txtNombreDuenio;
        private System.Windows.Forms.Label lblDniDuenio;
        private System.Windows.Forms.Label lblTelDuenio;
        private System.Windows.Forms.Label lblApellidoDuenio;
        private System.Windows.Forms.Label lblNombreDuenio;
        private System.Windows.Forms.TabPage tabMascota;
        private System.Windows.Forms.CheckBox cbRetirado;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnCargaMascota;
        private System.Windows.Forms.TextBox txtObsMascota;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.Label lblFechaNacMascota;
        private System.Windows.Forms.Label lblObsMascota;
        private System.Windows.Forms.Label lblTipoMascota;
        private System.Windows.Forms.Label lblNombreMascota;
        private System.Windows.Forms.ComboBox cbDueniosMascota;
        private System.Windows.Forms.Label lblDuenioMascota;
        private System.Windows.Forms.DataGridView dgvDuenios;
        private System.Windows.Forms.DataGridView dgvMascotas;
        private System.Windows.Forms.Button btnModificarDuenio;
        private System.Windows.Forms.Button btnModificarMascota;
        private System.Windows.Forms.Button btnCancelarDuenio;
        private System.Windows.Forms.Button btnCancelarMascota;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CapaNegocios;

namespace GuarderiaMascotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvDuenios.ColumnCount = 5;
            dgvDuenios.Columns[0].HeaderText = "Id";
            dgvDuenios.Columns[1].HeaderText = "DNI";
            dgvDuenios.Columns[2].HeaderText = "Nombre";
            dgvDuenios.Columns[3].HeaderText = "Apellido";
            dgvDuenios.Columns[4].HeaderText = "Telefono";

            dgvMascotas.ColumnCount = 7;
            dgvMascotas.Columns[0].HeaderText = "Id";
            dgvMascotas.Columns[1].HeaderText = "Nombre";
            dgvMascotas.Columns[2].HeaderText = "Tipo";
            dgvMascotas.Columns[3].HeaderText = "Observacion";
            dgvMascotas.Columns[4].HeaderText = "Fecha de nacimiento";
            dgvMascotas.Columns[5].HeaderText = "Retirado";
            dgvMascotas.Columns[6].HeaderText = "Dueño";

            cmbTipo.SelectedIndex = 1;
            LlenarDGVDuenio();
            LlenarDGVMascota();
            LlenarCombos();
        }
        #region LlenadoDGVs
        private void LlenarDGVDuenio()
        {
            dgvDuenios.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegDuenio.listadoDuenios("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvDuenios.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2], dr[3],dr[4].ToString());
                }
            }
        }
        private void LlenarDGVMascota()
        {
            dgvMascotas.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegMascota.listadoMascotas("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvMascotas.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4].ToString(), dr[5], dr[6].ToString());
                }
            }
        }
        #endregion

        #region DeclaracionVariables
        public Duenio objEntDuenio = new Duenio();
        public Mascota objEntMascota = new Mascota();

        public NegDuenio objNegDuenio = new NegDuenio();
        public NegMascota objNegMascota = new NegMascota();
        #endregion

        #region MetodoLlenadoCombo
        private void LlenarCombos()
        { 
            cbDueniosMascota.DataSource = objNegDuenio.ObtenerDueniosCB();
            cbDueniosMascota.DisplayMember = "nombreApellidoProp";
            cbDueniosMascota.ValueMember = "idProp";
        }
        #endregion

        #region MetodosTxtAObj
        private void TxtBox_a_ObjDuenio()
        {
            objEntDuenio.dniProp = int.Parse(txtDniDuenio.Text);
            objEntDuenio.nombreProp = txtNombreDuenio.Text;
            objEntDuenio.apellidoProp = txtApellidoDuenio.Text;
            objEntDuenio.telefonoProp = long.Parse(txtTelDuenio.Text);

        }
        private void TxtBox_a_ObjMascota()
        {
            objEntMascota.nombreProp = txtNombreMascota.Text;
            objEntMascota.tipoProp = cmbTipo.SelectedItem.ToString();//--
            objEntMascota.observacionProp = txtObsMascota.Text;
            objEntMascota.fechaNacimientoProp = dtpFechaNac.Value;
            objEntMascota.duenioIdProp = int.Parse(cbDueniosMascota.SelectedValue.ToString());
            bool retiradoABD = cbRetirado.Checked;
            objEntMascota.RetiradoM(retiradoABD);
        }
        #endregion

        #region MetodosValidacionesCampos
        public bool ValidacionCamposDuenio()
        {
            if(txtNombreDuenio.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtNombreDuenio.Text.Length > 50 || txtNombreDuenio.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten nombres entre 2 y 50 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            //Apellido
            if (txtApellidoDuenio.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un apellido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtApellidoDuenio.Text.Length > 50 || txtApellidoDuenio.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten apellidos entre 2 y 50 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            //Telefono
            if (txtTelDuenio.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un numero de telefono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtTelDuenio.Text.Length > 7 || txtTelDuenio.Text.Length < 7)
            {
                MessageBox.Show("Solo se permiten numeros de 7 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            //DNI
            if (txtDniDuenio.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un DNI", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtDniDuenio.Text.Length > 8 || txtDniDuenio.Text.Length <= 7)
            {
                MessageBox.Show("Solo se permiten DNI entre 7 y 8 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        public bool ValidacionCamposMascota()
        {
            if (txtNombreMascota.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un nombre de mascota", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtNombreMascota.Text.Length > 30 || txtNombreMascota.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten nombres menores a 30 caracteres y mayores a 2", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtObsMascota.Text.Length > 200)
            {
                MessageBox.Show("La observación no puede superar los 200 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        #endregion

        #region MetodosCargar
        private void btnCargarDuenio_Click(object sender, EventArgs e)
        {
            bool validado = ValidacionCamposDuenio();
            int nGrabados = -1;
            if(validado == true)
            {           
                TxtBox_a_ObjDuenio();
                nGrabados = objNegDuenio.abmDuenio("Alta", objEntDuenio); 
                if (nGrabados == -1)
                {
                    MessageBox.Show("No se logró agregar el dueño al sistema");
                }
                else
                {
                    MessageBox.Show("Se logró agregar al dueño con éxito");
                    LlenarDGVDuenio();
                    LimpiarDuenio();
                    LlenarCombos();
                    tabControl1.SelectTab(tabMascota);
                }
            }

        }
        private void btnCargaMascota_Click(object sender, EventArgs e)
        {
            bool validado = ValidacionCamposMascota();
            int nGrabados = -1;
            if (validado == true)
            {
                TxtBox_a_ObjMascota();
                nGrabados = objNegMascota.abmMascota("Alta", objEntMascota);
                if (nGrabados == -1)
                {
                    MessageBox.Show("No se logró agregar a la mascota al sistema");
                }
                else
                {
                    MessageBox.Show("Se logró agregar a la mascota con éxito");
                    LlenarDGVMascota();
                    LimpiarMascota();
                }
            }

        }
        #endregion

        #region MetodosLimpiar
        private void LimpiarDuenio()
        {
            txtDniDuenio.Text = string.Empty;
            txtApellidoDuenio.Text = string.Empty;
            txtNombreDuenio.Text = string.Empty;
            txtTelDuenio.Text = string.Empty;
        }
        private void LimpiarMascota()
        {
            txtNombreMascota.Text = string.Empty;
            txtObsMascota.Text = string.Empty;
            dtpFechaNac.Value = DateTime.Today;
            cbRetirado.Checked = false;
            cmbTipo.SelectedIndex = 1;
            cbDueniosMascota.SelectedIndex = 0;
        }
        #endregion

        #region MetodosDsATxt
        private void Ds_a_TxtBoxMascota(DataSet ds)
        {
            bool retirado;
            if (ds.Tables[0].Rows[0]["retirado"].ToString() == "si")
            {
                retirado = true;
            }
            else
            {
                retirado = false;
            }

            txtNombreMascota.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
            cmbTipo.SelectedItem = ds.Tables[0].Rows[0]["tipo"].ToString();
            txtObsMascota.Text = ds.Tables[0].Rows[0]["observacion"].ToString();
            dtpFechaNac.Value = System.Convert.ToDateTime(ds.Tables[0].Rows[0]["fechaNacimiento"]);
            cbRetirado.Checked = retirado; 
            cbDueniosMascota.SelectedValue = System.Convert.ToInt32(ds.Tables[0].Rows[0]["duenioId"].ToString());
        }
        private void Ds_a_TxtBoxDuenio(DataSet ds)
        {
            txtDniDuenio.Text = ds.Tables[0].Rows[0]["DNI"].ToString();
            txtNombreDuenio.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txtApellidoDuenio.Text = ds.Tables[0].Rows[0]["Apellido"].ToString();
            txtTelDuenio.Text = ds.Tables[0].Rows[0]["Telefono"].ToString();
        }
        #endregion

        #region MetodosModificar
        private void btnModificarDuenio_Click(object sender, EventArgs e)
        {
            bool validado = ValidacionCamposDuenio();
            int nResultado = -1;
            if (validado == true)
            {
                TxtBox_a_ObjDuenio();
                nResultado = objNegDuenio.abmDuenio("Modificar", objEntDuenio); 
                if (nResultado != -1)
                {
                    MessageBox.Show("El dueño fue modificado con éxito");
                    LimpiarDuenio();
                    LlenarDGVDuenio();
                    btnModificarDuenio.Visible = false;
                    btnCargarDuenio.Visible = true;
                    btnCancelarDuenio.Visible = false;
                }
                else
                {
                    MessageBox.Show("Se produjo un error al intentar modificar el dueño");
                }
            }
        }

        private void btnModificarMascota_Click(object sender, EventArgs e)
        {
            bool validado = ValidacionCamposMascota();
            int nResultado = -1;
            if (validado == true)
            {
                TxtBox_a_ObjMascota();
                nResultado = objNegMascota.abmMascota("Modificar", objEntMascota);
                if (nResultado != -1)
                {
                    MessageBox.Show("La mascota fue modificada con éxito");
                    LimpiarMascota();
                    LlenarDGVMascota();
                    btnModificarMascota.Visible = false;
                    btnCargaMascota.Visible = true;
                    btnCancelarMascota.Visible = false;
                }
                else
                {
                    MessageBox.Show("Se produjo un error al intentar modificar la mascota");
                }
            }

        }
        #endregion

        #region MetodosCellClick
        private void dgvDuenios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(tabDuenio);
            DataSet ds = new DataSet();
            objEntDuenio.idProp = Convert.ToInt32(dgvDuenios.CurrentRow.Cells[0].Value);
            ds = objNegDuenio.listadoDuenios(objEntDuenio.idProp.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_TxtBoxDuenio(ds);
                btnCargarDuenio.Visible = false;
                btnModificarDuenio.Visible = true;
                btnCancelarDuenio.Visible = true;
            }
        }

        private void dgvMascotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(tabMascota);
            DataSet ds = new DataSet();
            objEntMascota.idProp = Convert.ToInt32(dgvMascotas.CurrentRow.Cells[0].Value);
            ds = objNegMascota.listadoMascotas(objEntMascota.idProp.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_TxtBoxMascota(ds);
                btnCargaMascota.Visible = false;
                btnModificarMascota.Visible = true;
                btnCancelarMascota.Visible = true;
            }
        }
        #endregion

        #region Validaciones
        private void txtNombreDuenio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void txtApellidoDuenio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelDuenio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDniDuenio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombreMascota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtObsMascota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        #endregion

        #region MetodosBtnCancelar
        private void btnCancelarDuenio_Click(object sender, EventArgs e)
        {
            LimpiarDuenio();
            btnCargarDuenio.Visible = true;
            btnModificarDuenio.Visible = false;
            btnCancelarDuenio.Visible = false;
        }

        private void btnCancelarMascota_Click(object sender, EventArgs e)
        {
            LimpiarMascota();
            btnCargaMascota.Visible = true;
            btnModificarMascota.Visible = false;
            btnCancelarMascota.Visible = false;
        }
        #endregion
    }
}

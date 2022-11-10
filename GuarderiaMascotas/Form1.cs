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

            LlenarDGVDuenio();
            LlenarDGVMascota();
        }

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

        public Duenio objEntDuenio = new Duenio();
        public Mascota objEntMascota = new Mascota();

        public NegDuenio objNegDuenio = new NegDuenio();
        public NegMascota objNegMascota = new NegMascota();

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
            objEntMascota.tipoProp = cmbTipo.SelectedItem.ToString();
            objEntMascota.observacionProp = txtObsMascota.Text;
            objEntMascota.fechaNacimientoProp = dtpFechaNac.Value;
            objEntMascota.duenioIdProp = int.Parse(cbDueniosMascota.SelectedItem.ToString());
            objEntMascota.retiradoProp = cbRetirado.Checked;
        }

        private void btnCargarDuenio_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            TxtBox_a_ObjDuenio();
            nGrabados = objNegDuenio.abmDuenio("Alta", objEntDuenio); 
            if (nGrabados == -1)
                lblMensaje.Text = "No se logró agregar el dueño al sistema";
            else
            {
                lblMensaje.Text = "Se logró grabar con éxito el dueño";
                LlenarDGVDuenio();
                LimpiarDuenio();
            }
        }


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
            dtpFechaNac.Value = default;
            cbRetirado.Checked = false;
            cbDueniosMascota.SelectedItem = default;
        }

        private void btnCargaMascota_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            TxtBox_a_ObjMascota();
            nGrabados = objNegMascota.abmMascota("Alta", objEntMascota);
            if (nGrabados == -1)
                lblMensaje.Text = "No se logró agregar la mascota al sistema";
            else
            {
                lblMensaje.Text = "Se logró grabar con éxito la mascota";
                LlenarDGVMascota();
                LimpiarMascota();
            }
        }

        private void dgvDuenios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();
            objEntDuenio.idProp = Convert.ToInt32(dgvDuenios.CurrentRow.Cells[0].Value);
            ds = objNegDuenio.listadoDuenios(objEntDuenio.idProp.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_TxtBoxDuenio(ds);
                btnCargarDuenio.Visible = false;
                btnModificarDuenio.Visible = true;
                lblMensaje.Text = string.Empty;
            }
        }
        //private void dgvMascotas_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    DataSet ds = new DataSet();
        //    objEntMascota.idProp = Convert.ToInt32(dgvDuenios.CurrentRow.Cells[0].Value);
        //    ds = objNegMascota.listadoMascotas(objEntMascota.idProp.ToString());
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        Ds_a_TxtBoxMascota(ds);
        //        btnCargaMascota.Visible = false;
        //        btnModificarMascota.Visible = true;
        //        lblMensaje.Text = string.Empty;
        //    }
        //}
        private void Ds_a_TxtBoxMascota(DataSet ds)
        {
            string retirado;
            if (cbRetirado.Checked == true)
            {
                retirado = "si";
            }
            else
            {
                retirado = "no";
            }
            string fechaNacimiento = dtpFechaNac.Value.ToString();

            txtNombreMascota.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            cmbTipo.SelectedItem = ds.Tables[0].Rows[0]["Tipo"].ToString();
            txtObsMascota.Text = ds.Tables[0].Rows[0]["Observacion"].ToString();
            fechaNacimiento = ds.Tables[0].Rows[0]["Fecha de nacimiento"].ToString();
            retirado = ds.Tables[0].Rows[0]["Retirado"].ToString();
            cbDueniosMascota.SelectedItem = ds.Tables[0].Rows[0]["Dueño"].ToString();
        }
        private void Ds_a_TxtBoxDuenio(DataSet ds)
        {
            txtDniDuenio.Text = ds.Tables[0].Rows[0]["DNI"].ToString();
            txtNombreDuenio.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txtApellidoDuenio.Text = ds.Tables[0].Rows[0]["Apellido"].ToString();
            txtTelDuenio.Text = ds.Tables[0].Rows[0]["Telefono"].ToString();
        }

        private void btnModificarDuenio_Click(object sender, EventArgs e)
        {
            int nResultado = -1;
            TxtBox_a_ObjDuenio();
            nResultado = objNegDuenio.abmDuenio("Modificar", objEntDuenio); 
            if (nResultado != -1)
            {
                lblMensaje.Text = "El dueño fue modificado con éxito";
                LimpiarDuenio();
                LlenarDGVDuenio();
                btnModificarDuenio.Visible = false;
                btnCargarDuenio.Visible = true;
            }
            else
                lblMensaje.Text = "Se produjo un error al intentar modificar el dueño";
        }

        private void btnModificarMascota_Click(object sender, EventArgs e)
        {
            int nResultado = -1;
            TxtBox_a_ObjMascota();
            nResultado = objNegMascota.abmMascota("Modificar", objEntMascota);
            if (nResultado != -1)
            {
                lblMensaje.Text = "La mascota fue modificada con éxito";
                LimpiarMascota();
                LlenarDGVMascota();
                btnModificarMascota.Visible = false;
                btnCargaMascota.Visible = true;
            }
            else
                lblMensaje.Text = "Se produjo un error al intentar modificar la mascota";
        }

        private void dgvDuenios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();
            objEntDuenio.idProp = Convert.ToInt32(dgvDuenios.CurrentRow.Cells[0].Value);
            ds = objNegDuenio.listadoDuenios(objEntDuenio.idProp.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_TxtBoxDuenio(ds);
                btnCargarDuenio.Visible = false;
                btnModificarDuenio.Visible = true;
                lblMensaje.Text = string.Empty;
            }
        }
    }
}

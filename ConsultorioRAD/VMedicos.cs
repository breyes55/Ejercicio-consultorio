using CapaDatos.BaseDatos.Modelos;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioRAD
{
    public partial class VMedicos : Form
    {
        private NMedicos nMedicos;
        public VMedicos()
        {
            InitializeComponent();
            nMedicos = new NMedicos();
            CargarDatos();
        }

        private void VMedicos_Load(object sender, EventArgs e)
        {

        }

        void CargarDatos()
        {
            var datos = nMedicos.obtenerGridMedicos();
            dgmedicos.DataSource = datos;
        }
        void LimpiarDatos()
        {
            txtMedicoId.Text = "";
            txtnombres.Text = "";
            txtapellidos.Text = "";
            cbEstado.Checked = false;
            dtpFechaIngreso.Value = DateTime.Now;
            errormedicos.Clear();
        }

        private bool ValidarDatos()
        {
            var FormularioValido = true;
            if (string.IsNullOrEmpty(txtnombres.Text.ToString()) || string.IsNullOrWhiteSpace(txtnombres.Text.ToString()))
            {
                FormularioValido = false;
                errormedicos.SetError(txtnombres, "Debe ingresar los Nombres.");
                return FormularioValido;
            }

            if (string.IsNullOrEmpty(txtapellidos.Text.ToString()) || string.IsNullOrWhiteSpace(txtapellidos.Text.ToString()))
            {
                FormularioValido = false;
                errormedicos.SetError(txtapellidos, "Debe ingresar los Apellidos.");
                return FormularioValido;
            }


            return FormularioValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                MMedicos medicos = new MMedicos()
                {
                    Nombres = txtnombres.Text,
                   Apellidos = txtapellidos.Text,
                   Estado = cbEstado.Checked,
                   
                };
                if (!string.IsNullOrEmpty(txtMedicoId.Text) || !string.IsNullOrWhiteSpace(txtMedicoId.Text))
                {
                    if (int.TryParse(txtMedicoId.Text.ToString(), out int medicoId) && medicoId != 0)
                    {
                        medicos.MedicoId = medicoId;
                    }
                }
                nMedicos.GuardarMedicos(medicos);
               LimpiarDatos();
               CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            var MedicoId = txtMedicoId.Text.ToString();
            if (string.IsNullOrEmpty(MedicoId) || string.IsNullOrWhiteSpace(MedicoId))
            {
                return;
            }
            nMedicos.EliminarMedicos(int.Parse(MedicoId));
            CargarDatos();
            LimpiarDatos();
        }

        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            dgmedicos.DataSource = nMedicos.obtenerMedicosActivosGrid();
            if (cbActivos.Checked == false)
            {
                CargarDatos();
            }
        }

        private void dgmedicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgmedicos.Rows.Count)
            {
                DataGridViewRow row = dgmedicos.Rows[e.RowIndex];
                txtMedicoId.Text = row.Cells["MedicoId"].Value.ToString();
                txtnombres.Text = row.Cells["Nombres"].Value.ToString();
                txtapellidos.Text = row.Cells["Apellidos"].Value.ToString();
                cbEstado.Checked = bool.Parse(dgmedicos.CurrentRow.Cells["Estado"].Value.ToString());
                var FechaIngreso = row.Cells["FechaIngreso"].Value;
                if (FechaIngreso != null)
                {
                    dtpFechaIngreso.Value = (DateTime)FechaIngreso;
                }
            }
        }


    }
}

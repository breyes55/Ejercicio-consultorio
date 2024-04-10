using CapaDatos;
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
    public partial class VPacientes : Form
    {
        private NPacientes npacientes;
        public VPacientes()
        {
            InitializeComponent();
            npacientes = new NPacientes();
            CargarDatos();
        }
        private void VPacientes_Load(object sender, EventArgs e)
        {

        }
        void CargarDatos()
        {
            var datos = npacientes.obtenerGridPacientes();
            dgpacientes.DataSource = datos;
        }

        void LimpiarDatos()
        {
            txtpacienteid.Text = "";
            txtnombres.Text = "";
            txtapellidos.Text = "";
            cbEstado.Checked = false;
            dtpFechaIngreso.Value = DateTime.Now;
            errorpacientes.Clear();
        }

        private bool ValidarDatos()
        {
            var FormularioValido = true;
            if (string.IsNullOrEmpty(txtnombres.Text.ToString()) || string.IsNullOrWhiteSpace(txtnombres.Text.ToString()))
            {
                FormularioValido = false;
                errorpacientes.SetError(txtnombres, "Debe ingresar los Nombres.");
                return FormularioValido;
            }

            if (string.IsNullOrEmpty(txtapellidos.Text.ToString()) || string.IsNullOrWhiteSpace(txtapellidos.Text.ToString()))
            {
                FormularioValido = false;
                errorpacientes.SetError(txtapellidos, "Debe ingresar los Apellidos.");
                return FormularioValido;
            }
            return FormularioValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                MPacientes pacientes = new MPacientes()
                {
                    Nombres = txtnombres.Text,
                    Apellidos = txtapellidos.Text,
                    Estado = cbEstado.Checked,

                };
                if (!string.IsNullOrEmpty(txtpacienteid.Text) || !string.IsNullOrWhiteSpace(txtpacienteid.Text))
                {
                    if (int.TryParse(txtpacienteid.Text.ToString(), out int pacienteId) && pacienteId != 0)
                    {
                        pacientes.PacienteId = pacienteId;
                    }
                }
                npacientes.GuardarPacientes(pacientes);
                LimpiarDatos();
                CargarDatos();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            var PacienteId = txtpacienteid.Text.ToString();
            if (string.IsNullOrEmpty(PacienteId) || string.IsNullOrWhiteSpace(PacienteId))
            {
                return;
            }
            npacientes.EliminarPacientes(int.Parse(PacienteId));
            CargarDatos();
            LimpiarDatos();
        }

        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            dgpacientes.DataSource = npacientes.obtenerPacientesActivosGrid();
            if (cbActivos.Checked == false)
            {
                CargarDatos();
            }
        }

        private void dgpacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgpacientes.Rows.Count)
            {
                DataGridViewRow row = dgpacientes.Rows[e.RowIndex];
                txtpacienteid.Text = row.Cells["PacienteId"].Value.ToString();
                txtnombres.Text = row.Cells["Nombres"].Value.ToString();
                txtapellidos.Text = row.Cells["Apellidos"].Value.ToString();
                cbEstado.Checked = bool.Parse(dgpacientes.CurrentRow.Cells["Estado"].Value.ToString());
                var FechaIngreso = row.Cells["FechaIngreso"].Value;
                if (FechaIngreso != null)
                {
                    dtpFechaIngreso.Value = (DateTime)FechaIngreso;
                }
            }

        }
    }
}

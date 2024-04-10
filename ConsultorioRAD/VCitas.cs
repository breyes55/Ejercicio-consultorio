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
    public partial class VCitas : Form
    {
        private Ncitas ncitas;
        private NPacientes nPacientes;
        private NMedicos nMedicos;
        public VCitas()
        {
            InitializeComponent();
            ncitas = new Ncitas();
            nPacientes = new NPacientes();
            nMedicos = new NMedicos();
            CargarDatos();
            CargarCombos();
        }

        private void VCitas_Load(object sender, EventArgs e)
        {

        }

        void CargarDatos()
        {
            var datos = ncitas.obtenerGridCitas();
            dgcitas.DataSource = datos;
        }
        void LimpiarDatos()
        {
            txtCitaId.Text = "";
            cbxMedicoId.SelectedValue = "";
            cbxpacienteid.SelectedValue = "";
            dtpFechacita.Value = DateTime.Now;
            cbEstado.Checked = false;
            errorcitas.Clear();
        }

        private void CargarCombos()
        {
            cbxMedicoId.DataSource = nMedicos.CargaCombos();
            cbxMedicoId.ValueMember = "Valor";
            cbxMedicoId.DisplayMember = "Descripcion";

            cbxpacienteid.DataSource = nPacientes.CargaCombos();
            cbxpacienteid.ValueMember = "Valor";
            cbxpacienteid.DisplayMember = "Descripcion";

        }

        private bool ValidarDatos()
        {
            var FormularioValido = true;
            
  
            if (string.IsNullOrEmpty(cbxMedicoId.Text.ToString()) || string.IsNullOrWhiteSpace(cbxMedicoId.Text.ToString()))
            {
                FormularioValido = false;
                errorcitas.SetError(cbxMedicoId, "Debe ingresar un Medico para la cita");
                return FormularioValido;
            }
            if (string.IsNullOrEmpty(cbxpacienteid.Text.ToString()) || string.IsNullOrWhiteSpace(cbxpacienteid.Text.ToString()))
            {
                FormularioValido = false;
                errorcitas.SetError(cbxpacienteid, "Selecione un cliente para la cita");
                return FormularioValido;
            }
            return FormularioValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                MCitas citas = new MCitas()

                {
                    MedicoId = int.Parse(cbxMedicoId.SelectedValue.ToString()),
                    PacienteId = int.Parse(cbxpacienteid.SelectedValue.ToString()),
                    FechaICita = dtpFechacita.Value,
                    Estado = cbEstado.Checked
                };
                if (!string.IsNullOrEmpty(txtCitaId.Text) || !string.IsNullOrWhiteSpace(txtCitaId.Text))
                {
                    if (int.TryParse(txtCitaId.Text.ToString(), out int citaId) && citaId != 0)
                    {
                        citas.CitaId = citaId;
                    }
                }
                ncitas.GuardarCitas(citas);
                LimpiarDatos();
                CargarDatos();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var CitaId = txtCitaId.Text.ToString();
            if (string.IsNullOrEmpty(CitaId) || string.IsNullOrWhiteSpace(CitaId))
            {
                return;
            }
            ncitas.EliminarCitas(int.Parse(CitaId));
            CargarDatos();
            LimpiarDatos();
        }


        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            dgcitas.DataSource = ncitas.obtenerCitasActivosGrid();
            if (cbActivos.Checked == false)
            {
                CargarDatos();
            }
        }

        private void dgcitas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgcitas.Rows.Count)
            {
                DataGridViewRow row = dgcitas.Rows[e.RowIndex];
                txtCitaId.Text = row.Cells["CitaId"].Value.ToString();
                var Medico = dgcitas.CurrentRow.Cells["MedicoNombreCompleto"].Value.ToString();
                cbxMedicoId.SelectedIndex = cbxMedicoId.FindStringExact(Medico);
                var Paciente = dgcitas.CurrentRow.Cells["PacienteNombreCompleto"].Value.ToString();
                cbxpacienteid.SelectedIndex = cbxpacienteid.FindStringExact(Paciente);
                cbEstado.Checked = bool.Parse(dgcitas.CurrentRow.Cells["Estado"].Value.ToString());
                var FechaICita = row.Cells["FechaICita"].Value;
                if (FechaICita != null)
                {
                    dtpFechacita.Value = (DateTime)FechaICita;
                }
            }
        }

    }
}

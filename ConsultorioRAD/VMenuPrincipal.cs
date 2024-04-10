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
    public partial class VMenuPrincipal : Form
    {
        public VMenuPrincipal()
        {
            InitializeComponent();
        }
        private void VMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VCitas citas = new VCitas();
            citas.Show();
        }

        

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VMedicos medicos = new VMedicos();
            medicos.Show();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VPacientes pacientes = new VPacientes();
            pacientes.Show();

        }
    }
}

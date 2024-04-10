using CapaDatos;
using CapaDatos.BaseDatos.Modelos;
using CapaNegocios.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class Ncitas
    {
        private DCitas dCitas;
        private MMedicos mMedicos;
        private MPacientes mPacientes;

        public Ncitas()
        {
            dCitas = new DCitas();
            mMedicos = new MMedicos();
            mPacientes = new MPacientes();
        }

        public List<MCitas> CitasTodas()
        {
            return dCitas.TodosLasCitas();
        }

        public List<object> obtenerCitasActivosGrid()
        {
            var Citas = dCitas.TodosLasCitas().Select(c => new {
                c.CitaId,
                MedicoNombreCompleto = c.MMedicos.Nombres + " " + c.MMedicos.Apellidos,
                PacienteNombreCompleto = c.MPacientes.Nombres + " " + c.MPacientes.Apellidos,
                c.Estado,
                c.FechaICita,
              
            });
            return Citas.Where(c => c.Estado == true).Cast<object>().ToList();
        }

        public int GuardarCitas(MCitas Citas)
        {
            Citas.Eliminado =false;
            return dCitas.GuardarCitas(Citas);
        }

        public int EditarCitas(MCitas Citas)
        {
            Citas.Eliminado = false;
            return dCitas.GuardarCitas(Citas);
        }
        public int EliminarCitas(int CitaId)
        {
            return dCitas.EliminarCita(CitaId);
        }
       

        public List<object> obtenerGridCitas()
        {
            var Citas = dCitas.TodosLasCitas().Select(c => new {
                c.CitaId,
                MedicoNombreCompleto = c.MMedicos.Nombres + " " + c.MMedicos.Apellidos,
                PacienteNombreCompleto = c.MPacientes.Nombres + " " + c.MPacientes.Apellidos,
                c.Estado,
                c.FechaICita,
            
            });
            return Citas.Cast<object>().ToList();
        }

        ///////////////
    }
}

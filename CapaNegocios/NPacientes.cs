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
    public class NPacientes
    {
        private DPacientes dPacientes;
        public NPacientes()
        {
            dPacientes = new DPacientes();
        }
        public List<MPacientes> TodosPacientes()
        {
            return dPacientes.TodosLosPacientes();
        }

        public List<object> obtenerPacientesActivosGrid()
        {
            var pacientes = dPacientes.TodosLosPacientes().Select(c => new {
                c.PacienteId,
                c.Nombres,
                c.Apellidos,
                c.FechaIngreso,
                c.Estado,
            });

            return pacientes.Where(c => c.Estado == true).Cast<object>().ToList();
        }
        public int GuardarPacientes(MPacientes pacientes)
        {
            pacientes.FechaIngreso = DateTime.Now;
            return dPacientes.GuardarPacientes(pacientes);
        }

        public int EditarPacientes(MPacientes pacientes)
        {
            return dPacientes.GuardarPacientes(pacientes);
        }

        public int EliminarPacientes(int PacienteId)
        {
            return dPacientes.EliminarPacientes(PacienteId);
        }

        public List<object> obtenerGridPacientes()
        {
            var pacientes = dPacientes.TodosLosPacientes().Select(c => new {
                c.PacienteId,
                c.Nombres,
                c.Apellidos,
                c.Estado,
                c.FechaIngreso
            });
            return pacientes.Cast<object>().ToList();
        }

        public List<CargarCombos> CargaCombos()
        {
            List<CargarCombos> Datos = new List<CargarCombos>();
            var pacientes = TodosPacientes().Select(c => new
            {
                c.PacienteId,
                NombreCompleto = c.Nombres + " " + c.Apellidos
            }).ToList();
            foreach (var item in pacientes)
            {
                Datos.Add(new CargarCombos()
                {
                    Valor = item.PacienteId,
                    Descripcion = item.NombreCompleto
                });
            }

            return Datos;
        }

    }
}

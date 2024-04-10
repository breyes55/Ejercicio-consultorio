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
    public class NMedicos
    {
        private DMedicos dMedicos;

        public NMedicos()
        {
            dMedicos = new DMedicos();
        }

        public List<MMedicos> TodosMedicos()
        {
            return dMedicos.TodosLosMedicos();
        }

        public List<object> obtenerMedicosActivosGrid()
        {
            var medicos = dMedicos.TodosLosMedicos().Select(c => new {
                c.MedicoId,
                c.Nombres,
                c.Apellidos,
                c.FechaIngreso,
                c.Estado,
            });

            return medicos.Where(c => c.Estado == true).Cast<object>().ToList();
        }

        public int GuardarMedicos(MMedicos medicos)
        {
            medicos.FechaIngreso = DateTime.Now;
            return dMedicos.GuardarMedicos(medicos);
        }

        public int EditarMedicos(MMedicos medicos)
        {
            return dMedicos.GuardarMedicos(medicos);
        }

        public int EliminarMedicos(int MedicoId)
        {
            return dMedicos.EliminarMedicos(MedicoId);
        }


        public List<object> obtenerGridMedicos()
        {
            var medicos = dMedicos.TodosLosMedicos().Select(c => new {
                c.MedicoId,
                c.Nombres,
                c.Apellidos,
                c.Estado,
                c.FechaIngreso
            });
            return medicos.Cast<object>().ToList();
        }

        public List<CargarCombos> CargaCombos()
        {
            List<CargarCombos> Datos = new List<CargarCombos>();
            var pacientes = TodosMedicos().Select(c => new
            {
                c.MedicoId,
                NombreCompleto = c.Nombres + " " + c.Apellidos
            }).ToList();
            foreach (var item in pacientes)
            {
                Datos.Add(new CargarCombos()
                {
                    Valor = item.MedicoId,
                    Descripcion = item.NombreCompleto
                });
            }

            return Datos;
        }
    }
}

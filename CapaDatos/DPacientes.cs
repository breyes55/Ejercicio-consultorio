using CapaDatos.BaseDatos.Modelos;
using CapaDatos.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DPacientes
    {
        UnitOfWork _unitOfWork;
        public DPacientes()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int PacienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }

        public List<MPacientes> TodosLosPacientes()
        {
            return _unitOfWork.Repository<MPacientes>().Consulta().ToList();
        }
        public int GuardarPacientes(MPacientes pacientes)
        {
            if (pacientes.PacienteId == 0)
            {
                _unitOfWork.Repository<MPacientes>().Agregar(pacientes);
                return _unitOfWork.Guardar();
            }
            else
            {
                var PacientesInDb = _unitOfWork.Repository<MPacientes>().Consulta().FirstOrDefault(c => c.PacienteId == pacientes.PacienteId);

                if (PacientesInDb != null)
                {
                    PacientesInDb.Nombres = pacientes.Nombres;
                    PacientesInDb.Apellidos = pacientes.Apellidos;
                    PacientesInDb.Estado = pacientes.Estado;
                    _unitOfWork.Repository<MPacientes>().Editar(PacientesInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }
        }
        public int EliminarPacientes(int PacienteId)
        {
            var PacientesInDb = _unitOfWork.Repository<MPacientes>().Consulta().FirstOrDefault(c => c.PacienteId == PacienteId);
            if (PacientesInDb != null)
            {
                _unitOfWork.Repository<MPacientes>().Eliminar(PacientesInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}

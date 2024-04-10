using CapaDatos.BaseDatos.Modelos;
using CapaDatos.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DCitas
    {
        UnitOfWork _unitOfWork;
        public DCitas()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int CitaId { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }
        public DateTime FechaICita { get; set; }
        public bool Estado { get; set; }
        public bool Eliminado { get; set; }

        public List<MCitas> TodosLasCitas()
        {
            return _unitOfWork.Repository<MCitas>().Consulta().
                                     Include(c => c.MPacientes).
                                     Include(c => c.MMedicos)
                                    .ToList();
     }  

    

        public int GuardarCitas(MCitas Citas)
        {
            if (Citas.CitaId == 0)
            {
                _unitOfWork.Repository<MCitas>().Agregar(Citas);
                return _unitOfWork.Guardar();
            }
            else
            {
                var CitaInDb = _unitOfWork.Repository<MCitas>().Consulta().FirstOrDefault(c => c.CitaId == Citas.CitaId);

                if (CitaInDb != null)
                {
                    CitaInDb.MedicoId = Citas.MedicoId;
                    CitaInDb.PacienteId = Citas.PacienteId;
                    CitaInDb.Estado = Citas.Estado;
                    CitaInDb.FechaICita = Citas.FechaICita;
                    _unitOfWork.Repository<MCitas>().Editar(CitaInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }

        }

        public int EliminarCita(int CitaId)
        {
            var CitaInDb = _unitOfWork.Repository<MCitas>().Consulta().FirstOrDefault(c => c.CitaId == CitaId);
            if (CitaInDb != null)
            {
                _unitOfWork.Repository<MCitas>().Eliminar(CitaInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}

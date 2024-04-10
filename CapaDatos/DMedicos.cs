using CapaDatos.BaseDatos.Modelos;
using CapaDatos.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DMedicos
    {
        UnitOfWork _unitOfWork;

        public DMedicos()
        {
            _unitOfWork = new UnitOfWork();
        }
        public int MedicoId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }

        public List<MMedicos> TodosLosMedicos()
        {
            return _unitOfWork.Repository<MMedicos>().Consulta().ToList();                           
        }

        public int GuardarMedicos(MMedicos Medicos)
        {
            if (Medicos.MedicoId == 0)
            {
                _unitOfWork.Repository<MMedicos>().Agregar(Medicos);
                return _unitOfWork.Guardar();
            }
            else
            {
                var MedicosInDb = _unitOfWork.Repository<MMedicos>().Consulta().FirstOrDefault(c => c.MedicoId == Medicos.MedicoId);

                if (MedicosInDb != null)
                {
                    MedicosInDb.Nombres = Medicos.Nombres;
                    MedicosInDb.Apellidos = Medicos.Apellidos;
                    MedicosInDb.Estado = Medicos.Estado;
                    _unitOfWork.Repository<MMedicos>().Editar(MedicosInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }
        }

        public int EliminarMedicos(int MedicoId)
        {
            var MedicosInDb = _unitOfWork.Repository<MMedicos>().Consulta().FirstOrDefault(c => c.MedicoId == MedicoId);
            if (MedicosInDb != null)
            {
                _unitOfWork.Repository<MMedicos>().Eliminar(MedicosInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}

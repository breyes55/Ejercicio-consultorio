using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.BaseDatos.Modelos
{
    public class MCitas
    {
        [Key]
        public int CitaId { get; set; }
        public int MedicoId { get; set; }//
        public MMedicos MMedicos { get; set; }
        public int PacienteId { get; set; }//
        public MPacientes MPacientes { get; set; }
        public DateTime FechaICita { get; set; }//
        public bool Estado { get; set; }//
        public bool Eliminado { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoSESS.Models
{
    public class OrdenMedica
    {
        public int Id_Cita { get; set; }
        public int Id_Medico { get; set; }
        public int Id_Examen { get; set; }
        public string Medicamento { get; set; }
        public string Observaciones { get; set; }
    }
}
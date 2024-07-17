using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoSESS.Models
{
    public class Reservacita
    {
        public int Id_Cita { get; set; }
        public int Id_Paciente { get; set; }
        public int Id_Horario { get; set; }
        public int Id_Consultorio { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string Estado_Cita { get; set; }
    }
}
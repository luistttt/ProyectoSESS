using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoSESS.Models
{
    public class Examenes
    {
        public int Id_Cita { get; set; }
        public int Id_Servicio { get; set; }
        public string Nota_Medica { get; set; }
        public DateTime Fecha_examen { get; set; }
        public string Resultados { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoSESS.Models
{
    public class HistoriaMedica
    {
        public int Id_Historia { get; set; }
        public int Id_Medico { get; set; }
        public int Id_Paciente { get; set; }
        public DateTime Fecha_Ingreso { get; internal set; }
        public  string Estado_Historia { get; set; }
        public string Concepto { get; set; }
        public string Observaciones { get; set; }
    }
}
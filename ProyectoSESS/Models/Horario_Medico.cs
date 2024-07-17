using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoSESS.Models
{
    public class Horario_Medico
    {
        public int Id_Horario { get; set; }
        public int Id_Medico { get; set; }
        public DateTime Fecha_Horario { get; set; }
        public string Estado_Horario { get; set; }
    }
}
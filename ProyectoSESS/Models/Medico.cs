using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoSESS.Models
{
    public class Medico
    {
        public int Id_Medico { get; set; }
        public int Id_Empleado { get; set; }
        public int Id_Especialidad { get; set; }
        public int Numero_Consultorio { get; set; }
        public string Estado_Medico { get; set; }
    }
}
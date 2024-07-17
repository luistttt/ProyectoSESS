using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoSESS.Models
{
    public class Paciente
    {
        public int Id_Paciente { get; set; }
        public string Nombre_Paciente { get; set; }
        public string Apellido_Paciente { get; set; }
        public string Direccion_Paciente { get; set; }
        public string Correo { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Estado_Paciente { get; set; }
    }
}
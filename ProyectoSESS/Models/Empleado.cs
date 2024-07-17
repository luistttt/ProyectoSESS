using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoSESS.Models
{
    public class Empleado
    {
        public int Id_Empleado { get; set; }
        public string Nombre_Empleado { get; set; }
        public string Apellido_Empleado { get; set; }
        public int Id_Cargo { get; set; }
        public string Direccion_Empleado { get; set; }
        public int Telefono_Empleado { get; set; }
        public string Estado_Empleado { get; set; }
    }
}
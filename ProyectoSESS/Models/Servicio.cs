using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoSESS.Models
{
    public class Servicio
    {
        public int Id_Servicio { get; set; }
        public int Id_Tiposervicio { get; set; }
        public string Consulta_Servicio { get; set; }
        public string Estado_Servicio { get; set; }
    }
}
using ProyectoSESS.Data;
using ProyectoSESS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProyectoSESS.Controllers
{
    public class ServicioController : ApiController
    {
        // GET api/<controller>
        public List<Servicio> Get()
        {
            return ServicioData.Listarservicio();
        }
        // GET api/<controller>/5
        public List<Servicio> Get(int Id_Servicio)
        {
            return ServicioData.Obtenerservico(Id_Servicio);
        }
        // POST api/<controller>
        public bool Post([FromBody] Servicio oservicio)
        {
            return ServicioData.InsertarServicio(oservicio);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Servicio oservicio)
        {
            return ServicioData.Actualizarservicio(oservicio);
        }
        // DELETE api/<controller>/5
        public bool Delete(int Id_Servicio)
        {
            return ServicioData.Eliminarservicio(Id_Servicio);
        }
    }
}
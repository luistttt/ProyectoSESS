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
    public class EspecialidadController : ApiController
    {
        // GET api/<controller>
        public List<Especialidad> Get()
        {
            return EspecialidadData.Listar();
        }
        // GET api/<controller>/5
        public List<Especialidad> Get(string id)
        {
            return EspecialidadData.Consultar(id);
        }
        // POST api/<controller>
        public bool Post([FromBody] Especialidad oEspecialidad)
        {
            return EspecialidadData.InsertarEspecialidad(oEspecialidad);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Especialidad oEspecialidad)
        {
            return EspecialidadData.ActualizarEspecialidad(oEspecialidad);
        }
        // DELETE api/<controller>/5
        public bool Delete(string id)
        {
            return EspecialidadData.EliminarEspecialidad(id);
        }
    }
}
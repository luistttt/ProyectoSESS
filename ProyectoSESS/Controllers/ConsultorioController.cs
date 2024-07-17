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
    public class ConsultorioController : ApiController
    {
        // GET api/<controller>
        public List<Consultorio> Get()
        {
            return ConsultorioData.Listar();
        }
        // GET api/<controller>/5
        public List<Consultorio> Get(string id)
        {
            return ConsultorioData.Consultar(id);
        }
        // POST api/<controller>
        public bool Post([FromBody] Consultorio oConsultorio)
        {
            return ConsultorioData.InsertarConsultorio(oConsultorio);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Consultorio oConsultorio)
        {
            return ConsultorioData.ActualizarConsultorio(oConsultorio);
        }
        // DELETE api/<controller>/5
        public bool Delete(string id)
        {
            return ConsultorioData.EliminarConsultorio(id);
        }
    }
}
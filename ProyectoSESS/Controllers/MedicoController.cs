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
    public class MedicoController : ApiController
    {
        // GET api/<controller>
        public List<Medico> Get()
        {
            return MedicoData.ListarMedico();
        }

        // GET api/<controller>/5
        public List<Medico> Get(string Id_Medico)
        {
            return MedicoData.ObtenerMedico(Id_Medico);
        }

        // GET api/<controller>/5

        public bool Post([FromBody] Medico oMedico)
        {
            return MedicoData.InsertarMedico(oMedico);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Medico oMedico)
        {
            return MedicoData.ActualizarMedico(oMedico);
        }
        // DELETE api/<controller>/5
        public bool Delete(int Id_Medico)
        {
            return MedicoData.EliminarMedico(Id_Medico);
        }
    }
}
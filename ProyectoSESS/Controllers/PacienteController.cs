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
    public class PacienteController : ApiController
    {
        // GET api/<controller>
        public List<Paciente> Get()
        {
            return PacienteData.ListarPaciente();
        }
        // GET api/<controller>/5
        public List<Paciente> Get(int Id_Paciente)
        {
            return PacienteData.ConsultarPaciente(Id_Paciente);
        }
        // POST api/<controller>
        public bool Post([FromBody] Paciente oPaciente)
        {
            return PacienteData.InsertarPaciente(oPaciente);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Paciente oPaciente)
        {
            return PacienteData.ActualizarPaciente(oPaciente);
        }
        // DELETE api/<controller>/5
        public bool Delete(int Id_Paciente)
        {
            return PacienteData.EliminarPaciente(Id_Paciente);
        }
    }
}
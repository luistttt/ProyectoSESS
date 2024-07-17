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
    public class Horario_MedicoController : ApiController
    {
        // GET api/<controller>
        public List<Horario_Medico> Get()
        {
            return Horario_MedicoData.Listar_Horario_Medico();
        }

        // GET api/<controller>/5
        public List<Horario_Medico> Get(string Id_Horario)
        {
            return Horario_MedicoData.Obtener_Horario_Medico(Id_Horario);
        }

        // POST api/<controller>
        public bool Post([FromBody] Horario_Medico oHorario_Medico)
        {
            return Horario_MedicoData.Insertar_Horario_Medico(oHorario_Medico);
        }

        // PUT api/<controller>/5
        public bool Put([FromBody] Horario_Medico oHorario_Medico)
        {
            return Horario_MedicoData.Actualizar_Horario_Medico(oHorario_Medico);
        }

        // DELETE api/<controller>/5
        public bool Delete(int Id_Horario)
        {
            return Horario_MedicoData.Eliminar_Horario_Medico(Id_Horario);
        }
    }
}
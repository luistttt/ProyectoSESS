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
    public class ExamenesController : ApiController
    {
        // GET api/<controller>
        public List<Examenes> Get()
        {
            return ExamenesData.ListarExamenes();
        }

        // GET api/<controller>/5
        public List<Examenes> Get(int Id_Cita)
        {
            return ExamenesData.ObtenerExamen(Id_Cita);
        }

        // GET api/<controller>/5

        public bool Post([FromBody] Examenes oExamenes)
        {
            return ExamenesData.InsertarExamenes(oExamenes);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Examenes oExamenes)
        {
            return ExamenesData.ActualizarExamenes(oExamenes);
        }
    }
}
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
    public class HistoriaMedicaController : ApiController
    {
        // GET api/<controller>
        public List<HistoriaMedica> Get()
        {
            return HistoriaMedicaData.ListarHistoriaMedica();
        }

        // GET api/<controller>/5
        public List<HistoriaMedica> Get(int Id_Historia)
        {
            return HistoriaMedicaData.ObtenerHistoriaMedica(Id_Historia);
        }

        // POST api/<controller>
        public bool Post([FromBody] HistoriaMedica oHistoriaMedica)
        {
            return HistoriaMedicaData.InsertarHistoriaMedica(oHistoriaMedica);
        }

        // PUT api/<controller>/5
        public bool Put([FromBody] HistoriaMedica oHistoriaMedica)
        {
            return HistoriaMedicaData.ActualizarHistoriaMedica(oHistoriaMedica);
        }

        // DELETE api/<controller>/5
        public bool Delete(int Id_Historia)
        {
            return HistoriaMedicaData.EliminarHistoriaMedica(Id_Historia);
        }
    }
}
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
    public class OrdenMedicaController : ApiController
    {
        // GET api/<controller>
        public List<OrdenMedica> Get()
        {
            return OrdenMedicaData.ListarOrdenMedica();
        }
        // GET api/<controller>/5
        public List<OrdenMedica> Get(int Id_Cita)
        {
            return OrdenMedicaData.ObtenerOrdenMedica(Id_Cita);
        }
        // POST api/<controller>
        public bool Post([FromBody] OrdenMedica oOrdenMedica)
        {
            return OrdenMedicaData.InsertarOrdenMedica(oOrdenMedica);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] OrdenMedica oOrdenMedica)
        {
            return OrdenMedicaData.ActualizarOrdenMedica(oOrdenMedica);
        }
        // DELETE api/<controller>/5
        
    }
}
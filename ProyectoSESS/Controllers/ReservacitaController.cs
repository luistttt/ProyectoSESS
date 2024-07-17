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
    public class ReservacitaController : ApiController
    {
        // GET api/<controller>
        public List<Reservacita> Get()
        {
            return ReservacitaData.ListarReservacita();
        }
        // GET api/<controller>/5
        public List<Reservacita> Get(int Id_Cita)
        {
            return ReservacitaData.ConsultarReservacita(Id_Cita);
        }
        // POST api/<controller>
        public bool Post([FromBody] Reservacita oReservacita)
        {
            return ReservacitaData.InsertarReservacita(oReservacita);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Reservacita oReservacita)
        {
            return ReservacitaData.ActualizarReservacita(oReservacita);
        }
        // DELETE api/<controller>/5
        public bool Delete(int Id_Cita)
        {
            return ReservacitaData.EliminarReservacita(Id_Cita);
        }
    }
}
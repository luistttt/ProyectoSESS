using ProyectoSESS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoSESS.Data
{
    public class ReservacitaData
    {
        public static bool InsertarReservacita(Reservacita oReservacita)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_Insertar_ReservaCita '" + oReservacita.Id_Cita + "','" + oReservacita.Id_Paciente
           + "','" + oReservacita.Id_Horario + "','" + oReservacita.Id_Consultorio + "'; '" + oReservacita.Fecha_Ingreso + "','"
           + oReservacita.Estado_Cita + "'";

            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }

        }

        public static bool ActualizarReservacita(Reservacita oReservacita)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Actiualizar_ReservarCita '" + oReservacita.Id_Cita + "','" + oReservacita.Id_Paciente
           + "','" + oReservacita.Id_Horario + "','" + oReservacita.Id_Consultorio + "'; '" + oReservacita.Fecha_Ingreso + "','"
           + oReservacita.Estado_Cita + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }
        public static bool EliminarReservacita(int Id_Cita)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Eliminar_ReservarCita '" + Id_Cita + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }

        public static List<Reservacita> ListarReservacita()
        {
            List<Reservacita> oListaReservacita = new List<Reservacita>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_Listar_Reservacita";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaReservacita.Add(new Reservacita()
                    {
                        Id_Cita = Convert.ToInt32(dr["Id_Cita"]),
                        Id_Paciente = Convert.ToInt32(dr["Id_Paciente"]),
                        Id_Horario = Convert.ToInt32(dr["Id_Horario"]),
                        Id_Consultorio = Convert.ToInt32(dr["Id_Consultorio"]),
                        Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString()),
                        Estado_Cita = dr["Estado_Cita"].ToString()

                    });
                }
                return oListaReservacita;
            }
            else
            {
                return oListaReservacita;
            }


        }
        public static List<Reservacita> ConsultarReservacita(int Id_Cita)
        {
            List<Reservacita> oListaReservacita = new List<Reservacita>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Consultar_Reservacita '" + Id_Cita + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaReservacita.Add(new Reservacita()

                    {
                        Id_Cita = Convert.ToInt32(dr["Id_Cita"]),
                        Id_Paciente = Convert.ToInt32(dr["Id_Paciente"]),
                        Id_Horario = Convert.ToInt32(dr["Id_Horario"]),
                        Id_Consultorio = Convert.ToInt32(dr["Id_Consultorio"]),
                        Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString()),
                        Estado_Cita = dr["Estado_Cita"].ToString()
                    });
                }
                return oListaReservacita;
            }
            else
            {
                return oListaReservacita;
            }
        }
    }
}
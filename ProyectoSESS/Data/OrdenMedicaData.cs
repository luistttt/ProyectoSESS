using ProyectoSESS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoSESS.Data
{
    public class OrdenMedicaData
    {
        public static bool InsertarOrdenMedica(OrdenMedica oOrdenMedica)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia = "EXECUTE SP_Insertar_Orden_Medica" + oOrdenMedica.Id_Cita + "," + oOrdenMedica.Id_Medico
           + "," + oOrdenMedica.Id_Examen + ",'" + oOrdenMedica.Medicamento +"','" + oOrdenMedica.Observaciones+ "'";
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
        public static bool ActualizarOrdenMedica(OrdenMedica oOrdenMedica)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia = "EXECUTE SP_ACTUALIZAR_ORDEN_MEDICA " + oOrdenMedica.Id_Cita + "," + oOrdenMedica.Id_Medico
           + "," + oOrdenMedica.Id_Examen + ",'" + oOrdenMedica.Medicamento + "','" + oOrdenMedica.Observaciones + "'";

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

        

        public static List<OrdenMedica> ListarOrdenMedica()
        {
            List<OrdenMedica> oListarOrdenMedica = new List<OrdenMedica>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_Listar_Orden_Medica";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarOrdenMedica.Add(new OrdenMedica()
                    {
                        Id_Cita = Convert.ToInt32(dr["Id_Cita"]),
                        Id_Medico = Convert.ToInt32(dr["Id_Medico"]),
                        Id_Examen = Convert.ToInt32(dr["Id_Examen"]),
                        Medicamento = dr["Medicamento"].ToString(),
                        Observaciones = dr["Observaciones"].ToString()

                    });
                }
                return oListarOrdenMedica;
            }
            else
            {
                return oListarOrdenMedica;
            }
        }

        public static List<OrdenMedica> ObtenerOrdenMedica(int Id_Cita)
        {
            List<OrdenMedica> oListaOrdenMedica = new List<OrdenMedica>();
            ConexionBD objEst = new ConexionBD();
            string sentencia = "EXECUTE SP_CONSULTAR_ORDEN_MEDICA " + Id_Cita ;
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaOrdenMedica.Add(new OrdenMedica()
                    {
                        Id_Cita = Convert.ToInt32(dr["Id_Cita"]),
                        Id_Medico = Convert.ToInt32(dr["Id_Medico"]),
                        Id_Examen = Convert.ToInt32(dr["Id_Examen"]),
                        Medicamento = dr["Medicamento"].ToString(),
                        Observaciones = dr["Observaciones"].ToString()

                    });
                }
                return oListaOrdenMedica;
            }
            else
            {
                return oListaOrdenMedica;
            }
        }
    }
}
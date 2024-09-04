using ProyectoSESS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoSESS.Data
{
    public class ServicioData
    {
        public static bool InsertarServicio(Servicio oservicio) 
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia = "EXECUTE SP_INSERTAR_SERVICIO " + oservicio.Id_Servicio + "," + oservicio.Id_Tiposervicio
           + ",'" + oservicio.Consulta_Servicio + "','" + oservicio.Estado_Servicio + "'";
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
        public static bool Actualizarservicio(Servicio oservicio)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia = "EXECUTE SP_ACTUALIZAR_SERVICIO " + oservicio.Id_Servicio + "," + oservicio.Id_Tiposervicio         
           + ",'" + oservicio.Consulta_Servicio + "','" + oservicio.Estado_Servicio + "'";

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

        public static bool Eliminarservicio(int Id_servicio)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia = "EXECUTE SP_ELIMINAR_SERVICIO " + Id_servicio ;
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

        public static List<Servicio> Listarservicio()
        {
            List<Servicio> oListarservicio = new List<Servicio>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_Listar_Servicio ";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarservicio.Add(new Servicio()
                    {
                        Id_Servicio = Convert.ToInt32(dr["Id_Servicio"]),
                        Id_Tiposervicio = Convert.ToInt32(dr["Id_Tiposervicio"]),
                        Consulta_Servicio = dr["Consulta_Servicio"].ToString(),
                        Estado_Servicio = dr["Estado_Servicio"].ToString()

                    });
                }
                return oListarservicio;
            }
            else
            {
                return oListarservicio;
            }
        }

        public static List<Servicio> Obtenerservico(int Id_Servicio)
        {
            List<Servicio> oListaServicio = new List<Servicio>();
            ConexionBD objEst = new ConexionBD();
            string sentencia = "EXECUTE SP_CONSULTAR_SERVICIO " + Id_Servicio ;
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaServicio.Add(new Servicio()
                    {
                        Id_Servicio = Convert.ToInt32(dr["Id_Servicio"]),
                        Id_Tiposervicio = Convert.ToInt32(dr["Id_Tipo de servicio"]),
                        Consulta_Servicio = dr["Consulta_Servicio"].ToString(),
                        Estado_Servicio = dr["Estado_Servicio"].ToString()

                    });
                }
                return oListaServicio;
            }
            else
            {
                return oListaServicio;
            }
        }
    }
}
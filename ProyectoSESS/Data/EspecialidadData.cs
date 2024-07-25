using ProyectoSESS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoSESS.Data
{
    public class EspecialidadData
    {
        public static bool InsertarEspecialidad(Especialidad oEspecialidad)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_INSERTAR_ESPECIALIDAD '" + oEspecialidad.Id_Especialidad + "','" + oEspecialidad.Nombre_Especialidad + "'";

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

        public static bool ActualizarEspecialidad(Especialidad oEspecialidad)
        {
            ConexionBD objEst = new ConexionBD();

            string sentencia = "EXECUTE SP_ACTUALIZAR_ESPECIALIDAD " + oEspecialidad.Id_Especialidad + ",'" + oEspecialidad.Nombre_Especialidad + "'";

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

        public static bool EliminarEspecialidad(string id)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;

            sentencia = "EXECUTE SP_ELIMINAR_ESPECIALIDAD '" + id + "'";
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

        public static List<Especialidad> Listar()
        {
            List<Especialidad> oEspecialidad = new List<Especialidad>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_Listar_Especialidad";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oEspecialidad.Add(new Especialidad()
                    {
                        Id_Especialidad = Convert.ToInt32(dr["Id_Especialidad"]),
                        Nombre_Especialidad = dr["Nombre_Especialidad"].ToString()
                    });
                }
                return oEspecialidad;
            }
            else
            {
                return oEspecialidad;
            }
        }

        public static List<Especialidad> Consultar(string id)
        {
            List<Especialidad> oEspecialidad = new List<Especialidad>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Consultar_Especialidad '" + id + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oEspecialidad.Add(new Especialidad()
                    {

                        Id_Especialidad = Convert.ToInt32(dr["Id_Especialidad"]),
                        Nombre_Especialidad = dr["Nombre_Especialidad"].ToString()
                    });
                }
                return oEspecialidad;
            }
            else
            {
                return oEspecialidad;
            }
        }
    }
}
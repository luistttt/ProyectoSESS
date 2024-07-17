using ProyectoSESS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoSESS.Data
{
    public class ConsultorioData
    {
        public static bool InsertarConsultorio(Consultorio oConsultorio)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_Insertar_Consultorio '" + oConsultorio.IdConsultorio + "','" + oConsultorio.Numero_Consultorio + "'";

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

        public static bool ActualizarConsultorio(Consultorio oConsultorio)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Actualizar_Consultorio '" + oConsultorio.IdConsultorio + "','" + oConsultorio.Numero_Consultorio + "'";

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

        public static bool EliminarConsultorio(string id)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;

            sentencia = "EXECUTE Eliminar_Consultorio '" + id + "'";
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

        public static List<Consultorio> Listar()
        {
            List<Consultorio> oListaConsultorio = new List<Consultorio>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_Listar_Consultorio";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaConsultorio.Add(new Consultorio()
                    {
                        IdConsultorio = Convert.ToInt32(dr["ID_Consultorio"]),
                        Numero_Consultorio = Convert.ToInt32(dr["Numero_Consultorio"])
                    });
                }
                return oListaConsultorio;
            }
            else
            {
                return oListaConsultorio;
            }
        }

        public static List<Consultorio> Consultar(string id)
        {
            List<Consultorio> oListaConsultorio = new List<Consultorio>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Consultar_Consultorio '" + id + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaConsultorio.Add(new Consultorio()
                    {

                        IdConsultorio = Convert.ToInt32(dr["ID_Consultorio"]),
                        Numero_Consultorio = Convert.ToInt32(dr["Numero_Consultorio"])
                    });
                }
                return oListaConsultorio;
            }
            else
            {
                return oListaConsultorio;
            }
        }
    }
}
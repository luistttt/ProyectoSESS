using ProyectoSESS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static System.Net.WebRequestMethods;

namespace ProyectoSESS.Data
{
    public class CargoData
    {
        public static bool InsertarCargo(Cargo oCargo)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_Insertar_Cargo '" + oCargo.Id_Cargo + "','" + oCargo.Nombre_Cargo + "'";

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

        public static bool ActualizarCargo(Cargo oCargo)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia = "EXECUTE SP_ACTUALIZAR_Cargo " + oCargo.Id_Cargo + ",'" + oCargo.Nombre_Cargo + "'";

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

        public static bool EliminarCargo(string id)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;

            sentencia = "EXECUTE SP_Eliminar_Cargo '" + id + "'";
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

        public static List<Cargo> Listar()
        {
            List<Cargo> oListaCargo = new List<Cargo>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_Listar_Cargo";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaCargo.Add(new Cargo()
                    {
                        Id_Cargo = Convert.ToInt32(dr["Id_Cargo"]),
                        Nombre_Cargo = dr["Nombre_Cargo"].ToString()
                    });
                }
                return oListaCargo;
            }
            else
            {
                return oListaCargo;
            }
        }

        public static List<Cargo> Consultar(string id)
        {
            List<Cargo> oListaCargo = new List<Cargo>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_Consultar_Cargo '" + id + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaCargo.Add(new Cargo()
                    {

                        Id_Cargo = Convert.ToInt32(dr["Id_Cargo"]),
                        Nombre_Cargo = dr["Nombre_Cargo"].ToString()
                    });
                }
                return oListaCargo;
            }
            else
            {
                return oListaCargo;
            }
        }
    }
}
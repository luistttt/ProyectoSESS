using ProyectoSESS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoSESS.Data
{
    public class EmpleadoData
    {
        public static bool InsertarEmpleado(Empleado oEmpleado)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_INSERTAR_EMPLEADO '" + oEmpleado.Id_Empleado + "','" + oEmpleado.Nombre_Empleado + "','" + oEmpleado.Apellido_Empleado + "','" + oEmpleado.Id_Cargo + "','" + oEmpleado.Direccion_Empleado + "','" + oEmpleado.Telefono_Empleado + "','" + oEmpleado.Estado_Empleado + "'";

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

        public static bool ActualizarEmpleado(Empleado oEmpleado)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_ACTUALIZAR_EMPLEADO '" + oEmpleado.Id_Empleado + "','" + oEmpleado.Nombre_Empleado + "','" + oEmpleado.Apellido_Empleado + "','" + oEmpleado.Id_Cargo + "','" + oEmpleado.Direccion_Empleado + "','" + oEmpleado.Telefono_Empleado + "','" + oEmpleado.Estado_Empleado + "'";

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

        public static bool EliminarEmpleado(string id)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;

            sentencia = "EXECUTE SP_ELIMINAR_EMPLEADO '" + id + "'";
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

        public static List<Empleado> Listar()
        {
            List<Empleado> oListaEmpleado = new List<Empleado>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_Listar_Empleado";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaEmpleado.Add(new Empleado()
                    {
                        Id_Empleado = Convert.ToInt32(dr["Id_Empleado"]),
                        Nombre_Empleado = dr["Nombre_Empleado"].ToString(),
                        Apellido_Empleado = dr["Apellido_Empleado"].ToString(),
                        Id_Cargo = Convert.ToInt32(dr["Id_Cargo"]),
                        Direccion_Empleado = dr["Direccion_Empleado"].ToString(),
                        Telefono_Empleado = Convert.ToInt32(dr["Telefono_Empleado"]),
                        Estado_Empleado = dr["Estado_Empleado"].ToString()
                    });
                }
                return oListaEmpleado;
            }
            else
            {
                return oListaEmpleado;
            }
        }

        public static List<Empleado> Consultar(string id)
        {
            List<Empleado> oListaEmpleado = new List<Empleado>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_CONSULTAR_EMPLEADO '" + id + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaEmpleado.Add(new Empleado()
                    {

                        Id_Empleado = Convert.ToInt32(dr["Id_Empleado"]),
                        Nombre_Empleado = dr["Nombre_Empleado"].ToString(),
                        Apellido_Empleado = dr["Apellido_Empleado"].ToString(),
                        Id_Cargo = Convert.ToInt32(dr["Id_Cargo"]),
                        Direccion_Empleado = dr["Direccion_Empleado"].ToString(),
                        Telefono_Empleado = Convert.ToInt32(dr["Telefono_Empleado"]),
                        Estado_Empleado = dr["Estado_Empleado"].ToString()
                    });
                }
                return oListaEmpleado;
            }
            else
            {
                return oListaEmpleado;
            }
        }
    }
}
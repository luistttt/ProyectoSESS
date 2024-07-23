using ProyectoSESS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoSESS.Data
{
    public class MedicoData
    {
        public static bool InsertarMedico(Medico oMedico)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_Insertar_Medico'" + oMedico.Id_Medico + "','" + oMedico.Id_Empleado
           + "','" + oMedico.Id_Especialidad + "','" + oMedico.Numero_Consultorio + "','" + oMedico.Estado_Medico + "'";
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

        public static bool ActualizarMedico(Medico oMedico)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_Actualizar_Medico'" + oMedico.Id_Medico + "','" + oMedico.Id_Empleado
           + "','" + oMedico.Id_Especialidad + "','" + oMedico.Numero_Consultorio + "','" + oMedico.Estado_Medico + "'";

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

        public static bool EliminarMedico(int Id_medico)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Sp_Eliminar_Medico '" + Id_medico + "'";
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

        public static List<Medico> ListarMedico()
        {
            List<Medico> oListarMedico = new List<Medico>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_Listar_Medico";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarMedico.Add(new Medico()
                    {
                        Id_Medico = Convert.ToInt32(dr["Id_Medico"]),
                        Id_Empleado = Convert.ToInt32(dr["Id_Empleado"]),
                        Id_Especialidad = Convert.ToInt32(dr["Id_Especialidad"]),
                        Numero_Consultorio = Convert.ToInt32(dr["Numero_Consultorio"]),
                        Estado_Medico = dr["Estado_Medico"].ToString()

                    });
                }
                return oListarMedico;
            }
            else
            {
                return oListarMedico;
            }
        }

        public static List<Medico> ObtenerMedico(string Id_Medico)
        {
            List<Medico> oListaMedico = new List<Medico>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Consultar_Medico "+ Id_Medico;
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaMedico.Add(new Medico()
                    {

                        Id_Medico = Convert.ToInt32(dr["Id_Medico"]),
                        Id_Empleado = Convert.ToInt32(dr["Id_Empleado"]),
                        Id_Especialidad = Convert.ToInt32(dr["Id_Especialidad"]),
                        Numero_Consultorio = Convert.ToInt32(dr["Numero_Consultorio"]),
                        Estado_Medico = dr["Estado_Medico"].ToString()
                    });
                }
                return oListaMedico;
            }
            else
            {
                return oListaMedico;
            }
        }
    }
}
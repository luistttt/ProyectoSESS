using ProyectoSESS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoSESS.Data
{
    public class Horario_MedicoData
    {
        public static bool Insertar_Horario_Medico(Horario_Medico oHorario_Medico)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Insertar_Horario_Medico'" + oHorario_Medico.Id_Horario + "','" + oHorario_Medico.Id_Medico
           + "','" + oHorario_Medico.Fecha_Horario + "','" + oHorario_Medico.Estado_Horario + "'";
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



        public static bool Actualizar_Horario_Medico(Horario_Medico oHorario_Medico)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Actualizar_Horario_Medico'" + oHorario_Medico.Id_Horario + "','" + oHorario_Medico.Id_Medico + "','" + oHorario_Medico.Fecha_Horario
                + "','" + oHorario_Medico.Estado_Horario + "'";

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

        public static List<Horario_Medico> Listar_Horario_Medico()
        {
            List<Horario_Medico> oListar_Horario_Medico = new List<Horario_Medico>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_Listar_Horario_Medico";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListar_Horario_Medico.Add(new Horario_Medico()
                    {
                        Id_Horario = Convert.ToInt32(dr["Id_Horario"]),
                        Id_Medico = Convert.ToInt32(dr["Id_Medico"]),
                        Fecha_Horario = Convert.ToDateTime(dr["Fecha_Horario"].ToString()),
                        Estado_Horario = dr["Estado_horario"].ToString()
                    });
                }
                return oListar_Horario_Medico;
            }
            else
            {
                return oListar_Horario_Medico;
            }
        }

        public static List<Horario_Medico> Obtener_Horario_Medico(string Id_Horario)
        {
            List<Horario_Medico> oObtener_Horario_Medico = new List<Horario_Medico>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Consultar_Horario_Medico " + Id_Horario ;
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oObtener_Horario_Medico.Add(new Horario_Medico()
                    {
                        Id_Horario = Convert.ToInt32(dr["Id_Horario"]),
                        Id_Medico = Convert.ToInt32(dr["Id_Medico"]),
                        Fecha_Horario = Convert.ToDateTime(dr["Fecha_Horario"].ToString()),
                        Estado_Horario = dr["Estado_Horario"].ToString()
                    });
                }
                return oObtener_Horario_Medico;
            }
            else
            {
                return oObtener_Horario_Medico;
            }
        }

        public static bool Eliminar_Horario_Medico(int Id_Horario)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;

            sentencia = "EXECUTE Eliminar_HorarioMedico '" + Id_Horario + "'";
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
    }
}
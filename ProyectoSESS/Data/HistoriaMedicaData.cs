using ProyectoSESS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;

namespace ProyectoSESS.Data
{
    public class HistoriaMedicaData
    {
        public static bool InsertarHistoriaMedica(HistoriaMedica oHistoriaMedica)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_INSERTAR_HISTORIA_MEDICA'" + oHistoriaMedica.Id_Historia + "','" + oHistoriaMedica.Id_Paciente
           + "','" + oHistoriaMedica.Id_Medico + "','" + oHistoriaMedica.Fecha_Ingreso + "','" + oHistoriaMedica.Estado_Historia + 
           "','" + oHistoriaMedica.Concepto +"','" +oHistoriaMedica.Observaciones + "'";
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

       
        public static bool ActualizarHistoriaMedica(HistoriaMedica oHistoriaMedica)
        {
            ConexionBD objEst = new ConexionBD();

            string fechaFormateada = oHistoriaMedica.Fecha_Ingreso.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            string sentencia = "EXECUTE SP_ACTUALIZAR_HISTORIA_MEDICA " + oHistoriaMedica.Id_Historia + "," + oHistoriaMedica.Id_Paciente
           + ",'" + fechaFormateada + "','" + oHistoriaMedica.Estado_Historia +
           "','" + oHistoriaMedica.Concepto + "','" + oHistoriaMedica.Observaciones + "'";

            
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

        public static bool EliminarHistoriaMedica(int Id_historia)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_ELIMINAR_HISTORIA_MEDICA '" + Id_historia + "'";
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

        public static List<HistoriaMedica> ListarHistoriaMedica()
        {
            List<HistoriaMedica> oListarHistoriaMedica = new List<HistoriaMedica>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_Listar_Historia_Medica";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarHistoriaMedica.Add(new HistoriaMedica()
                    {
                        Id_Historia = Convert.ToInt32(dr["Id_Historia"]),
                        Id_Medico = Convert.ToInt32(dr["Id_Medico"]),
                        Id_Paciente = Convert.ToInt32(dr["Id_Paciente"]),
                        Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString()),
                        Concepto = dr["Concepto"].ToString(),
                        Observaciones = dr["Observaciones"].ToString()

                    });
                }
                return oListarHistoriaMedica;
            }
            else
            {
                return oListarHistoriaMedica;
            }
        }

        public static List<HistoriaMedica> ObtenerHistoriaMedica(int Id_Historia)
        {
            List<HistoriaMedica> oListaHistoriaMedica = new List<HistoriaMedica>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_CONSULTAR_HISTORIA_MEDICA " + Id_Historia;
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaHistoriaMedica.Add(new HistoriaMedica()
                    {

                        Id_Historia = Convert.ToInt32(dr["Id_Historia"]),
                        Id_Medico = Convert.ToInt32(dr["Id_Medico"]),
                        Id_Paciente = Convert.ToInt32(dr["Id_Paciente"]),
                        Fecha_Ingreso = Convert.ToDateTime(dr["Fecha_Ingreso"].ToString()),
                        Concepto = dr["Concepto"].ToString(),
                        Observaciones = dr["Observaciones"].ToString()
                    });
                }
                return oListaHistoriaMedica;
            }
            else
            {
                return oListaHistoriaMedica;
            }
        }
    }
}
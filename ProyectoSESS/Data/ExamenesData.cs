using ProyectoSESS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;

namespace ProyectoSESS.Data
{
    public class ExamenesData
    {
        public static bool InsertarExamenes(Examenes oExamenes)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_Insertar_Examenes'" + oExamenes.Id_Cita + "','" + oExamenes.Id_Servicio
           + "','" + oExamenes.Nota_Medica + "','" + oExamenes.Fecha_examen + "','" + oExamenes.Resultados + "'";
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

        public static bool ActualizarExamenes(Examenes oExamenes)
        {
            ConexionBD objEst = new ConexionBD();

            string fechaFormateada = oExamenes.Fecha_examen.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            string sentencia = "EXECUTE SP_Actualizar_Examenes " + oExamenes.Id_Cita + "," + oExamenes.Id_Servicio
           + ",'" + oExamenes.Nota_Medica + "','" + fechaFormateada + "'," + oExamenes.Resultados + "";

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

        public static List<Examenes> ListarExamenes()
        {
            List<Examenes> oListarExamenes = new List<Examenes>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_Listar_Examenes";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarExamenes.Add(new Examenes()
                    {
                        Id_Cita = Convert.ToInt32(dr["Id_Cita"]),
                        Id_Servicio = Convert.ToInt32(dr["Id_Servicio"]),
                        Nota_Medica = dr["Nota_Medica"].ToString(),
                        Fecha_examen = Convert.ToDateTime(dr["Fecha_Examen"].ToString()),
                        Resultados = dr["Resultados"].ToString()

                    });
                }
                return oListarExamenes;
            }
            else
            {
                return oListarExamenes;
            }
        }

        public static List<Examenes> ObtenerExamen(int Id_Cita)
        {
            List<Examenes> oListarExamenes = new List<Examenes>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_Consultar_Examenes'" + Id_Cita + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarExamenes.Add(new Examenes()
                    {

                        Id_Cita = Convert.ToInt32(dr["Id_Cita"]),
                        Id_Servicio = Convert.ToInt32(dr["Id_Servicio"]),
                        Nota_Medica = dr["Fecha_Examen"].ToString(),
                        Fecha_examen = Convert.ToDateTime(dr["Fecha_Examen"].ToString()),
                        Resultados = dr["Resultados"].ToString()
                    });
                }
                return oListarExamenes;
            }
            else
            {
                return oListarExamenes;
            }
        }
    }
}
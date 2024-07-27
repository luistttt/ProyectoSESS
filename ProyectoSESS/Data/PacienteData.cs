using ProyectoSESS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;

namespace ProyectoSESS.Data
{
    public class PacienteData
    {
        public static bool InsertarPaciente(Paciente oPaciente)
        {
            string fechaFormateada = oPaciente.Fecha_Nacimiento.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
        
            ConexionBD objEst = new ConexionBD();
            string sentencia = "EXECUTE SP_Insertar_Paciente " + oPaciente.Id_Paciente + ",'" + oPaciente.Nombre_Paciente
                + "','" + oPaciente.Apellido_Paciente + "','" + oPaciente.Direccion_Paciente + "','" + oPaciente.Correo +
                "','" + fechaFormateada + "','" + oPaciente.Estado_Paciente + "'";
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

        public static bool ActualizarPaciente(Paciente oPaciente)
        {
            ConexionBD objEst = new ConexionBD();

            string fechaFormateada = oPaciente.Fecha_Nacimiento.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            string sentencia = "EXECUTE SP_Actualizar_Paciente " + oPaciente.Id_Paciente + ",'" + oPaciente.Nombre_Paciente
           + "','" + oPaciente.Apellido_Paciente + "','" + oPaciente.Direccion_Paciente + "','" + oPaciente.Correo + "','"
           + fechaFormateada + "','" + oPaciente.Estado_Paciente + "'";

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

        public static bool EliminarPaciente(int Id_Paciente)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia = "EXECUTE SP_Eliminar_Paciente " + Id_Paciente ;
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

        public static List<Paciente> ListarPaciente()
        {
            List<Paciente> oListarPaciente = new List<Paciente>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE SP_Listar_Paciente";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListarPaciente.Add(new Paciente()
                    {
                        Id_Paciente = Convert.ToInt32(dr["Id_Paciente"]),
                        Nombre_Paciente = dr["Nombre_Paciente"].ToString(),
                        Apellido_Paciente = dr["Apellido_Paciente"].ToString(),
                        Direccion_Paciente = dr["Direccion_Paciente"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        Fecha_Nacimiento = Convert.ToDateTime(dr["Fecha_Nacimiento"].ToString()),
                        Estado_Paciente = dr["Estado_Paciente"].ToString()

                    });
                }
                return oListarPaciente;
            }
            else
            {
                return oListarPaciente;
            }
        }

        public static List<Paciente> ConsultarPaciente(int Id_Paciente)
        {
            List<Paciente> oListaPaciente = new List<Paciente>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE Consultar_Paciente'" + Id_Paciente + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaPaciente.Add(new Paciente()
                    {
                        Id_Paciente = Convert.ToInt32(dr["Id_Paciente"]),
                        Nombre_Paciente = dr["Nombre_Paciente"].ToString(),
                        Apellido_Paciente = dr["Apellido_Paciente"].ToString(),
                        Direccion_Paciente = dr["Direccion_Paciente"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        Fecha_Nacimiento = Convert.ToDateTime(dr["Fecha_Nacimiento"].ToString()),
                        Estado_Paciente = dr["Estado_Paciente"].ToString()

                    });
                }
                return oListaPaciente;
            }
            else
            {
                return oListaPaciente;
            }
        }
    }
}
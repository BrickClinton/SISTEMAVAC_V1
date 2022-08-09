using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Libreria del NET.FRAMEWORK
using System.Data;
using System.Data.SqlClient;

// Libreria personal
using DAL;

namespace BOL
{
    public class Rol
    {
        // Objeto de conexión
        DbAccess conn = new DbAccess();

        // Método listar
        public DataTable listarRoles()
        {
            // Objeto datatable
            DataTable tabla = new DataTable();

            // Abrir conexión
            conn.abrirConexion();

            // Indicar la instrucción sql y la conexión activa
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM roles", conn.getConexion());
            adaptador.Fill(tabla);

            // Cerrar conexión
            conn.cerrarConexion();

            // Valor de retorno
            return tabla;
        }

        // Método registrar
        public String registrarRol(String rol)
        {
            // Instancia comando, indicar la instrucción sql y la conexion activa
            SqlCommand comando = new SqlCommand("INSERT INTO roles (rol) VALUES (@rol)", conn.getConexion());
            comando.CommandType = CommandType.Text;

            // Abrir conexión
            conn.abrirConexion();

            // Capturar el Error 
            string error = "";

            // Manejador de excepción
            try
            {
                // Valores de los parametros
                comando.Parameters.AddWithValue("@rol", rol);

                // Ejecutar consulta
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                // Error capturado
                error = ex.Message;
            }

            // Cerrar conexión
            conn.cerrarConexion();

            // Valor de retorno
            return error;  
        }
        

        // Método actualizar
        public String actualizarRol(String rol, int idrol)
        {
            // Instancia comando, indicar la instrucción sql y la conexion activa
            SqlCommand comando = new SqlCommand("UPDATE roles SET rol = @rol WHERE idrol = @idrol", conn.getConexion());
            comando.CommandType = CommandType.Text;

            // Abrir conexión
            conn.abrirConexion();

            // Capturar el Error 
            string error = "";

            // Manejador de excepción
            try
            {
                // Valores de los parametros
                comando.Parameters.AddWithValue("@rol", rol);
                comando.Parameters.AddWithValue("@idrol", idrol);

                // Ejecutar consulta
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                // Error capturado
                error = ex.Message;
            }

            // Cerrar conexión
            conn.cerrarConexion();

            // Valor de retorno
            return error;
        }

        // Método eliminar
        public String eliminarRol(int idrol)
        {
            // Instancia comando, indicar la instrucción sql y la conexion activa
            SqlCommand comando = new SqlCommand("DELETE FROM roles WHERE idrol = @idrol", conn.getConexion());
            comando.CommandType = CommandType.Text;

            // Abrir conexión
            conn.abrirConexion();

            // Capturar el Error 
            string error = "";

            // Manejador de excepción
            try
            {
                // Valores de los parametros
                comando.Parameters.AddWithValue("@idrol", idrol);
                // Ejecutar consulta
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }

            // Cerrar conexión
            conn.cerrarConexion();

            // Valor retornado
            return error;
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;

// Libreira basada en mi propio proyecto
using DAL;
using ENTITIES;

namespace BOL
{
	public class Persona
	{
		// Instancia de la clase conexión
		DbAccess conn = new DbAccess();
		
		// Método listar
		public DataTable listarPersonas(){
			// Instancia datatable
			DataTable tabla = new DataTable();
			
			// Abrir conexión
			conn.abrirConexion();
			
			// Indicar la instrucción sql y la conexión activa
			SqlDataAdapter adaptador = new SqlDataAdapter("SPU_PERSONAS_LISTAR", conn.getConexion());
			adaptador.Fill(tabla);
			
			// Cerrar conexión
			conn.cerrarConexion();
			
			// Valor retornado
			return tabla;
		}
		
		// Método registrar
		public String registrarPersona(EPersona epersona){
			// Instancia comando, indicar la instrucción sql y la conexion activa
			SqlCommand comando = new SqlCommand("SPU_PERSONAS_REGISTRAR", conn.getConexion());
			comando.CommandType = CommandType.StoredProcedure;
			
			// Abrir conexión
			conn.abrirConexion();

			// Capturar el Error 
			string error = "";

			// Manejador de excepción
			try
			{
				// Valores de los parametros
				comando.Parameters.AddWithValue("@apellidos", epersona.apellidos);
				comando.Parameters.AddWithValue("@nombres", epersona.nombres);
				comando.Parameters.AddWithValue("@tipodocumento", epersona.tipodocumento);
				comando.Parameters.AddWithValue("@nrodocumento", epersona.nrodocumento);
				comando.Parameters.AddWithValue("@telefono", epersona.telefono);

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
		public String actualizarPersona(EPersona epersona){
			// Instancia comando, indicar la instrucción sql y la conexion activa
			SqlCommand comando = new SqlCommand("SPU_PERSONAS_ACTUALIZAR", conn.getConexion());
			comando.CommandType = CommandType.StoredProcedure;
			
			// Abrir conexión
			conn.abrirConexion();

			// Capturar el Error 
			string error = "";

			// Manejador de excepción
			try
			{
				// Valores de los parametros
				comando.Parameters.AddWithValue("@apellidos", epersona.apellidos);
				comando.Parameters.AddWithValue("@nombres", epersona.nombres);
				comando.Parameters.AddWithValue("@tipodocumento", epersona.tipodocumento);
				comando.Parameters.AddWithValue("@nrodocumento", epersona.nrodocumento);
				comando.Parameters.AddWithValue("@telefono", epersona.telefono);
				comando.Parameters.AddWithValue("@idpersona", epersona.idpersona);

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
		public String eliminarPerosna(int idpersona){
			// Instancia comando, indicar la instrucción sql y la conexion activa
			SqlCommand comando = new SqlCommand("SPU_PERSONAS_ELIMINAR", conn.getConexion());
			comando.CommandType = CommandType.StoredProcedure;
			
			// Abrir conexión
			conn.abrirConexion();

			// Capturar el Error 
			string error = "";

			// Manejador de excepción
			try
			{
				// Valores de los parametros
				comando.Parameters.AddWithValue("@idpersona", idpersona);
				// Ejecutar consulta
				comando.ExecuteNonQuery();
			}
			catch (SqlException ex)
			{
				error = ex.Message;
			}

			// Cerrar conexión
			conn.cerrarConexion();

			// error
			return error;
		}
	}
}

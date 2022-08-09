using System;
using System.Data;
using System.Data.SqlClient;

// Libreria basada en mi propio proyecto
using DAL;

namespace BOL
{
	public class Laboratorio
	{
		// Este objeto representa la conexión activa
		DbAccess conn = new DbAccess();
		
		// Método listar
		public DataTable listarLaboratorios(){
			// Instancia de la clase databla
			DataTable tabla = new DataTable();
			
			// Abrir conexión 
			conn.abrirConexion();
			
			SqlDataAdapter adaptador = new SqlDataAdapter("SPU_LABORATORIOS_LISTAR", conn.getConexion());
			adaptador.Fill(tabla);
			
			// Cerrar conexión
			conn.cerrarConexion();
			
			// Valor de retorno
			return tabla;
		}
		
		// Registrar
		public String registrarLaboratorio(String laboratorio, String pais){
			// Indicar la instruccion sql
			SqlCommand comando = new SqlCommand("SPU_LABORATORIOS_REGISTRAR", conn.getConexion());
			comando.CommandType = CommandType.StoredProcedure;
			
			// Abrir conexión
			conn.abrirConexion();

			// Capturar el Error 
			string error = "";

			// Manejador de excepción
			try
			{
				// Pasando valor de los parametros
				comando.Parameters.AddWithValue("@laboratorio", laboratorio);
				comando.Parameters.AddWithValue("@pais", pais);

				// Ejecutar la consulta
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
		
		// Actualizar datos
		public String actualizarLaboratorio(String laboratorio, String pais, int idlaboratorio){
			// Indicar la instrucción sql
			SqlCommand comando = new SqlCommand("SPU_LABORATORIOS_ACTUALIZAR", conn.getConexion());
			comando.CommandType = CommandType.StoredProcedure;
			
			// Abrir conexión
			conn.abrirConexion();

			// Capturar el Error 
			string error = "";

			// Manejador de excepción
			try
			{
				comando.Parameters.AddWithValue("@laboratorio", laboratorio);
				comando.Parameters.AddWithValue("@pais", pais);
				comando.Parameters.AddWithValue("@idlaboratorio", idlaboratorio);

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
		
		// Eliminar laboratorio
		public String eliminarLaboratorio(int idlaboratorio){
			// Indicar la instrucción sql
			SqlCommand comando = new SqlCommand("SPU_LABORATORIOS_ELIMINAR", conn.getConexion());
			comando.CommandType = CommandType.StoredProcedure;
			
			// Abrir conexión
			conn.abrirConexion();

			// Capturar el Error 
			string error = "";

			// Manejador de excepción
			try
			{
				// Valor del parametro
				comando.Parameters.AddWithValue("@idlaboratorio", idlaboratorio);
				// Ejecutar consulta
				comando.ExecuteNonQuery();
			}
			catch (SqlException ex)
			{
				error = ex.Message;
			}

			// Cerrar conexión
			conn.cerrarConexion();

			// Error
			return error;
		}
	}
}

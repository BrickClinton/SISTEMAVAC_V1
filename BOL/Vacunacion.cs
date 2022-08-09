using System;
using System.Data;
using System.Data.SqlClient;

// Libreira basada en mi propio proyecto
using DAL;
using ENTITIES;

namespace BOL
{
	public class Vacunacion
	{
		// Instancia de la clase conexión 
		DbAccess conn = new DbAccess();
		
		// Método listar
		public DataTable listarVacunaciones(){
			// Instancia datatable
			DataTable tabla = new DataTable();
			
			// Abrir conexión
			conn.abrirConexion();
			
			// Objeto adaptador, indicar instrucción sql y la conexiín
			SqlDataAdapter adaptador = new SqlDataAdapter("SPU_VACUNACION_LISTAR", conn.getConexion());
			adaptador.Fill(tabla);
			
			// Cerrar conexión
			conn.cerrarConexion();
			
			// Valor retornado
			return tabla;
		}
		
		// Método registrar
		public String registrarVacunacion(EVacunacion evacunacion){
			// Objeto comando, indicar instrucción sql y la conexión
			SqlCommand comando = new SqlCommand("SPU_VACUNACION_REGISTRAR", conn.getConexion());
			comando.CommandType = CommandType.StoredProcedure;
			
			// Abrir conexión
			conn.abrirConexion();

			// Capturar el Error 
			string error = "";

			// Manejador de excepción
			try
			{
				// Valor de los párametros
				comando.Parameters.AddWithValue("@idatendido", evacunacion.idatendido);
				comando.Parameters.AddWithValue("@idresponsable", evacunacion.idresponsable);
				comando.Parameters.AddWithValue("@idstockvac", evacunacion.idstockvac);
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
		public String actualizarVacunacion(EVacunacion evacunacion){
			// Objeto comando, indicar instrucción sql y la conexión
			SqlCommand comando = new SqlCommand("SPU_VACUNACION_ACTUALIZAR", conn.getConexion());
			comando.CommandType = CommandType.StoredProcedure;
			
			// Abrir conexión
			conn.abrirConexion();

			// Capturar el Error 
			string error = "";

			// Manejador de excepción
			try
			{
				// Valor de los párametros
				comando.Parameters.AddWithValue("@idatendido", evacunacion.idatendido);
				comando.Parameters.AddWithValue("@idresponsable", evacunacion.idresponsable);
				comando.Parameters.AddWithValue("@idstockvac", evacunacion.idstockvac);
				comando.Parameters.AddWithValue("@fechahoravac", evacunacion.fechahoravac);
				comando.Parameters.AddWithValue("@idvacunacion", evacunacion.idvacunacion);
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
		public String eliminarVacunacion(int idvacunacion){
			// Objeto comando, indicar instrucción sql y la conexión
			SqlCommand comando = new SqlCommand("SPU_VACUNACION_ELIMINAR", conn.getConexion());
			comando.CommandType = CommandType.StoredProcedure;
			
			// Abrir conexión
			conn.abrirConexion();

			// Capturar el Error 
			string error = "";

			// Manejador de excepción
			try
			{
				// Valor de los párametros
				comando.Parameters.AddWithValue("@idvacunacion", idvacunacion);
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

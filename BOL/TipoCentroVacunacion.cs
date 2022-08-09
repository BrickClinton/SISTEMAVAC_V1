using System;

// Librerias del .NET FRAMEWORK
using System.Data;
using System.Data.SqlClient;

// Libreria basada en mi propio proyecto
using DAL;

namespace BOL
{
	/// <summary>
	/// Description of TipoCentroVacunacion.
	/// </summary>
	public class TipoCentroVacunacion
	{
		// Objeto que contiene la conexiòn activa
		DbAccess conn = new DbAccess();
		
		// Mètodo listar
		public DataTable listarTipoCentroVacunacion(){
			// Instancia de la clase DataTable
			DataTable tabla = new DataTable();
			
			// Abrir conexión
			conn.abrirConexion();

			// Con el objeto adaptador indicamos la instrucción sql y la conexión activa
			SqlDataAdapter adaptador = new SqlDataAdapter("SPU_TIPOCENTROVAC_LISTAR", conn.getConexion());
			// Llenando al objeto tabla con los resultados
			adaptador.Fill(tabla);
			
			// Cerrar conexión
			conn.cerrarConexion();
			
			// Valor de retorno
			return tabla;
		}

		// Método registrar
		public String registrarTipoCentro(String tipocentro)
        {
			// Instancia comando, indicar la instrucción sql y la conexion activa
			SqlCommand comando = new SqlCommand("SPU_TIPOCENTROVAC_REGISTRAR", conn.getConexion());
			comando.CommandType = CommandType.StoredProcedure;

			// Abrir conexión
			conn.abrirConexion();

			// Capturar el Error 
			string error = "";

			// Manejador de excepción
			try
			{
				// Valores de los parametros
				comando.Parameters.AddWithValue("@tipocentro", tipocentro);
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
		public String actualizarTipoCentro(String tipocentro, int idtipocentro)
		{
			// Instancia comando, indicar la instrucción sql y la conexion activa
			SqlCommand comando = new SqlCommand("SPU_TIPOCENTROVAC_ACTUALIZAR", conn.getConexion());
			comando.CommandType = CommandType.StoredProcedure;

			// Abrir conexión
			conn.abrirConexion();

			// Capturar el Error 
			string error = "";

			// Manejador de excepción
			try
			{
				// Valores de los parametros
				comando.Parameters.AddWithValue("@tipocentro", tipocentro);
				comando.Parameters.AddWithValue("@idtipocentro", idtipocentro);
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
		public String eliminarTipoCentro(int idtipocentro)
		{
			// Instancia comando, indicar la instrucción sql y la conexion activa
			SqlCommand comando = new SqlCommand("SPU_TIPOCENTROVAC_ELIMINAR", conn.getConexion());
			comando.CommandType = CommandType.StoredProcedure;

			// Abrir conexión
			conn.abrirConexion();

			// Capturar el Error 
			string error = "";

			// Manejador de excepción
			try
			{
				// Valores de los parametros
				comando.Parameters.AddWithValue("@idtipocentro", idtipocentro);
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

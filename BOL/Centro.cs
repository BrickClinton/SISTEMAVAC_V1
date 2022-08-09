using System;

// Librerias del .NET FRAMEWORK
using System.Data;
using System.Data.SqlClient;

// Libreria basada en mi propio proyecto
using DAL;
using ENTITIES;

namespace BOL
{
	public class Centro
	{
		// Objeto que contiene la conexión activa
		DbAccess conn = new DbAccess();
		
		// Método para registrar centros
		public String registrarCentro(ECentro ecentro){
			// Ejecuta la consulta
			SqlCommand comando = new SqlCommand("SPU_CENTROVAC_REGISTRAR", conn.getConexion());
			// Especificar el tipo de consulta
			comando.CommandType = CommandType.StoredProcedure;
			
			// Abrir conexion
			conn.abrirConexion();

			// Capturar el Error 
			string error = "";

			// Manejador de excepción
			try
			{
				comando.Parameters.AddWithValue("@iddistrito", ecentro.iddistrito);
				comando.Parameters.AddWithValue("@idtipocentro", ecentro.idtipocentro);
				comando.Parameters.AddWithValue("@nombrecentro", ecentro.nombrecentro);
				comando.Parameters.AddWithValue("@direccion", ecentro.direccion);
				comando.Parameters.AddWithValue("@telefono", ecentro.telefono);

				// Ejecutar la consulta
				comando.ExecuteNonQuery();
			}
			catch (SqlException ex)
			{
				error = ex.Message;
			}

			// Cerrar conexion
			conn.cerrarConexion();

			// Valor de retorno
			return error;
		}

		// Método actualizar
		public String actualizarCentro(ECentro ecentro)
        {
			// Ejecuta la consulta
			SqlCommand comando = new SqlCommand("SPU_CENTROVAC_ACTUALIZAR", conn.getConexion());
			// Especificar el tipo de consulta
			comando.CommandType = CommandType.StoredProcedure;

			// Abrir conexion
			conn.abrirConexion();

			// Capturar el Error 
			string error = "";

			// Manejador de excepción
			try
			{
				comando.Parameters.AddWithValue("@iddistrito", ecentro.iddistrito);
				comando.Parameters.AddWithValue("@idtipocentro", ecentro.idtipocentro);
				comando.Parameters.AddWithValue("@nombrecentro", ecentro.nombrecentro);
				comando.Parameters.AddWithValue("@direccion", ecentro.direccion);
				comando.Parameters.AddWithValue("@telefono", ecentro.telefono);
				comando.Parameters.AddWithValue("@idcentrovac", ecentro.idcentro);

				// Ejecutar la consulta
				comando.ExecuteNonQuery();
			}
			catch (SqlException ex)
			{
				error = ex.Message;
			}

			// Cerrar conexion
			conn.cerrarConexion();

			// Valor de retorno
			return error;
		}
		
		// Método para listar
		public DataTable listarCentros(){
			// Objeto datatable
			DataTable listarCentros = new DataTable();
			
			// Abrir conexion
			conn.abrirConexion();
			
			SqlDataAdapter adaptador = new SqlDataAdapter("SPU_CENTROVAC_LISTAR", conn.getConexion());
			adaptador.Fill(listarCentros);
			
			// Cerrar conexion
			conn.cerrarConexion();
			
			return listarCentros;
		}
		
		// Método para obtener un solo registro
		public ECentro getCentro(int idcentrovac){
			// Instancia de la entidad
			ECentro ecentro = new ECentro();
			
			// Con el objeto comando indicamos la instrucción sql y la conexión activa
			SqlCommand comando = new SqlCommand("SPU_CENTROVAC_GETCENTROVAC", conn.getConexion());
			// Indicando el tipo de instrucción sql
			comando.CommandType = CommandType.StoredProcedure;
			
			// Abrir conexión
			conn.abrirConexion();
			
			// Parametro que necesita el SPU
			comando.Parameters.AddWithValue("@idcentrovac", idcentrovac);
			// ALmacenar los datos en el objeto
			//ecentro = comando.ExecuteReader();
			
			// Cerrar conexión
			conn.cerrarConexion();
			
			// Valor de retorno
			return ecentro;
		}
		
		// Método eliminar
		public String eliminarCentrovac(int idcentrovac){
			// con el objeto comando indicamos la instrcción SQL y la conexion
			SqlCommand comando = new SqlCommand("SPU_CENTROVAC_ELIMINAR", conn.getConexion());
			// Tipo de instrucción sql espesificada
			comando.CommandType = CommandType.StoredProcedure;
			
			//Abrir conexión
			conn.abrirConexion();

			// Capturar el Error 
			string error = "";

            // Manejador de excepción
            try
            {
				// Parametro requerido para el SPU
				comando.Parameters.AddWithValue("@idcentrovac", idcentrovac);
				// Ejecutando la instrucción sql
				comando.ExecuteNonQuery();
			}
            catch (SqlException ex)
            {
				error = ex.Message;
			}

			// Cerrar conexión
			conn.cerrarConexion();

			// Error obtenido
			return error;
		}
	}
}

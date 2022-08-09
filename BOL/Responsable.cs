using System;
using System.Data;
using System.Data.SqlClient;

// Libreria propia
using DAL;
using ENTITIES;

namespace BOL
{
	public class Responsable
	{
		// Instancia de la clase conexión
		DbAccess conn = new DbAccess();
		
		// Método listar
		public DataTable listarResponsables(){
			// Instancia datatable
			DataTable tabla = new DataTable();
			
			// Abrir conexión
			conn.abrirConexion();
			
			// Objeto adaptador, indicar instrucción sql y la conexiín
			SqlDataAdapter adaptador = new SqlDataAdapter("SPU_RESPONSABLES_LISTAR", conn.getConexion());
			adaptador.Fill(tabla);
			
			// Cerrar conexión
			conn.cerrarConexion();
			
			// Valor retornado
			return tabla;
		}
		
		// Método registrar
		public String registrarResponsable(EResponsable eresponsable){
			// Objeto comando, indicar instrucción sql y la conexión
			SqlCommand comando = new SqlCommand("SPU_RESPONSABLES_REGISTRAR", conn.getConexion());
			comando.CommandType = CommandType.StoredProcedure;
			
			// Abrir conexión
			conn.abrirConexion();

			// Capturar el Error 
			string error = "";

			// Manejador de excepción
			try
			{
				// Valor de los párametros
				comando.Parameters.AddWithValue("@idcentrovac", eresponsable.idcentrovac);
				comando.Parameters.AddWithValue("@idpersona", eresponsable.idpersona);
				comando.Parameters.AddWithValue("@idrol", eresponsable.idrol);
				comando.Parameters.AddWithValue("@fechaalta", eresponsable.fechalta);
				comando.Parameters.AddWithValue("@fechabaja", eresponsable.fechabaja);
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
		public String actualizarResponsable(EResponsable eresponsable){
			// Objeto comando, indicar instrucción sql y la conexión
			SqlCommand comando = new SqlCommand("SPU_RESPONSABLES_ACTUALIZAR", conn.getConexion());
			comando.CommandType = CommandType.StoredProcedure;
			
			// Abrir conexión
			conn.abrirConexion();

			// Capturar el Error 
			string error = "";

			// Manejador de excepción
			try
			{
				// Valor de los párametros
				comando.Parameters.AddWithValue("@idcentrovac", eresponsable.idcentrovac);
				comando.Parameters.AddWithValue("@idpersona", eresponsable.idpersona);
				comando.Parameters.AddWithValue("@idrol", eresponsable.idrol);
				comando.Parameters.AddWithValue("@fechaalta", eresponsable.fechalta);
				comando.Parameters.AddWithValue("@fechabaja", eresponsable.fechabaja);
				comando.Parameters.AddWithValue("@idresponsable", eresponsable.idresponsable);

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

		// Método listar por centro
		public DataTable listarPorCentro(int idcentro)
		{
			// Instancia datatable
			DataTable tabla = new DataTable();

			// Objeto adaptador, indicar instrucción sql y la conexiín
			SqlCommand comando = new SqlCommand("SPU_RESPONSABLE_FILTRAR_CENTRO", conn.getConexion());
			comando.CommandType = CommandType.StoredProcedure;

			// Abrir conexión
			conn.abrirConexion();

			comando.Parameters.AddWithValue("@idcentro", idcentro);
			tabla.Load(comando.ExecuteReader());

			// Cerrar conexión
			conn.cerrarConexion();

			// Valor retornado
			return tabla;
		}
		
		// Método eliminar
		public String eliminarResponsable(int idresponsable){
			// Objeto comando, indicar instrucción sql y la conexión
			SqlCommand comando = new SqlCommand("SPU_RESPONSABLES_ELIMINAR", conn.getConexion());
			comando.CommandType = CommandType.StoredProcedure;
			
			// Abrir conexión
			conn.abrirConexion();

			// Capturar el Error 
			string error = "";

			// Manejador de excepción
			try
			{
				// Valor de los párametros
				comando.Parameters.AddWithValue("@idresponsable", idresponsable);
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

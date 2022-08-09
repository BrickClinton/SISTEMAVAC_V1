using System;
using System.Data;
using System.Data.SqlClient;

// Libreria personal
using DAL;
using ENTITIES;

namespace BOL
{

	public class StockVac
	{
		// Instancia de clase noción
		DbAccess conn = new DbAccess();
		
		// Método listar
		public DataTable listarStockVacunas(){
			// Instancia datatable
			DataTable tabla = new DataTable();
			
			// Abrir conexión
			conn.abrirConexion();
			
			// Instancia Adapter, indicar instrución sql y la conexión activa
			SqlDataAdapter adaptador = new SqlDataAdapter("SPU_STOCKVACUNAS_LISTAR", conn.getConexion());
			adaptador.Fill(tabla);
			
			// Cerrar conexión
			conn.cerrarConexion();
			
			// Valor de retorno
			return tabla;
		}
		
		// Método registrar
		public String registrarStockVacunas(EStockVac estockvac){
			// Instancia comando, indicar instrucción sql y la conexión activa
			SqlCommand comando = new SqlCommand("SPU_STOCKVACUNAS_REGISTRAR", conn.getConexion());
			comando.CommandType = CommandType.StoredProcedure;
			
			// Abrir conexión
			conn.abrirConexion();

			// Capturar el Error 
			string error = "";

			// Manejador de excepción
			try
			{
				comando.Parameters.AddWithValue("@idlote", estockvac.idlote);
				comando.Parameters.AddWithValue("@idcentrovac", estockvac.idcentrovac);
				comando.Parameters.AddWithValue("@fechaasignacion", estockvac.fechaasignacion);
				comando.Parameters.AddWithValue("@cantidad", estockvac.cantidad);
				comando.Parameters.AddWithValue("@fechainicio", estockvac.fechainicio);
				comando.Parameters.AddWithValue("@fechafin", estockvac.fechafin);
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
		
		// Método actializar
		public String actualizarStockVacunas(EStockVac estockvac){
			// Instancia comando, indicar instrucción sql y la conexión activa
			SqlCommand comando = new SqlCommand("SPU_STOCKVACUNAS_ACTUALIZAR", conn.getConexion());
			comando.CommandType = CommandType.StoredProcedure;
			
			// Abrir conexión
			conn.abrirConexion();

			// Capturar el Error 
			string error = "";

			// Manejador de excepción
			try
			{
				comando.Parameters.AddWithValue("@idlote", estockvac.idlote);
				comando.Parameters.AddWithValue("@idcentrovac", estockvac.idcentrovac);
				comando.Parameters.AddWithValue("@fechaasignacion", estockvac.fechaasignacion);
				comando.Parameters.AddWithValue("@cantidad", estockvac.cantidad);
				comando.Parameters.AddWithValue("@fechainicio", estockvac.fechainicio);
				comando.Parameters.AddWithValue("@fechafin", estockvac.fechafin);
				comando.Parameters.AddWithValue("@idstockvac", estockvac.idstockvac);
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
		public String eliminarStockVacunas(int idstockvac){
			// Instancia comando, indicar instrucción sql y la conexión activa
			SqlCommand comando = new SqlCommand("SPU_STOCKVACUNAS_ELIMINAR", conn.getConexion());
			comando.CommandType = CommandType.StoredProcedure;
			
			// Abrir conexión
			conn.abrirConexion();

			// Capturar el Error 
			String error = "";

			// Manejador de excepción
			try
			{
				comando.Parameters.AddWithValue("@idstockvac", idstockvac);
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

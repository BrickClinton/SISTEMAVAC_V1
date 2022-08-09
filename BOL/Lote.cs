using System;
using System.Data;
using System.Data.SqlClient;

// Libreria basada en mi propio proyecto
using DAL;
using ENTITIES;

namespace BOL
{

	public class Lote
	{
		// Objeto que representa la conexión
		DbAccess conn = new DbAccess();
		// Entidad
		ELote elote = new ELote();

		
		// Método general TIPO DE MÉTODO: Actualizar, Registrar, Eliminar
		/// <summary>
		/// Esté método necesita que indiques el Tipo de función: actualizar, registrar o eliminar.
		/// No tiene valor de retorno.
		/// </summary>
		/// <param name="tipoMetodo">Se debe indicar que acción requiere utilizar</param>
		/// <param name="elote">Pasar un objeto(Entidad) que contenga los valores que necesitan los parametros</param>
		public String metodosCUD(String tipoMetodo, ELote elote){
			// Instancia comando
			SqlCommand comando = null;
			
			// Abrir conexión
			conn.abrirConexion();

			// Capturar el Error 
			string error = "";

			// Manejador de excepción
			try
			{
				// Comprobar acción
				if (tipoMetodo.ToLower() == "registrar")
				{
					// Indicar instrucción
					comando = new SqlCommand("SPU_LOTES_REGISTRAR", conn.getConexion());
					comando.CommandType = CommandType.StoredProcedure;

					// Pasando valor de los parametros
					comando.Parameters.AddWithValue("@idlaboratorio", elote.idlaboratorio);
					comando.Parameters.AddWithValue("@fechaentrada", elote.fechaentrada);
					comando.Parameters.AddWithValue("@cantidad", elote.cantidad);
				}
				else if (tipoMetodo.ToLower() == "actualizar")
				{
					// Indicar instrucción
					comando = new SqlCommand("SPU_LOTES_ACTUALIZAR", conn.getConexion());
					comando.CommandType = CommandType.StoredProcedure;

					// Pasando valor de los parametros
					comando.Parameters.AddWithValue("@idlaboratorio", elote.idlaboratorio);
					comando.Parameters.AddWithValue("@fechaentrada", elote.fechaentrada);
					comando.Parameters.AddWithValue("@cantidad", elote.cantidad);
					comando.Parameters.AddWithValue("@idlote", elote.idlote);
				}
				else if (tipoMetodo.ToLower() == "eliminar")
				{
					// Indicar instrucción
					comando = new SqlCommand("SPU_LOTES_ELIMINAR", conn.getConexion());
					comando.CommandType = CommandType.StoredProcedure;

					// Pasando valor de los parametros
					comando.Parameters.AddWithValue("@idlote", elote.idlote);
				}

				// Ejecutar la consulta
				comando.ExecuteNonQuery();
			}
			catch (SqlException ex)
			{
				error = ex.Message;
			}

			// Cerrar conexión
			conn.cerrarConexion();

			// Retornar
			return error;
		}
		
		
		// Método listar
		public DataTable listarLotes(){
			// Instancia datatable
			DataTable tabla = new DataTable();
			
			// Abrir conexión
			conn.abrirConexion();
			
			SqlDataAdapter adaptador = new SqlDataAdapter("SPU_LOTES_LISTAR", conn.getConexion());
			adaptador.Fill(tabla);
			
			// Cerrar conexión
			conn.cerrarConexion();
			
			// Valor retornado
			return tabla;
		}
	}
}

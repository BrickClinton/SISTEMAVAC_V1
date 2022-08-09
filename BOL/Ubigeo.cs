using System;

// Librerias del .NET FRAMEWORK
using System.Data;
using System.Data.SqlClient;

// Libreria basada en i propio proyecto
using DAL;

namespace BOL
{
	/// <summary>
	/// Description of Ubigeo.
	/// </summary>
	public class Ubigeo
	{
		// Objeto que cotiene la conexión
		DbAccess conn = new DbAccess();
		
		// Método listar Departamentos
		public DataTable listarDepaetamentos(){
			// Instancia de la clase DataTable
			DataTable tabla = new DataTable();
			
			// Abrir conexión
			conn.abrirConexion();
			
			// Con el objeto sqlDaraAdapter, indicamos la instrucción sql y la conexión activa
			SqlDataAdapter adaptador = new SqlDataAdapter("SPU_DEPARTAMENTOS_LISTAR", conn.getConexion());
			// Poblar de datos al objeto tabla
			adaptador.Fill(tabla);
			
			// Cerrar conexión
			conn.cerrarConexion();
			
			// Valor retornado
			return tabla;
		}
		
		// Método listar provincias
		public DataTable listarProvincias(String iddepartamento){
			// Instanciando la clase DataTable
			DataTable tabla = new DataTable();
			
			// Utilizando el comando para indicar la instrucción y la conexión activa
			SqlCommand comando = new SqlCommand("SPU_PROVINCIAS_LISTAR", conn.getConexion());
			// Indicar el tipo de instrucción SQL - SPU
			comando.CommandType = CommandType.StoredProcedure;
			
			// Abrir conexion
			conn.abrirConexion();
			
			// Parametro necesario para ejecutar el procedimiento
			comando.Parameters.AddWithValue("@iddepartamento", iddepartamento);
			// Llenando de datos al objeto tabla
			tabla.Load(comando.ExecuteReader());
			
			// Cerrar conexión
			conn.cerrarConexion();
			
			// Valor retornado
			return tabla;
		}
		
		// Método listar Distritos
		public DataTable listarDistritos(String idprovincia){
			// Instancia dataTable
			DataTable tabla = new DataTable();
			
			// Objeto comando
			SqlCommand comando = new SqlCommand("SPU_DISTRITOS_LISTAR", conn.getConexion());
			// Indicando el tipo de instrucción sql
			comando.CommandType = CommandType.StoredProcedure;
			
			// Abrir conexión
			conn.abrirConexion();
			
			// Pasar parametro
			comando.Parameters.AddWithValue("@idprovincia", idprovincia);
			// Poblar de datos al objeto tabla
			tabla.Load(comando.ExecuteReader());
			
			// Cerrar conexión
			conn.cerrarConexion();
			
			// Valor retornado
			return tabla;
		}
	}
}

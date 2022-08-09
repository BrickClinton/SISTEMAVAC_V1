using System;

// 1. Librerias del .NET FRAMEWORK
using System.Data;
using System.Data.SqlClient;

namespace DAL
{

	public class DbAccess
	{

		// 2. Objeto de conexiòn
		private SqlConnection conexion = new SqlConnection("data source=.;database=SISTEMAVACUNACION;user id=sa; password=123456;integrated security=true");
		
		// 3. Mètodo que retorna la conexiòn
		public SqlConnection getConexion(){
			return this.conexion;
		}
		
		// 4 Abrir conexion
		public void abrirConexion(){
			// El método open se ejecuta si la conexión esta cerrada
			if (this.conexion.State == ConnectionState.Closed){
				this.conexion.Open();
			}
		}
		
		// 5 Cerrar conexión
		public void cerrarConexion(){
			// El método close se ejecuta si la conexión esta abierta
			if (this.conexion.State == ConnectionState.Open){
				this.conexion.Close();
			}
		}
	
	}
}

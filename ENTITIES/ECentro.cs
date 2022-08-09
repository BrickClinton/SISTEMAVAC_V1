
using System;

namespace ENTITIES
{
	/// <summary>
	/// Description of ECentro.
	/// </summary>
	public class ECentro
	{
		// Propiedades
		public int idcentro { get; set; }
		public string iddepartamento { get; set; }
		public String idprovincia { get; set; }
		public String iddistrito {get; set;}
		public int idtipocentro {get; set;}
		public String nombrecentro {get; set;}
		public String direccion {get; set;}
		public String telefono {get; set;}
	}
}

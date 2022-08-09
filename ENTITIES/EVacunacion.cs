using System;

namespace ENTITIES
{

	public class EVacunacion
	{
		// Propiedades
		public int idvacunacion {get; set;}
		public int idatendido {get; set;}
		public String atendido {get; set;}
		public int idresponsable {get; set;}
		public int idstockvac {get; set;}
		public int idcentro { get; set; }
		public String fechahoravac {get; set;}
	}
}

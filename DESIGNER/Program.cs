/*
 * Creado por SharpDevelop.
 * Usuario: Clinton
 * Fecha: 19/05/2021
 * Hora: 16:25
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Windows.Forms;
using DESIGNER.Mantenimientos;

namespace DESIGNER
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MenuInicio.fromMenu());
		}
		
	}
}

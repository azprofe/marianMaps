/*
 * Creado por SharpDevelop.
 * Usuario: enoldor
 * Fecha: 24/06/2015
 */
using System;
using System.Windows.Forms;

namespace mapas
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
			Application.Run(new MainForm());
		}
		
	}
}

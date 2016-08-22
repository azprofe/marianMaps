/*
 * Creado por SharpDevelop.
 * Usuario: azuniga
 * Fecha: 07/08/2015
 * Hora: 11:09
 * 
 * RIEGOSALZ SL
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using mapas.Clases;

namespace mapas.Formularios
{
	/// <summary>
	/// Description of PreferenciasForm.
	/// </summary>
	public partial class PreferenciasForm : Form
	{
		Preferencias pref;
		public PreferenciasForm(Preferencias pf)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			pref = pf;
			media.Value = pref.DistMedia;
			lejana.Value = pref.DistLarga;
		}
		void PreferenciasFormFormClosing(object sender, FormClosingEventArgs e)
		{
			pref.DistMedia =Convert.ToInt32(media.Value);
			pref.DistLarga= Convert.ToInt32(lejana.Value) ;
		}
		
		
	}
}

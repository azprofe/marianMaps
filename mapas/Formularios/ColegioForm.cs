/*
 * Creado por SharpDevelop.
 * Usuario: enoldor
 * Fecha: 24/06/2015
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using mapas.Clases;

namespace mapas.Formularios
{
	/// <summary>
	/// Description of ColegioForm.
	/// </summary>
	public partial class ColegioForm : Form
	{
		Colegio cole;
		public ColegioForm(Colegio m, IList<Jornada> jornadas)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			cole = m;
			this.Text = !string.IsNullOrEmpty(cole.nombre) ? cole.nombre+":"+cole.posicion : "Nuevo cole";
			tbDistancia.Text = cole.distancia;
			tbKm.Text =string.Format("{0:0.00}",cole.km);
			tbNombre.Text = cole.nombre;
			tbLocalidad.Text = cole.localidad;
			tbVacante.Text = cole.vacante;
			posicion.Value = cole.posicion;
			cbJornada.DataSource = jornadas;
			if (cole.jornada!=null) {
				cbJornada.SelectedIndex = cole.jornada.id;
			}
			chkItinerante.Checked = cole.itinerante;
			chkVoluntaria.Checked = cole.voluntaria;
			chkContinuada.Checked = cole.continuada;
		}
		void ColegioFormFormClosing(object sender, FormClosingEventArgs e)
		{
			cole.nombre = tbNombre.Text;
			cole.posicion = (int)posicion.Value;
			cole.itinerante = chkItinerante.Checked;
			cole.jornada = (Jornada)cbJornada.SelectedItem;
			cole.voluntaria = chkVoluntaria.Checked;
			cole.vacante = tbVacante.Text;
			cole.continuada = chkContinuada.Checked;
			cole.localidad = tbLocalidad.Text;
		}
		
		void BBorrarClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Desea eliminar el cole seleccionado?","",MessageBoxButtons.YesNo)==DialogResult.Yes) {
				DialogResult = DialogResult.Abort;
			}
			
		}
		void BGuardarClick(object sender, EventArgs e)
		{
			this.Close();
		}

		
		
	}
}

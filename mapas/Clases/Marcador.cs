/*
 * Creado por SharpDevelop.
 * Usuario: enoldor
 * Fecha: 24/06/2015
 */
using System;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;

namespace mapas.Clases
{
	/// <summary>
	/// Description of Marcador.
	/// </summary>
	public class Marcador : GMarkerGoogle
	{
		public Colegio cole; 
		public Marcador(PointLatLng p, GMarkerGoogleType type) : base( p,  type)
		{
			cole = new Colegio();
			cole.localizacion = p;
		}
		
		

	}
}

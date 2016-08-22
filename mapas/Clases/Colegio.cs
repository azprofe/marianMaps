/*
 * Creado por SharpDevelop.
 * Usuario: enoldor
 * Fecha: 24/06/2015
 */
using System;
using System.Collections.Generic;
using GMap.NET;
using GMap.NET.WindowsForms;

namespace mapas.Clases
{
	/// <summary>
	/// Description of Colegio.
	/// </summary>
	public class Colegio
	{
		public string localidad {get;set;}
		public string nombre {get;set;}
		public string vacante {get;set;}
		public string distancia {get;set;}
		public double km {get;set;}
		public int posicion {get;set;}
		public PointLatLng localizacion {get;set;}
		public Jornada jornada {get;set;}
		public bool itinerante {get;set;}
		public bool voluntaria {get;set;}
		public GMapRoute ruta {get;set;}
		public bool seleccinado {get;set;}
		public bool continuada {get;set;}
		
		
		public Colegio()
		{
		}
		
		public override string ToString()
		{
			return nombre;
		}
	}
	

}

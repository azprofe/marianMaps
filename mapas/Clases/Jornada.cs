/*
 * Creado por SharpDevelop.
 * Usuario: enoldor
 * Fecha: 15/07/2015
 */
using System;

namespace mapas.Clases
{
	/// <summary>
	/// Description of Jornada.
	/// </summary>
	public class Jornada:IComparable
	{
		public int id{get;set;}
		public string nombre{get;set;}
		public Jornada(int i, string n)
		{
			id = i;
			nombre = n;
		}
		
		public override string ToString()
		{
			return nombre;
		}
		
		public override bool Equals(object obj)
		{
			Jornada other = obj as Jornada;
			if (other == null)
				return false;
			return this.id == other.id;
		}
	
		#region IComparable implementation
	public int CompareTo(object obj)
	{
		Jornada c = (Jornada)obj;
		return id.CompareTo(c.id);
		//	return String.Compare(this.id, c.descripcion, StringComparison.Ordinal);
	}
	#endregion
	}
}

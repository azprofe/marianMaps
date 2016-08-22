/*
 * Creado por SharpDevelop.
 * Usuario: azuniga
 * Fecha: 10/08/2015
 * Hora: 10:27
 * 
 * RIEGOSALZ SL
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using mapas.Clases;

namespace mapas.Formularios
{
	/// <summary>
	/// Description of OrdenarForm.
	/// </summary>
	public partial class OrdenarForm : Form
	{
		SortableBindingList<Colegio> listaXordenar;
		SortableBindingList<Colegio> listaOrdenada;
		public OrdenarForm(IList<Colegio> lc)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			var lista = lc.OrderBy(x => x.km);
			 listaXordenar = new SortableBindingList<Colegio>();

			foreach (Colegio element in lista) {
				if (!element.seleccinado) {
					listaXordenar.Add(element);
				}
			}
			
			tabla.DataSource = listaXordenar;

			 listaOrdenada =  new SortableBindingList<Colegio>();
			foreach (Colegio element in lista) {
				if (element.seleccinado) {
					listaOrdenada.Add(element);
				}
			}
			tablaOrdenada.DataSource = listaOrdenada;
		}
		void BAnadirClick(object sender, EventArgs e)
		{
			
			if (tabla.SelectedRows.Count==1) {
				Colegio cole = (Colegio) tabla.SelectedRows[0].DataBoundItem;
				int index = tabla.SelectedRows[0].Index;
				tabla.DataSource = null;
				tabla.Refresh();
				tablaOrdenada.DataSource = null;
				tablaOrdenada.Refresh();
				cole.seleccinado = true;
				listaXordenar.Remove(cole);
				listaOrdenada.Add(cole);
				tabla.DataSource = listaXordenar;
				tablaOrdenada.DataSource = listaOrdenada;

			}
		}
		void BQuitarClick(object sender, EventArgs e)
		{
	
		}
		
		
//	private Rectangle dragBoxFromMouseDown;
//    private object valueFromMouseDown;
//    private void Tabla_MouseMove(object sender, MouseEventArgs e)
//    {
//        if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
//        {
//            // If the mouse moves outside the rectangle, start the drag.
//            if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
//            {
//                // Proceed with the drag and drop, passing in the list item.                    
//                DragDropEffects dropEffect = tabla.DoDragDrop(valueFromMouseDown, DragDropEffects.Copy);
//            }
//        }
//    }
//
//    private void Tabla_MouseDown(object sender, MouseEventArgs e)
//    {
//        // Get the index of the item the mouse is below.
//        var hittestInfo = tabla.HitTest(e.X, e.Y);
//
//        if (hittestInfo.RowIndex != -1 && hittestInfo.ColumnIndex != -1)
//        {
//            valueFromMouseDown = tabla.Rows[hittestInfo.RowIndex].Cells[hittestInfo.ColumnIndex].Value;
//            if (valueFromMouseDown != null)
//            {
//                // Remember the point where the mouse down occurred. 
//                // The DragSize indicates the size that the mouse can move 
//                // before a drag event should be started.                
//                Size dragSize = SystemInformation.DragSize;
//
//                // Create a rectangle using the DragSize, with the mouse position being
//                // at the center of the rectangle.
//                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
//            }
//        }
//        else
//            // Reset the rectangle if the mouse is not over an item in the ListBox.
//            dragBoxFromMouseDown = Rectangle.Empty;
//    }
//		void TablaOrdenadaDragDrop(object sender, DragEventArgs e)
//		{
//			e.Effect = DragDropEffects.Copy;
//		}
//		
//		 private void TablaOrdenada_DragOver(object sender, DragEventArgs e)
//    {
//        e.Effect = DragDropEffects.Copy;
//    }
//
//    private void TablaOrdenada_DragDrop(object sender, DragEventArgs e)
//    {
//        // The mouse locations are relative to the screen, so they must be 
//        // converted to client coordinates.
//        Point clientPoint = tablaOrdenada.PointToClient(new Point(e.X, e.Y));
//
//        // If the drag operation was a copy then add the row to the other control.
//        if (e.Effect == DragDropEffects.Copy)
//        {
//            string cellvalue = e.Data.GetData(typeof(string)) as string;
//            var hittest = tablaOrdenada.HitTest(clientPoint.X, clientPoint.Y);
//            if (hittest.ColumnIndex != -1
//                && hittest.RowIndex != -1)
//                tablaOrdenada[hittest.ColumnIndex, hittest.RowIndex].Value = cellvalue;
//
//        }
//    }
//    
//            private void TablaOrdenada_DragEnter(object sender, DragEventArgs e)
//    {
//        e.Effect = DragDropEffects.Copy;
//    }
	}
}

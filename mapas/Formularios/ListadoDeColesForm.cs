/*
 * Creado por SharpDevelop.
 * Usuario: enoldor
 * Fecha: 29/06/2015
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using mapas.Clases;

namespace mapas.Formularios
{
	/// <summary>
	/// Description of ListadoDeColesForm.
	/// </summary>
	public partial class ListadoDeColesForm : Form
	{
		IList<Colegio> listadoColes;
		public ListadoDeColesForm(IList<Colegio> lc,IList<Jornada> jornadas)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			listadoColes = lc;
			var lista = new SortableBindingList<Colegio>();
			listadoColes.OrderByDescending(x => x.posicion);
			foreach (Colegio c in listadoColes) {
				lista.Add(c);
			}
			Tabla.DataSource = lista;
			//rellenar();
			Tabla.Columns[4].DisplayIndex = 0;
		//	Tabla.Columns[].DisplayIndex = 1;
		//	Tabla.Columns[2].DisplayIndex = 2;
			//Tabla.Columns[6].DisplayIndex = 3;
			//Tabla.Columns[5].Visible = false;
			//Tabla.Columns[9].Visible = false;
			//Tabla.Columns[5].Visible = false;
			Tabla.Columns[6].Visible = false;
			Tabla.Columns[10].Visible = false;
//			DataGridViewComboBoxColumn columna = new DataGridViewComboBoxColumn();
//			columna.HeaderText = "Jornada";
//			columna.DisplayIndex = 10;
////			columna.ValueType = typeof(int);
//			columna.DataSource = jornadas;
//			columna.ValueMember = "id";
//			columna.DisplayMember = "nombre";
////			columna.Items.AddRange(new object[] {
////			                       	"Completa",
////			                       	"1/2 jornada",
////			                       	"1/3 jornada"});
//			columna.Name = "jornada2";
//			columna.DataPropertyName = "jornadas";
//			Tabla.Columns.Add(columna);
			//rellenarCombo();
		}

		void rellenar()
		{
			foreach (Colegio c in listadoColes) {
				DataGridViewRow row = (DataGridViewRow)Tabla.Rows[0].Clone();
				//Tabla.Rows.Add(c.posicion,c.nombre,c.nombre,c.km,(row.Cells["jornada"] as DataGridViewComboBoxCell).Items[c.jornada],c.itinerante);
				row.Cells[0].Value = c.posicion;
				row.Cells[1].Value = c.nombre;
				row.Cells[2].Value = c.km;
				row.Cells[3].Value = c.distancia;
				//row.Cells[4].Value = (row.Cells[4] as DataGridViewComboBoxCell).Items[c.jornada];
				row.Cells[5].Value = c.itinerante;
				Tabla.Rows.Add(row);
				
			}
		}
		
		
		void TablaDataError(object sender, System.Windows.Forms.DataGridViewDataErrorEventArgs e)
		{
			
		}
		
		void rellenarCombo()
		{
			
			foreach (DataGridViewRow row in Tabla.Rows) {
				int i = Convert.ToInt32(row.Cells[5].Value);
				foreach (DataGridViewCell cell in row.Cells) {
					if (cell is DataGridViewComboBoxCell) {
						var other = cell as DataGridViewComboBoxCell;
						//other.
						other.Value = other.Items[i];
						i = 5;
						
					}
				}
				Tabla.Refresh();
//				row.Cells["jornada2"].Value = (row.Cells["jornada2"] as DataGridViewComboBoxCell).Items[i];
			}
		}

		
		private void copyAlltoClipboard(DataGridView dgv)
		{
			dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
			dgv.MultiSelect = true;
			dgv.SelectAll();
			DataObject dataObj = dgv.GetClipboardContent();
			if (dataObj != null)
				Clipboard.SetDataObject(dataObj);
		}
		
		void ExportarAExcelToolStripMenuItemClick(object sender, EventArgs e)
		{
			var boton = sender as Control;
			DataGridView grd = Tabla;
			copyAlltoClipboard(grd);
			Microsoft.Office.Interop.Excel.Application xlexcel;
			Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
			Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
			object misValue = System.Reflection.Missing.Value;
			xlexcel = new Microsoft.Office.Interop.Excel.Application();
			xlexcel.Visible = true;
			xlWorkBook = xlexcel.Workbooks.Add(misValue);
			xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
			Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
			CR.Select();
			xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
			

			
		}
	}
}

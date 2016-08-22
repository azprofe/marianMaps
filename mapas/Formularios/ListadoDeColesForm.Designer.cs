/*
 * Creado por SharpDevelop.
 * Usuario: azuniga
 * Fecha: 29/06/2015
 * Hora: 8:47
 * 
 * RIEGOSALZ SL
 */
namespace mapas.Formularios
{
	partial class ListadoDeColesForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
		private System.Windows.Forms.DataGridView Tabla;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoDeColesForm));
			this.Tabla = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportarAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Tabla
			// 
			this.Tabla.AllowUserToAddRows = false;
			this.Tabla.AllowUserToDeleteRows = false;
			this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Tabla.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Tabla.Location = new System.Drawing.Point(0, 24);
			this.Tabla.Name = "Tabla";
			this.Tabla.Size = new System.Drawing.Size(991, 545);
			this.Tabla.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.excelToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(991, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// excelToolStripMenuItem
			// 
			this.excelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.exportarAExcelToolStripMenuItem});
			this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
			this.excelToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.excelToolStripMenuItem.Text = "Excel";
			// 
			// exportarAExcelToolStripMenuItem
			// 
			this.exportarAExcelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportarAExcelToolStripMenuItem.Image")));
			this.exportarAExcelToolStripMenuItem.Name = "exportarAExcelToolStripMenuItem";
			this.exportarAExcelToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.exportarAExcelToolStripMenuItem.Text = "Exportar a excel";
			this.exportarAExcelToolStripMenuItem.Click += new System.EventHandler(this.ExportarAExcelToolStripMenuItemClick);
			// 
			// ListadoDeColesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(991, 569);
			this.Controls.Add(this.Tabla);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "ListadoDeColesForm";
			this.Text = "Listado de coles";
			((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

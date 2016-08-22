/*
 * Creado por SharpDevelop.
 * Usuario: azuniga
 * Fecha: 24/06/2015
 * Hora: 8:41
 * 
 * RIEGOSALZ SL
 */
namespace mapas
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelMap;
		private System.Windows.Forms.ContextMenuStrip MapaCMS;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem MapaTS;
		private System.Windows.Forms.ToolStripMenuItem hibridoTS;
		private System.Windows.Forms.ToolStripMenuItem sateliteTS;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem nuevoColeToolStripMenuItem;
		private System.Windows.Forms.Button bBuscar;
		private System.Windows.Forms.TextBox tbBusqueda;
		private System.Windows.Forms.Button bListar;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog DialogAbrir;
		private System.Windows.Forms.SaveFileDialog DialogGuardar;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panelMap = new System.Windows.Forms.Panel();
			this.MapaCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.MapaTS = new System.Windows.Forms.ToolStripMenuItem();
			this.hibridoTS = new System.Windows.Forms.ToolStripMenuItem();
			this.sateliteTS = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.nuevoColeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bBuscar = new System.Windows.Forms.Button();
			this.tbBusqueda = new System.Windows.Forms.TextBox();
			this.bListar = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cambiarUbicaciónInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.preferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DialogAbrir = new System.Windows.Forms.OpenFileDialog();
			this.DialogGuardar = new System.Windows.Forms.SaveFileDialog();
			this.bOrdenar = new System.Windows.Forms.Button();
			this.MapaCMS.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMap
			// 
			this.panelMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panelMap.AutoSize = true;
			this.panelMap.Location = new System.Drawing.Point(0, 61);
			this.panelMap.Name = "panelMap";
			this.panelMap.Size = new System.Drawing.Size(870, 471);
			this.panelMap.TabIndex = 0;
			// 
			// MapaCMS
			// 
			this.MapaCMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
			this.MapaCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripSeparator1,
			this.MapaTS,
			this.hibridoTS,
			this.sateliteTS,
			this.toolStripSeparator2,
			this.nuevoColeToolStripMenuItem});
			this.MapaCMS.Name = "MapaCMS";
			this.MapaCMS.Size = new System.Drawing.Size(198, 104);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
			// 
			// MapaTS
			// 
			this.MapaTS.Name = "MapaTS";
			this.MapaTS.Size = new System.Drawing.Size(197, 22);
			this.MapaTS.Text = "Mapa";
			this.MapaTS.Click += new System.EventHandler(this.MapaTSClick);
			// 
			// hibridoTS
			// 
			this.hibridoTS.Name = "hibridoTS";
			this.hibridoTS.Size = new System.Drawing.Size(197, 22);
			this.hibridoTS.Text = "Hibrido";
			this.hibridoTS.Click += new System.EventHandler(this.HibridoTSClick);
			// 
			// sateliteTS
			// 
			this.sateliteTS.Name = "sateliteTS";
			this.sateliteTS.Size = new System.Drawing.Size(197, 22);
			this.sateliteTS.Text = "Satélite";
			this.sateliteTS.Click += new System.EventHandler(this.SateliteTSClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(194, 6);
			// 
			// nuevoColeToolStripMenuItem
			// 
			this.nuevoColeToolStripMenuItem.Name = "nuevoColeToolStripMenuItem";
			this.nuevoColeToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
			this.nuevoColeToolStripMenuItem.Text = "Nueva ubicación inicial";
			// 
			// bBuscar
			// 
			this.bBuscar.Location = new System.Drawing.Point(276, 32);
			this.bBuscar.Name = "bBuscar";
			this.bBuscar.Size = new System.Drawing.Size(75, 23);
			this.bBuscar.TabIndex = 1;
			this.bBuscar.Text = "Buscar";
			this.bBuscar.UseVisualStyleBackColor = true;
			this.bBuscar.Click += new System.EventHandler(this.Button1Click);
			// 
			// tbBusqueda
			// 
			this.tbBusqueda.Location = new System.Drawing.Point(9, 34);
			this.tbBusqueda.Name = "tbBusqueda";
			this.tbBusqueda.Size = new System.Drawing.Size(261, 20);
			this.tbBusqueda.TabIndex = 2;
			// 
			// bListar
			// 
			this.bListar.Location = new System.Drawing.Point(648, 31);
			this.bListar.Name = "bListar";
			this.bListar.Size = new System.Drawing.Size(75, 23);
			this.bListar.TabIndex = 3;
			this.bListar.Text = "Ver listado";
			this.bListar.UseVisualStyleBackColor = true;
			this.bListar.Click += new System.EventHandler(this.BListarClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.archivoToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(870, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.guardarToolStripMenuItem,
			this.cargarToolStripMenuItem,
			this.cambiarUbicaciónInicialToolStripMenuItem,
			this.preferenciasToolStripMenuItem,
			this.toolStripSeparator3,
			this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// guardarToolStripMenuItem
			// 
			this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
			this.guardarToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.guardarToolStripMenuItem.Text = "Guardar";
			this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItemClick);
			// 
			// cargarToolStripMenuItem
			// 
			this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
			this.cargarToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.cargarToolStripMenuItem.Text = "Cargar";
			this.cargarToolStripMenuItem.Click += new System.EventHandler(this.CargarToolStripMenuItemClick);
			// 
			// cambiarUbicaciónInicialToolStripMenuItem
			// 
			this.cambiarUbicaciónInicialToolStripMenuItem.Name = "cambiarUbicaciónInicialToolStripMenuItem";
			this.cambiarUbicaciónInicialToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.cambiarUbicaciónInicialToolStripMenuItem.Text = "Cambiar ubicación inicial";
			this.cambiarUbicaciónInicialToolStripMenuItem.Click += new System.EventHandler(this.CambiarUbicaciónInicialToolStripMenuItemClick);
			// 
			// preferenciasToolStripMenuItem
			// 
			this.preferenciasToolStripMenuItem.Name = "preferenciasToolStripMenuItem";
			this.preferenciasToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.preferenciasToolStripMenuItem.Text = "Preferencias";
			this.preferenciasToolStripMenuItem.Click += new System.EventHandler(this.PreferenciasToolStripMenuItemClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(205, 6);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// DialogAbrir
			// 
			this.DialogAbrir.FileName = "openFileDialog1";
			this.DialogAbrir.Filter = "Archivos txt|*.txt";
			// 
			// DialogGuardar
			// 
			this.DialogGuardar.Filter = "Archivos txt|*.txt";
			// 
			// bOrdenar
			// 
			this.bOrdenar.Location = new System.Drawing.Point(743, 31);
			this.bOrdenar.Name = "bOrdenar";
			this.bOrdenar.Size = new System.Drawing.Size(115, 23);
			this.bOrdenar.TabIndex = 5;
			this.bOrdenar.Text = "Ordenar Vacantes";
			this.bOrdenar.UseVisualStyleBackColor = true;
			this.bOrdenar.Visible = false;
			this.bOrdenar.Click += new System.EventHandler(this.BOrdenarClick);
			// 
			// MainForm
			// 
			this.AcceptButton = this.bBuscar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(870, 541);
			this.Controls.Add(this.bOrdenar);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.bListar);
			this.Controls.Add(this.tbBusqueda);
			this.Controls.Add(this.bBuscar);
			this.Controls.Add(this.panelMap);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MarianMaps";
			this.MapaCMS.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.ToolStripMenuItem cambiarUbicaciónInicialToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem preferenciasToolStripMenuItem;
		private System.Windows.Forms.Button bOrdenar;
	}
}

/*
 * Creado por SharpDevelop.
 * Usuario: azuniga
 * Fecha: 10/08/2015
 * Hora: 10:27
 * 
 * RIEGOSALZ SL
 */
namespace mapas.Formularios
{
	partial class OrdenarForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView tabla;
		private System.Windows.Forms.DataGridView tablaOrdenada;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bAnadir;
		private System.Windows.Forms.Button bQuitar;
		
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
			this.tabla = new System.Windows.Forms.DataGridView();
			this.tablaOrdenada = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.bAnadir = new System.Windows.Forms.Button();
			this.bQuitar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tablaOrdenada)).BeginInit();
			this.SuspendLayout();
			// 
			// tabla
			// 
			this.tabla.AllowUserToAddRows = false;
			this.tabla.AllowUserToOrderColumns = true;
			this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tabla.Location = new System.Drawing.Point(12, 46);
			this.tabla.MultiSelect = false;
			this.tabla.Name = "tabla";
			this.tabla.Size = new System.Drawing.Size(482, 505);
			this.tabla.TabIndex = 0;
//			this.tabla.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tabla_MouseDown);
//			this.tabla.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tabla_MouseMove);
			// 
			// tablaOrdenada
			// 
			this.tablaOrdenada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tablaOrdenada.Location = new System.Drawing.Point(559, 46);
			this.tablaOrdenada.Name = "tablaOrdenada";
			this.tablaOrdenada.Size = new System.Drawing.Size(490, 505);
			this.tablaOrdenada.TabIndex = 1;
//			this.tablaOrdenada.DragDrop += new System.Windows.Forms.DragEventHandler(this.TablaOrdenada_DragDrop);
//			this.tablaOrdenada.DragEnter += new System.Windows.Forms.DragEventHandler(this.TablaOrdenada_DragEnter);
//			this.tablaOrdenada.DragOver += new System.Windows.Forms.DragEventHandler(this.TablaOrdenada_DragOver);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Vacantes por ordenar";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(559, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Vacantes Ordenadas";
			// 
			// bAnadir
			// 
			this.bAnadir.Location = new System.Drawing.Point(500, 243);
			this.bAnadir.Name = "bAnadir";
			this.bAnadir.Size = new System.Drawing.Size(53, 52);
			this.bAnadir.TabIndex = 4;
			this.bAnadir.Text = "Añadir";
			this.bAnadir.UseVisualStyleBackColor = true;
			this.bAnadir.Click += new System.EventHandler(this.BAnadirClick);
			// 
			// bQuitar
			// 
			this.bQuitar.Location = new System.Drawing.Point(500, 312);
			this.bQuitar.Name = "bQuitar";
			this.bQuitar.Size = new System.Drawing.Size(53, 52);
			this.bQuitar.TabIndex = 5;
			this.bQuitar.Text = "Quitar";
			this.bQuitar.UseVisualStyleBackColor = true;
			this.bQuitar.Click += new System.EventHandler(this.BQuitarClick);
			// 
			// OrdenarForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1061, 563);
			this.Controls.Add(this.bQuitar);
			this.Controls.Add(this.bAnadir);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tablaOrdenada);
			this.Controls.Add(this.tabla);
			this.Name = "OrdenarForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OrdenarForm";
			((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tablaOrdenada)).EndInit();
			this.ResumeLayout(false);

		}
	}
}

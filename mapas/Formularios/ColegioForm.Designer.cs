/*
 * Creado por SharpDevelop.
 * Usuario: azuniga
 * Fecha: 24/06/2015
 * Hora: 11:51
 * 
 * RIEGOSALZ SL
 */
namespace mapas.Formularios
{
	partial class ColegioForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox tbNombre;
		private System.Windows.Forms.TextBox tbDistancia;
		private System.Windows.Forms.TextBox tbKm;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown posicion;
		private System.Windows.Forms.ComboBox cbJornada;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox chkItinerante;
		private System.Windows.Forms.CheckBox chkVoluntaria;
		private System.Windows.Forms.Button bBorrar;
		private System.Windows.Forms.Button bGuardar;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColegioForm));
			this.tbNombre = new System.Windows.Forms.TextBox();
			this.tbDistancia = new System.Windows.Forms.TextBox();
			this.tbKm = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.posicion = new System.Windows.Forms.NumericUpDown();
			this.cbJornada = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.chkItinerante = new System.Windows.Forms.CheckBox();
			this.chkVoluntaria = new System.Windows.Forms.CheckBox();
			this.bBorrar = new System.Windows.Forms.Button();
			this.bGuardar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.tbVacante = new System.Windows.Forms.TextBox();
			this.chkContinuada = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tbLocalidad = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.posicion)).BeginInit();
			this.SuspendLayout();
			// 
			// tbNombre
			// 
			this.tbNombre.Location = new System.Drawing.Point(137, 14);
			this.tbNombre.Name = "tbNombre";
			this.tbNombre.Size = new System.Drawing.Size(100, 20);
			this.tbNombre.TabIndex = 0;
			// 
			// tbDistancia
			// 
			this.tbDistancia.Location = new System.Drawing.Point(137, 111);
			this.tbDistancia.Name = "tbDistancia";
			this.tbDistancia.ReadOnly = true;
			this.tbDistancia.Size = new System.Drawing.Size(135, 20);
			this.tbDistancia.TabIndex = 25;
			// 
			// tbKm
			// 
			this.tbKm.Location = new System.Drawing.Point(137, 157);
			this.tbKm.Name = "tbKm";
			this.tbKm.ReadOnly = true;
			this.tbKm.Size = new System.Drawing.Size(100, 20);
			this.tbKm.TabIndex = 26;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(31, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(31, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Distancia en tiempo";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(31, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Distancia";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(31, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Posición";
			this.label4.Visible = false;
			// 
			// posicion
			// 
			this.posicion.Location = new System.Drawing.Point(137, 170);
			this.posicion.Maximum = new decimal(new int[] {
			10000,
			0,
			0,
			0});
			this.posicion.Name = "posicion";
			this.posicion.Size = new System.Drawing.Size(100, 20);
			this.posicion.TabIndex = 8;
			this.posicion.Visible = false;
			// 
			// cbJornada
			// 
			this.cbJornada.FormattingEnabled = true;
			this.cbJornada.Location = new System.Drawing.Point(137, 219);
			this.cbJornada.Name = "cbJornada";
			this.cbJornada.Size = new System.Drawing.Size(121, 21);
			this.cbJornada.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(31, 219);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Tipo de jornada";
			// 
			// chkItinerante
			// 
			this.chkItinerante.Location = new System.Drawing.Point(12, 257);
			this.chkItinerante.Name = "chkItinerante";
			this.chkItinerante.Size = new System.Drawing.Size(104, 24);
			this.chkItinerante.TabIndex = 11;
			this.chkItinerante.Text = "Itinerante";
			this.chkItinerante.UseVisualStyleBackColor = true;
			// 
			// chkVoluntaria
			// 
			this.chkVoluntaria.Location = new System.Drawing.Point(101, 257);
			this.chkVoluntaria.Name = "chkVoluntaria";
			this.chkVoluntaria.Size = new System.Drawing.Size(104, 24);
			this.chkVoluntaria.TabIndex = 12;
			this.chkVoluntaria.Text = "Voluntaria";
			this.chkVoluntaria.UseVisualStyleBackColor = true;
			// 
			// bBorrar
			// 
			this.bBorrar.Image = ((System.Drawing.Image)(resources.GetObject("bBorrar.Image")));
			this.bBorrar.Location = new System.Drawing.Point(191, 294);
			this.bBorrar.Name = "bBorrar";
			this.bBorrar.Size = new System.Drawing.Size(46, 33);
			this.bBorrar.TabIndex = 15;
			this.bBorrar.UseVisualStyleBackColor = true;
			this.bBorrar.Click += new System.EventHandler(this.BBorrarClick);
			// 
			// bGuardar
			// 
			this.bGuardar.Image = ((System.Drawing.Image)(resources.GetObject("bGuardar.Image")));
			this.bGuardar.Location = new System.Drawing.Point(85, 294);
			this.bGuardar.Name = "bGuardar";
			this.bGuardar.Size = new System.Drawing.Size(46, 33);
			this.bGuardar.TabIndex = 14;
			this.bGuardar.UseVisualStyleBackColor = true;
			this.bGuardar.Click += new System.EventHandler(this.BGuardarClick);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(31, 46);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 16;
			this.label6.Text = "Vacante";
			// 
			// tbVacante
			// 
			this.tbVacante.Location = new System.Drawing.Point(137, 43);
			this.tbVacante.Name = "tbVacante";
			this.tbVacante.Size = new System.Drawing.Size(100, 20);
			this.tbVacante.TabIndex = 1;
			// 
			// chkContinuada
			// 
			this.chkContinuada.Location = new System.Drawing.Point(191, 257);
			this.chkContinuada.Name = "chkContinuada";
			this.chkContinuada.Size = new System.Drawing.Size(104, 24);
			this.chkContinuada.TabIndex = 17;
			this.chkContinuada.Text = "Continuada";
			this.chkContinuada.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(31, 79);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 19;
			this.label7.Text = "Localidad";
			// 
			// tbLocalidad
			// 
			this.tbLocalidad.Location = new System.Drawing.Point(137, 76);
			this.tbLocalidad.Name = "tbLocalidad";
			this.tbLocalidad.Size = new System.Drawing.Size(100, 20);
			this.tbLocalidad.TabIndex = 3;
			// 
			// ColegioForm
			// 
			this.AcceptButton = this.bGuardar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 335);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tbLocalidad);
			this.Controls.Add(this.chkContinuada);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbVacante);
			this.Controls.Add(this.bGuardar);
			this.Controls.Add(this.bBorrar);
			this.Controls.Add(this.chkVoluntaria);
			this.Controls.Add(this.chkItinerante);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbJornada);
			this.Controls.Add(this.posicion);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbKm);
			this.Controls.Add(this.tbDistancia);
			this.Controls.Add(this.tbNombre);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ColegioForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ColegioForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColegioFormFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.posicion)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.TextBox tbVacante;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox chkContinuada;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbLocalidad;
	}
}

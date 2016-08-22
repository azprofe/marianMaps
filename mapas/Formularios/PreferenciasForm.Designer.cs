/*
 * Creado por SharpDevelop.
 * Usuario: azuniga
 * Fecha: 07/08/2015
 * Hora: 11:09
 * 
 * RIEGOSALZ SL
 */
namespace mapas.Formularios
{
	partial class PreferenciasForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.NumericUpDown media;
		private System.Windows.Forms.NumericUpDown lejana;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferenciasForm));
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.media = new System.Windows.Forms.NumericUpDown();
			this.lejana = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.media)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lejana)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(12, 25);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(22, 27);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(12, 70);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(22, 27);
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// media
			// 
			this.media.Location = new System.Drawing.Point(155, 32);
			this.media.Maximum = new decimal(new int[] {
			10000,
			0,
			0,
			0});
			this.media.Name = "media";
			this.media.Size = new System.Drawing.Size(52, 20);
			this.media.TabIndex = 4;
			// 
			// lejana
			// 
			this.lejana.Location = new System.Drawing.Point(155, 77);
			this.lejana.Maximum = new decimal(new int[] {
			10000,
			0,
			0,
			0});
			this.lejana.Name = "lejana";
			this.lejana.Size = new System.Drawing.Size(52, 20);
			this.lejana.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(49, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 18);
			this.label2.TabIndex = 7;
			this.label2.Text = "Distancia media";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(49, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 18);
			this.label3.TabIndex = 8;
			this.label3.Text = "Distancia lejana";
			// 
			// PreferenciasForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(232, 113);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lejana);
			this.Controls.Add(this.media);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Name = "PreferenciasForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Preferencias";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreferenciasFormFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.media)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lejana)).EndInit();
			this.ResumeLayout(false);

		}
	}
}

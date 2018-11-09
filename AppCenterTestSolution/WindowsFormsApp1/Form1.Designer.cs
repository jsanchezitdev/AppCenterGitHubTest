namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.customControl11 = new WindowsFormsApp1.CustomControl1();
			this.SuspendLayout();
			// 
			// customControl11
			// 
			this.customControl11.BackColor = System.Drawing.Color.Yellow;
			this.customControl11.Location = new System.Drawing.Point(131, 120);
			this.customControl11.Name = "customControl11";
			this.customControl11.Size = new System.Drawing.Size(320, 233);
			this.customControl11.TabIndex = 0;
			this.customControl11.Text = "customControl11";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Red;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.customControl11);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private CustomControl1 customControl11;
	}
}


/*
 * Created by SharpDevelop.
 * User: CC2_PC13
 * Date: 27/10/2026
 * Time: 07:17 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto_1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.btnResta = new System.Windows.Forms.Button();
			this.btnMul = new System.Windows.Forms.Button();
			this.btnSuma = new System.Windows.Forms.Button();
			this.btnDiv = new System.Windows.Forms.Button();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnResta
			// 
			this.btnResta.Location = new System.Drawing.Point(136, 193);
			this.btnResta.Name = "btnResta";
			this.btnResta.Size = new System.Drawing.Size(75, 23);
			this.btnResta.TabIndex = 0;
			this.btnResta.Text = "resta";
			this.btnResta.UseVisualStyleBackColor = true;
			this.btnResta.Click += new System.EventHandler(this.BtnRestaClick);
			// 
			// btnMul
			// 
			this.btnMul.Location = new System.Drawing.Point(237, 193);
			this.btnMul.Name = "btnMul";
			this.btnMul.Size = new System.Drawing.Size(75, 23);
			this.btnMul.TabIndex = 1;
			this.btnMul.Text = "multiplicacion";
			this.btnMul.UseVisualStyleBackColor = true;
			this.btnMul.Click += new System.EventHandler(this.BtnMulClick);
			// 
			// btnSuma
			// 
			this.btnSuma.Location = new System.Drawing.Point(44, 192);
			this.btnSuma.Name = "btnSuma";
			this.btnSuma.Size = new System.Drawing.Size(75, 23);
			this.btnSuma.TabIndex = 2;
			this.btnSuma.Text = "Suma";
			this.btnSuma.UseVisualStyleBackColor = true;
			this.btnSuma.Click += new System.EventHandler(this.BtnSumaClick);
			// 
			// btnDiv
			// 
			this.btnDiv.Location = new System.Drawing.Point(327, 193);
			this.btnDiv.Name = "btnDiv";
			this.btnDiv.Size = new System.Drawing.Size(75, 23);
			this.btnDiv.TabIndex = 3;
			this.btnDiv.Text = "divicion";
			this.btnDiv.UseVisualStyleBackColor = true;
			this.btnDiv.Click += new System.EventHandler(this.BtnDivClick);
			// 
			// txtNum2
			// 
			this.txtNum2.Location = new System.Drawing.Point(252, 121);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(100, 20);
			this.txtNum2.TabIndex = 4;
			// 
			// txtNum1
			// 
			this.txtNum1.Location = new System.Drawing.Point(252, 75);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(100, 20);
			this.txtNum1.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 352);
			this.Controls.Add(this.txtNum1);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.btnDiv);
			this.Controls.Add(this.btnSuma);
			this.Controls.Add(this.btnMul);
			this.Controls.Add(this.btnResta);
			this.Name = "MainForm";
			this.Text = "Proyecto_1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.Button btnDiv;
		private System.Windows.Forms.Button btnSuma;
		private System.Windows.Forms.Button btnMul;
		private System.Windows.Forms.Button btnResta;
	}
}

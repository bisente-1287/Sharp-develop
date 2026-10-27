/*
 * Created by SharpDevelop.
 * User: CC2_PC13
 * Date: 27/10/2026
 * Time: 07:17 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public double n,m;
		public double R;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnSumaClick(object sender, EventArgs e)
		{
			n=Convert.ToDouble(txtNum1.Text);
			m=Convert.ToDouble(txtNum2.Text);
			R=n+m;
			MessageBox.Show("El resultado es: "+R);
		}
		
		void BtnRestaClick(object sender, EventArgs e)
		{
			n=Convert.ToDouble(txtNum1.Text);
			m=Convert.ToDouble(txtNum2.Text);
			R=n-m;
			MessageBox.Show("El resultado es: "+R);
		}
		
		void BtnMulClick(object sender, EventArgs e)
		{
			n=Convert.ToDouble(txtNum1.Text);
			m=Convert.ToDouble(txtNum2.Text);
			R=n*m;
			MessageBox.Show("El resultado es: "+R);
		}
		
		void BtnDivClick(object sender, EventArgs e)
		{
			n=Convert.ToDouble(txtNum1.Text);
			m=Convert.ToDouble(txtNum2.Text);
			R=n/m;
			MessageBox.Show("El resultado es: "+R);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form1 f= new Form1();
			f.Show();
			this.Hide();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			n=Convert.ToDouble(txtNum1.Text);
			m=Convert.ToDouble(txtNum2.Text);
			R=n%m;
			MessageBox.Show("El resultado es: "+R);
		}
	}
}

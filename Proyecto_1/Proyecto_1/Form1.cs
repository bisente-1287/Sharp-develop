/*
 * Created by SharpDevelop.
 * User: CC2_PC13
 * Date: 27/10/2026
 * Time: 07:57 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_1
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public double resultado1,resultado2;
		public double a,b,c,gen;
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			a=Convert.ToDouble(txt1.Text);
			b=Convert.ToDouble(txt2.Text);
			c=Convert.ToDouble(txt3.Text);
			gen=b*b-4*a*c;
			resultado1=(-b+Math.Sqrt(gen))/(2*a);
			resultado2=(-b-Math.Sqrt(gen))/(2*a);
			MessageBox.Show("los resultados son: "+resultado1+ "n\""+ resultado2);
		}
	}
}

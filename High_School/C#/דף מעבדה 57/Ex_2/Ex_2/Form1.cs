using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void CalcButton_Click(object sender, EventArgs e)
		{
			try { 
			switch(this.Operator.Text)
			{
				case("+"):
				{
					MessageBox.Show((Decimal.Parse(this.Number1.Text) + Decimal.Parse(this.Number2.Text)).ToString());
				}
				break;
				case("-"):
				{
					MessageBox.Show((Decimal.Parse(this.Number1.Text) - Decimal.Parse(this.Number2.Text)).ToString());
				}
				break;
				case("*"):
				{
					MessageBox.Show((Decimal.Parse(this.Number1.Text) * Decimal.Parse(this.Number2.Text)).ToString());
				}
				break;
				case("/"):
				{
					MessageBox.Show((Decimal.Parse(this.Number1.Text) / Decimal.Parse(this.Number2.Text)).ToString());
				}
				break;
				case("^"):
				{
					MessageBox.Show(Math.Pow(Double.Parse(this.Number1.Text), Double.Parse(this.Number2.Text)).ToString());
				}
				break;
				case("%"):
				{
					MessageBox.Show((Decimal.Parse(this.Number1.Text) % Decimal.Parse(this.Number2.Text)).ToString());
				}
				break;
				default:
				{
					throw new FormatException();
				}
				break;
			}
			}
			catch(Exception info)
			{
				MessageBox.Show("Error:\n\n"+info+"\n");
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.pictureBox1.ImageLocation = @"C:\Users\vlad\Desktop\Lab_57\Ex_3\Ex_3\Resources\pic_bulboff.gif";
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.pictureBox1.ImageLocation = this.pictureBox1.ImageLocation == @"C:\Users\vlad\Desktop\Lab_57\Ex_3\Ex_3\Resources\pic_bulboff.gif" ?
				this.pictureBox1.ImageLocation = @"C:\Users\vlad\Desktop\Lab_57\Ex_3\Ex_3\Resources\pic_bulbon.gif" :
				this.pictureBox1.ImageLocation = @"C:\Users\vlad\Desktop\Lab_57\Ex_3\Ex_3\Resources\pic_bulboff.gif";
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_1
{
	public partial class Convertor : Form
	{
		public Convertor()
		{
			InitializeComponent();
		}

		private void ConvertButton_MouseClick(object sender, MouseEventArgs e)
		{
			this.CTextBox.Text = (((int.Parse(this.FTextBox.Text)-32)*5)/9).ToString();
		}

        private void FTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

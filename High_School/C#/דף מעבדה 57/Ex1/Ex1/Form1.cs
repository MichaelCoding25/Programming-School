using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double temp;
            temp = Convert.ToDouble(textBox1.Text) - 32.0;
            temp = temp * 5.0;
            temp = temp / 9.0;
            textBox2.Text = Convert.ToString(temp);

        }
    }
}

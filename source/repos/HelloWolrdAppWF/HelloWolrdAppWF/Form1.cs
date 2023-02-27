using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWolrdAppWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            int n;
            if (int.TryParse(a, out n) && int.TryParse(b, out n))
            {
                int a_1 = Convert.ToInt32(a);
                int b_1 = Convert.ToInt32(b);
                int ab = a_1 + b_1;
                textBox3.Text = ab.ToString();
            }
            else {MessageBox.Show("Введите число, а не букву");
        }

    }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

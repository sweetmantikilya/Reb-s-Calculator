using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.IndianRed;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c;
            if (radioButton1.Checked)
            {
                c = a + b;
                label5.Text = c.ToString();
            }
            else if (radioButton2.Checked) 
            {
                c = a - b;
                label5.Text = c.ToString();
            }
            else if (radioButton3.Checked)
            {
                c = a * b;
                label5.Text = c.ToString();
            }
            else if (radioButton4.Checked)
            { 
                c = a / b;
                label5.Text = c.ToString();
            }
            else if (radioButton5.Checked)
            {
                c = a % b;
                label5.Text = c.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}

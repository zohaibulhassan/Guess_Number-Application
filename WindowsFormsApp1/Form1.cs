using Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Form2 a = new Form2();
        Form3 b = new Form3();
        
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            int R = rnd.Next(1, 25);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            a.n1 = textBox1.Text;

            if (radioButton1.Checked && this.textBox1.Text == "abc" & this.textBox2.Text == "123")
            {
                a.Show();
            }
            else
            {
                this.Show();
            }
            b.b1 = textBox2.Text;
            if (radioButton2.Checked && this.textBox1.Text == "abc" & this.textBox2.Text == "123")
            {
                b.Show();
            }
            else
            {
                this.Show();
            }  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}

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
    public partial class Form3 : Form
    {
        int b, count = 0;
        public string b1;
       public static Random ert = new Random();
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Text = ert.Next(1, 20).ToString();

            int val = Convert.ToInt32(button2.Text);
            b += val;
            count++;
            this.button2.Enabled = false;
           

            
            
            
            if (count > 2)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                if (b > 50)
                {
                    MessageBox.Show("Congratz" + b1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + b1);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button3.Text = ert.Next(1, 20).ToString();

            int val = Convert.ToInt32(button3.Text);
            b += val;
            count++;
            this.button3.Enabled = false;
            

            
            if (count > 2)
            {
                this.button2.Enabled = false;
                this.button1.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                if (b > 50)
                {
                    MessageBox.Show("Congratz" + b1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + b1);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.button4.Text = ert.Next(1, 20).ToString();
            int val = Convert.ToInt32(button4.Text);
            b += val;
            count++;
            this.button4.Enabled = false;
            

           
            if (count > 2)
            {
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button1.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                if (b > 2)
                {
                    MessageBox.Show("Congratz" + b1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + b1);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.button5.Text = ert.Next(1, 20).ToString();
            int val = Convert.ToInt32(button5.Text);
            b += val;
            count++;
            this.button5.Enabled = false;
            

           
            if (count > 2)
            {
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button1.Enabled = false;
                this.button6.Enabled = false;
                if (b > 2)
                {
                    MessageBox.Show("Congratz" + b1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + b1);
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.button6.Text = ert.Next(1, 20).ToString();

            int val = Convert.ToInt32(button6.Text);
            b += val;
            count++;
            this.button6.Enabled = false;
            

            
            if (count > 2)
            {
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button1.Enabled = false;
                if (b > 50)
                {
                    MessageBox.Show("Congratz" + b1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + b1);
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            count = 0;
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;
            this.button5.Enabled = true;
            this.button6.Enabled = true;
            this.button1.Text = "";
            this.button2.Text = "";
            this.button3.Text = "";
            this.button4.Text = "";
            this.button5.Text = "";
            this.button6.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Text = ert.Next(1, 20).ToString();

            int val = Convert.ToInt32(button1.Text);
            b += val;
            count++;
            this.button1.Enabled = false;
            
           

            
            if (count > 1)
            {
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                if (b > 50)
                {
                    MessageBox.Show("Congratz" + b1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + b1);
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game
{
    public partial class Form2 : Form

    {
        
       
        int n, count = 0 ;
        public string n1;
        public static Random rnd = new Random();
        int ron = rnd.Next(1,20);

        public Form2()
        {
            InitializeComponent();
            
        }
        private void button11_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            count = 0;
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;
            this.button5.Enabled = true;
            this.button6.Enabled = true;
            this.button7.Enabled = true;
            this.button8.Enabled = true;
            this.button9.Enabled = true;
            this.button1.Text = "";
            this.button2.Text = "";
            this.button3.Text = "";
            this.button4.Text = "";
            this.button5.Text = "";
            this.button6.Text = "";
            this.button7.Text = "";
            this.button8.Text = "";
            this.button9.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.button1.Text = rnd.Next(1, 20).ToString();

            int val = Convert.ToInt32(button1.Text);
            n += val;
            count++;
            this.button1.Enabled = false;
            if (count > 3)
            {
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + n1);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            this.button2.Text = rnd.Next(1, 20).ToString();

            int val = Convert.ToInt32(button2.Text);
            n += val;
            count++;
            this.button2.Enabled = false;
            if (count > 3)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + n1);
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.button4.Text = rnd.Next(1, 20).ToString();

            int val = Convert.ToInt32(button4.Text);
            n += val;
            count++;
            this.button4.Enabled = false;
            if (count > 3)
            {
                this.button3.Enabled = false;
                this.button2.Enabled = false;
                this.button1.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + n1);
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.button5.Text = rnd.Next(1, 20).ToString();

            int val = Convert.ToInt32(button5.Text);
            n += val;
            count++;
            this.button5.Enabled = false;
            if (count > 3)
            {
                this.button3.Enabled = false;
                this.button2.Enabled = false;
                this.button4.Enabled = false;
                this.button1.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + n1);
                }
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.button6.Text = rnd.Next(1, 20).ToString();

            int val = Convert.ToInt32(button6.Text);
            n += val;
            count++;
            this.button6.Enabled = false;
            if (count > 3)
            {
                this.button3.Enabled = false;
                this.button2.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button1.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + n1);
                }
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.button7.Text = rnd.Next(1, 20).ToString();

            int val = Convert.ToInt32(button7.Text);
            n += val;
            count++;
            this.button7.Enabled = false;
            if (count > 3)
            {
                this.button3.Enabled = false;
                this.button2.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button1.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + n1);
                }
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

            this.button8.Text = rnd.Next(1, 20).ToString();

            int val = Convert.ToInt32(button8.Text);
            n += val;
            count++;
            this.button8.Enabled = false;
            if (count > 3)
            {
                this.button3.Enabled = false;
                this.button2.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button1.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + n1);
                }
            }


        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.button9.Text = rnd.Next(1, 20).ToString();

            int val = Convert.ToInt32(button9.Text);
            n += val;
            count++;
            this.button9.Enabled = false;
            if (count > 3)
            {
                this.button3.Enabled = false;
                this.button2.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button1.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + n1);
                }
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.button3.Text = rnd.Next(1, 20).ToString();

            int val = Convert.ToInt32(button3.Text);
            n += val;
            count++;
            this.button3.Enabled = false;
            if (count > 3)
            {
                this.button4.Enabled = false;
                this.button2.Enabled = false;
                this.button1.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (n > 50)
                {
                    MessageBox.Show("Congratz" + n1 + "You Win");
                }
                else
                {
                    MessageBox.Show("You Lose" + n1);
                }
            }

            
        }
    } }

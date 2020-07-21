using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Unipa.Project1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fibonacci_num = Convert.ToInt32(textBox1.Text);

            if (fibonacci_num <= 0)
            {
                label3.Text = "Please enter a valid number";
            }
            else if (fibonacci_num == 1)
            {
                label3.Text = "Fibonacci Number 1 = 0";
            }
            else if (fibonacci_num == 2)
            {
                label3.Text = "Fibonacci Number 2 = 1";
            }   
            else
            {
                var firstnum = 0;
                var secondnum = 1;
                var temp = 0;
                for (var i = 1; i < fibonacci_num-1; i++)
                {
                    temp = firstnum;
                    firstnum = secondnum;
                    secondnum = firstnum + temp;
                    
                }


                label3.Text = "Fibonacci Number " + fibonacci_num + " = " + secondnum;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

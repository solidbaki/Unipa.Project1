using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Unipa.Project1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string zigzag = "";
            
            for (var i = 1; i<=200; i++)
            {
                if (i % 5 == 0 && i % 3 == 0 && i > 100)
                {
                    zigzag += "zagzig ";
                }
                else if (i % 5 == 0 && i % 3 == 0)
                {
                    zigzag += "zigzag ";
                } else if (i % 3 == 0)
                {
                    zigzag += "zig ";
                } else if (i % 5 == 0)
                {
                    zigzag += "zag ";
                } else
                {
                    zigzag += Convert.ToString(i)+" ";
                }

                label1.Text = zigzag;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}

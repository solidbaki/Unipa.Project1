using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Unipa.Project1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            string multiplicationTable = "";

            if (num > 0)
            {
                for (int i = 0; i <= num; i++)
                {
                    if (i != 0)
                    {
                        // If i is 0, multiplication is not possible, so print each element for the first line
                        multiplicationTable += Convert.ToString(i) + "  ";
                        for (int j = 1; j <= num; j++)
                        {
                            int result = j * i;
                            multiplicationTable += Convert.ToString(result) + "  ";
                        }
                    }
                    else
                    {
                        for (int k = 0; k <= num; k++)
                        {
                            multiplicationTable += Convert.ToString(k) + "  ";
                        }
                    }


                    multiplicationTable += "\n";
                }

                label2.Text = multiplicationTable;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

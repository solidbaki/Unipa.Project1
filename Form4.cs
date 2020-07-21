using Markdig.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Unipa.Project1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var numbers = new List<double>();
            //Stream stream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Browse a text file";
            openFileDialog.DefaultExt = "txt";
            openFileDialog.ShowDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(openFileDialog.FileName);
                text += "\n  \n";

                using (StringReader reader = new StringReader(text))
                {
                    String line = reader.ReadLine();
                    while (reader.ReadLine() != null)
                    {
                        line = reader.ReadLine();
                        if (line != null)
                        {
                            var split_nums = line.Split(' ');
                            foreach (var num in split_nums)
                            {
                                numbers.Add(Convert.ToDouble(num));
                            }
                        }
                    }
                    numbers.Sort();

                    foreach (var num in numbers)
                    {
                        text += Convert.ToString(" " + num);
                    }
                    label2.Text = text;
                }



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}

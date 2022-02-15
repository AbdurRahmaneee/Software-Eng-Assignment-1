using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace DAQ_application
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        float[] terms = new float[500];
        float[] ase1 = new float[500];
        float[] ase2 = new float[500];
        float[] ase3 = new float[500];
        float[] ase4 = new float[500];
        float[] ase5 = new float[500];
        float[] ase6 = new float[500];
        float[] ase7 = new float[500];
        float[] ase8 = new float[500];
        float[] ase9 = new float[500];
        float[] digi1 = new float[500];
        float[] digi2 = new float[500];
        float[] digi3 = new float[500];
        float[] digi4 = new float[500];
        string separator = ", ";

        public void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {

                MessageBox.Show("Please enter values");
            }
            else
            {
                try
                {

                    int atx = int.Parse(textBox1.Text);
                    int btx = int.Parse(textBox2.Text);






                    for (int i = 0; i < btx; i++)
                    {
                        float a = float.Parse(textBox1.Text);
                        Random rnd = new Random();
                        int month = rnd.Next(-5, 6);
                        int ana1 = rnd.Next(-5, 6);
                        Thread.Sleep(10);
                        int ana2 = rnd.Next(-5, 6);
                        Thread.Sleep(10);
                        int ana3 = rnd.Next(-5, 6);
                        Thread.Sleep(10);
                        int ana4 = rnd.Next(-5, 6);
                        Thread.Sleep(10);
                        int ana5 = rnd.Next(-5, 6);
                        int ana6 = rnd.Next(-5, 6);
                        int ana7 = rnd.Next(-5, 6);
                        Thread.Sleep(10);
                        int ana8 = rnd.Next(-5, 6);
                        Thread.Sleep(10);
                        int ana9 = rnd.Next(-5, 6);
                        Thread.Sleep(10);
                        int dig1 = rnd.Next(0, 2);
                        Thread.Sleep(10);
                        int dig2 = rnd.Next(0, 2);
                        Thread.Sleep(10);
                        int dig3 = rnd.Next(0, 2);
                        Thread.Sleep(10);
                        int dig4 = rnd.Next(0, 2);
                        Thread.Sleep(10);

                        Thread.Sleep(atx*1000);
                        Thread.Sleep(10);

                        ase1[i] = ana1;
                        ase2[i] = ana2;
                        ase3[i] = ana3;
                        ase4[i] = ana4;
                        ase5[i] = ana5;
                        ase6[i] = ana6;
                        ase7[i] = ana7;
                        ase8[i] = ana8;
                        ase9[i] = ana9;
                        digi1[i] = dig1;
                        digi2[i] = dig2;
                        digi3[i] = dig3;
                        digi4[i] = dig4;

                        terms[i] = month;
                        Thread.Sleep(400);

                    }

                   


                   


                }
                catch
                {



                }

            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Text == "Analog sensor 1")
            {

                richTextBox1.Text = string.Join(separator, ase1);
                MessageBox.Show(string.Join(separator, ase1));

            }
            if (listBox1.Text == "Analog sensor 2")
            {

                richTextBox1.Text = string.Join(separator, ase2);
                MessageBox.Show(string.Join(separator, ase2));

            }
            if (listBox1.Text == "Analog sensor 3")
            {

                richTextBox1.Text = string.Join(separator, ase3);
                MessageBox.Show(string.Join(separator, ase3));

            }
            if (listBox1.Text == "Analog sensor 4")
            {

                richTextBox1.Text = string.Join(separator, ase4);
                MessageBox.Show(string.Join(separator, ase4));

            }
            if (listBox1.Text == "Analog sensor 5")
            {

                richTextBox1.Text = string.Join(separator, ase5);
                MessageBox.Show(string.Join(separator, ase5));

            }
            if (listBox1.Text == "Analog sensor 6")
            {

                richTextBox1.Text = string.Join(separator, ase6);
                MessageBox.Show(string.Join(separator, ase6));

            }
            if (listBox1.Text == "Analog sensor 7")
            {

                richTextBox1.Text = string.Join(separator, ase7);
                MessageBox.Show(string.Join(separator, ase7));

            }
            if (listBox1.Text == "Analog sensor 8")
            {

                richTextBox1.Text = string.Join(separator, ase8);
                MessageBox.Show(string.Join(separator, ase8));

            }
            if (listBox1.Text == "Analog sensor 9")
            {

                richTextBox1.Text = string.Join(separator, ase9);
                MessageBox.Show(string.Join(separator, ase9));

            }
            if (listBox1.Text == "Digital sensor 1")
            {

                richTextBox1.Text = string.Join(separator, digi1);
                MessageBox.Show(string.Join(separator, digi1));

            }
            if (listBox1.Text == "Digital sensor 2")
            {

                richTextBox1.Text = string.Join(separator, digi2);
                MessageBox.Show(string.Join(separator, digi2));

            }
            if (listBox1.Text == "Digital sensor 1")
            {

                richTextBox1.Text = string.Join(separator, digi3);
                MessageBox.Show(string.Join(separator, digi3));

            }
            if (listBox1.Text == "Digital sensor 2")
            {

                richTextBox1.Text = string.Join(separator, digi4);
                MessageBox.Show(string.Join(separator, digi4));

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }




        private void button3_Click(object sender, EventArgs e)
        {


            var csv = new StringBuilder();
            for (int i = 0; i < ase1.Length; i++)
            {
                string first = ase1[i].ToString();
                
                string newLine = string.Format("{0},{1}{2}", first, Environment.NewLine);
                csv.Append(newLine);

            }
            //after your loop
            File.WriteAllText("D:\\files.csv", csv.ToString());


        }
    }
}

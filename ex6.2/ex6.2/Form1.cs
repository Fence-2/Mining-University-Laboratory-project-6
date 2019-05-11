using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text.ToString();
            listBox1.Items.Add(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;
            char[] k = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < len; i++)
            {
                for (int g = 0; g < 10; g++)
                {
                    if (str[i] == k[g])
                    {
                        label2.Text += str[i];
                    }
                }
            }
        }
    }
}

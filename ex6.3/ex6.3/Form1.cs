using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex6._3
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
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;
            string n = "";
            for (int i = len - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    n += str[i];
                }
            }
            listBox1.Items.Add(n);
        }
    }
}

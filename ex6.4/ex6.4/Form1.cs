using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex6._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string str1, str2;
        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            listBox1.Items.Add(s);
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            str1 = str2 = "";
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                if (i % 2 != 0)
                {
                    str1 += str[i];
                }
                else
                {
                    str2 += str[i];
                }
            }
            listBox1.Items.Add(str1);
            listBox1.Items.Add(str2);
        }
    }
}

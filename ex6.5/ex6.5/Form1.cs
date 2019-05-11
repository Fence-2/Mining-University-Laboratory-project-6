using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex6._5
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            listBox1.Items.Add(s);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label2.Text = "";
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;
            char[] k = { '0', '2', '4', '6', '8' };
            for (int i = 0; i < len; i++)
            {
                for (int g = 0; g < 5; g++)
                {
                    if (str[i] == k[g])
                    {
                        count++;
                    }
                }
            }
            label2.Text = $"Количество чётных чисел = {count}";
        }
    }
}

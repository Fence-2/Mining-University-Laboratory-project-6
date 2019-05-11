using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex6._7
{
    public partial class Form1 : Form
    {
        int p;
        string str1, str2, str3;
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
            str1 = str2 = str3 = "";
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;
            char[] k = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int i = 0; i < len; i++)
            {
                p = 0;
                for (int g = 0; g < 10; g++)
                {
                    if (str[i] == k[g])
                    {
                        str1 += str[i];
                        p++;
                    }
                }
                if (Char.IsPunctuation(str[i]) == true)
                    str2 += str[i];
                else if (p != 1)
                    str3 += str[i];

            }
            if (str1 != "")
                listBox1.Items.Add(str1);
            if (str2 != "")
                listBox1.Items.Add(str2);
            if (str3 != "")
                listBox1.Items.Add(str3);
        }
    }
}

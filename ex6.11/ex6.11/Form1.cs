using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex6._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string t = textBox1.Text.ToString();
            listBox1.Items.Add(t);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            char o = ' ', p = ' ';
            int t = 0;
            int q = Convert.ToInt32(textBox2.Text);
            int w = Convert.ToInt32(textBox3.Text);
            int index = listBox1.SelectedIndex;
            string a = (string)listBox1.Items[index];
            int x = a.Length;
            for (int i = 0; i < x; i++)
            {
                if (!(a[i] == ' '))
                    t++;
                if ((t == q) && !(a[i] == ' '))
                    o = a[i];
                if ((t == w) && !(a[i] == ' '))
                    p = a[i];

            }
            t = 0;
            for (int i = 0; i < x; i++)
            {
                if (!(a[i] == ' '))
                    t++;
                if (t == q && !(a[i] == ' '))
                {
                    label2.Text += p;
                }
                else
                if (t == w && !(a[i] == ' '))
                {
                    label2.Text += o;
                }
                else label2.Text += a[i];

            }
            label2.Text += o;

        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex6._14
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
            bool s = false;
            int l = 0;
            label2.Text = "";
            int index = listBox1.SelectedIndex;
            string a = (string)listBox1.Items[index];
            int x = a.Length;
            for (int i = 0; i < x; i++)
            {
                if (s == false && char.IsLetter(a[i]))
                {
                    s = true;

                }
                if (s == true && char.IsLetter(a[i]))
                    l++;
                if (s == true && a[i] == ' ')
                {
                    s = false;
                    label2.Text += l.ToString();
                    l = 0;
                }
                if (i == x - 1)
                    label2.Text += l.ToString();
            }
        }
    }
}

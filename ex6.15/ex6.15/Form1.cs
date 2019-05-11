using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex6._15
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
            int y = 0;
            label2.Text = "";

            char q = ' ';
            int index = listBox1.SelectedIndex;
            string a = (string)listBox1.Items[index];
            int x = a.Length;
            for (int i = 0; i < x; i++)
            {
                if (a[i] == ' ')
                {
                    q = a[i - 1];
                    a = a.Remove(i - 1, 1);
                    a = a.Insert(i - 1, a[y].ToString());
                    a = a.Remove(y, 1);
                    a = a.Insert(y, q.ToString());
                    y = i + 1;

                }
                if (i == x - 1)
                {
                    q = a[i];
                    a = a.Remove(i, 1);
                    a = a.Insert(i, a[y].ToString());
                    a = a.Remove(y, 1);
                    a = a.Insert(y, q.ToString());
                    y = i + 1;
                }



            }
            label2.Text = a;
        }
    }
}

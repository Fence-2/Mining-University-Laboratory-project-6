using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex6._8
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
            string label = "";
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            string rus = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            int fulllen = str.Length;
            int ruslen = rus.Length;
            for (int i = 0; i < fulllen; i++)
            {
                for (int g = 0; g < ruslen; g++)
                {
                    if (str[i] == rus[g])
                    {
                        label += str[i];
                    }
                }
            }
            label2.Text = label;
        }
    }
}

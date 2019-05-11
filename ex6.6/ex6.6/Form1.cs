using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex6._6
{
    public partial class Form1 : Form
    {
        int count;
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
            count = 0;
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
                        count++;
                    }
                }
            }
            label2.Text = $"Количество строчных русских символов = {count}";
        }
    }
}

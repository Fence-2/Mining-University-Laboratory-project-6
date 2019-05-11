using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex6._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];

            int len = str.Length;

            int count = 0;

            int i = 0;
            while (i < len)
            {
                if (str[i] == ' ')
                    count++;
                i++;
            }
            label1.Text = "Количество пробелов = " + count.ToString();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("Hello white world!");
            listBox1.Items.Add("1 2 3 4 5 6");
        }
    }
}

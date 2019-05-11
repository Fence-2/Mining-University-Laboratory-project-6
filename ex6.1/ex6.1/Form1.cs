using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex6._1
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
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;
            int countP, countZ, count0, count1;
            bool b;
            countZ = count0 = count1 = 0;
            int i = 0;
            
            if ((str[len - 1] != ' ') && Char.IsPunctuation(str[len-1]) == false)
            {
                countP = 1;
            }
            else
            {
                countP = 0; 
            }
            for (int k = 0; k < len; k++)
            {
                if (k < len - 1)
                {
                    if (Char.IsPunctuation(str[k + 1]) || (str[k + 1] == ' '))
                    {
                        b = true;
                    }
                    else
                    {
                        b = false;
                    }
                }
                else
                {
                    b = false;
                }
                if (b && ((str[k] != ' ') && Char.IsPunctuation(str[k]) == false))
                {
                    countP++;
                }
            }

            while (i < len)
            {

                if (str[i] == '0')
                    count0++;
                if (str[i] == '1')
                    count1++;
                if (char.IsPunctuation(str[i]))
                    countZ++;
                i++;
            }

            label2.Text = "Количество слов: " + countP + Environment.NewLine + "Количество нулей: " + count0 + Environment.NewLine + "Количество единиц: " + count1 + Environment.NewLine + "Количество знаков препинания: " + countZ;
        }
    }
}

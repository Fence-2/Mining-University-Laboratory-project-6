﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex6._10
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
            bool bo = false;
            int index = listBox1.SelectedIndex;
            string a = (string)listBox1.Items[index];
            int x = a.Length;
            for (int i = 0; i < x; i++)
            {
                if ((bo == false) && !(a[i] == ' '))
                {
                    bo = true;
                }
                else label2.Text += a[i].ToString();
                if ((bo == true) && (a[i] == ' '))
                    bo = false;
            }
        }
    }
}


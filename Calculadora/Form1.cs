﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBoxRes.Text += "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            
            foreach (char pos in textBoxRes.Text)
            {
                int val1 = int.Parse(pos.ToString().Split('+'));

            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            textBoxRes.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

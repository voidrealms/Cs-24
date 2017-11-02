﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sColor = "";

            if (radioButton1.Checked)
            {
                sColor = radioButton1.Text;
            }

            if (radioButton2.Checked)
            {
                sColor = radioButton2.Text;
            }


            if (radioButton3.Checked)
            {
                sColor = radioButton3.Text;
            }

            MessageBox.Show(sColor);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetColor(radioButton4);
            GetColor(radioButton5);
            GetColor(radioButton6);
        }

        private void GetColor(RadioButton rdoButton)
        {
            if (rdoButton.Checked)
            {
                MessageBox.Show(rdoButton.Text);
            }
        }
    }
}

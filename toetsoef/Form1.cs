﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toetsoef
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int teller = 0; teller < 10; teller++)
            {
                MessageBox.Show("Maggie");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23pr
{
    public partial class Ex3 : Ex2
    {
        public Ex3()
        {
            InitializeComponent();
        }

        private void Ex3_Load(object sender, EventArgs e)
        {
            this.Text = "Задание 3";
            label1.Text = DateTime.Now.ToString();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A10Blok
{
    public partial class Uputstvo : Form
    {
        public Uputstvo()
        {
            InitializeComponent();
        }

        private void Uputstvo_Load(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"../../A10.rtf");
        }
    }
}

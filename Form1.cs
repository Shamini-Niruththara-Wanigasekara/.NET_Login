﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbwelcome.Text = "";
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String Email = txtemail.Text;
            String Password = txtpassword.Text;
            lbwelcome.Text = "Hello User !";

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            txtemail.Text = "";
            txtpassword.Text = "";
            lbwelcome.Text = "";

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien.FormFolder
{
    public partial class LoginForm : AbstractForms.BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbstractForms.BaseForm Form1 = new AdminForms.AdminMain();
            Form1.ShowDialog();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Topic3.FormFolder.AbstractForms
{
    public partial class EditInfo : BaseForm
    {
        public EditInfo() :base()
        {
            InitializeComponent();
        }
        protected virtual void Form_Load(object sender, EventArgs e){}

        protected virtual void btnSave_Click(object sender, EventArgs e){}
    }
}

using System;
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
    public abstract partial class MainRule : BaseForm
    {
        public MainRule()
        {
            InitializeComponent();
        }

        protected abstract void btnEditInfo_Click(object sender, EventArgs e);

        protected abstract void btnViewTimetable_Click(object sender, EventArgs e);
    }
}

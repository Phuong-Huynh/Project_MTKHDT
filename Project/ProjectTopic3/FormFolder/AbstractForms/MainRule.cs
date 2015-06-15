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
    public partial class MainRule : BaseForm
    {
        protected MainRule()
        {
            InitializeComponent();
        }

        protected virtual void btnEditInfo_Click(object sender, EventArgs e) {
            MessageBox.Show("koko");
        }

        protected virtual void btnViewTimetable_Click(object sender, EventArgs e) { }
    }
}

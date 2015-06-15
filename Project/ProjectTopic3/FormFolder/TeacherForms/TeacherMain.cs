using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Topic3.FormFolder.TeacherForms
{
    public partial class TeacherMain : AbstractForms.MainRule
    {
        public TeacherMain() : base() { InitializeComponent(); }

        protected override void btnEditInfo_Click(object sender, EventArgs e)
        {
            AbstractForms.BaseForm formAcc = new TeacherEditInfo();
            formAcc.ShowDialog();
        }

        protected override void btnViewTimetable_Click(object sender, EventArgs e)
        {
            AbstractForms.BaseForm formAcc = new TeacherViewTimetable();
            formAcc.ShowDialog();
        }
    }
}

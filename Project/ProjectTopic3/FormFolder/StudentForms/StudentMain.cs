using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Topic3.FormFolder.StudentForms
{
    public partial class StudentMain : AbstractForms.MainRule
    {
        public StudentMain() {
            InitializeComponent();
        }

        private void btnRegisSubj_Click(object sender, EventArgs e)
        {
            AbstractForms.BaseForm formAcc = new StudentRegistSubject();
            formAcc.ShowDialog();
        }

        protected override void btnEditInfo_Click(object sender, EventArgs e)
        {
            AbstractForms.BaseForm formAcc = new StudentEditInfo();
            formAcc.ShowDialog();
        }

         protected override void btnViewTimetable_Click(object sender, EventArgs e)
        {
            AbstractForms.BaseForm formAcc = new StudentViewTimetable();
            formAcc.ShowDialog();
        }
    }
}

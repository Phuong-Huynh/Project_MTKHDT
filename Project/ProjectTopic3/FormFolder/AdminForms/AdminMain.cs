using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Topic3.FormFolder.AdminForms
{
    public partial class AdminMain : AbstractForms.BaseForm
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void btnAccessClass_Click(object sender, EventArgs e)
        {
            AbstractForms.BaseForm formAcc = new AdminAccClass();
            formAcc.ShowDialog();
        }

        private void btnRating_Click(object sender, EventArgs e)
        {
            AbstractForms.BaseForm formAcc = new AdminRate();
            formAcc.ShowDialog();
        }

        private void btnAccessSubject_Click(object sender, EventArgs e)
        {
            AbstractForms.BaseForm formAcc = new AdminAccSubject();
            formAcc.ShowDialog();
        }

        private void btnAccessStudent_Click(object sender, EventArgs e)
        {
            AbstractForms.BaseForm formAcc = new AdminAccStudent();
            formAcc.ShowDialog();
        }

        private void btnAccessTeacher_Click(object sender, EventArgs e)
        {
            AbstractForms.BaseForm formAcc = new AdminAccTeacher();
            formAcc.ShowDialog();
        }

        private void btnAccessTimetable_Click(object sender, EventArgs e)
        {
            AbstractForms.BaseForm formAcc = new AdminAccTimetable();
            formAcc.ShowDialog();
        }
    }
}

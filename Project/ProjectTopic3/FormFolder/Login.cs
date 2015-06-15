using Project_Topic3.FormFolder.AdminForms;
using Project_Topic3.FormFolder.StudentForms;
using Project_Topic3.FormFolder.TeacherForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Topic3.FormFolder
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

        private void button1_Click(object sender, EventArgs e)
        {
            new AdminMain().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new StudentMain().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new TeacherMain().ShowDialog();
        }
    }
}

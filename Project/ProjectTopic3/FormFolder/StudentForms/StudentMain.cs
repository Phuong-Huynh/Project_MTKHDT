using Project_Topic3.DataLayer;
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
        protected HocSinh student = new HocSinh();

        public StudentMain(HocSinh Stu) {
            //this.student = Stu;
            this.lblTitle.Text = "QUẢN LÝ HỌC SINH";
            InitializeComponent();

            this.student.MSSV = "1234";
            this.student.HoTen = "Luong thu thao";
            this.student.NgaySinh = new DateTime(2014, 09, 12);
            this.student.DiaChi = "12, tran phu, tphcm";
        }

        private void btnRegisSubj_Click(object sender, EventArgs e)
        {
            //Chú ý: truyền 1 đối tượng học sinh vào
            AbstractForms.BaseForm formAcc = new StudentRegistSubject(student);
            formAcc.ShowDialog();
        }

        protected override void btnEditInfo_Click(object sender, EventArgs e)
        {
            //Chú ý: truyền 1 đối tượng học sinh vào
            AbstractForms.BaseForm formAcc = new StudentEditInfo(student);
            formAcc.ShowDialog();
        }

        protected override void btnViewTimetable_Click(object sender, EventArgs e)
        {
            AbstractForms.BaseForm formAcc = new StudentViewTimetable();
            formAcc.ShowDialog();
        }

        protected override void Form_Load(object sender, EventArgs e)
        {
            this.lbMSSV.Text = this.student.MSSV;
            this.lbAddress.Text = this.student.DiaChi;
            this.lbBirthDay.Text = this.student.NgaySinh.ToString();
            this.lbName.Text = this.student.HoTen;
        }
    }
}

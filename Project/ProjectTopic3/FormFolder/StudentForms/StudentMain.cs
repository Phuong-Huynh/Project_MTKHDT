using Project_Topic3.DataLayer.DAO;
//using Project_Topic3.DataLayer;
using Project_Topic3.DataLayer.DTO;
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
        protected HocSinhDTO student = new HocSinhDTO();

        public StudentMain(HocSinhDTO Stu)
        {
            //this.student = Stu;
            this.lblTitle.Text = "QUẢN LÝ HỌC SINH";
            InitializeComponent();

            //Thay the bang roi tuong : test
            HocSinhDAO hocSinhDAO = new HocSinhDAO();
            student = hocSinhDAO.convert(hocSinhDAO.get(1));
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
            AbstractForms.BaseForm formAcc = new StudentViewTimetable(student);
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

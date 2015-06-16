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
    public partial class StudentEditInfo : AbstractForms.EditInfo
    {
        protected HocSinh hocsinh;
        public StudentEditInfo(HocSinh Stu)
        {
            this.hocsinh = Stu;
            InitializeComponent(); 
        }

        protected override void Form_Load(object sender, EventArgs e)
        {
            this.tbxAddress.Text = this.hocsinh.DiaChi;
            this.tbxBirthday.Text = this.hocsinh.NgaySinh.ToString();
            this.tbxName.Text = this.hocsinh.HoTen;

        }
    }
}

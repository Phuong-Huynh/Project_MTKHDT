using Project_Topic3.DataLayer.DAO;
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
    public partial class StudentEditInfo : AbstractForms.EditInfo
    {
        protected HocSinhDTO hocsinh;
        public StudentEditInfo(HocSinhDTO Stu)
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

        protected override void btnSave_Click(object sender, EventArgs e)
        {
            hocsinh.DiaChi = this.tbxAddress.Text;
            hocsinh.NgaySinh = DateTime.Parse(this.tbxBirthday.Text);
            hocsinh.HoTen = this.tbxName.Text;
            HocSinhDAO hocSinhDAO = new HocSinhDAO();
            if(hocSinhDAO.update(hocSinhDAO.convertDTOToEntity(hocsinh)))
                MessageBox.Show("Cập nhật thành công");
            else
                MessageBox.Show("Cập nhật thất bại");
        }
    }
}

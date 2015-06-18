using Project_Topic3.DataLayer;
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
    public partial class StudentViewTimetable : AbstractForms.ViewTimetable
    {
        public StudentViewTimetable(HocSinhDTO Stu)
        {
            this.lblTitle.Text = "LỊCH HỌC";
            InitializeComponent(); 
        }

        protected override void Form_Load(object sender, System.EventArgs e)
        {
            HocKiDAO hocKiDAO = new HocKiDAO();
            List<HocKi> listHK = hocKiDAO.getList();

            cbxTerm.DataSource = listHK;
            cbxTerm.DisplayMember = "TenHK";

            cbxYear.DataSource = listHK;
            cbxYear.DisplayMember = "BatDau";
        }
    }
}

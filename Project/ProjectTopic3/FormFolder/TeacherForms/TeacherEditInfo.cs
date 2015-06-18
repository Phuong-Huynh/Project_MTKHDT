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

namespace Project_Topic3.FormFolder.TeacherForms
{
    public partial class TeacherEditInfo : AbstractForms.EditInfo
    {
        private GiangVien gv;

        public TeacherEditInfo() 
        {
            InitializeComponent(); 
        }

        public TeacherEditInfo(GiangVien gv)
        {
            InitializeComponent(); 
            this.gv = gv;
        }
        protected override void Form_Load(object sender, EventArgs e)
        {
            base.Form_Load(sender, e);
            tbxName.Text = gv.HoTen;
            tbxBirthday.Text = gv.NgaySinh.ToShortDateString();
            tbxAddress.Text = gv.DiaChi;
        }

        
    }
}

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
    public partial class StudentRegistSubject : AbstractForms.BaseForm
    {
        protected HocSinhDTO hocsinh;
        protected CTHocKiDAO ctHocKiDAO = new CTHocKiDAO();

        public StudentRegistSubject(HocSinhDTO Stu)
        {
            this.hocsinh = Stu;
            InitializeComponent();
        }

        protected override void Form_Load(object sender, EventArgs e)
        {
            List<CTHocKiDTO> dsMonHoc = ctHocKiDAO.getListDTO();
            dgvListSubjects.DataSource = dsMonHoc;
        }
    }
}

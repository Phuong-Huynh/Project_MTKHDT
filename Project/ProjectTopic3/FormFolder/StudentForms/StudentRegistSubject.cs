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
        
        public StudentRegistSubject(HocSinhDTO Stu)
        {
            this.hocsinh = Stu;
            InitializeComponent();
        }

        protected override void Form_Load(object sender, EventArgs e)
        {
            CTHocKiDAO ctHocKiDAO = new CTHocKiDAO();
            List<CTHocKiDTO> dsMonHoc = ctHocKiDAO.getListDTO();
            dgvListSubjects.DataSource = dsMonHoc;

            TkbDAO tkbDAO = new TkbDAO();
            HocSinhDAO hocSinhDAO = new HocSinhDAO();
            List<TKB> dsTKB = tkbDAO.getList(hocSinhDAO.convertDTOToEntity(hocsinh));
            List<CTHocKiDTO> dsMonDaDk = new List<CTHocKiDTO>();
            foreach (TKB temp in dsTKB) {
                CTHocKiDTO tempCT = ctHocKiDAO.convert(temp.CTHocKi);
                dsMonDaDk.Add(tempCT);
            }
            dgvRegistedSubject.DataSource = dsMonDaDk;
        }
    }
}

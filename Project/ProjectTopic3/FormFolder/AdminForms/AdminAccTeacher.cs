using Project_Topic3.DataLayer;
using Project_Topic3.DataLayer.DAO;
using Project_Topic3.DataLayer.DTO;
using Project_Topic3.FormFolder.AbstractForms;
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

namespace Project_Topic3.FormFolder.AdminForms
{
    public partial class AdminAccTeacher : AbstractForms.AccessObj
    {
        protected GiangVien gv;
        protected List<GiangVien> list;
        protected List<GiangVienDTO> listDTO;
        protected GiangVienDAO gvDao;
        public AdminAccTeacher()
        {
            InitializeComponent();
            gvDao = new GiangVienDAO();

        }
        protected GiangVien getCurrentRow()
        {
            if (dgvListObjects.RowCount > 0)
            {
                int id = Int32.Parse(dgvListObjects.CurrentRow.Cells["Id"].Value.ToString());
                return gvDao.get(id);
            }
            return null;

        }
        protected override void Form_Load(object sender, EventArgs e)
        {
            base.Form_Load(sender, e);
            listDTO = gvDao.getListDTO();
            this.dgvListObjects.DataSource = listDTO;
            gv = getCurrentRow();

        }
        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            base.btnAdd_Click(sender, e);

        }

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            base.btnDelete_Click(sender, e);
            gvDao.delete(gv.Id);
            this.dgvListObjects.Update();


        }

        protected override void dgvListObjects_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            base.dgvListObjects_MouseDoubleClick(sender, e);
            BaseForm f = new TeacherEditInfo(gv);
            f.ShowDialog();
        }


        protected override void dgvListObjects_MouseClick(object sender, MouseEventArgs e)
        {
            gv = this.getCurrentRow();
        }


    }
}

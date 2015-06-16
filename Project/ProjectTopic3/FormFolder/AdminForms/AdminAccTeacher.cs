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
        protected override void Form_Load(object sender, EventArgs e)
        {
            base.Form_Load(sender, e);
            listDTO = gvDao.getListDTO();
            this.dgvListObjects.DataSource = listDTO;

        }
        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            base.btnAdd_Click(sender, e);
        }

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            base.btnDelete_Click(sender, e);
        }
    }
}

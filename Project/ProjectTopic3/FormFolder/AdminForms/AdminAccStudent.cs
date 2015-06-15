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
    public partial class AdminAccStudent : AbstractForms.AccessObj
    {
        public AdminAccStudent() : base() { 

            InitializeComponent();
            this.lbTitleLayout.Text = "QUẢN LÝ HỌC SINH";
            this.lbTittleDataGridview.Text = "Danh sách học sinh";
            //this.dgvListObjects.ColumnAdded
        }
    }
}

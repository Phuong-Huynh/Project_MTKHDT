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
    public partial class AdminAccTimetable : AbstractForms.AccessObj
    {
        public AdminAccTimetable()
        {
            InitializeComponent();
            this.lbTitleLayout.Text = "QUẢN LÝ THỜI KHÓA BIỂU";
            this.lbTittleDataGridview.Text = "Danh sách thời khóa biểu";
        }
    }
}

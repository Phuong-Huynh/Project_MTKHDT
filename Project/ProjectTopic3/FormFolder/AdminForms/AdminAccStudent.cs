﻿using Project_Topic3.DataLayer;
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
    public partial class AdminAccStudent : AbstractForms.AccessObj
    {
        protected List<HocSinh> list;
        protected List<HocSinhDTO> listDTO;
        protected HocSinhDAO hsDAO;
        public AdminAccStudent() { 

            InitializeComponent();
            hsDAO = new HocSinhDAO();
            
            //this.dgvListObjects.ColumnAdded 
        }

        protected override void Form_Load(object sender, EventArgs e)
        {
            //base.Form_Load(sender, e);
            listDTO = hsDAO.getListDTO();
            this.dgvListObjects.DataSource = listDTO;

            //fill datagridview
            
        }
    }
}

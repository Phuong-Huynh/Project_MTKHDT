using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Topic3.FormFolder.AbstractForms
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MaximizeBox = false;
            this.InitializeComponent();
            
        }
        public void exit(){
            this.Close();
        }

        protected virtual void Form_Load(object sender, EventArgs e)
        {

        }
    }
}

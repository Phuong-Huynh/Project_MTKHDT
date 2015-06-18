namespace Project_Topic3.FormFolder.AdminForms
{
    partial class AdminAccTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            
            // 
            // lbTitleLayout
            // 
            this.lbTitleLayout.Size = new System.Drawing.Size(209, 24);
            this.lbTitleLayout.Text = "QUẢN LÝ GIÁO VIÊN";
            // 
            // lbTittleDataGridview
            // 
            this.lbTittleDataGridview.Size = new System.Drawing.Size(130, 16);
            this.lbTittleDataGridview.Text = "Danh sách giáo viên";
            // 
            // AdminAccTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 482);
            this.Name = "AdminAccTeacher";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
﻿namespace Project_Topic3.FormFolder.AdminForms
{
    partial class AdminAccStudent
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
            // lbTitleLayout
            // 
            this.lbTitleLayout.Size = new System.Drawing.Size(204, 24);
            this.lbTitleLayout.Text = "QUẢN LÝ HỌC SINH";
            // 
            // lbTittleDataGridview
            // 
            this.lbTittleDataGridview.Size = new System.Drawing.Size(124, 16);
            this.lbTittleDataGridview.Text = "Danh sách học sinh";
            // 
            // AdminAccStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 482);
            this.Name = "AdminAccStudent";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}
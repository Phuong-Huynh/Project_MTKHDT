﻿namespace Project_Topic3.FormFolder.StudentForms
{
    partial class StudentMain
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
            this.lbMSSV = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegisSubj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSSV.Location = new System.Drawing.Point(254, 71);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(57, 16);
            this.lbMSSV.TabIndex = 14;
            this.lbMSSV.Text = "1112223";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(170, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "MSSV:";
            // 
            // btnRegisSubj
            // 
            this.btnRegisSubj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisSubj.Location = new System.Drawing.Point(380, 213);
            this.btnRegisSubj.Name = "btnRegisSubj";
            this.btnRegisSubj.Size = new System.Drawing.Size(160, 40);
            this.btnRegisSubj.TabIndex = 15;
            this.btnRegisSubj.Text = "Đăng kí môn học";
            this.btnRegisSubj.UseVisualStyleBackColor = true;
            this.btnRegisSubj.Click += new System.EventHandler(this.btnRegisSubj_Click);
            // 
            // StudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 267);
            this.Controls.Add(this.btnRegisSubj);
            this.Controls.Add(this.lbMSSV);
            this.Controls.Add(this.label6);
            this.Name = "StudentMain";
            this.Text = "QUẢN LÝ HỌC SINH";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lbName, 0);
            this.Controls.SetChildIndex(this.lbAddress, 0);
            this.Controls.SetChildIndex(this.lbBirthDay, 0);
            this.Controls.SetChildIndex(this.btnEditInfo, 0);
            this.Controls.SetChildIndex(this.btnViewTimetable, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.lbMSSV, 0);
            this.Controls.SetChildIndex(this.btnRegisSubj, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegisSubj;
    }
}
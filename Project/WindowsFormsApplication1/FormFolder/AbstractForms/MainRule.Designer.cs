namespace GiaoDien.FormFolder.AbstractForms
{
    partial class MainRule
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBirthDay = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnEditInfo = new System.Windows.Forms.Button();
            this.btnViewTimetable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày sinh:";
            // 
            // lbBirthDay
            // 
            this.lbBirthDay.AutoSize = true;
            this.lbBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthDay.Location = new System.Drawing.Point(254, 129);
            this.lbBirthDay.Name = "lbBirthDay";
            this.lbBirthDay.Size = new System.Drawing.Size(65, 16);
            this.lbBirthDay.TabIndex = 8;
            this.lbBirthDay.Text = "12/2/1993";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(254, 157);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(143, 16);
            this.lbAddress.TabIndex = 7;
            this.lbAddress.Text = "123Nguyen Dinh Chieu";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(254, 100);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(127, 16);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Nguyen Hoang Han";
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditInfo.Location = new System.Drawing.Point(27, 213);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(160, 40);
            this.btnEditInfo.TabIndex = 11;
            this.btnEditInfo.Text = "Cập nhật thông tin";
            this.btnEditInfo.UseVisualStyleBackColor = true;
            // 
            // btnViewTimetable
            // 
            this.btnViewTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTimetable.Location = new System.Drawing.Point(203, 213);
            this.btnViewTimetable.Name = "btnViewTimetable";
            this.btnViewTimetable.Size = new System.Drawing.Size(160, 40);
            this.btnViewTimetable.TabIndex = 12;
            this.btnViewTimetable.Text = "Xem thời khóa biểu";
            this.btnViewTimetable.UseVisualStyleBackColor = true;
            // 
            // MainRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 290);
            this.Controls.Add(this.btnViewTimetable);
            this.Controls.Add(this.btnEditInfo);
            this.Controls.Add(this.lbBirthDay);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "MainRule";
            this.Text = "mainObj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbBirthDay;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnEditInfo;
        private System.Windows.Forms.Button btnViewTimetable;

    }
}
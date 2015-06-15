namespace Project_Topic3.FormFolder.AdminForms
{
    partial class AdminMain
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnRating = new System.Windows.Forms.Button();
            this.btnAccessTimetable = new System.Windows.Forms.Button();
            this.btnAccessTeacher = new System.Windows.Forms.Button();
            this.btnAccessClass = new System.Windows.Forms.Button();
            this.btnAccessStudent = new System.Windows.Forms.Button();
            this.btnAccessSubject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "TRANG QUẢN LÝ";
            // 
            // btnRating
            // 
            this.btnRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRating.Location = new System.Drawing.Point(404, 154);
            this.btnRating.Name = "btnRating";
            this.btnRating.Size = new System.Drawing.Size(160, 40);
            this.btnRating.TabIndex = 19;
            this.btnRating.Text = "Xếp hạng";
            this.btnRating.UseVisualStyleBackColor = true;
            this.btnRating.Click += new System.EventHandler(this.btnRating_Click);
            // 
            // btnAccessTimetable
            // 
            this.btnAccessTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccessTimetable.Location = new System.Drawing.Point(220, 154);
            this.btnAccessTimetable.Name = "btnAccessTimetable";
            this.btnAccessTimetable.Size = new System.Drawing.Size(160, 40);
            this.btnAccessTimetable.TabIndex = 20;
            this.btnAccessTimetable.Text = "Quản lý thời khóa biểu";
            this.btnAccessTimetable.UseVisualStyleBackColor = true;
            this.btnAccessTimetable.Click += new System.EventHandler(this.btnAccessTimetable_Click);
            // 
            // btnAccessTeacher
            // 
            this.btnAccessTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccessTeacher.Location = new System.Drawing.Point(220, 89);
            this.btnAccessTeacher.Name = "btnAccessTeacher";
            this.btnAccessTeacher.Size = new System.Drawing.Size(160, 40);
            this.btnAccessTeacher.TabIndex = 21;
            this.btnAccessTeacher.Text = "Quản lý giáo viên";
            this.btnAccessTeacher.UseVisualStyleBackColor = true;
            this.btnAccessTeacher.Click += new System.EventHandler(this.btnAccessTeacher_Click);
            // 
            // btnAccessClass
            // 
            this.btnAccessClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccessClass.Location = new System.Drawing.Point(33, 154);
            this.btnAccessClass.Name = "btnAccessClass";
            this.btnAccessClass.Size = new System.Drawing.Size(160, 40);
            this.btnAccessClass.TabIndex = 22;
            this.btnAccessClass.Text = "Quản lý lớp";
            this.btnAccessClass.UseVisualStyleBackColor = true;
            this.btnAccessClass.Click += new System.EventHandler(this.btnAccessClass_Click);
            // 
            // btnAccessStudent
            // 
            this.btnAccessStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccessStudent.Location = new System.Drawing.Point(33, 89);
            this.btnAccessStudent.Name = "btnAccessStudent";
            this.btnAccessStudent.Size = new System.Drawing.Size(160, 40);
            this.btnAccessStudent.TabIndex = 23;
            this.btnAccessStudent.Text = "Quản lý học sinh";
            this.btnAccessStudent.UseVisualStyleBackColor = true;
            this.btnAccessStudent.Click += new System.EventHandler(this.btnAccessStudent_Click);
            // 
            // btnAccessSubject
            // 
            this.btnAccessSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccessSubject.Location = new System.Drawing.Point(404, 89);
            this.btnAccessSubject.Name = "btnAccessSubject";
            this.btnAccessSubject.Size = new System.Drawing.Size(160, 40);
            this.btnAccessSubject.TabIndex = 24;
            this.btnAccessSubject.Text = "Quản lý môn học";
            this.btnAccessSubject.UseVisualStyleBackColor = true;
            this.btnAccessSubject.Click += new System.EventHandler(this.btnAccessSubject_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 267);
            this.Controls.Add(this.btnAccessSubject);
            this.Controls.Add(this.btnAccessStudent);
            this.Controls.Add(this.btnAccessClass);
            this.Controls.Add(this.btnAccessTeacher);
            this.Controls.Add(this.btnAccessTimetable);
            this.Controls.Add(this.btnRating);
            this.Controls.Add(this.label4);
            this.Name = "AdminMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRating;
        private System.Windows.Forms.Button btnAccessTimetable;
        private System.Windows.Forms.Button btnAccessTeacher;
        private System.Windows.Forms.Button btnAccessClass;
        private System.Windows.Forms.Button btnAccessStudent;
        private System.Windows.Forms.Button btnAccessSubject;
    }
}
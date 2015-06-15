namespace GiaoDien.FormFolder.StudentForms
{
    partial class StudentViewTimetable
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTimetable = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weekday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "THỜI KHÓA BIỂU";
            // 
            // dgvTimetable
            // 
            this.dgvTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Weekday,
            this.Time,
            this.Room,
            this.Score});
            this.dgvTimetable.Location = new System.Drawing.Point(29, 118);
            this.dgvTimetable.Name = "dgvTimetable";
            this.dgvTimetable.Size = new System.Drawing.Size(594, 119);
            this.dgvTimetable.TabIndex = 44;
            // 
            // Id
            // 
            this.Id.HeaderText = "STT";
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // Name
            // 
            this.Name.HeaderText = "Tên môn học";
            this.Name.Name = "Name";
            // 
            // Weekday
            // 
            this.Weekday.HeaderText = "Thứ";
            this.Weekday.Name = "Weekday";
            // 
            // Time
            // 
            this.Time.HeaderText = "Thời gian học";
            this.Time.Name = "Time";
            // 
            // Room
            // 
            this.Room.HeaderText = "Phòng";
            this.Room.Name = "Room";
            // 
            // Score
            // 
            this.Score.HeaderText = "Điểm";
            this.Score.Name = "Score";
            this.Score.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // StudentViewTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 305);
            this.Controls.Add(this.dgvTimetable);
            this.Controls.Add(this.label1);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dgvTimetable, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTimetable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weekday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}
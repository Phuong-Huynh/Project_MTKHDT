namespace Project_Topic3.FormFolder.AdminForms
{
    partial class AdminRate
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvResultRank = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTerm = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnClass = new System.Windows.Forms.RadioButton();
            this.rbtnSubject = new System.Windows.Forms.RadioButton();
            this.cbxSubject = new System.Windows.Forms.ComboBox();
            this.cbxClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultRank)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "Tiêu chí xếp hạng:";
            // 
            // dgvResultRank
            // 
            this.dgvResultRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultRank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.MSSV,
            this.Name,
            this.Score,
            this.Rank});
            this.dgvResultRank.Location = new System.Drawing.Point(51, 256);
            this.dgvResultRank.Name = "dgvResultRank";
            this.dgvResultRank.Size = new System.Drawing.Size(498, 279);
            this.dgvResultRank.TabIndex = 61;
            // 
            // Id
            // 
            this.Id.HeaderText = "STT";
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            // 
            // Name
            // 
            this.Name.HeaderText = "Họ tên";
            this.Name.Name = "Name";
            // 
            // Score
            // 
            this.Score.HeaderText = "Điểm số";
            this.Score.Name = "Score";
            // 
            // Rank
            // 
            this.Rank.HeaderText = "Thứ hạng";
            this.Rank.Name = "Rank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 60;
            this.label1.Text = "XẾP HẠNG HỌC SINH";
            // 
            // cbxTerm
            // 
            this.cbxTerm.FormattingEnabled = true;
            this.cbxTerm.Location = new System.Drawing.Point(210, 94);
            this.cbxTerm.Name = "cbxTerm";
            this.cbxTerm.Size = new System.Drawing.Size(220, 21);
            this.cbxTerm.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(155, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 63;
            this.label6.Text = "Học kì:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(225, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 66;
            this.label8.Text = "2015";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "Năm học:";
            // 
            // rbtnClass
            // 
            this.rbtnClass.AutoSize = true;
            this.rbtnClass.Checked = true;
            this.rbtnClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnClass.Location = new System.Drawing.Point(142, 157);
            this.rbtnClass.Name = "rbtnClass";
            this.rbtnClass.Size = new System.Drawing.Size(83, 20);
            this.rbtnClass.TabIndex = 67;
            this.rbtnClass.TabStop = true;
            this.rbtnClass.Text = "Theo lớp:";
            this.rbtnClass.UseVisualStyleBackColor = true;
            // 
            // rbtnSubject
            // 
            this.rbtnSubject.AutoSize = true;
            this.rbtnSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSubject.Location = new System.Drawing.Point(142, 181);
            this.rbtnSubject.Name = "rbtnSubject";
            this.rbtnSubject.Size = new System.Drawing.Size(90, 20);
            this.rbtnSubject.TabIndex = 68;
            this.rbtnSubject.Text = "Theo môn:";
            this.rbtnSubject.UseVisualStyleBackColor = true;
            // 
            // cbxSubject
            // 
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.Location = new System.Drawing.Point(252, 182);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Size = new System.Drawing.Size(121, 21);
            this.cbxSubject.TabIndex = 69;
            // 
            // cbxClass
            // 
            this.cbxClass.FormattingEnabled = true;
            this.cbxClass.Location = new System.Drawing.Point(252, 155);
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Size = new System.Drawing.Size(121, 21);
            this.cbxClass.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "Kết quả xếp hạng";
            // 
            // btnRate
            // 
            this.btnRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRate.Location = new System.Drawing.Point(394, 167);
            this.btnRate.Name = "btnRate";
            this.btnRate.Size = new System.Drawing.Size(94, 29);
            this.btnRate.TabIndex = 72;
            this.btnRate.Text = "Xếp hạng";
            this.btnRate.UseVisualStyleBackColor = true;
            // 
            // AdminRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 576);
            this.Controls.Add(this.btnRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxClass);
            this.Controls.Add(this.cbxSubject);
            this.Controls.Add(this.rbtnSubject);
            this.Controls.Add(this.rbtnClass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxTerm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvResultRank);
            this.Controls.Add(this.label1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultRank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvResultRank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTerm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.RadioButton rbtnClass;
        private System.Windows.Forms.RadioButton rbtnSubject;
        private System.Windows.Forms.ComboBox cbxSubject;
        private System.Windows.Forms.ComboBox cbxClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRate;
    }
}
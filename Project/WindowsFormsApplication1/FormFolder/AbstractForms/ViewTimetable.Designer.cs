namespace GiaoDien.FormFolder.AbstractForms
{
    partial class ViewTimetable
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxTerm = new System.Windows.Forms.ComboBox();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Năm học:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Học kì:";
            // 
            // cbxTerm
            // 
            this.cbxTerm.FormattingEnabled = true;
            this.cbxTerm.Location = new System.Drawing.Point(151, 65);
            this.cbxTerm.Name = "cbxTerm";
            this.cbxTerm.Size = new System.Drawing.Size(121, 21);
            this.cbxTerm.TabIndex = 40;
            // 
            // cbxYear
            // 
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Location = new System.Drawing.Point(426, 67);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(121, 21);
            this.cbxYear.TabIndex = 41;
            // 
            // ViewTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 265);
            this.Controls.Add(this.cbxYear);
            this.Controls.Add(this.cbxTerm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "ViewTimetable";
            this.Text = "ViewTimetable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxTerm;
        private System.Windows.Forms.ComboBox cbxYear;
    }
}
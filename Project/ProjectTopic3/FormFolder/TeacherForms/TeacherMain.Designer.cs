namespace Project_Topic3.FormFolder.TeacherForms
{
    partial class TeacherMain
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
            this.btnAddScores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddScores
            // 
            this.btnAddScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddScores.Location = new System.Drawing.Point(385, 213);
            this.btnAddScores.Name = "btnAddScores";
            this.btnAddScores.Size = new System.Drawing.Size(160, 40);
            this.btnAddScores.TabIndex = 13;
            this.btnAddScores.Text = "Nhập điểm";
            this.btnAddScores.UseVisualStyleBackColor = true;
            this.btnAddScores.Click += new System.EventHandler(this.btnAddScores_Click);
            // 
            // TeacherMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 290);
            this.Controls.Add(this.btnAddScores);
            this.Name = "TeacherMain";
            this.Text = "";
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lbName, 0);
            this.Controls.SetChildIndex(this.lbAddress, 0);
            this.Controls.SetChildIndex(this.lbBirthDay, 0);
            this.Controls.SetChildIndex(this.btnEditInfo, 0);
            this.Controls.SetChildIndex(this.btnViewTimetable, 0);
            this.Controls.SetChildIndex(this.btnAddScores, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddScores;
    }
}
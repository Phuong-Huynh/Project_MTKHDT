namespace Project_Topic3.FormFolder.AbstractForms
{
    partial class AccessObj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
        protected void InitializeComponent()
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbTitleLayout = new System.Windows.Forms.Label();
            this.lbTittleDataGridview = new System.Windows.Forms.Label();
            this.dgvListObjects = new System.Windows.Forms.DataGridView();
            this.IdObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthdayObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListObjects)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(164, 413);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 42);
            this.btnDelete.TabIndex = 64;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(391, 413);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 42);
            this.btnAdd.TabIndex = 63;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbTitleLayout
            // 
            this.lbTitleLayout.AutoSize = true;
            this.lbTitleLayout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleLayout.Location = new System.Drawing.Point(250, 12);
            this.lbTitleLayout.Name = "lbTitleLayout";
            this.lbTitleLayout.Size = new System.Drawing.Size(165, 24);
            this.lbTitleLayout.TabIndex = 70;
            this.lbTitleLayout.Text = "FORM QUẢN LÝ";
            // 
            // lbTittleDataGridview
            // 
            this.lbTittleDataGridview.AutoSize = true;
            this.lbTittleDataGridview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittleDataGridview.Location = new System.Drawing.Point(104, 66);
            this.lbTittleDataGridview.Name = "lbTittleDataGridview";
            this.lbTittleDataGridview.Size = new System.Drawing.Size(121, 16);
            this.lbTittleDataGridview.TabIndex = 69;
            this.lbTittleDataGridview.Text = "Danh sách quản lý:";
            // 
            // dgvListObjects
            // 
            this.dgvListObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListObjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdObj,
            this.NameObj,
            this.BirthdayObj,
            this.AddressObj});
            this.dgvListObjects.Location = new System.Drawing.Point(90, 93);
            this.dgvListObjects.Name = "dgvListObjects";
            this.dgvListObjects.Size = new System.Drawing.Size(544, 295);
            this.dgvListObjects.TabIndex = 68;
            // 
            // IdObj
            // 
            this.IdObj.HeaderText = "STT";
            this.IdObj.Name = "IdObj";
            this.IdObj.Width = 50;
            // 
            // NameObj
            // 
            this.NameObj.HeaderText = "Họ tên";
            this.NameObj.Name = "NameObj";
            // 
            // BirthdayObj
            // 
            this.BirthdayObj.HeaderText = "Ngày sinh";
            this.BirthdayObj.Name = "BirthdayObj";
            // 
            // AddressObj
            // 
            this.AddressObj.HeaderText = "Địa chỉ";
            this.AddressObj.Name = "AddressObj";
            // 
            // AccessObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 482);
            this.Controls.Add(this.lbTitleLayout);
            this.Controls.Add(this.lbTittleDataGridview);
            this.Controls.Add(this.dgvListObjects);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "AccessObj";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListObjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnDelete;
        protected System.Windows.Forms.Button btnAdd;
        protected System.Windows.Forms.Label lbTitleLayout;
        protected System.Windows.Forms.Label lbTittleDataGridview;
        protected System.Windows.Forms.DataGridView dgvListObjects;
        protected System.Windows.Forms.DataGridViewTextBoxColumn IdObj;
        protected System.Windows.Forms.DataGridViewTextBoxColumn NameObj;
        protected System.Windows.Forms.DataGridViewTextBoxColumn BirthdayObj;
        protected System.Windows.Forms.DataGridViewTextBoxColumn AddressObj;

    }
}
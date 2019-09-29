namespace CHP4_1_20170207
{
    partial class FrmSearchStudentByGrade
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
            this.lblGrade = new System.Windows.Forms.Label();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clBornDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(67, 47);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(35, 12);
            this.lblGrade.TabIndex = 0;
            this.lblGrade.Text = "年级:";
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(128, 42);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(121, 20);
            this.cboGrade.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(264, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clName,
            this.clGender,
            this.clBornDate});
            this.dgvStudent.Location = new System.Drawing.Point(12, 90);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.RowTemplate.Height = 23;
            this.dgvStudent.Size = new System.Drawing.Size(521, 295);
            this.dgvStudent.TabIndex = 3;
            // 
            // clName
            // 
            this.clName.DataPropertyName = "StudentName";
            this.clName.HeaderText = "姓名";
            this.clName.Name = "clName";
            // 
            // clGender
            // 
            this.clGender.DataPropertyName = "Gender";
            this.clGender.HeaderText = "性别";
            this.clGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.clGender.Name = "clGender";
            // 
            // clBornDate
            // 
            this.clBornDate.DataPropertyName = "BornDate";
            this.clBornDate.HeaderText = "出生日期";
            this.clBornDate.Name = "clBornDate";
            // 
            // FrmSearchStudentByGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 397);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboGrade);
            this.Controls.Add(this.lblGrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSearchStudentByGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSearchStudentByGrade";
            this.Load += new System.EventHandler(this.FrmSearchStudentByGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewComboBoxColumn clGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBornDate;
    }
}
namespace CHP4_1_20170207
{
	partial class FrmSearchStudentByName
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lvComputer = new System.Windows.Forms.ListView();
            this.chStuNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsUpdate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(49, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(84, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(204, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(299, 37);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(89, 12);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "(支持模糊查询)";
            // 
            // lvComputer
            // 
            this.lvComputer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chStuNo,
            this.chName,
            this.chGender,
            this.chGrade});
            this.lvComputer.ContextMenuStrip = this.cmsUpdate;
            this.lvComputer.FullRowSelect = true;
            this.lvComputer.Location = new System.Drawing.Point(41, 79);
            this.lvComputer.Name = "lvComputer";
            this.lvComputer.Size = new System.Drawing.Size(488, 276);
            this.lvComputer.TabIndex = 4;
            this.lvComputer.UseCompatibleStateImageBehavior = false;
            this.lvComputer.View = System.Windows.Forms.View.Details;
            // 
            // chStuNo
            // 
            this.chStuNo.Text = "学号";
            this.chStuNo.Width = 100;
            // 
            // chName
            // 
            this.chName.Text = "姓名";
            this.chName.Width = 100;
            // 
            // chGender
            // 
            this.chGender.Text = "性别";
            this.chGender.Width = 100;
            // 
            // chGrade
            // 
            this.chGrade.Text = "年级";
            this.chGrade.Width = 100;
            // 
            // cmsUpdate
            // 
            this.cmsUpdate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUpdate});
            this.cmsUpdate.Name = "cmsUpdate";
            this.cmsUpdate.Size = new System.Drawing.Size(153, 48);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(152, 22);
            this.tsmiUpdate.Text = "修改";
            this.tsmiUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
            // 
            // FrmSearchStudentByName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 401);
            this.Controls.Add(this.lvComputer);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "FrmSearchStudentByName";
            this.Text = "查询学生信息";
            this.Load += new System.EventHandler(this.FrmSearchStudentByName_Load);
            this.cmsUpdate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.ListView lvComputer;
		private System.Windows.Forms.ColumnHeader chStuNo;
		private System.Windows.Forms.ColumnHeader chName;
		private System.Windows.Forms.ColumnHeader chGender;
		private System.Windows.Forms.ColumnHeader chGrade;
        private System.Windows.Forms.ContextMenuStrip cmsUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
	}
}
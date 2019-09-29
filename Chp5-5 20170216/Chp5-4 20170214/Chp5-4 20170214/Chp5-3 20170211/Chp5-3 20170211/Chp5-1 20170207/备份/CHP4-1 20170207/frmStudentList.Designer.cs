namespace CHP4_1_20170207
{
	partial class frmStudentList
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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("男");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("女");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("S1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("男");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("女");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("S2", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("男");
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("女");
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Y2", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("全部", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9});
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tvGrade = new System.Windows.Forms.TreeView();
			this.dgvStu = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStu)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tvGrade);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dgvStu);
			this.splitContainer1.Size = new System.Drawing.Size(574, 377);
			this.splitContainer1.SplitterDistance = 191;
			this.splitContainer1.TabIndex = 0;
			// 
			// tvGrade
			// 
			this.tvGrade.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvGrade.Location = new System.Drawing.Point(0, 0);
			this.tvGrade.Name = "tvGrade";
			treeNode1.Name = "节点4";
			treeNode1.Text = "男";
			treeNode2.Name = "节点5";
			treeNode2.Text = "女";
			treeNode3.Name = "节点1";
			treeNode3.Text = "S1";
			treeNode4.Name = "节点6";
			treeNode4.Text = "男";
			treeNode5.Name = "节点7";
			treeNode5.Text = "女";
			treeNode6.Name = "节点2";
			treeNode6.Text = "S2";
			treeNode7.Name = "节点8";
			treeNode7.Text = "男";
			treeNode8.Name = "节点9";
			treeNode8.Text = "女";
			treeNode9.Name = "节点3";
			treeNode9.Text = "Y2";
			treeNode10.Name = "节点0";
			treeNode10.Text = "全部";
			this.tvGrade.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
			this.tvGrade.Size = new System.Drawing.Size(191, 377);
			this.tvGrade.TabIndex = 0;
			this.tvGrade.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// dgvStu
			// 
			this.dgvStu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dgvStu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvStu.Location = new System.Drawing.Point(0, 0);
			this.dgvStu.Name = "dgvStu";
			this.dgvStu.RowHeadersVisible = false;
			this.dgvStu.RowTemplate.Height = 23;
			this.dgvStu.Size = new System.Drawing.Size(379, 377);
			this.dgvStu.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "StudentNo";
			this.Column1.HeaderText = "学号";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "StudentName";
			this.Column2.HeaderText = "姓名";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Gender";
			this.Column3.HeaderText = "性别";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "GradeName";
			this.Column4.HeaderText = "年级";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "Phone";
			this.Column5.HeaderText = "电话";
			this.Column5.Name = "Column5";
			// 
			// frmStudentList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(574, 377);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmStudentList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "学生信息列表";
			this.Load += new System.EventHandler(this.frmStudentList_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvStu)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView tvGrade;
		private System.Windows.Forms.DataGridView dgvStu;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
	}
}
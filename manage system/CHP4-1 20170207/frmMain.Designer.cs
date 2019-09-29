namespace CHP4_1_20170207
{
    partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.msMain = new System.Windows.Forms.MenuStrip();
			this.tsmiAccountManager = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiAddStu = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiStuUserManager = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSubjectManager = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiForm = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiContact = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMain = new System.Windows.Forms.ToolStrip();
			this.tsbtnAddStu = new System.Windows.Forms.ToolStripButton();
			this.tsbtnSearchByName = new System.Windows.Forms.ToolStripButton();
			this.tsbtnSearchByGrade = new System.Windows.Forms.ToolStripButton();
			this.tsbtnStuList = new System.Windows.Forms.ToolStripButton();
			this.tsbtnSubjectList = new System.Windows.Forms.ToolStripButton();
			this.msMain.SuspendLayout();
			this.tsMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// msMain
			// 
			this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAccountManager,
            this.tsmiStuUserManager,
            this.tsmiSubjectManager,
            this.tsmiForm,
            this.tsmiHelp});
			this.msMain.Location = new System.Drawing.Point(0, 0);
			this.msMain.Name = "msMain";
			this.msMain.Size = new System.Drawing.Size(734, 25);
			this.msMain.TabIndex = 0;
			this.msMain.Text = "menuStrip1";
			// 
			// tsmiAccountManager
			// 
			this.tsmiAccountManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddStu,
            this.tsmiExit});
			this.tsmiAccountManager.Name = "tsmiAccountManager";
			this.tsmiAccountManager.Size = new System.Drawing.Size(85, 21);
			this.tsmiAccountManager.Text = "账户管理(&U)";
			// 
			// tsmiAddStu
			// 
			this.tsmiAddStu.Name = "tsmiAddStu";
			this.tsmiAddStu.Size = new System.Drawing.Size(140, 22);
			this.tsmiAddStu.Text = "新增学生(&A)";
			this.tsmiAddStu.Click += new System.EventHandler(this.tsbtnAddStu_Click);
			// 
			// tsmiExit
			// 
			this.tsmiExit.Name = "tsmiExit";
			this.tsmiExit.Size = new System.Drawing.Size(140, 22);
			this.tsmiExit.Text = "退出(&E)";
			this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
			// 
			// tsmiStuUserManager
			// 
			this.tsmiStuUserManager.Name = "tsmiStuUserManager";
			this.tsmiStuUserManager.Size = new System.Drawing.Size(107, 21);
			this.tsmiStuUserManager.Text = "学生用户管理(&S)";
			// 
			// tsmiSubjectManager
			// 
			this.tsmiSubjectManager.Name = "tsmiSubjectManager";
			this.tsmiSubjectManager.Size = new System.Drawing.Size(84, 21);
			this.tsmiSubjectManager.Text = "科目管理(&C)";
			// 
			// tsmiForm
			// 
			this.tsmiForm.Name = "tsmiForm";
			this.tsmiForm.Size = new System.Drawing.Size(64, 21);
			this.tsmiForm.Text = "窗口(&W)";
			// 
			// tsmiHelp
			// 
			this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiContact});
			this.tsmiHelp.Name = "tsmiHelp";
			this.tsmiHelp.Size = new System.Drawing.Size(61, 21);
			this.tsmiHelp.Text = "帮助(&H)";
			// 
			// tsmiContact
			// 
			this.tsmiContact.Name = "tsmiContact";
			this.tsmiContact.Size = new System.Drawing.Size(124, 22);
			this.tsmiContact.Text = "联系我们";
			this.tsmiContact.Click += new System.EventHandler(this.tsmiContact_Click);
			// 
			// tsMain
			// 
			this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddStu,
            this.tsbtnSearchByName,
            this.tsbtnSearchByGrade,
            this.tsbtnStuList,
            this.tsbtnSubjectList});
			this.tsMain.Location = new System.Drawing.Point(0, 25);
			this.tsMain.Name = "tsMain";
			this.tsMain.Size = new System.Drawing.Size(734, 39);
			this.tsMain.TabIndex = 1;
			this.tsMain.Text = "toolStrip1";
			// 
			// tsbtnAddStu
			// 
			this.tsbtnAddStu.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddStu.Image")));
			this.tsbtnAddStu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsbtnAddStu.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnAddStu.Name = "tsbtnAddStu";
			this.tsbtnAddStu.Size = new System.Drawing.Size(116, 36);
			this.tsbtnAddStu.Text = "新建学生用户";
			this.tsbtnAddStu.Click += new System.EventHandler(this.tsbtnAddStu_Click);
			// 
			// tsbtnSearchByName
			// 
			this.tsbtnSearchByName.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearchByName.Image")));
			this.tsbtnSearchByName.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsbtnSearchByName.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnSearchByName.Name = "tsbtnSearchByName";
			this.tsbtnSearchByName.Size = new System.Drawing.Size(152, 36);
			this.tsbtnSearchByName.Text = "按姓名查询学生信息";
			this.tsbtnSearchByName.Click += new System.EventHandler(this.tsbtnSearchByName_Click);
			// 
			// tsbtnSearchByGrade
			// 
			this.tsbtnSearchByGrade.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearchByGrade.Image")));
			this.tsbtnSearchByGrade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsbtnSearchByGrade.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnSearchByGrade.Name = "tsbtnSearchByGrade";
			this.tsbtnSearchByGrade.Size = new System.Drawing.Size(152, 36);
			this.tsbtnSearchByGrade.Text = "按年级查询学生信息";
			this.tsbtnSearchByGrade.Click += new System.EventHandler(this.tsbtnSearchByGrade_Click);
			// 
			// tsbtnStuList
			// 
			this.tsbtnStuList.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStuList.Image")));
			this.tsbtnStuList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsbtnStuList.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnStuList.Name = "tsbtnStuList";
			this.tsbtnStuList.Size = new System.Drawing.Size(92, 36);
			this.tsbtnStuList.Text = "学生列表";
			this.tsbtnStuList.Click += new System.EventHandler(this.tsbtnStuList_Click);
			// 
			// tsbtnSubjectList
			// 
			this.tsbtnSubjectList.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSubjectList.Image")));
			this.tsbtnSubjectList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsbtnSubjectList.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnSubjectList.Name = "tsbtnSubjectList";
			this.tsbtnSubjectList.Size = new System.Drawing.Size(92, 36);
			this.tsbtnSubjectList.Text = "科目列表";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 438);
			this.Controls.Add(this.tsMain);
			this.Controls.Add(this.msMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.msMain;
			this.Name = "frmMain";
			this.Text = "MySchool-管理员";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.msMain.ResumeLayout(false);
			this.msMain.PerformLayout();
			this.tsMain.ResumeLayout(false);
			this.tsMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccountManager;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddStu;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiStuUserManager;
        private System.Windows.Forms.ToolStripMenuItem tsmiSubjectManager;
        private System.Windows.Forms.ToolStripMenuItem tsmiForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbtnAddStu;
        private System.Windows.Forms.ToolStripButton tsbtnSearchByName;
        private System.Windows.Forms.ToolStripButton tsbtnSearchByGrade;
        private System.Windows.Forms.ToolStripButton tsbtnStuList;
        private System.Windows.Forms.ToolStripButton tsbtnSubjectList;
        private System.Windows.Forms.ToolStripMenuItem tsmiContact;
    }
}
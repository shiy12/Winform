namespace CHP4_1_20170207
{
    partial class frmAddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStudent));
            this.gbZhuCeInfo = new System.Windows.Forms.GroupBox();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtStuNo = new System.Windows.Forms.TextBox();
            this.lblPwd2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPwd1 = new System.Windows.Forms.Label();
            this.lblStuNo = new System.Windows.Forms.Label();
            this.gbBasicInfo = new System.Windows.Forms.GroupBox();
            this.dtpBornDate = new System.Windows.Forms.DateTimePicker();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.pnlGender = new System.Windows.Forms.Panel();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBornDate = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbZhuCeInfo.SuspendLayout();
            this.gbBasicInfo.SuspendLayout();
            this.pnlGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbZhuCeInfo
            // 
            this.gbZhuCeInfo.Controls.Add(this.txtPwd2);
            this.gbZhuCeInfo.Controls.Add(this.txtPwd);
            this.gbZhuCeInfo.Controls.Add(this.txtStuNo);
            this.gbZhuCeInfo.Controls.Add(this.lblPwd2);
            this.gbZhuCeInfo.Controls.Add(this.label3);
            this.gbZhuCeInfo.Controls.Add(this.lblPwd1);
            this.gbZhuCeInfo.Controls.Add(this.lblStuNo);
            this.gbZhuCeInfo.Location = new System.Drawing.Point(13, 24);
            this.gbZhuCeInfo.Name = "gbZhuCeInfo";
            this.gbZhuCeInfo.Size = new System.Drawing.Size(307, 136);
            this.gbZhuCeInfo.TabIndex = 0;
            this.gbZhuCeInfo.TabStop = false;
            this.gbZhuCeInfo.Text = "用户注册信息";
            // 
            // txtPwd2
            // 
            this.txtPwd2.Location = new System.Drawing.Point(94, 92);
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.PasswordChar = '*';
            this.txtPwd2.Size = new System.Drawing.Size(187, 21);
            this.txtPwd2.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(94, 58);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(187, 21);
            this.txtPwd.TabIndex = 1;
            // 
            // txtStuNo
            // 
            this.txtStuNo.Location = new System.Drawing.Point(94, 22);
            this.txtStuNo.Name = "txtStuNo";
            this.txtStuNo.Size = new System.Drawing.Size(187, 21);
            this.txtStuNo.TabIndex = 1;
            // 
            // lblPwd2
            // 
            this.lblPwd2.AutoSize = true;
            this.lblPwd2.Location = new System.Drawing.Point(28, 95);
            this.lblPwd2.Name = "lblPwd2";
            this.lblPwd2.Size = new System.Drawing.Size(53, 12);
            this.lblPwd2.TabIndex = 0;
            this.lblPwd2.Text = "确认密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "label1";
            // 
            // lblPwd1
            // 
            this.lblPwd1.AutoSize = true;
            this.lblPwd1.Location = new System.Drawing.Point(28, 60);
            this.lblPwd1.Name = "lblPwd1";
            this.lblPwd1.Size = new System.Drawing.Size(29, 12);
            this.lblPwd1.TabIndex = 0;
            this.lblPwd1.Text = "密码";
            // 
            // lblStuNo
            // 
            this.lblStuNo.AutoSize = true;
            this.lblStuNo.Location = new System.Drawing.Point(28, 31);
            this.lblStuNo.Name = "lblStuNo";
            this.lblStuNo.Size = new System.Drawing.Size(29, 12);
            this.lblStuNo.TabIndex = 0;
            this.lblStuNo.Text = "学号";
            // 
            // gbBasicInfo
            // 
            this.gbBasicInfo.Controls.Add(this.dtpBornDate);
            this.gbBasicInfo.Controls.Add(this.cboGrade);
            this.gbBasicInfo.Controls.Add(this.pnlGender);
            this.gbBasicInfo.Controls.Add(this.txtEmail);
            this.gbBasicInfo.Controls.Add(this.txtAddress);
            this.gbBasicInfo.Controls.Add(this.txtTel);
            this.gbBasicInfo.Controls.Add(this.txtName);
            this.gbBasicInfo.Controls.Add(this.lblEmail);
            this.gbBasicInfo.Controls.Add(this.lblBornDate);
            this.gbBasicInfo.Controls.Add(this.lblTel);
            this.gbBasicInfo.Controls.Add(this.lblGrade);
            this.gbBasicInfo.Controls.Add(this.lblAddress);
            this.gbBasicInfo.Controls.Add(this.lblName);
            this.gbBasicInfo.Controls.Add(this.lblGender);
            this.gbBasicInfo.Controls.Add(this.label4);
            this.gbBasicInfo.Location = new System.Drawing.Point(13, 189);
            this.gbBasicInfo.Name = "gbBasicInfo";
            this.gbBasicInfo.Size = new System.Drawing.Size(307, 251);
            this.gbBasicInfo.TabIndex = 1;
            this.gbBasicInfo.TabStop = false;
            this.gbBasicInfo.Text = "用户基本信息";
            // 
            // dtpBornDate
            // 
            this.dtpBornDate.Location = new System.Drawing.Point(94, 184);
            this.dtpBornDate.Name = "dtpBornDate";
            this.dtpBornDate.Size = new System.Drawing.Size(200, 21);
            this.dtpBornDate.TabIndex = 5;
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(94, 87);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(187, 20);
            this.cboGrade.TabIndex = 4;
            // 
            // pnlGender
            // 
            this.pnlGender.Controls.Add(this.rbtnFemale);
            this.pnlGender.Controls.Add(this.rbtnMale);
            this.pnlGender.Location = new System.Drawing.Point(94, 57);
            this.pnlGender.Name = "pnlGender";
            this.pnlGender.Size = new System.Drawing.Size(168, 22);
            this.pnlGender.TabIndex = 3;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(77, 3);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(35, 16);
            this.rbtnFemale.TabIndex = 1;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "女";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Checked = true;
            this.rbtnMale.Location = new System.Drawing.Point(4, 4);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(35, 16);
            this.rbtnMale.TabIndex = 0;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "男";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(94, 216);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 21);
            this.txtEmail.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(94, 152);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(187, 21);
            this.txtAddress.TabIndex = 2;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(94, 123);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(187, 21);
            this.txtTel.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 21);
            this.txtName.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(28, 219);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 12);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblBornDate
            // 
            this.lblBornDate.AutoSize = true;
            this.lblBornDate.Location = new System.Drawing.Point(28, 190);
            this.lblBornDate.Name = "lblBornDate";
            this.lblBornDate.Size = new System.Drawing.Size(53, 12);
            this.lblBornDate.TabIndex = 0;
            this.lblBornDate.Text = "出生日期";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(28, 126);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(29, 12);
            this.lblTel.TabIndex = 0;
            this.lblTel.Text = "电话";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(28, 96);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(29, 12);
            this.lblGrade.TabIndex = 0;
            this.lblGrade.Text = "年级";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(28, 155);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(29, 12);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "地址";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(28, 61);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(29, 12);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(122, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(219, 446);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 474);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbBasicInfo);
            this.Controls.Add(this.gbZhuCeInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑学生信息";
            this.Load += new System.EventHandler(this.frmAddStudent_Load);
            this.gbZhuCeInfo.ResumeLayout(false);
            this.gbZhuCeInfo.PerformLayout();
            this.gbBasicInfo.ResumeLayout(false);
            this.gbBasicInfo.PerformLayout();
            this.pnlGender.ResumeLayout(false);
            this.pnlGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbZhuCeInfo;
        private System.Windows.Forms.GroupBox gbBasicInfo;
        private System.Windows.Forms.Label lblPwd2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPwd1;
        private System.Windows.Forms.Label lblStuNo;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtStuNo;
        private System.Windows.Forms.Label lblBornDate;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel pnlGender;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dtpBornDate;
    }
}
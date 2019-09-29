namespace FrmContactUs
{
    partial class FrmContactUs
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContactUs));
            this.pbContactUs = new System.Windows.Forms.PictureBox();
            this.ilContactUs = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbContactUs)).BeginInit();
            this.SuspendLayout();
            // 
            // pbContactUs
            // 
            this.pbContactUs.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.pbContactUs.Location = new System.Drawing.Point(54, 96);
            this.pbContactUs.Name = "pbContactUs";
            this.pbContactUs.Size = new System.Drawing.Size(100, 50);
            this.pbContactUs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbContactUs.TabIndex = 0;
            this.pbContactUs.TabStop = false;
            // 
            // ilContactUs
            // 
            this.ilContactUs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilContactUs.ImageStream")));
            this.ilContactUs.TransparentColor = System.Drawing.Color.Transparent;
            this.ilContactUs.Images.SetKeyName(0, "girl_1.gif");
            this.ilContactUs.Images.SetKeyName(1, "girl_2.gif");
            this.ilContactUs.Images.SetKeyName(2, "girl_3.gif");
            this.ilContactUs.Images.SetKeyName(3, "girl_4.gif");
            // 
            // FrmContactUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 343);
            this.Controls.Add(this.pbContactUs);
            this.Name = "FrmContactUs";
            this.Text = "联系我们";
            ((System.ComponentModel.ISupportInitialize)(this.pbContactUs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbContactUs;
        private System.Windows.Forms.ImageList ilContactUs;
    }
}


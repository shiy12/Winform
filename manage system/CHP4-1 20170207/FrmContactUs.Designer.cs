namespace CHP4_1_20170207
{
    partial class FrmContactUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContactUs));
            this.pbContactUs = new System.Windows.Forms.PictureBox();
            this.ilContactUs = new System.Windows.Forms.ImageList(this.components);
            this.tContactUs = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbContactUs)).BeginInit();
            this.SuspendLayout();
            // 
            // pbContactUs
            // 
            this.pbContactUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbContactUs.Image = ((System.Drawing.Image)(resources.GetObject("pbContactUs.Image")));
            this.pbContactUs.Location = new System.Drawing.Point(38, 71);
            this.pbContactUs.Name = "pbContactUs";
            this.pbContactUs.Size = new System.Drawing.Size(160, 178);
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
            // tContactUs
            // 
            this.tContactUs.Enabled = true;
            this.tContactUs.Interval = 500;
            this.tContactUs.Tick += new System.EventHandler(this.tContactUs_Tick);
            // 
            // FrmContactUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 358);
            this.Controls.Add(this.pbContactUs);
            this.Name = "FrmContactUs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "联系我们";
            ((System.ComponentModel.ISupportInitialize)(this.pbContactUs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbContactUs;
        private System.Windows.Forms.ImageList ilContactUs;
        private System.Windows.Forms.Timer tContactUs;
    }
}
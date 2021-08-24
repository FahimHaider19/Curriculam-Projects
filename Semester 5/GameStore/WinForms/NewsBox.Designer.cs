
namespace GameStore
{
    partial class NewsBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewsBox));
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.labelNewsTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // picturebox
            // 
            this.picturebox.Dock = System.Windows.Forms.DockStyle.Top;
            this.picturebox.Image = ((System.Drawing.Image)(resources.GetObject("picturebox.Image")));
            this.picturebox.Location = new System.Drawing.Point(0, 0);
            this.picturebox.Margin = new System.Windows.Forms.Padding(2);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(251, 272);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox.TabIndex = 0;
            this.picturebox.TabStop = false;
            this.picturebox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // labelNewsTitle
            // 
            this.labelNewsTitle.AutoSize = true;
            this.labelNewsTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.labelNewsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNewsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewsTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNewsTitle.Location = new System.Drawing.Point(0, 272);
            this.labelNewsTitle.MaximumSize = new System.Drawing.Size(251, 82);
            this.labelNewsTitle.MinimumSize = new System.Drawing.Size(250, 85);
            this.labelNewsTitle.Name = "labelNewsTitle";
            this.labelNewsTitle.Size = new System.Drawing.Size(250, 85);
            this.labelNewsTitle.TabIndex = 1;
            this.labelNewsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNewsTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picturebox_MouseClick);
            // 
            // NewsBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.labelNewsTitle);
            this.Controls.Add(this.picturebox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewsBox";
            this.Size = new System.Drawing.Size(251, 357);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.Label labelNewsTitle;
    }
}

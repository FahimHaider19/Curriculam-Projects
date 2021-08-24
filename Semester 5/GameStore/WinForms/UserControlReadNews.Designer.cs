
namespace GameStore.WinForms
{
    partial class UserControlReadNews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlReadNews));
            this.labelDescription = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelPosted = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDescription.Location = new System.Drawing.Point(0, 772);
            this.labelDescription.MaximumSize = new System.Drawing.Size(1130, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Padding = new System.Windows.Forms.Padding(10);
            this.labelDescription.Size = new System.Drawing.Size(109, 40);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "Description";
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(0, 122);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.MaximumSize = new System.Drawing.Size(1140, 650);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox.Size = new System.Drawing.Size(1140, 650);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // labelPosted
            // 
            this.labelPosted.AutoSize = true;
            this.labelPosted.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPosted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosted.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPosted.Location = new System.Drawing.Point(0, 104);
            this.labelPosted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPosted.Name = "labelPosted";
            this.labelPosted.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.labelPosted.Size = new System.Drawing.Size(97, 18);
            this.labelPosted.TabIndex = 5;
            this.labelPosted.Text = "Posted : ";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.MaximumSize = new System.Drawing.Size(1130, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(10);
            this.labelTitle.Size = new System.Drawing.Size(1094, 104);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Red Dead Redemption 2: 13 Minutes of Call to Arms Gameplay (Red Dead Online)";
            // 
            // UserControlReadNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelPosted);
            this.Controls.Add(this.labelTitle);
            this.Name = "UserControlReadNews";
            this.Size = new System.Drawing.Size(1140, 812);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelPosted;
        private System.Windows.Forms.Label labelTitle;
    }
}

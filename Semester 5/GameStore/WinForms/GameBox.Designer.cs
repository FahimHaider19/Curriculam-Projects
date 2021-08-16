
namespace GameStore
{
    partial class GameBox
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelGameboxGameName = new System.Windows.Forms.Label();
            this.labelpriceTag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox.Image = global::GameStore.Resource.RedDeadRedemption2;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(157, 180);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // labelGameboxGameName
            // 
            this.labelGameboxGameName.AutoSize = true;
            this.labelGameboxGameName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGameboxGameName.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameboxGameName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelGameboxGameName.Location = new System.Drawing.Point(0, 180);
            this.labelGameboxGameName.MaximumSize = new System.Drawing.Size(155, 40);
            this.labelGameboxGameName.MinimumSize = new System.Drawing.Size(155, 40);
            this.labelGameboxGameName.Name = "labelGameboxGameName";
            this.labelGameboxGameName.Size = new System.Drawing.Size(155, 40);
            this.labelGameboxGameName.TabIndex = 4;
            this.labelGameboxGameName.Text = "GameName";
            this.labelGameboxGameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelpriceTag
            // 
            this.labelpriceTag.AutoSize = true;
            this.labelpriceTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpriceTag.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelpriceTag.Location = new System.Drawing.Point(-3, 220);
            this.labelpriceTag.MinimumSize = new System.Drawing.Size(155, 0);
            this.labelpriceTag.Name = "labelpriceTag";
            this.labelpriceTag.Size = new System.Drawing.Size(155, 16);
            this.labelpriceTag.TabIndex = 6;
            this.labelpriceTag.Text = "0.00$";
            this.labelpriceTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.labelpriceTag);
            this.Controls.Add(this.labelGameboxGameName);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameBox";
            this.Size = new System.Drawing.Size(157, 245);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelGameboxGameName;
        private System.Windows.Forms.Label labelpriceTag;
    }
}

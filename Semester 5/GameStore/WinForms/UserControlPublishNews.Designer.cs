
namespace GameStore
{
    partial class UserControlPublishNews
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
            this.panel = new System.Windows.Forms.Panel();
            this.textBoxGameTopic = new System.Windows.Forms.TextBox();
            this.labelGameTopic = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxImages = new System.Windows.Forms.TextBox();
            this.labelImages = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonInsertNews = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.buttonInsertNews);
            this.panel.Controls.Add(this.textBoxGameTopic);
            this.panel.Controls.Add(this.labelGameTopic);
            this.panel.Controls.Add(this.textBoxDescription);
            this.panel.Controls.Add(this.labelDescription);
            this.panel.Controls.Add(this.textBoxImages);
            this.panel.Controls.Add(this.labelImages);
            this.panel.Controls.Add(this.textBoxTitle);
            this.panel.Controls.Add(this.labelTitle);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1121, 664);
            this.panel.TabIndex = 0;
            // 
            // textBoxGameTopic
            // 
            this.textBoxGameTopic.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGameTopic.Location = new System.Drawing.Point(283, 292);
            this.textBoxGameTopic.Name = "textBoxGameTopic";
            this.textBoxGameTopic.Size = new System.Drawing.Size(456, 33);
            this.textBoxGameTopic.TabIndex = 8;
            // 
            // labelGameTopic
            // 
            this.labelGameTopic.AutoSize = true;
            this.labelGameTopic.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelGameTopic.Location = new System.Drawing.Point(125, 300);
            this.labelGameTopic.Name = "labelGameTopic";
            this.labelGameTopic.Size = new System.Drawing.Size(124, 25);
            this.labelGameTopic.TabIndex = 7;
            this.labelGameTopic.Text = "Game/Topic :";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(283, 226);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(456, 33);
            this.textBoxDescription.TabIndex = 6;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelDescription.Location = new System.Drawing.Point(125, 234);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(120, 25);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Description :";
            // 
            // textBoxImages
            // 
            this.textBoxImages.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImages.Location = new System.Drawing.Point(283, 168);
            this.textBoxImages.Name = "textBoxImages";
            this.textBoxImages.Size = new System.Drawing.Size(456, 33);
            this.textBoxImages.TabIndex = 4;
            // 
            // labelImages
            // 
            this.labelImages.AutoSize = true;
            this.labelImages.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelImages.Location = new System.Drawing.Point(125, 176);
            this.labelImages.Name = "labelImages";
            this.labelImages.Size = new System.Drawing.Size(84, 25);
            this.labelImages.TabIndex = 3;
            this.labelImages.Text = "Images :";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(283, 97);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(456, 33);
            this.textBoxTitle.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(125, 105);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(59, 25);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title :";
            // 
            // buttonInsertNews
            // 
            this.buttonInsertNews.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonInsertNews.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertNews.Location = new System.Drawing.Point(369, 361);
            this.buttonInsertNews.Name = "buttonInsertNews";
            this.buttonInsertNews.Size = new System.Drawing.Size(224, 44);
            this.buttonInsertNews.TabIndex = 9;
            this.buttonInsertNews.Text = "Confirm";
            this.buttonInsertNews.UseVisualStyleBackColor = true;
            this.buttonInsertNews.Click += new System.EventHandler(this.buttonInsertNews_Click);
            // 
            // UserControlPublishNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "UserControlPublishNews";
            this.Size = new System.Drawing.Size(1121, 664);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox textBoxGameTopic;
        private System.Windows.Forms.Label labelGameTopic;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxImages;
        private System.Windows.Forms.Label labelImages;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonInsertNews;
    }
}

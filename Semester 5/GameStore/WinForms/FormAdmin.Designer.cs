
namespace GameStore.WinForms
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonMyProfile = new System.Windows.Forms.Button();
            this.buttonNews = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.panelManagementTab = new System.Windows.Forms.Panel();
            this.buttonUserManagement = new System.Windows.Forms.Button();
            this.buttonDeveloperManagement = new System.Windows.Forms.Button();
            this.buttonStoreManagement = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelManagementTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.panelLeft.Controls.Add(this.buttonSettings);
            this.panelLeft.Controls.Add(this.buttonMyProfile);
            this.panelLeft.Controls.Add(this.buttonNews);
            this.panelLeft.Controls.Add(this.buttonBrowse);
            this.panelLeft.Controls.Add(this.buttonDashboard);
            this.panelLeft.Controls.Add(this.buttonHome);
            this.panelLeft.Controls.Add(this.panelLogo);
            this.panelLeft.Controls.Add(this.buttonSignOut);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(195, 489);
            this.panelLeft.TabIndex = 13;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(0, 347);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.buttonSettings.Size = new System.Drawing.Size(195, 42);
            this.buttonSettings.TabIndex = 17;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonMyProfile
            // 
            this.buttonMyProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMyProfile.FlatAppearance.BorderSize = 0;
            this.buttonMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyProfile.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.buttonMyProfile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMyProfile.Image = global::GameStore.Resource.profile;
            this.buttonMyProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMyProfile.Location = new System.Drawing.Point(0, 305);
            this.buttonMyProfile.Name = "buttonMyProfile";
            this.buttonMyProfile.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.buttonMyProfile.Size = new System.Drawing.Size(195, 42);
            this.buttonMyProfile.TabIndex = 16;
            this.buttonMyProfile.Text = "My Profile";
            this.buttonMyProfile.UseVisualStyleBackColor = true;
            this.buttonMyProfile.Click += new System.EventHandler(this.buttonMyProfile_Click);
            // 
            // buttonNews
            // 
            this.buttonNews.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonNews.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNews.FlatAppearance.BorderSize = 0;
            this.buttonNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNews.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNews.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNews.Image = ((System.Drawing.Image)(resources.GetObject("buttonNews.Image")));
            this.buttonNews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNews.Location = new System.Drawing.Point(0, 263);
            this.buttonNews.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNews.Name = "buttonNews";
            this.buttonNews.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.buttonNews.Size = new System.Drawing.Size(195, 42);
            this.buttonNews.TabIndex = 15;
            this.buttonNews.Text = "News";
            this.buttonNews.UseVisualStyleBackColor = true;
            this.buttonNews.Click += new System.EventHandler(this.buttonNews_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBrowse.FlatAppearance.BorderSize = 0;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBrowse.Image = ((System.Drawing.Image)(resources.GetObject("buttonBrowse.Image")));
            this.buttonBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBrowse.Location = new System.Drawing.Point(0, 221);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.buttonBrowse.Size = new System.Drawing.Size(195, 42);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.buttonDashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDashboard.Image = global::GameStore.Resource.dashboard;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 179);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.buttonDashboard.Size = new System.Drawing.Size(195, 42);
            this.buttonDashboard.TabIndex = 14;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click_1);
            // 
            // buttonHome
            // 
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(0, 137);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(195, 42);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(195, 137);
            this.panelLogo.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSignOut.FlatAppearance.BorderSize = 0;
            this.buttonSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignOut.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSignOut.Image = ((System.Drawing.Image)(resources.GetObject("buttonSignOut.Image")));
            this.buttonSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSignOut.Location = new System.Drawing.Point(0, 447);
            this.buttonSignOut.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.buttonSignOut.Size = new System.Drawing.Size(195, 42);
            this.buttonSignOut.TabIndex = 4;
            this.buttonSignOut.Text = "Sign Out";
            this.buttonSignOut.UseVisualStyleBackColor = true;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // panelManagementTab
            // 
            this.panelManagementTab.Controls.Add(this.buttonUserManagement);
            this.panelManagementTab.Controls.Add(this.buttonDeveloperManagement);
            this.panelManagementTab.Controls.Add(this.buttonStoreManagement);
            this.panelManagementTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManagementTab.Location = new System.Drawing.Point(195, 0);
            this.panelManagementTab.Name = "panelManagementTab";
            this.panelManagementTab.Size = new System.Drawing.Size(1109, 49);
            this.panelManagementTab.TabIndex = 21;
            // 
            // buttonUserManagement
            // 
            this.buttonUserManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserManagement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserManagement.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUserManagement.Location = new System.Drawing.Point(369, 0);
            this.buttonUserManagement.Name = "buttonUserManagement";
            this.buttonUserManagement.Size = new System.Drawing.Size(371, 49);
            this.buttonUserManagement.TabIndex = 5;
            this.buttonUserManagement.Text = "User Management";
            this.buttonUserManagement.UseVisualStyleBackColor = true;
            this.buttonUserManagement.Click += new System.EventHandler(this.buttonUserManagement_Click_2);
            // 
            // buttonDeveloperManagement
            // 
            this.buttonDeveloperManagement.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDeveloperManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeveloperManagement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeveloperManagement.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeveloperManagement.Location = new System.Drawing.Point(740, 0);
            this.buttonDeveloperManagement.Name = "buttonDeveloperManagement";
            this.buttonDeveloperManagement.Size = new System.Drawing.Size(369, 49);
            this.buttonDeveloperManagement.TabIndex = 4;
            this.buttonDeveloperManagement.Text = "Developer Management";
            this.buttonDeveloperManagement.UseVisualStyleBackColor = true;
            this.buttonDeveloperManagement.Click += new System.EventHandler(this.buttonDeveloperManagement_Click_2);
            // 
            // buttonStoreManagement
            // 
            this.buttonStoreManagement.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonStoreManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStoreManagement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStoreManagement.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStoreManagement.Location = new System.Drawing.Point(0, 0);
            this.buttonStoreManagement.Name = "buttonStoreManagement";
            this.buttonStoreManagement.Size = new System.Drawing.Size(369, 49);
            this.buttonStoreManagement.TabIndex = 2;
            this.buttonStoreManagement.Text = "Store Management";
            this.buttonStoreManagement.UseVisualStyleBackColor = true;
            this.buttonStoreManagement.Click += new System.EventHandler(this.buttonStoreManagement_Click_2);
            // 
            // panelCenter
            // 
            this.panelCenter.AutoScroll = true;
            this.panelCenter.AutoSize = true;
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCenter.Location = new System.Drawing.Point(195, 49);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1109, 0);
            this.panelCenter.TabIndex = 22;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1304, 489);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelManagementTab);
            this.Controls.Add(this.panelLeft);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.panelLeft.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelManagementTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonMyProfile;
        private System.Windows.Forms.Button buttonNews;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.Panel panelManagementTab;
        private System.Windows.Forms.Button buttonUserManagement;
        private System.Windows.Forms.Button buttonDeveloperManagement;
        private System.Windows.Forms.Button buttonStoreManagement;
        private System.Windows.Forms.Panel panelCenter;
    }
}
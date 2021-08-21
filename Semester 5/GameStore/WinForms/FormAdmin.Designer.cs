
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonMyProfile = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonNews = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelIcon = new System.Windows.Forms.Panel();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.panelManagementTab = new System.Windows.Forms.Panel();
            this.buttonDeveloperManagement = new System.Windows.Forms.Button();
            this.buttonStoreManagement = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.buttonUserManagement = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelManagementTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1304, 16);
            this.panelTop.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.panelLeft.Controls.Add(this.buttonSettings);
            this.panelLeft.Controls.Add(this.buttonMyProfile);
            this.panelLeft.Controls.Add(this.buttonDashboard);
            this.panelLeft.Controls.Add(this.buttonNews);
            this.panelLeft.Controls.Add(this.buttonBrowse);
            this.panelLeft.Controls.Add(this.buttonHome);
            this.panelLeft.Controls.Add(this.panelIcon);
            this.panelLeft.Controls.Add(this.buttonSignOut);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 16);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(196, 434);
            this.panelLeft.TabIndex = 2;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.buttonSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSettings.Image = global::GameStore.Resource.settings;
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(0, 310);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.buttonSettings.Size = new System.Drawing.Size(196, 42);
            this.buttonSettings.TabIndex = 16;
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
            this.buttonMyProfile.Location = new System.Drawing.Point(0, 268);
            this.buttonMyProfile.Name = "buttonMyProfile";
            this.buttonMyProfile.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.buttonMyProfile.Size = new System.Drawing.Size(196, 42);
            this.buttonMyProfile.TabIndex = 15;
            this.buttonMyProfile.Text = "My Profile";
            this.buttonMyProfile.UseVisualStyleBackColor = true;
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
            this.buttonDashboard.Location = new System.Drawing.Point(0, 226);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.buttonDashboard.Size = new System.Drawing.Size(196, 42);
            this.buttonDashboard.TabIndex = 14;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            // 
            // buttonNews
            // 
            this.buttonNews.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNews.FlatAppearance.BorderSize = 0;
            this.buttonNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNews.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.buttonNews.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNews.Image = global::GameStore.Resource.news;
            this.buttonNews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNews.Location = new System.Drawing.Point(0, 184);
            this.buttonNews.Name = "buttonNews";
            this.buttonNews.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.buttonNews.Size = new System.Drawing.Size(196, 42);
            this.buttonNews.TabIndex = 13;
            this.buttonNews.Text = "News";
            this.buttonNews.UseVisualStyleBackColor = true;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBrowse.FlatAppearance.BorderSize = 0;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.buttonBrowse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBrowse.Image = global::GameStore.Resource.shop;
            this.buttonBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBrowse.Location = new System.Drawing.Point(0, 142);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.buttonBrowse.Size = new System.Drawing.Size(196, 42);
            this.buttonBrowse.TabIndex = 12;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            // 
            // buttonHome
            // 
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.buttonHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHome.Image = global::GameStore.Resource.home;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(0, 100);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(196, 42);
            this.buttonHome.TabIndex = 11;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // panelIcon
            // 
            this.panelIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIcon.Location = new System.Drawing.Point(0, 0);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(196, 100);
            this.panelIcon.TabIndex = 10;
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSignOut.FlatAppearance.BorderSize = 0;
            this.buttonSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignOut.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.buttonSignOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSignOut.Image = global::GameStore.Resource.sign_out;
            this.buttonSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSignOut.Location = new System.Drawing.Point(0, 398);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.buttonSignOut.Size = new System.Drawing.Size(196, 36);
            this.buttonSignOut.TabIndex = 9;
            this.buttonSignOut.Text = "Sign Out";
            this.buttonSignOut.UseVisualStyleBackColor = true;
            // 
            // panelManagementTab
            // 
            this.panelManagementTab.Controls.Add(this.buttonUserManagement);
            this.panelManagementTab.Controls.Add(this.buttonDeveloperManagement);
            this.panelManagementTab.Controls.Add(this.buttonStoreManagement);
            this.panelManagementTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManagementTab.Location = new System.Drawing.Point(196, 16);
            this.panelManagementTab.Name = "panelManagementTab";
            this.panelManagementTab.Size = new System.Drawing.Size(1108, 49);
            this.panelManagementTab.TabIndex = 3;
            // 
            // buttonDeveloperManagement
            // 
            this.buttonDeveloperManagement.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDeveloperManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeveloperManagement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeveloperManagement.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeveloperManagement.Location = new System.Drawing.Point(739, 0);
            this.buttonDeveloperManagement.Name = "buttonDeveloperManagement";
            this.buttonDeveloperManagement.Size = new System.Drawing.Size(369, 49);
            this.buttonDeveloperManagement.TabIndex = 4;
            this.buttonDeveloperManagement.Text = "Developer Management";
            this.buttonDeveloperManagement.UseVisualStyleBackColor = true;
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
            // 
            // panelCenter
            // 
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(196, 65);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1108, 385);
            this.panelCenter.TabIndex = 4;
            // 
            // buttonUserManagement
            // 
            this.buttonUserManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserManagement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserManagement.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUserManagement.Location = new System.Drawing.Point(369, 0);
            this.buttonUserManagement.Name = "buttonUserManagement";
            this.buttonUserManagement.Size = new System.Drawing.Size(370, 49);
            this.buttonUserManagement.TabIndex = 5;
            this.buttonUserManagement.Text = "User Management";
            this.buttonUserManagement.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1304, 450);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelManagementTab);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.panelLeft.ResumeLayout(false);
            this.panelManagementTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonMyProfile;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonNews;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panelIcon;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.Panel panelManagementTab;
        private System.Windows.Forms.Button buttonDeveloperManagement;
        private System.Windows.Forms.Button buttonStoreManagement;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Button buttonUserManagement;
    }
}
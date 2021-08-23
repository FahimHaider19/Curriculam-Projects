
namespace GameStore
{
    partial class FormDeveloper
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
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelManageMent = new System.Windows.Forms.Panel();
            this.buttonPublishGames = new System.Windows.Forms.Button();
            this.buttonPublishNews = new System.Windows.Forms.Button();
            this.buttonGameManagement = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonMyProfile = new System.Windows.Forms.Button();
            this.buttonDashBoard = new System.Windows.Forms.Button();
            this.buttonNews = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelManageMent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1317, 16);
            this.panelTop.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.panelLeft.Controls.Add(this.buttonSignOut);
            this.panelLeft.Controls.Add(this.buttonSettings);
            this.panelLeft.Controls.Add(this.buttonMyProfile);
            this.panelLeft.Controls.Add(this.buttonDashBoard);
            this.panelLeft.Controls.Add(this.buttonNews);
            this.panelLeft.Controls.Add(this.buttonBrowse);
            this.panelLeft.Controls.Add(this.buttonHome);
            this.panelLeft.Controls.Add(this.panelLogo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 16);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(196, 713);
            this.panelLeft.TabIndex = 1;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBrowse.FlatAppearance.BorderSize = 0;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.buttonBrowse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBrowse.Image = global::GameStore.Resource.browse;
            this.buttonBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBrowse.Location = new System.Drawing.Point(0, 142);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(196, 42);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(196, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelManageMent
            // 
            this.panelManageMent.Controls.Add(this.buttonPublishGames);
            this.panelManageMent.Controls.Add(this.buttonPublishNews);
            this.panelManageMent.Controls.Add(this.buttonGameManagement);
            this.panelManageMent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManageMent.Location = new System.Drawing.Point(196, 16);
            this.panelManageMent.Name = "panelManageMent";
            this.panelManageMent.Size = new System.Drawing.Size(1121, 49);
            this.panelManageMent.TabIndex = 0;
            // 
            // buttonPublishGames
            // 
            this.buttonPublishGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPublishGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPublishGames.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.buttonPublishGames.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPublishGames.Location = new System.Drawing.Point(380, 0);
            this.buttonPublishGames.Name = "buttonPublishGames";
            this.buttonPublishGames.Size = new System.Drawing.Size(377, 49);
            this.buttonPublishGames.TabIndex = 3;
            this.buttonPublishGames.Text = "Publish Games";
            this.buttonPublishGames.UseVisualStyleBackColor = true;
            this.buttonPublishGames.Click += new System.EventHandler(this.buttonPublishGames_Click);
            // 
            // buttonPublishNews
            // 
            this.buttonPublishNews.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonPublishNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPublishNews.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.buttonPublishNews.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPublishNews.Location = new System.Drawing.Point(757, 0);
            this.buttonPublishNews.Name = "buttonPublishNews";
            this.buttonPublishNews.Size = new System.Drawing.Size(364, 49);
            this.buttonPublishNews.TabIndex = 2;
            this.buttonPublishNews.Text = "Publish News";
            this.buttonPublishNews.UseVisualStyleBackColor = true;
            this.buttonPublishNews.Click += new System.EventHandler(this.buttonPublishNews_Click);
            // 
            // buttonGameManagement
            // 
            this.buttonGameManagement.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonGameManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGameManagement.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.buttonGameManagement.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGameManagement.Location = new System.Drawing.Point(0, 0);
            this.buttonGameManagement.Name = "buttonGameManagement";
            this.buttonGameManagement.Size = new System.Drawing.Size(380, 49);
            this.buttonGameManagement.TabIndex = 0;
            this.buttonGameManagement.Text = "GameManagement";
            this.buttonGameManagement.UseVisualStyleBackColor = true;
            this.buttonGameManagement.Click += new System.EventHandler(this.buttonGameManagement_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(196, 65);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1121, 664);
            this.panelCenter.TabIndex = 2;
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
            this.buttonSignOut.Location = new System.Drawing.Point(0, 671);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(196, 42);
            this.buttonSignOut.TabIndex = 7;
            this.buttonSignOut.Text = "Sign Out";
            this.buttonSignOut.UseVisualStyleBackColor = true;
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
            this.buttonSettings.Size = new System.Drawing.Size(196, 42);
            this.buttonSettings.TabIndex = 6;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
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
            this.buttonMyProfile.Size = new System.Drawing.Size(196, 42);
            this.buttonMyProfile.TabIndex = 5;
            this.buttonMyProfile.Text = "MyProfile";
            this.buttonMyProfile.UseVisualStyleBackColor = true;
            this.buttonMyProfile.Click += new System.EventHandler(this.buttonMyProfile_Click);
            // 
            // buttonDashBoard
            // 
            this.buttonDashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashBoard.FlatAppearance.BorderSize = 0;
            this.buttonDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashBoard.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.buttonDashBoard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDashBoard.Image = global::GameStore.Resource.dashboard;
            this.buttonDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashBoard.Location = new System.Drawing.Point(0, 226);
            this.buttonDashBoard.Name = "buttonDashBoard";
            this.buttonDashBoard.Size = new System.Drawing.Size(196, 42);
            this.buttonDashBoard.TabIndex = 4;
            this.buttonDashBoard.Text = "DashBoard";
            this.buttonDashBoard.UseVisualStyleBackColor = true;
            this.buttonDashBoard.Click += new System.EventHandler(this.buttonDashBoard_Click);
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
            this.buttonNews.Size = new System.Drawing.Size(196, 42);
            this.buttonNews.TabIndex = 3;
            this.buttonNews.Text = "News";
            this.buttonNews.UseVisualStyleBackColor = true;
            this.buttonNews.Click += new System.EventHandler(this.buttonNews_Click);
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
            this.buttonHome.Size = new System.Drawing.Size(196, 42);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // FormDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1317, 729);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelManageMent);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Name = "FormDeveloper";
            this.Text = "FormDeveloper";
            this.Load += new System.EventHandler(this.FormDeveloper_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelManageMent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelManageMent;
        private System.Windows.Forms.Button buttonGameManagement;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonMyProfile;
        private System.Windows.Forms.Button buttonDashBoard;
        private System.Windows.Forms.Button buttonNews;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Button buttonPublishNews;
        private System.Windows.Forms.Button buttonPublishGames;
    }
}
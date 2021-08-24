
namespace GameStore
{
    partial class UserControlUserManagement
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
            this.panelCenter = new System.Windows.Forms.Panel();
            this.listViewBanUsers = new System.Windows.Forms.ListView();
            this.columnHeaderuserid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderusername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderemail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderbanstatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonUnbanUser = new System.Windows.Forms.Button();
            this.buttonBan = new System.Windows.Forms.Button();
            this.panelCenter.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.listViewBanUsers);
            this.panelCenter.Controls.Add(this.panelButton);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1121, 664);
            this.panelCenter.TabIndex = 1;
            // 
            // listViewBanUsers
            // 
            this.listViewBanUsers.AllowColumnReorder = true;
            this.listViewBanUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderuserid,
            this.columnHeaderusername,
            this.columnHeaderemail,
            this.columnHeaderbanstatus});
            this.listViewBanUsers.FullRowSelect = true;
            this.listViewBanUsers.GridLines = true;
            this.listViewBanUsers.HideSelection = false;
            this.listViewBanUsers.LabelEdit = true;
            this.listViewBanUsers.Location = new System.Drawing.Point(227, 29);
            this.listViewBanUsers.MultiSelect = false;
            this.listViewBanUsers.Name = "listViewBanUsers";
            this.listViewBanUsers.Size = new System.Drawing.Size(432, 450);
            this.listViewBanUsers.TabIndex = 3;
            this.listViewBanUsers.UseCompatibleStateImageBehavior = false;
            this.listViewBanUsers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderuserid
            // 
            this.columnHeaderuserid.Text = "userid";
            this.columnHeaderuserid.Width = 100;
            // 
            // columnHeaderusername
            // 
            this.columnHeaderusername.Text = "userName";
            this.columnHeaderusername.Width = 100;
            // 
            // columnHeaderemail
            // 
            this.columnHeaderemail.Text = "Email";
            this.columnHeaderemail.Width = 110;
            // 
            // columnHeaderbanstatus
            // 
            this.columnHeaderbanstatus.Text = "banstatus";
            this.columnHeaderbanstatus.Width = 120;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.buttonUnbanUser);
            this.panelButton.Controls.Add(this.buttonBan);
            this.panelButton.Location = new System.Drawing.Point(206, 516);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(500, 122);
            this.panelButton.TabIndex = 2;
            // 
            // buttonUnbanUser
            // 
            this.buttonUnbanUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnbanUser.Location = new System.Drawing.Point(319, 38);
            this.buttonUnbanUser.Name = "buttonUnbanUser";
            this.buttonUnbanUser.Size = new System.Drawing.Size(148, 55);
            this.buttonUnbanUser.TabIndex = 1;
            this.buttonUnbanUser.Text = "Unban User";
            this.buttonUnbanUser.UseVisualStyleBackColor = true;
            this.buttonUnbanUser.Click += new System.EventHandler(this.buttonUnbanUser_Click_1);
            // 
            // buttonBan
            // 
            this.buttonBan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBan.Location = new System.Drawing.Point(68, 38);
            this.buttonBan.Name = "buttonBan";
            this.buttonBan.Size = new System.Drawing.Size(138, 55);
            this.buttonBan.TabIndex = 0;
            this.buttonBan.Text = "Ban User";
            this.buttonBan.UseVisualStyleBackColor = true;
            this.buttonBan.Click += new System.EventHandler(this.buttonBan_Click_1);
            // 
            // UserControlUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCenter);
            this.Name = "UserControlUserManagement";
            this.Size = new System.Drawing.Size(1121, 664);
            this.panelCenter.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.ListView listViewBanUsers;
        private System.Windows.Forms.ColumnHeader columnHeaderuserid;
        private System.Windows.Forms.ColumnHeader columnHeaderusername;
        private System.Windows.Forms.ColumnHeader columnHeaderemail;
        private System.Windows.Forms.ColumnHeader columnHeaderbanstatus;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button buttonUnbanUser;
        private System.Windows.Forms.Button buttonBan;
    }
}

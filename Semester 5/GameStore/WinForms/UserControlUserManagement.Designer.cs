
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelReason = new System.Windows.Forms.Label();
            this.listViewBanUsers = new System.Windows.Forms.ListView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxReason = new System.Windows.Forms.TextBox();
            this.buttonViewUsers = new System.Windows.Forms.Button();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonBan = new System.Windows.Forms.Button();
            this.buttonUnbanUser = new System.Windows.Forms.Button();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelCenter.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.panelButton);
            this.panelCenter.Controls.Add(this.listViewBanUsers);
            this.panelCenter.Controls.Add(this.panelLeft);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1121, 664);
            this.panelCenter.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.buttonViewUsers);
            this.panelLeft.Controls.Add(this.textBoxReason);
            this.panelLeft.Controls.Add(this.textBoxEmail);
            this.panelLeft.Controls.Add(this.textBoxName);
            this.panelLeft.Controls.Add(this.labelReason);
            this.panelLeft.Controls.Add(this.labelEmail);
            this.panelLeft.Controls.Add(this.labelName);
            this.panelLeft.Location = new System.Drawing.Point(49, 41);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(401, 450);
            this.panelLeft.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(21, 163);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 21);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name :";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(21, 235);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(65, 21);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email  :";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelReason
            // 
            this.labelReason.AutoSize = true;
            this.labelReason.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReason.Location = new System.Drawing.Point(21, 318);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(73, 21);
            this.labelReason.TabIndex = 2;
            this.labelReason.Text = "Reason :";
            this.labelReason.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listViewBanUsers
            // 
            this.listViewBanUsers.AllowColumnReorder = true;
            this.listViewBanUsers.CheckBoxes = true;
            this.listViewBanUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderEmail,
            this.columnHeaderReason});
            this.listViewBanUsers.FullRowSelect = true;
            this.listViewBanUsers.GridLines = true;
            this.listViewBanUsers.HideSelection = false;
            this.listViewBanUsers.LabelEdit = true;
            this.listViewBanUsers.Location = new System.Drawing.Point(510, 41);
            this.listViewBanUsers.Name = "listViewBanUsers";
            this.listViewBanUsers.Size = new System.Drawing.Size(489, 450);
            this.listViewBanUsers.TabIndex = 1;
            this.listViewBanUsers.UseCompatibleStateImageBehavior = false;
            this.listViewBanUsers.View = System.Windows.Forms.View.Details;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(120, 160);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(259, 29);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(120, 235);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(259, 29);
            this.textBoxEmail.TabIndex = 4;
            // 
            // textBoxReason
            // 
            this.textBoxReason.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReason.Location = new System.Drawing.Point(120, 315);
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.Size = new System.Drawing.Size(259, 35);
            this.textBoxReason.TabIndex = 5;
            // 
            // buttonViewUsers
            // 
            this.buttonViewUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewUsers.Location = new System.Drawing.Point(177, 24);
            this.buttonViewUsers.Name = "buttonViewUsers";
            this.buttonViewUsers.Size = new System.Drawing.Size(202, 30);
            this.buttonViewUsers.TabIndex = 6;
            this.buttonViewUsers.Text = "Veiw All Users  -->>";
            this.buttonViewUsers.UseVisualStyleBackColor = true;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.buttonUnbanUser);
            this.panelButton.Controls.Add(this.buttonBan);
            this.panelButton.Location = new System.Drawing.Point(499, 517);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(500, 122);
            this.panelButton.TabIndex = 2;
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
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 160;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderEmail.Width = 137;
            // 
            // columnHeaderReason
            // 
            this.columnHeaderReason.Width = 190;
            // 
            // UserControlUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCenter);
            this.Name = "UserControlUserManagement";
            this.Size = new System.Drawing.Size(1121, 664);
            this.panelCenter.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button buttonUnbanUser;
        private System.Windows.Forms.Button buttonBan;
        private System.Windows.Forms.ListView listViewBanUsers;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderReason;
        private System.Windows.Forms.Button buttonViewUsers;
        private System.Windows.Forms.TextBox textBoxReason;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelReason;
        private System.Windows.Forms.Label labelEmail;
    }
}

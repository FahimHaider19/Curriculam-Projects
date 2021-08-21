
namespace GameStore
{
    partial class UserControlDeveloperManagement
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
            this.panelDiscount = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.listViewDiscount = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDiscount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonDecline = new System.Windows.Forms.Button();
            this.panelPublishGames = new System.Windows.Forms.Panel();
            this.labelPublishRequest = new System.Windows.Forms.Label();
            this.listViewPublishGameREquests = new System.Windows.Forms.ListView();
            this.columnHeaderGameName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDeveloperName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonReject = new System.Windows.Forms.Button();
            this.buttonPublish = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAddDeveloper = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.panelCenter.SuspendLayout();
            this.panelDiscount.SuspendLayout();
            this.panelPublishGames.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.panel1);
            this.panelCenter.Controls.Add(this.panelPublishGames);
            this.panelCenter.Controls.Add(this.panelDiscount);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1121, 2000);
            this.panelCenter.TabIndex = 0;
            // 
            // panelDiscount
            // 
            this.panelDiscount.Controls.Add(this.buttonDecline);
            this.panelDiscount.Controls.Add(this.buttonApply);
            this.panelDiscount.Controls.Add(this.listViewDiscount);
            this.panelDiscount.Controls.Add(this.labelName);
            this.panelDiscount.Location = new System.Drawing.Point(120, 21);
            this.panelDiscount.Name = "panelDiscount";
            this.panelDiscount.Size = new System.Drawing.Size(706, 522);
            this.panelDiscount.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(255, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(169, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Discount Requests";
            // 
            // listViewDiscount
            // 
            this.listViewDiscount.AllowColumnReorder = true;
            this.listViewDiscount.CheckBoxes = true;
            this.listViewDiscount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderEmail,
            this.columnHeaderDiscount});
            this.listViewDiscount.FullRowSelect = true;
            this.listViewDiscount.GridLines = true;
            this.listViewDiscount.HideSelection = false;
            this.listViewDiscount.LabelEdit = true;
            this.listViewDiscount.Location = new System.Drawing.Point(86, 82);
            this.listViewDiscount.Name = "listViewDiscount";
            this.listViewDiscount.Size = new System.Drawing.Size(533, 332);
            this.listViewDiscount.TabIndex = 1;
            this.listViewDiscount.UseCompatibleStateImageBehavior = false;
            this.listViewDiscount.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Game Name";
            this.columnHeaderName.Width = 250;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.Width = 150;
            // 
            // columnHeaderDiscount
            // 
            this.columnHeaderDiscount.Text = "Discount Rate";
            this.columnHeaderDiscount.Width = 130;
            // 
            // buttonApply
            // 
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonApply.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApply.Location = new System.Drawing.Point(149, 444);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(144, 41);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // buttonDecline
            // 
            this.buttonDecline.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDecline.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecline.Location = new System.Drawing.Point(389, 444);
            this.buttonDecline.Name = "buttonDecline";
            this.buttonDecline.Size = new System.Drawing.Size(138, 41);
            this.buttonDecline.TabIndex = 3;
            this.buttonDecline.Text = "Decline";
            this.buttonDecline.UseVisualStyleBackColor = true;
            // 
            // panelPublishGames
            // 
            this.panelPublishGames.Controls.Add(this.buttonReject);
            this.panelPublishGames.Controls.Add(this.buttonPublish);
            this.panelPublishGames.Controls.Add(this.listViewPublishGameREquests);
            this.panelPublishGames.Controls.Add(this.labelPublishRequest);
            this.panelPublishGames.Location = new System.Drawing.Point(120, 580);
            this.panelPublishGames.Name = "panelPublishGames";
            this.panelPublishGames.Size = new System.Drawing.Size(706, 522);
            this.panelPublishGames.TabIndex = 1;
            // 
            // labelPublishRequest
            // 
            this.labelPublishRequest.AutoSize = true;
            this.labelPublishRequest.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPublishRequest.Location = new System.Drawing.Point(288, 30);
            this.labelPublishRequest.Name = "labelPublishRequest";
            this.labelPublishRequest.Size = new System.Drawing.Size(155, 25);
            this.labelPublishRequest.TabIndex = 0;
            this.labelPublishRequest.Text = "Publish Requests";
            this.labelPublishRequest.Click += new System.EventHandler(this.labelPublishRequest_Click);
            // 
            // listViewPublishGameREquests
            // 
            this.listViewPublishGameREquests.AllowColumnReorder = true;
            this.listViewPublishGameREquests.CheckBoxes = true;
            this.listViewPublishGameREquests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderGameName,
            this.columnHeaderDeveloperName});
            this.listViewPublishGameREquests.GridLines = true;
            this.listViewPublishGameREquests.HideSelection = false;
            this.listViewPublishGameREquests.LabelEdit = true;
            this.listViewPublishGameREquests.Location = new System.Drawing.Point(111, 85);
            this.listViewPublishGameREquests.Name = "listViewPublishGameREquests";
            this.listViewPublishGameREquests.Size = new System.Drawing.Size(508, 332);
            this.listViewPublishGameREquests.TabIndex = 1;
            this.listViewPublishGameREquests.UseCompatibleStateImageBehavior = false;
            this.listViewPublishGameREquests.View = System.Windows.Forms.View.Details;
            this.listViewPublishGameREquests.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeaderGameName
            // 
            this.columnHeaderGameName.Text = "Game Name";
            this.columnHeaderGameName.Width = 255;
            // 
            // columnHeaderDeveloperName
            // 
            this.columnHeaderDeveloperName.Text = "Developer Name";
            this.columnHeaderDeveloperName.Width = 255;
            // 
            // buttonReject
            // 
            this.buttonReject.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonReject.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReject.Location = new System.Drawing.Point(411, 449);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(138, 41);
            this.buttonReject.TabIndex = 5;
            this.buttonReject.Text = "Reject";
            this.buttonReject.UseVisualStyleBackColor = true;
            // 
            // buttonPublish
            // 
            this.buttonPublish.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPublish.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPublish.Location = new System.Drawing.Point(171, 449);
            this.buttonPublish.Name = "buttonPublish";
            this.buttonPublish.Size = new System.Drawing.Size(144, 41);
            this.buttonPublish.TabIndex = 4;
            this.buttonPublish.Text = "Publish";
            this.buttonPublish.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCreate);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.labelAddDeveloper);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Location = new System.Drawing.Point(120, 1184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 522);
            this.panel1.TabIndex = 2;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(120, 149);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(69, 25);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email :";
            // 
            // labelAddDeveloper
            // 
            this.labelAddDeveloper.AutoSize = true;
            this.labelAddDeveloper.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddDeveloper.Location = new System.Drawing.Point(300, 34);
            this.labelAddDeveloper.Name = "labelAddDeveloper";
            this.labelAddDeveloper.Size = new System.Drawing.Size(145, 25);
            this.labelAddDeveloper.TabIndex = 1;
            this.labelAddDeveloper.Text = "Add  Developer";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(293, 149);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(284, 29);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(298, 247);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(284, 29);
            this.textBoxPassword.TabIndex = 4;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(120, 247);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(101, 25);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password :";
            // 
            // buttonCreate
            // 
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(275, 375);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(237, 46);
            this.buttonCreate.TabIndex = 5;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // UserControlDeveloperManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCenter);
            this.Name = "UserControlDeveloperManagement";
            this.Size = new System.Drawing.Size(1121, 2000);
            this.panelCenter.ResumeLayout(false);
            this.panelDiscount.ResumeLayout(false);
            this.panelDiscount.PerformLayout();
            this.panelPublishGames.ResumeLayout(false);
            this.panelPublishGames.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelDiscount;
        private System.Windows.Forms.Button buttonDecline;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.ListView listViewDiscount;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderDiscount;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelPublishGames;
        private System.Windows.Forms.ListView listViewPublishGameREquests;
        private System.Windows.Forms.Label labelPublishRequest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelAddDeveloper;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonReject;
        private System.Windows.Forms.Button buttonPublish;
        private System.Windows.Forms.ColumnHeader columnHeaderGameName;
        private System.Windows.Forms.ColumnHeader columnHeaderDeveloperName;
    }
}

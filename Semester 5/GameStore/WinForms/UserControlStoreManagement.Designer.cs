
namespace GameStore
{
    partial class UserControlDashboardAdmin
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
            this.buttonStoreManagement = new System.Windows.Forms.Button();
            this.buttonUserManagement = new System.Windows.Forms.Button();
            this.buttonDeveloperManagement = new System.Windows.Forms.Button();
            this.panelManagementTab = new System.Windows.Forms.Panel();
            this.panelManagementTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStoreManagement
            // 
            this.buttonStoreManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStoreManagement.Location = new System.Drawing.Point(0, 3);
            this.buttonStoreManagement.Name = "buttonStoreManagement";
            this.buttonStoreManagement.Size = new System.Drawing.Size(369, 41);
            this.buttonStoreManagement.TabIndex = 2;
            this.buttonStoreManagement.Text = "Store Management";
            this.buttonStoreManagement.UseVisualStyleBackColor = true;
            // 
            // buttonUserManagement
            // 
            this.buttonUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserManagement.Location = new System.Drawing.Point(367, 3);
            this.buttonUserManagement.Name = "buttonUserManagement";
            this.buttonUserManagement.Size = new System.Drawing.Size(377, 41);
            this.buttonUserManagement.TabIndex = 3;
            this.buttonUserManagement.Text = "User Management";
            this.buttonUserManagement.UseVisualStyleBackColor = true;
            // 
            // buttonDeveloperManagement
            // 
            this.buttonDeveloperManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeveloperManagement.Location = new System.Drawing.Point(736, 3);
            this.buttonDeveloperManagement.Name = "buttonDeveloperManagement";
            this.buttonDeveloperManagement.Size = new System.Drawing.Size(369, 41);
            this.buttonDeveloperManagement.TabIndex = 4;
            this.buttonDeveloperManagement.Text = "Developer Management";
            this.buttonDeveloperManagement.UseVisualStyleBackColor = true;
            // 
            // panelManagementTab
            // 
            this.panelManagementTab.Controls.Add(this.buttonDeveloperManagement);
            this.panelManagementTab.Controls.Add(this.buttonUserManagement);
            this.panelManagementTab.Controls.Add(this.buttonStoreManagement);
            this.panelManagementTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManagementTab.Location = new System.Drawing.Point(0, 0);
            this.panelManagementTab.Name = "panelManagementTab";
            this.panelManagementTab.Size = new System.Drawing.Size(1105, 49);
            this.panelManagementTab.TabIndex = 0;
            // 
            // UserControlDashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelManagementTab);
            this.Name = "UserControlDashboardAdmin";
            this.Size = new System.Drawing.Size(1105, 388);
            this.panelManagementTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStoreManagement;
        private System.Windows.Forms.Button buttonUserManagement;
        private System.Windows.Forms.Button buttonDeveloperManagement;
        private System.Windows.Forms.Panel panelManagementTab;
    }
}

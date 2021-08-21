
namespace GameStore
{
    partial class Register
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelAlreadyHaveAnAccount = new System.Windows.Forms.Label();
            this.showPassCheckbox1 = new System.Windows.Forms.CheckBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.labelRegisterBanner = new System.Windows.Forms.Label();
            this.showPassCheckbox2 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.confirmPasswordBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLogin.Location = new System.Drawing.Point(155, 391);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(37, 13);
            this.labelLogin.TabIndex = 18;
            this.labelLogin.Text = "Log In";
            // 
            // labelAlreadyHaveAnAccount
            // 
            this.labelAlreadyHaveAnAccount.AutoSize = true;
            this.labelAlreadyHaveAnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAlreadyHaveAnAccount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAlreadyHaveAnAccount.Location = new System.Drawing.Point(114, 378);
            this.labelAlreadyHaveAnAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlreadyHaveAnAccount.Name = "labelAlreadyHaveAnAccount";
            this.labelAlreadyHaveAnAccount.Size = new System.Drawing.Size(130, 13);
            this.labelAlreadyHaveAnAccount.TabIndex = 17;
            this.labelAlreadyHaveAnAccount.Text = "Already have an Account!";
            // 
            // showPassCheckbox1
            // 
            this.showPassCheckbox1.AutoSize = true;
            this.showPassCheckbox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.showPassCheckbox1.Location = new System.Drawing.Point(61, 203);
            this.showPassCheckbox1.Margin = new System.Windows.Forms.Padding(2);
            this.showPassCheckbox1.Name = "showPassCheckbox1";
            this.showPassCheckbox1.Size = new System.Drawing.Size(102, 17);
            this.showPassCheckbox1.TabIndex = 16;
            this.showPassCheckbox1.Text = "Show Password";
            this.showPassCheckbox1.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(82, 334);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(189, 36);
            this.registerButton.TabIndex = 15;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(57, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(61, 170);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(242, 26);
            this.passwordBox.TabIndex = 13;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(57, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Username";
            // 
            // usernameBox
            // 
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(61, 114);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(242, 26);
            this.usernameBox.TabIndex = 11;
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // labelRegisterBanner
            // 
            this.labelRegisterBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRegisterBanner.AutoSize = true;
            this.labelRegisterBanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRegisterBanner.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisterBanner.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRegisterBanner.Location = new System.Drawing.Point(126, 62);
            this.labelRegisterBanner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegisterBanner.Name = "labelRegisterBanner";
            this.labelRegisterBanner.Size = new System.Drawing.Size(97, 30);
            this.labelRegisterBanner.TabIndex = 10;
            this.labelRegisterBanner.Text = "Register";
            // 
            // showPassCheckbox2
            // 
            this.showPassCheckbox2.AutoSize = true;
            this.showPassCheckbox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.showPassCheckbox2.Location = new System.Drawing.Point(61, 278);
            this.showPassCheckbox2.Margin = new System.Windows.Forms.Padding(2);
            this.showPassCheckbox2.Name = "showPassCheckbox2";
            this.showPassCheckbox2.Size = new System.Drawing.Size(102, 17);
            this.showPassCheckbox2.TabIndex = 21;
            this.showPassCheckbox2.Text = "Show Password";
            this.showPassCheckbox2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(57, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Confirm Password";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // confirmPasswordBox
            // 
            this.confirmPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordBox.Location = new System.Drawing.Point(61, 246);
            this.confirmPasswordBox.Margin = new System.Windows.Forms.Padding(2);
            this.confirmPasswordBox.Name = "confirmPasswordBox";
            this.confirmPasswordBox.Size = new System.Drawing.Size(242, 26);
            this.confirmPasswordBox.TabIndex = 19;
            this.confirmPasswordBox.TextChanged += new System.EventHandler(this.confirmPasswordBox_TextChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(348, 446);
            this.Controls.Add(this.showPassCheckbox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.confirmPasswordBox);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelAlreadyHaveAnAccount);
            this.Controls.Add(this.showPassCheckbox1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.labelRegisterBanner);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelAlreadyHaveAnAccount;
        private System.Windows.Forms.CheckBox showPassCheckbox1;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label labelRegisterBanner;
        private System.Windows.Forms.CheckBox showPassCheckbox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox confirmPasswordBox;
    }
}
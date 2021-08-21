﻿
namespace GameStore
{
    partial class LogIn
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
            this.labelLoginBanner = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.checkBoxShowCheckbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRegistered = new System.Windows.Forms.Label();
            this.labelForgotPassword = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLoginBanner
            // 
            this.labelLoginBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoginBanner.AutoSize = true;
            this.labelLoginBanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLoginBanner.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginBanner.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLoginBanner.Location = new System.Drawing.Point(140, 39);
            this.labelLoginBanner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoginBanner.Name = "labelLoginBanner";
            this.labelLoginBanner.Size = new System.Drawing.Size(79, 30);
            this.labelLoginBanner.TabIndex = 0;
            this.labelLoginBanner.Text = "Log In";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(58, 120);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(242, 26);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBoxUserName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(55, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(55, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "PASSWORD";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(58, 185);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(242, 26);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // checkBoxShowCheckbox
            // 
            this.checkBoxShowCheckbox.AutoSize = true;
            this.checkBoxShowCheckbox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxShowCheckbox.Location = new System.Drawing.Point(58, 218);
            this.checkBoxShowCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxShowCheckbox.Name = "checkBoxShowCheckbox";
            this.checkBoxShowCheckbox.Size = new System.Drawing.Size(102, 17);
            this.checkBoxShowCheckbox.TabIndex = 6;
            this.checkBoxShowCheckbox.Text = "Show Password";
            this.checkBoxShowCheckbox.UseVisualStyleBackColor = true;
            this.checkBoxShowCheckbox.CheckedChanged += new System.EventHandler(this.checkBoxShowCheckbox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(117, 293);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Do not have an Account!";
            // 
            // labelRegistered
            // 
            this.labelRegistered.AutoSize = true;
            this.labelRegistered.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRegistered.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRegistered.Location = new System.Drawing.Point(147, 306);
            this.labelRegistered.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegistered.Name = "labelRegistered";
            this.labelRegistered.Size = new System.Drawing.Size(69, 13);
            this.labelRegistered.TabIndex = 8;
            this.labelRegistered.Text = "Register now";
            this.labelRegistered.Click += new System.EventHandler(this.labelRegistered_Click);
            // 
            // labelForgotPassword
            // 
            this.labelForgotPassword.AutoSize = true;
            this.labelForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelForgotPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelForgotPassword.Location = new System.Drawing.Point(138, 341);
            this.labelForgotPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(86, 13);
            this.labelForgotPassword.TabIndex = 9;
            this.labelForgotPassword.Text = "Forgot Password";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(89, 255);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(189, 36);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(348, 446);
            this.Controls.Add(this.labelForgotPassword);
            this.Controls.Add(this.labelRegistered);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxShowCheckbox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelLoginBanner);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogIn_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoginBanner;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxShowCheckbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRegistered;
        private System.Windows.Forms.Label labelForgotPassword;
        private System.Windows.Forms.Button loginButton;
    }
}


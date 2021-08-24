
namespace GameStore
{
    partial class UserControlCart
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelCartEmpty = new System.Windows.Forms.Label();
            this.panelSeparatorLine = new System.Windows.Forms.Panel();
            this.labelTotalTag = new System.Windows.Forms.Label();
            this.labelTotalBill = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.buttonConfirmPurchase = new System.Windows.Forms.Button();
            this.comboBoxCardBrand = new System.Windows.Forms.ComboBox();
            this.textBoxExpYear = new System.Windows.Forms.TextBox();
            this.textBoxExpMonth = new System.Windows.Forms.TextBox();
            this.textBoxCVV = new System.Windows.Forms.TextBox();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.labelCVV = new System.Windows.Forms.Label();
            this.labelExpireDate = new System.Windows.Forms.Label();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.radioButtonCard = new System.Windows.Forms.RadioButton();
            this.radioButtonStoreCredit = new System.Windows.Forms.RadioButton();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.AutoSize = true;
            this.panelTop.Controls.Add(this.labelCartEmpty);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1164, 97);
            this.panelTop.TabIndex = 0;
            // 
            // labelCartEmpty
            // 
            this.labelCartEmpty.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCartEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartEmpty.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCartEmpty.Location = new System.Drawing.Point(0, 0);
            this.labelCartEmpty.Name = "labelCartEmpty";
            this.labelCartEmpty.Size = new System.Drawing.Size(1164, 97);
            this.labelCartEmpty.TabIndex = 0;
            this.labelCartEmpty.Text = "Cart Is Empty";
            this.labelCartEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSeparatorLine
            // 
            this.panelSeparatorLine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelSeparatorLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeparatorLine.Location = new System.Drawing.Point(0, 97);
            this.panelSeparatorLine.Name = "panelSeparatorLine";
            this.panelSeparatorLine.Size = new System.Drawing.Size(1164, 2);
            this.panelSeparatorLine.TabIndex = 16;
            // 
            // labelTotalTag
            // 
            this.labelTotalTag.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTotalTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTag.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTotalTag.Location = new System.Drawing.Point(0, 0);
            this.labelTotalTag.Name = "labelTotalTag";
            this.labelTotalTag.Size = new System.Drawing.Size(100, 59);
            this.labelTotalTag.TabIndex = 18;
            this.labelTotalTag.Text = "Total";
            this.labelTotalTag.Click += new System.EventHandler(this.labelTotalTag_Click);
            // 
            // labelTotalBill
            // 
            this.labelTotalBill.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBill.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTotalBill.Location = new System.Drawing.Point(1064, 0);
            this.labelTotalBill.Name = "labelTotalBill";
            this.labelTotalBill.Size = new System.Drawing.Size(100, 59);
            this.labelTotalBill.TabIndex = 19;
            this.labelTotalBill.Text = "60.00$";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTotalTag);
            this.panel1.Controls.Add(this.labelTotalBill);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 59);
            this.panel1.TabIndex = 20;
            // 
            // panelPayment
            // 
            this.panelPayment.Controls.Add(this.buttonConfirmPurchase);
            this.panelPayment.Controls.Add(this.comboBoxCardBrand);
            this.panelPayment.Controls.Add(this.textBoxExpYear);
            this.panelPayment.Controls.Add(this.textBoxExpMonth);
            this.panelPayment.Controls.Add(this.textBoxCVV);
            this.panelPayment.Controls.Add(this.textBoxCardNumber);
            this.panelPayment.Controls.Add(this.labelCVV);
            this.panelPayment.Controls.Add(this.labelExpireDate);
            this.panelPayment.Controls.Add(this.labelCardNumber);
            this.panelPayment.Controls.Add(this.radioButtonCard);
            this.panelPayment.Controls.Add(this.radioButtonStoreCredit);
            this.panelPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPayment.Location = new System.Drawing.Point(0, 158);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(1164, 268);
            this.panelPayment.TabIndex = 21;
            // 
            // buttonConfirmPurchase
            // 
            this.buttonConfirmPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmPurchase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConfirmPurchase.Location = new System.Drawing.Point(449, 123);
            this.buttonConfirmPurchase.Name = "buttonConfirmPurchase";
            this.buttonConfirmPurchase.Size = new System.Drawing.Size(217, 48);
            this.buttonConfirmPurchase.TabIndex = 13;
            this.buttonConfirmPurchase.Text = "Confirm Purchase";
            this.buttonConfirmPurchase.UseVisualStyleBackColor = true;
            this.buttonConfirmPurchase.Click += new System.EventHandler(this.buttonConfirmPurchase_Click);
            // 
            // comboBoxCardBrand
            // 
            this.comboBoxCardBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCardBrand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxCardBrand.FormattingEnabled = true;
            this.comboBoxCardBrand.Location = new System.Drawing.Point(704, 17);
            this.comboBoxCardBrand.Name = "comboBoxCardBrand";
            this.comboBoxCardBrand.Size = new System.Drawing.Size(179, 32);
            this.comboBoxCardBrand.TabIndex = 9;
            this.comboBoxCardBrand.Text = "American Express";
            // 
            // textBoxExpYear
            // 
            this.textBoxExpYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExpYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxExpYear.Location = new System.Drawing.Point(516, 67);
            this.textBoxExpYear.Name = "textBoxExpYear";
            this.textBoxExpYear.Size = new System.Drawing.Size(107, 29);
            this.textBoxExpYear.TabIndex = 8;
            this.textBoxExpYear.Text = "YYYY";
            this.textBoxExpYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExpMonth
            // 
            this.textBoxExpMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExpMonth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxExpMonth.Location = new System.Drawing.Point(449, 66);
            this.textBoxExpMonth.Name = "textBoxExpMonth";
            this.textBoxExpMonth.Size = new System.Drawing.Size(61, 29);
            this.textBoxExpMonth.TabIndex = 7;
            this.textBoxExpMonth.Text = "MM";
            this.textBoxExpMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCVV
            // 
            this.textBoxCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCVV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxCVV.Location = new System.Drawing.Point(750, 67);
            this.textBoxCVV.Name = "textBoxCVV";
            this.textBoxCVV.Size = new System.Drawing.Size(133, 29);
            this.textBoxCVV.TabIndex = 6;
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCardNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxCardNumber.Location = new System.Drawing.Point(442, 18);
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(256, 29);
            this.textBoxCardNumber.TabIndex = 5;
            // 
            // labelCVV
            // 
            this.labelCVV.AutoSize = true;
            this.labelCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCVV.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCVV.Location = new System.Drawing.Point(692, 68);
            this.labelCVV.Name = "labelCVV";
            this.labelCVV.Size = new System.Drawing.Size(64, 24);
            this.labelCVV.TabIndex = 4;
            this.labelCVV.Text = "CVV : ";
            // 
            // labelExpireDate
            // 
            this.labelExpireDate.AutoSize = true;
            this.labelExpireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpireDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelExpireDate.Location = new System.Drawing.Point(323, 68);
            this.labelExpireDate.Name = "labelExpireDate";
            this.labelExpireDate.Size = new System.Drawing.Size(123, 24);
            this.labelExpireDate.TabIndex = 3;
            this.labelExpireDate.Text = "Expire Date : ";
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCardNumber.Location = new System.Drawing.Point(309, 19);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(134, 24);
            this.labelCardNumber.TabIndex = 2;
            this.labelCardNumber.Text = "Card Number :";
            // 
            // radioButtonCard
            // 
            this.radioButtonCard.AutoSize = true;
            this.radioButtonCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonCard.Location = new System.Drawing.Point(192, 15);
            this.radioButtonCard.Name = "radioButtonCard";
            this.radioButtonCard.Size = new System.Drawing.Size(68, 28);
            this.radioButtonCard.TabIndex = 1;
            this.radioButtonCard.TabStop = true;
            this.radioButtonCard.Text = "Card";
            this.radioButtonCard.UseVisualStyleBackColor = true;
            // 
            // radioButtonStoreCredit
            // 
            this.radioButtonStoreCredit.AutoSize = true;
            this.radioButtonStoreCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonStoreCredit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButtonStoreCredit.Location = new System.Drawing.Point(30, 15);
            this.radioButtonStoreCredit.Name = "radioButtonStoreCredit";
            this.radioButtonStoreCredit.Size = new System.Drawing.Size(126, 28);
            this.radioButtonStoreCredit.TabIndex = 0;
            this.radioButtonStoreCredit.TabStop = true;
            this.radioButtonStoreCredit.Text = "Store Credit";
            this.radioButtonStoreCredit.UseVisualStyleBackColor = true;
            // 
            // UserControlCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panelPayment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSeparatorLine);
            this.Controls.Add(this.panelTop);
            this.Name = "UserControlCart";
            this.Size = new System.Drawing.Size(1164, 655);
            this.Load += new System.EventHandler(this.testUC_Load);
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelPayment.ResumeLayout(false);
            this.panelPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelCartEmpty;
        private System.Windows.Forms.Panel panelSeparatorLine;
        private System.Windows.Forms.Label labelTotalTag;
        private System.Windows.Forms.Label labelTotalBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.Button buttonConfirmPurchase;
        private System.Windows.Forms.ComboBox comboBoxCardBrand;
        private System.Windows.Forms.TextBox textBoxExpYear;
        private System.Windows.Forms.TextBox textBoxExpMonth;
        private System.Windows.Forms.TextBox textBoxCVV;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.Label labelCVV;
        private System.Windows.Forms.Label labelExpireDate;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.RadioButton radioButtonCard;
        private System.Windows.Forms.RadioButton radioButtonStoreCredit;
    }
}

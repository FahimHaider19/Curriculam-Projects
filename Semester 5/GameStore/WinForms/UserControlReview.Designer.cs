
namespace GameStore.WinForms
{
    partial class UserControlReview
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelReview = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(0, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Padding = new System.Windows.Forms.Padding(5);
            this.labelUsername.Size = new System.Drawing.Size(73, 30);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Name : ";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.Location = new System.Drawing.Point(0, 30);
            this.labelRating.Name = "labelRating";
            this.labelRating.Padding = new System.Windows.Forms.Padding(5);
            this.labelRating.Size = new System.Drawing.Size(74, 30);
            this.labelRating.TabIndex = 1;
            this.labelRating.Text = "Rating: ";
            // 
            // labelReview
            // 
            this.labelReview.AutoSize = true;
            this.labelReview.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReview.Location = new System.Drawing.Point(0, 60);
            this.labelReview.MaximumSize = new System.Drawing.Size(380, 0);
            this.labelReview.Name = "labelReview";
            this.labelReview.Padding = new System.Windows.Forms.Padding(5);
            this.labelReview.Size = new System.Drawing.Size(82, 30);
            this.labelReview.TabIndex = 2;
            this.labelReview.Text = "Reveiw : ";
            // 
            // UserControlReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelReview);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelUsername);
            this.MaximumSize = new System.Drawing.Size(391, 0);
            this.Name = "UserControlReview";
            this.Size = new System.Drawing.Size(391, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelReview;
    }
}

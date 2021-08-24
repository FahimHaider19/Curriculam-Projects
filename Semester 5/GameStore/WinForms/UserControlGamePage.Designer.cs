
namespace GameStore.WinForms
{
    partial class UserControlGamePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlGamePage));
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelPurchase = new System.Windows.Forms.Panel();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.buttonAddToWishlist = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelReleaseDate = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelDeveloper = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDescriptionTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanelSystemRequirment = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSystemRequirments = new System.Windows.Forms.Label();
            this.tableLayoutPanelTop.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelPurchase.SuspendLayout();
            this.panelDescription.SuspendLayout();
            this.flowLayoutPanelSystemRequirment.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.ColumnCount = 2;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.0746F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.9254F));
            this.tableLayoutPanelTop.Controls.Add(this.panelInfo, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.panelPurchase, 1, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(1132, 446);
            this.tableLayoutPanelTop.TabIndex = 1;
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.Controls.Add(this.pictureBox);
            this.panelInfo.Location = new System.Drawing.Point(3, 3);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(741, 440);
            this.panelInfo.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(4, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(732, 432);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // panelPurchase
            // 
            this.panelPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPurchase.Controls.Add(this.buttonAddToCart);
            this.panelPurchase.Controls.Add(this.buttonAddToWishlist);
            this.panelPurchase.Controls.Add(this.labelPrice);
            this.panelPurchase.Controls.Add(this.labelGenre);
            this.panelPurchase.Controls.Add(this.labelRating);
            this.panelPurchase.Controls.Add(this.labelReleaseDate);
            this.panelPurchase.Controls.Add(this.labelPublisher);
            this.panelPurchase.Controls.Add(this.labelDeveloper);
            this.panelPurchase.Controls.Add(this.labelTitle);
            this.panelPurchase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelPurchase.Location = new System.Drawing.Point(750, 3);
            this.panelPurchase.Name = "panelPurchase";
            this.panelPurchase.Size = new System.Drawing.Size(379, 440);
            this.panelPurchase.TabIndex = 2;
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToCart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddToCart.Location = new System.Drawing.Point(77, 328);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(243, 49);
            this.buttonAddToCart.TabIndex = 22;
            this.buttonAddToCart.Text = "Add to Cart";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // buttonAddToWishlist
            // 
            this.buttonAddToWishlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddToWishlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToWishlist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddToWishlist.Location = new System.Drawing.Point(77, 375);
            this.buttonAddToWishlist.Name = "buttonAddToWishlist";
            this.buttonAddToWishlist.Size = new System.Drawing.Size(243, 49);
            this.buttonAddToWishlist.TabIndex = 22;
            this.buttonAddToWishlist.Text = "Add to Wishlist";
            this.buttonAddToWishlist.UseVisualStyleBackColor = true;
            this.buttonAddToWishlist.Click += new System.EventHandler(this.buttonAddToWishlist_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPrice.Location = new System.Drawing.Point(6, 295);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(56, 20);
            this.labelPrice.TabIndex = 21;
            this.labelPrice.Text = "Price : ";
            // 
            // labelGenre
            // 
            this.labelGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelGenre.Location = new System.Drawing.Point(6, 259);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(66, 20);
            this.labelGenre.TabIndex = 21;
            this.labelGenre.Text = "Genre : ";
            // 
            // labelRating
            // 
            this.labelRating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRating.Location = new System.Drawing.Point(6, 224);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(68, 20);
            this.labelRating.TabIndex = 20;
            this.labelRating.Text = "Rating : ";
            // 
            // labelReleaseDate
            // 
            this.labelReleaseDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelReleaseDate.AutoSize = true;
            this.labelReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReleaseDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelReleaseDate.Location = new System.Drawing.Point(6, 104);
            this.labelReleaseDate.Name = "labelReleaseDate";
            this.labelReleaseDate.Size = new System.Drawing.Size(119, 20);
            this.labelReleaseDate.TabIndex = 19;
            this.labelReleaseDate.Text = "Release Date : ";
            // 
            // labelPublisher
            // 
            this.labelPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPublisher.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPublisher.Location = new System.Drawing.Point(6, 184);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(86, 20);
            this.labelPublisher.TabIndex = 18;
            this.labelPublisher.Text = "Publisher : ";
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeveloper.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDeveloper.Location = new System.Drawing.Point(6, 142);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(89, 20);
            this.labelDeveloper.TabIndex = 17;
            this.labelDeveloper.Text = "Developer :";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitle.Location = new System.Drawing.Point(3, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(373, 100);
            this.labelTitle.TabIndex = 16;
            this.labelTitle.Text = "Red Dead Redemption 2";
            // 
            // panelDescription
            // 
            this.panelDescription.Controls.Add(this.labelDescription);
            this.panelDescription.Controls.Add(this.labelDescriptionTitle);
            this.panelDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDescription.Location = new System.Drawing.Point(0, 446);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(741, 826);
            this.panelDescription.TabIndex = 2;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDescription.Location = new System.Drawing.Point(0, 43);
            this.labelDescription.MaximumSize = new System.Drawing.Size(700, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Padding = new System.Windows.Forms.Padding(10);
            this.labelDescription.Size = new System.Drawing.Size(55, 40);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "text";
            // 
            // labelDescriptionTitle
            // 
            this.labelDescriptionTitle.AutoSize = true;
            this.labelDescriptionTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDescriptionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriptionTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDescriptionTitle.Location = new System.Drawing.Point(0, 0);
            this.labelDescriptionTitle.Name = "labelDescriptionTitle";
            this.labelDescriptionTitle.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.labelDescriptionTitle.Size = new System.Drawing.Size(196, 43);
            this.labelDescriptionTitle.TabIndex = 0;
            this.labelDescriptionTitle.Text = "Description : ";
            // 
            // flowLayoutPanelSystemRequirment
            // 
            this.flowLayoutPanelSystemRequirment.AutoSize = true;
            this.flowLayoutPanelSystemRequirment.Controls.Add(this.labelSystemRequirments);
            this.flowLayoutPanelSystemRequirment.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelSystemRequirment.Location = new System.Drawing.Point(741, 446);
            this.flowLayoutPanelSystemRequirment.MaximumSize = new System.Drawing.Size(390, 0);
            this.flowLayoutPanelSystemRequirment.Name = "flowLayoutPanelSystemRequirment";
            this.flowLayoutPanelSystemRequirment.Size = new System.Drawing.Size(390, 261);
            this.flowLayoutPanelSystemRequirment.TabIndex = 3;
            // 
            // labelSystemRequirments
            // 
            this.labelSystemRequirments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSystemRequirments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSystemRequirments.Location = new System.Drawing.Point(3, 0);
            this.labelSystemRequirments.Name = "labelSystemRequirments";
            this.labelSystemRequirments.Size = new System.Drawing.Size(382, 261);
            this.labelSystemRequirments.TabIndex = 0;
            this.labelSystemRequirments.Text = "CPU : \r\n\r\nGPU :\r\n\r\nMemory : \r\n\r\nStorage : \r\n\r\nOS : \r\n\r\n\r\n";
            // 
            // UserControlGamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelSystemRequirment);
            this.Controls.Add(this.panelDescription);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Name = "UserControlGamePage";
            this.Size = new System.Drawing.Size(1132, 1272);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelPurchase.ResumeLayout(false);
            this.panelPurchase.PerformLayout();
            this.panelDescription.ResumeLayout(false);
            this.panelDescription.PerformLayout();
            this.flowLayoutPanelSystemRequirment.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panelPurchase;
        private System.Windows.Forms.Button buttonAddToWishlist;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelReleaseDate;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label labelDeveloper;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSystemRequirment;
        private System.Windows.Forms.Label labelSystemRequirments;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDescriptionTitle;
    }
}

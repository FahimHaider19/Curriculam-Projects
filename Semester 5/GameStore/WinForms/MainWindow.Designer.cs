
namespace GameStore
{
    partial class MainWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonStore = new System.Windows.Forms.Button();
            this.panelStoreDropdown = new System.Windows.Forms.Panel();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonWishlist = new System.Windows.Forms.Button();
            this.buttonCart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelStoreDropdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panelStoreDropdown);
            this.panel1.Controls.Add(this.buttonStore);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 681);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(0, 617);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(253, 64);
            this.button7.TabIndex = 4;
            this.button7.Text = "Sign Out";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(334, 467);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(247, 64);
            this.button6.TabIndex = 3;
            this.button6.Text = "Settings";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 100);
            this.panel2.TabIndex = 5;
            // 
            // buttonStore
            // 
            this.buttonStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStore.FlatAppearance.BorderSize = 0;
            this.buttonStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStore.Location = new System.Drawing.Point(0, 100);
            this.buttonStore.Name = "buttonStore";
            this.buttonStore.Size = new System.Drawing.Size(253, 64);
            this.buttonStore.TabIndex = 0;
            this.buttonStore.Text = "Store";
            this.buttonStore.UseVisualStyleBackColor = true;
            this.buttonStore.Click += new System.EventHandler(this.store_Click);
            // 
            // panelStoreDropdown
            // 
            this.panelStoreDropdown.Controls.Add(this.buttonCart);
            this.panelStoreDropdown.Controls.Add(this.buttonWishlist);
            this.panelStoreDropdown.Controls.Add(this.buttonBrowse);
            this.panelStoreDropdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStoreDropdown.Location = new System.Drawing.Point(0, 164);
            this.panelStoreDropdown.Name = "panelStoreDropdown";
            this.panelStoreDropdown.Size = new System.Drawing.Size(253, 201);
            this.panelStoreDropdown.TabIndex = 6;
            this.panelStoreDropdown.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStoreDropdown_Paint);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBrowse.FlatAppearance.BorderSize = 0;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBrowse.Location = new System.Drawing.Point(0, 0);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(253, 64);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            // 
            // buttonWishlist
            // 
            this.buttonWishlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonWishlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonWishlist.FlatAppearance.BorderSize = 0;
            this.buttonWishlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWishlist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonWishlist.Location = new System.Drawing.Point(0, 64);
            this.buttonWishlist.Name = "buttonWishlist";
            this.buttonWishlist.Size = new System.Drawing.Size(253, 64);
            this.buttonWishlist.TabIndex = 2;
            this.buttonWishlist.Text = "Wishlist";
            this.buttonWishlist.UseVisualStyleBackColor = true;
            // 
            // buttonCart
            // 
            this.buttonCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCart.FlatAppearance.BorderSize = 0;
            this.buttonCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCart.Location = new System.Drawing.Point(0, 128);
            this.buttonCart.Name = "buttonCart";
            this.buttonCart.Size = new System.Drawing.Size(253, 64);
            this.buttonCart.TabIndex = 3;
            this.buttonCart.Text = "Cart";
            this.buttonCart.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 64);
            this.button1.TabIndex = 7;
            this.button1.Text = "Library";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(0, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 64);
            this.button2.TabIndex = 8;
            this.button2.Text = "Store";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button6);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.panel1.ResumeLayout(false);
            this.panelStoreDropdown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonStore;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelStoreDropdown;
        private System.Windows.Forms.Button buttonCart;
        private System.Windows.Forms.Button buttonWishlist;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
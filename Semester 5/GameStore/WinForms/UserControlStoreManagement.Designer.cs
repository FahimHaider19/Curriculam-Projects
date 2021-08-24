namespace GameStore.WinForms
{
    partial class UserControlStoreManagement
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
            this.panelManageGames = new System.Windows.Forms.Panel();
            this.labelManageGames = new System.Windows.Forms.Label();
            this.buttonSaveGames = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxOnSale = new System.Windows.Forms.TextBox();
            this.textBoxTrending = new System.Windows.Forms.TextBox();
            this.textBoxDiscountRate = new System.Windows.Forms.TextBox();
            this.textBoxFeatured = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelOnSale = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDiscountRate = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.cProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cProductType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDiscountRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cFeatured = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTrending = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cOnSale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPublished = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelManageTopNews = new System.Windows.Forms.Panel();
            this.comboBoxSelectNews1 = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectNews4 = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectGame1 = new System.Windows.Forms.ComboBox();
            this.buttonSaveTopNews = new System.Windows.Forms.Button();
            this.comboBoxSelectNews3 = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectGame4 = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectNews2 = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectGame3 = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectGame2 = new System.Windows.Forms.ComboBox();
            this.labelTopNews4 = new System.Windows.Forms.Label();
            this.labelTopNews3 = new System.Windows.Forms.Label();
            this.labelTopNews2 = new System.Windows.Forms.Label();
            this.labelTopNews1 = new System.Windows.Forms.Label();
            this.labelManageTopNews = new System.Windows.Forms.Label();
            this.panelManageGames.SuspendLayout();
            this.panelManageTopNews.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelManageGames
            // 
            this.panelManageGames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelManageGames.Controls.Add(this.labelManageGames);
            this.panelManageGames.Controls.Add(this.buttonSaveGames);
            this.panelManageGames.Controls.Add(this.textBox1);
            this.panelManageGames.Controls.Add(this.textBoxOnSale);
            this.panelManageGames.Controls.Add(this.textBoxTrending);
            this.panelManageGames.Controls.Add(this.textBoxDiscountRate);
            this.panelManageGames.Controls.Add(this.textBoxFeatured);
            this.panelManageGames.Controls.Add(this.label3);
            this.panelManageGames.Controls.Add(this.labelOnSale);
            this.panelManageGames.Controls.Add(this.label2);
            this.panelManageGames.Controls.Add(this.label1);
            this.panelManageGames.Controls.Add(this.labelDiscountRate);
            this.panelManageGames.Controls.Add(this.listView);
            this.panelManageGames.Location = new System.Drawing.Point(3, 3);
            this.panelManageGames.Name = "panelManageGames";
            this.panelManageGames.Size = new System.Drawing.Size(1100, 336);
            this.panelManageGames.TabIndex = 0;
            // 
            // labelManageGames
            // 
            this.labelManageGames.AutoSize = true;
            this.labelManageGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageGames.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelManageGames.Location = new System.Drawing.Point(18, 15);
            this.labelManageGames.Name = "labelManageGames";
            this.labelManageGames.Size = new System.Drawing.Size(183, 29);
            this.labelManageGames.TabIndex = 5;
            this.labelManageGames.Text = "Manage Games";
            // 
            // buttonSaveGames
            // 
            this.buttonSaveGames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveGames.Location = new System.Drawing.Point(809, 256);
            this.buttonSaveGames.Name = "buttonSaveGames";
            this.buttonSaveGames.Size = new System.Drawing.Size(195, 50);
            this.buttonSaveGames.TabIndex = 3;
            this.buttonSaveGames.Text = "Save";
            this.buttonSaveGames.UseVisualStyleBackColor = true;
            this.buttonSaveGames.Click += new System.EventHandler(this.buttonSaveGames_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(868, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 24);
            this.textBox1.TabIndex = 2;
            // 
            // textBoxOnSale
            // 
            this.textBoxOnSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOnSale.Location = new System.Drawing.Point(867, 175);
            this.textBoxOnSale.Name = "textBoxOnSale";
            this.textBoxOnSale.Size = new System.Drawing.Size(135, 24);
            this.textBoxOnSale.TabIndex = 2;
            // 
            // textBoxTrending
            // 
            this.textBoxTrending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTrending.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrending.Location = new System.Drawing.Point(867, 135);
            this.textBoxTrending.Name = "textBoxTrending";
            this.textBoxTrending.Size = new System.Drawing.Size(135, 24);
            this.textBoxTrending.TabIndex = 2;
            // 
            // textBoxDiscountRate
            // 
            this.textBoxDiscountRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDiscountRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscountRate.Location = new System.Drawing.Point(901, 59);
            this.textBoxDiscountRate.Name = "textBoxDiscountRate";
            this.textBoxDiscountRate.Size = new System.Drawing.Size(101, 24);
            this.textBoxDiscountRate.TabIndex = 2;
            // 
            // textBoxFeatured
            // 
            this.textBoxFeatured.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFeatured.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFeatured.Location = new System.Drawing.Point(867, 98);
            this.textBoxFeatured.Name = "textBoxFeatured";
            this.textBoxFeatured.Size = new System.Drawing.Size(135, 24);
            this.textBoxFeatured.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(782, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Published :";
            // 
            // labelOnSale
            // 
            this.labelOnSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOnSale.AutoSize = true;
            this.labelOnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOnSale.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelOnSale.Location = new System.Drawing.Point(791, 178);
            this.labelOnSale.Name = "labelOnSale";
            this.labelOnSale.Size = new System.Drawing.Size(69, 18);
            this.labelOnSale.TabIndex = 1;
            this.labelOnSale.Text = "On Sale :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(788, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trending :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(787, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Featured :";
            // 
            // labelDiscountRate
            // 
            this.labelDiscountRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDiscountRate.AutoSize = true;
            this.labelDiscountRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscountRate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDiscountRate.Location = new System.Drawing.Point(787, 59);
            this.labelDiscountRate.Name = "labelDiscountRate";
            this.labelDiscountRate.Size = new System.Drawing.Size(110, 18);
            this.labelDiscountRate.TabIndex = 1;
            this.labelDiscountRate.Text = "Discount Rate :";
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cProductId,
            this.cProductName,
            this.cProductType,
            this.cPrice,
            this.cDiscountRate,
            this.cFeatured,
            this.cTrending,
            this.cOnSale,
            this.cPublished});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(23, 56);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(743, 249);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Listview_Click);
            // 
            // cProductId
            // 
            this.cProductId.Text = "ProductId";
            this.cProductId.Width = 66;
            // 
            // cProductName
            // 
            this.cProductName.Text = "Name";
            this.cProductName.Width = 255;
            // 
            // cProductType
            // 
            this.cProductType.Text = "Type";
            this.cProductType.Width = 45;
            // 
            // cPrice
            // 
            this.cPrice.Text = "Price";
            this.cPrice.Width = 47;
            // 
            // cDiscountRate
            // 
            this.cDiscountRate.Text = "DiscountRate";
            this.cDiscountRate.Width = 84;
            // 
            // cFeatured
            // 
            this.cFeatured.Text = "Featured";
            this.cFeatured.Width = 62;
            // 
            // cTrending
            // 
            this.cTrending.Text = "Trending";
            this.cTrending.Width = 61;
            // 
            // cOnSale
            // 
            this.cOnSale.Text = "OnSale";
            this.cOnSale.Width = 58;
            // 
            // cPublished
            // 
            this.cPublished.Text = "Published";
            // 
            // panelManageTopNews
            // 
            this.panelManageTopNews.Controls.Add(this.comboBoxSelectNews1);
            this.panelManageTopNews.Controls.Add(this.comboBoxSelectNews4);
            this.panelManageTopNews.Controls.Add(this.comboBoxSelectGame1);
            this.panelManageTopNews.Controls.Add(this.buttonSaveTopNews);
            this.panelManageTopNews.Controls.Add(this.comboBoxSelectNews3);
            this.panelManageTopNews.Controls.Add(this.comboBoxSelectGame4);
            this.panelManageTopNews.Controls.Add(this.comboBoxSelectNews2);
            this.panelManageTopNews.Controls.Add(this.comboBoxSelectGame3);
            this.panelManageTopNews.Controls.Add(this.comboBoxSelectGame2);
            this.panelManageTopNews.Controls.Add(this.labelTopNews4);
            this.panelManageTopNews.Controls.Add(this.labelTopNews3);
            this.panelManageTopNews.Controls.Add(this.labelTopNews2);
            this.panelManageTopNews.Controls.Add(this.labelTopNews1);
            this.panelManageTopNews.Controls.Add(this.labelManageTopNews);
            this.panelManageTopNews.Location = new System.Drawing.Point(3, 359);
            this.panelManageTopNews.Name = "panelManageTopNews";
            this.panelManageTopNews.Size = new System.Drawing.Size(1100, 279);
            this.panelManageTopNews.TabIndex = 1;
            // 
            // comboBoxSelectNews1
            // 
            this.comboBoxSelectNews1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectNews1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBoxSelectNews1.FormattingEnabled = true;
            this.comboBoxSelectNews1.Location = new System.Drawing.Point(292, 50);
            this.comboBoxSelectNews1.Name = "comboBoxSelectNews1";
            this.comboBoxSelectNews1.Size = new System.Drawing.Size(773, 26);
            this.comboBoxSelectNews1.TabIndex = 9;
            // 
            // comboBoxSelectNews4
            // 
            this.comboBoxSelectNews4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectNews4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBoxSelectNews4.FormattingEnabled = true;
            this.comboBoxSelectNews4.Location = new System.Drawing.Point(292, 174);
            this.comboBoxSelectNews4.Name = "comboBoxSelectNews4";
            this.comboBoxSelectNews4.Size = new System.Drawing.Size(773, 26);
            this.comboBoxSelectNews4.TabIndex = 9;
            // 
            // comboBoxSelectGame1
            // 
            this.comboBoxSelectGame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectGame1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBoxSelectGame1.FormattingEnabled = true;
            this.comboBoxSelectGame1.Location = new System.Drawing.Point(46, 50);
            this.comboBoxSelectGame1.Name = "comboBoxSelectGame1";
            this.comboBoxSelectGame1.Size = new System.Drawing.Size(231, 26);
            this.comboBoxSelectGame1.TabIndex = 9;
            this.comboBoxSelectGame1.SelectedIndexChanged += new System.EventHandler(this.SelectedGameChanged1);
            // 
            // buttonSaveTopNews
            // 
            this.buttonSaveTopNews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveTopNews.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveTopNews.Location = new System.Drawing.Point(872, 215);
            this.buttonSaveTopNews.Name = "buttonSaveTopNews";
            this.buttonSaveTopNews.Size = new System.Drawing.Size(195, 50);
            this.buttonSaveTopNews.TabIndex = 3;
            this.buttonSaveTopNews.Text = "Save";
            this.buttonSaveTopNews.UseVisualStyleBackColor = true;
            this.buttonSaveTopNews.Click += new System.EventHandler(this.buttonSaveTopNews_Click);
            // 
            // comboBoxSelectNews3
            // 
            this.comboBoxSelectNews3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectNews3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBoxSelectNews3.FormattingEnabled = true;
            this.comboBoxSelectNews3.Location = new System.Drawing.Point(292, 131);
            this.comboBoxSelectNews3.Name = "comboBoxSelectNews3";
            this.comboBoxSelectNews3.Size = new System.Drawing.Size(773, 26);
            this.comboBoxSelectNews3.TabIndex = 9;
            // 
            // comboBoxSelectGame4
            // 
            this.comboBoxSelectGame4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectGame4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBoxSelectGame4.FormattingEnabled = true;
            this.comboBoxSelectGame4.Location = new System.Drawing.Point(46, 174);
            this.comboBoxSelectGame4.Name = "comboBoxSelectGame4";
            this.comboBoxSelectGame4.Size = new System.Drawing.Size(231, 26);
            this.comboBoxSelectGame4.TabIndex = 9;
            this.comboBoxSelectGame4.SelectedIndexChanged += new System.EventHandler(this.SelectedGameChanged4);
            // 
            // comboBoxSelectNews2
            // 
            this.comboBoxSelectNews2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectNews2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBoxSelectNews2.FormattingEnabled = true;
            this.comboBoxSelectNews2.Location = new System.Drawing.Point(292, 89);
            this.comboBoxSelectNews2.Name = "comboBoxSelectNews2";
            this.comboBoxSelectNews2.Size = new System.Drawing.Size(773, 26);
            this.comboBoxSelectNews2.TabIndex = 9;
            // 
            // comboBoxSelectGame3
            // 
            this.comboBoxSelectGame3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectGame3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBoxSelectGame3.FormattingEnabled = true;
            this.comboBoxSelectGame3.Location = new System.Drawing.Point(46, 131);
            this.comboBoxSelectGame3.Name = "comboBoxSelectGame3";
            this.comboBoxSelectGame3.Size = new System.Drawing.Size(231, 26);
            this.comboBoxSelectGame3.TabIndex = 9;
            this.comboBoxSelectGame3.SelectedIndexChanged += new System.EventHandler(this.SelectedGameChanged3);
            // 
            // comboBoxSelectGame2
            // 
            this.comboBoxSelectGame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectGame2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBoxSelectGame2.FormattingEnabled = true;
            this.comboBoxSelectGame2.Location = new System.Drawing.Point(46, 89);
            this.comboBoxSelectGame2.Name = "comboBoxSelectGame2";
            this.comboBoxSelectGame2.Size = new System.Drawing.Size(231, 26);
            this.comboBoxSelectGame2.TabIndex = 9;
            this.comboBoxSelectGame2.SelectedIndexChanged += new System.EventHandler(this.SelectedGameChanged2);
            // 
            // labelTopNews4
            // 
            this.labelTopNews4.AutoSize = true;
            this.labelTopNews4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopNews4.Location = new System.Drawing.Point(20, 177);
            this.labelTopNews4.Name = "labelTopNews4";
            this.labelTopNews4.Size = new System.Drawing.Size(20, 18);
            this.labelTopNews4.TabIndex = 8;
            this.labelTopNews4.Text = "4.";
            // 
            // labelTopNews3
            // 
            this.labelTopNews3.AutoSize = true;
            this.labelTopNews3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopNews3.Location = new System.Drawing.Point(20, 134);
            this.labelTopNews3.Name = "labelTopNews3";
            this.labelTopNews3.Size = new System.Drawing.Size(20, 18);
            this.labelTopNews3.TabIndex = 8;
            this.labelTopNews3.Text = "3.";
            // 
            // labelTopNews2
            // 
            this.labelTopNews2.AutoSize = true;
            this.labelTopNews2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopNews2.Location = new System.Drawing.Point(20, 92);
            this.labelTopNews2.Name = "labelTopNews2";
            this.labelTopNews2.Size = new System.Drawing.Size(20, 18);
            this.labelTopNews2.TabIndex = 8;
            this.labelTopNews2.Text = "2.";
            // 
            // labelTopNews1
            // 
            this.labelTopNews1.AutoSize = true;
            this.labelTopNews1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopNews1.Location = new System.Drawing.Point(20, 50);
            this.labelTopNews1.Name = "labelTopNews1";
            this.labelTopNews1.Size = new System.Drawing.Size(20, 18);
            this.labelTopNews1.TabIndex = 8;
            this.labelTopNews1.Text = "1.";
            // 
            // labelManageTopNews
            // 
            this.labelManageTopNews.AutoSize = true;
            this.labelManageTopNews.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageTopNews.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelManageTopNews.Location = new System.Drawing.Point(18, 9);
            this.labelManageTopNews.Name = "labelManageTopNews";
            this.labelManageTopNews.Size = new System.Drawing.Size(218, 29);
            this.labelManageTopNews.TabIndex = 7;
            this.labelManageTopNews.Text = "Manage Top News";
            // 
            // UserControlStoreManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelManageTopNews);
            this.Controls.Add(this.panelManageGames);
            this.Name = "UserControlStoreManagement";
            this.Size = new System.Drawing.Size(1109, 656);
            this.panelManageGames.ResumeLayout(false);
            this.panelManageGames.PerformLayout();
            this.panelManageTopNews.ResumeLayout(false);
            this.panelManageTopNews.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelManageGames;
        private System.Windows.Forms.Label labelManageGames;
        private System.Windows.Forms.Button buttonSaveGames;
        private System.Windows.Forms.TextBox textBoxFeatured;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDiscountRate;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader cProductId;
        private System.Windows.Forms.ColumnHeader cProductName;
        private System.Windows.Forms.ColumnHeader cProductType;
        private System.Windows.Forms.ColumnHeader cPrice;
        private System.Windows.Forms.ColumnHeader cDiscountRate;
        private System.Windows.Forms.ColumnHeader cFeatured;
        private System.Windows.Forms.ColumnHeader cTrending;
        private System.Windows.Forms.ColumnHeader cOnSale;
        private System.Windows.Forms.Panel panelManageTopNews;
        private System.Windows.Forms.Label labelManageTopNews;
        private System.Windows.Forms.ComboBox comboBoxSelectNews1;
        private System.Windows.Forms.ComboBox comboBoxSelectNews4;
        private System.Windows.Forms.ComboBox comboBoxSelectGame1;
        private System.Windows.Forms.Button buttonSaveTopNews;
        private System.Windows.Forms.ComboBox comboBoxSelectNews3;
        private System.Windows.Forms.ComboBox comboBoxSelectGame4;
        private System.Windows.Forms.ComboBox comboBoxSelectNews2;
        private System.Windows.Forms.ComboBox comboBoxSelectGame3;
        private System.Windows.Forms.ComboBox comboBoxSelectGame2;
        private System.Windows.Forms.Label labelTopNews4;
        private System.Windows.Forms.Label labelTopNews3;
        private System.Windows.Forms.Label labelTopNews2;
        private System.Windows.Forms.Label labelTopNews1;
        private System.Windows.Forms.Label labelOnSale;
        private System.Windows.Forms.TextBox textBoxOnSale;
        private System.Windows.Forms.TextBox textBoxTrending;
        private System.Windows.Forms.TextBox textBoxDiscountRate;
        private System.Windows.Forms.ColumnHeader cPublished;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameStore.Classes;

namespace GameStore.WinForms
{
    public partial class UserControlWishlist : UserControl
    {
        Product product;
        List<Product> list;
        public UserControlWishlist()
        {
            InitializeComponent();
        }
        public UserControlWishlist(Product product)
        {
            this.product = product;
            InitializeComponent();
            labelTitle.Text = product.Name;
            labelGenre.Text = "Gener : ";
            foreach (string s in product.Genre)
            {
                if (s != product.Genre[0])
                    labelGenre.Text += ", ";
                labelGenre.Text += s;
            }
            labelPublisher.Text = "Publisher : " + product.Publisher;
            labelPrice.Text = product.Price.ToString() + "$";
            labelReleaseDate.Text = "Release Date : " + product.ReleaseDate.ToString();
        }
        public UserControlWishlist(Product product, List<Product> list)
        {
            //if (itemType == "wishlist") this.wishlist = list;
            //if (itemType == "cart") this.cart = list;
            this.list = list;
            this.product = product;
            InitializeComponent();
            labelTitle.Text = product.Name;
            labelGenre.Text = "Gener : ";
            foreach (string s in product.Genre)
            {
                if (s != product.Genre[0])
                    labelGenre.Text += ", ";
                labelGenre.Text += s;
            }
            labelPublisher.Text = "Publisher : " + product.Publisher;
            labelPrice.Text = product.Price.ToString() + "$";
            labelReleaseDate.Text = "Release Date : " + product.ReleaseDate.ToString();
        }
        public Label LabelTitle
        {
            set { this.labelTitle = value; }
            get { return labelTitle; }
        }
        public Label LabelGenre
        {
            set { this.labelGenre = value; }
            get { return labelGenre; }
        }
        public Label LabelPublisher
        {
            set { this.labelPublisher = value; }
            get { return labelPublisher; }
        }
        public Label LabelPrice
        {
            set { this.labelPrice = value; }
            get { return labelPrice; }
        }
        public Label LabelReleaseDate
        {
            set { this.labelReleaseDate = value; }
            get { return labelReleaseDate; }
        }
/*        public TextBox TextBoxPriority
        {
            set { this.textBoxPriority = value; }
            get { return textBoxPriority; }
        }*/
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            list.Remove(product);
        }
    }
}

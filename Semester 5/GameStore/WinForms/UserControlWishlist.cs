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
        public UserControlWishlist()
        {
            InitializeComponent();
        }
        public UserControlWishlist(Game game, string priority)
        {
            InitializeComponent();
            labelTitle.Text = game.Name;
            labelGenre.Text = "";
            foreach (string s in game.Genre)
            {
                if (s != game.Genre[0])
                    labelGenre.Text += ", ";
                labelGenre.Text += s;
            }
            labelPublisher.Text = game.Publisher;
            labelPrice.Text = game.Price + "$";
            labelReleaseDate.Text = game.ReleaseDate;
            textBoxPriority.Text = priority;

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
        public TextBox TextBoxPriority
        {
            set { this.textBoxPriority = value; }
            get { return textBoxPriority; }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

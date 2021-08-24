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
    public partial class UserControlGamePage : UserControl
    {
        Store store;
        Game game;
        /*public UserControlGamePage()
        {
            InitializeComponent();
        }*/
        public UserControlGamePage(Store store, Game game)
        {
            this.game = game;
            this.store = store;
            InitializeComponent();
            //this.pictureBox.Image = Image.FromFile(store.ProjectDirectory + @"\Resources\" + game.ImageCover);
            this.labelTitle.Text = game.Name;
            this.labelSystemRequirments.Text = game.SystemRequirements;
            this.labelDeveloper.Text = "Developer : "+game.Developer;
            this.labelPublisher.Text = "Publisher : " + game.Publisher;
            this.labelPrice.Text = "Price : "+game.Price.ToString() + "$";
            this.labelDescription.Text = game.Description;
            this.LabelReleaseDate.Text = game.ReleaseDate;

            /*foreach (Review r in game.Reviews)
            {
                UserControlReview rev = new UserControlReview(r);
                //panelreviews.Controls.Add(rev);
                rev.Dock = DockStyle.Top;
            }*/
                
        }
        public PictureBox PictureBox
        {
            set { this.pictureBox = value; }
            get { return pictureBox; }
        }
        public Label LabelTitle
        {
            set { this.labelTitle = value; }
            get { return labelTitle; }
        }
        public Label LabelGenre
        {
            set { this.LabelGenre = value; }
            get { return labelGenre; }
        }
        public Label LabelPublisher
        {
            set { this.labelPublisher = value; }
            get { return labelPublisher; }
        }
        public Label LabelDeveloper
        {
            set { this.labelDeveloper = value; }
            get { return labelDeveloper; }
        }
        public Label LabelReleaseDate
        {
            set { this.LabelReleaseDate = value; }
            get { return labelReleaseDate; }
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if (store!= null && store.LoggedInUser.GetType().Name == "Gamer")
                ((Gamer)store.LoggedInUser).Cart.Add(game);
        }

        private void buttonAddToWishlist_Click(object sender, EventArgs e)
        {
            if (store != null && store.LoggedInUser.GetType().Name == "Gamer")
                ((Gamer)store.LoggedInUser).Wishlist.Add(game);
        }
    }
}

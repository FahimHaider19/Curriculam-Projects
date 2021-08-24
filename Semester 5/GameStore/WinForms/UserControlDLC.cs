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
using GameStore.WinForms;

namespace GameStore.WinForms
{
    public partial class UserControlDLC : UserControl
    {
        Store store;
        Dlc dlc;
        public UserControlDLC()
        {
            InitializeComponent();
        }
        public UserControlDLC(Store store, Dlc dlc)
        {
            this.store = store;
            this.dlc = dlc;
            InitializeComponent();
            this.labelTitle.Text = dlc.Name;
            this.labelPrice.Text = dlc.Price.ToString() + "$";
            this.labelReleaseDate.Text = dlc.ReleaseDate;
            this.labelPublisher.Text = dlc.Publisher;
            this.pictureBox.Image = Image.FromFile(store.ProjectDirectory + @"\Resources\" + dlc.ImageCover);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool added = false;
            List<Product> cart = ((Gamer)store.LoggedInUser).Cart;
            foreach (Product p in cart)
            {
                if (p == this.dlc)
                {
                    added = true;
                    break;
                }
            }
            if(added==false)
                cart.Add(dlc);
        }
    }
}

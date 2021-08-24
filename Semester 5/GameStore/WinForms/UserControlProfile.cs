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
    public partial class UserControlProfile : UserControl
    {
        Store store;
        public UserControlProfile()
        {
            InitializeComponent();
        }
        public UserControlProfile(Store store)
        {
            this.store = store;
            InitializeComponent();
            Reload();            
        }

        public void Reload()
        {
            labelUsernameTop.Text = store.LoggedInUser.UserName;
            textBoxUsername.Text = store.LoggedInUser.UserName;
            textBoxEmail.Text = store.LoggedInUser.Email;
            textBoxPhone.Text = store.LoggedInUser.Phone;
            labelCountryTop.Text = store.LoggedInUser.Country;
            //pictureBox
            if (store.LoggedInUser.GetType().Name == "Gamer")
            {
                
                textBoxFirstName.Text = ((Gamer)store.LoggedInUser).FirstName;
                textBoxLastName.Text = ((Gamer)store.LoggedInUser).LastName;
                labelNameTop.Text = ((Gamer)store.LoggedInUser).FirstName + " " + ((Gamer)store.LoggedInUser).LastName;
                textBoxSex.Text = ((Gamer)store.LoggedInUser).Sex;
                textBoxAddress.Text = ((Gamer)store.LoggedInUser).Address;
                labelGamesOwnedValue.Text = ((Gamer)store.LoggedInUser).PurchasedGames.Count.ToString();
                int dlcCount = 0;
                foreach (Game g in ((Gamer)store.LoggedInUser).PurchasedGames)
                    foreach (Dlc d in g.Dlcs)
                        dlcCount++;
                labelDlcOwnedValue.Text = dlcCount.ToString();
                labelWishlitedValue.Text = ((Gamer)store.LoggedInUser).Wishlist.Count.ToString();
            }
            else if (store.LoggedInUser.GetType().Name == "Admin")
            {
                textBoxFirstName.Text = ((Admin)store.LoggedInUser).FirstName;
                textBoxLastName.Text = ((Admin)store.LoggedInUser).LastName;
                labelNameTop.Text = ((Admin)store.LoggedInUser).FirstName + " " + ((Admin)store.LoggedInUser).LastName;
                textBoxSex.Text = ((Admin)store.LoggedInUser).Sex;
                textBoxAddress.Text = ((Admin)store.LoggedInUser).Address;
                tableLayoutPanel1.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            if(buttonEditProfile.Text == "Edit Profile")
            {
                textBoxUsername.Enabled = true;
                textBoxFirstName.Enabled = true;
                textBoxLastName.Enabled = true;
                textBoxEmail.Enabled = true;
                textBoxPhone.Enabled = true;
                textBoxSex.Enabled = true;
                textBoxAddress.Enabled = true;
                buttonEditProfile.Text = "Save";
            }
            else if(buttonEditProfile.Text == "Save")
            {
                textBoxUsername.Enabled = false;
                textBoxFirstName.Enabled = false;
                textBoxLastName.Enabled = false;
                textBoxEmail.Enabled = false;
                textBoxPhone.Enabled = false;
                textBoxSex.Enabled = false;
                textBoxAddress.Enabled = false;

                string sql = "UPDATE Users SET username='" + textBoxUsername.Text + "', first_name='" + textBoxFirstName.Text + "', last_name='" + textBoxLastName.Text + "', email='" + textBoxEmail.Text + "', phone='" + textBoxPhone.Text + "', sex='" + textBoxSex.Text + "', address='" + textBoxAddress.Text + "' where userID ='" + store.LoggedInUser.UserId + "' ";
                int result = store.Uda.ExecuteQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show("Update Saved");

                    store.LoggedInUser.UserName = textBoxUsername.Text;
                    store.LoggedInUser.Email = textBoxEmail.Text;
                    store.LoggedInUser.Phone = textBoxPhone.Text;
                    store.LoggedInUser.Country = labelCountryTop.Text;
                    //pictureBox
                    if (store.LoggedInUser.GetType().Name == "Gamer")
                    {
                        ((Gamer)store.LoggedInUser).FirstName = textBoxFirstName.Text;
                        ((Gamer)store.LoggedInUser).LastName = textBoxLastName.Text;
                        ((Gamer)store.LoggedInUser).Sex = textBoxSex.Text;
                        ((Gamer)store.LoggedInUser).Address = textBoxAddress.Text;
                    }
                    else if (store.LoggedInUser.GetType().Name == "Admin")
                    {
                        ((Admin)store.LoggedInUser).FirstName = textBoxFirstName.Text;
                        ((Admin)store.LoggedInUser).LastName = textBoxLastName.Text;
                        ((Admin)store.LoggedInUser).Sex = textBoxSex.Text;
                        ((Admin)store.LoggedInUser).Address = textBoxAddress.Text;
                    }
                }

                buttonEditProfile.Text = "Edit Profile";
            }
        }
    }
}

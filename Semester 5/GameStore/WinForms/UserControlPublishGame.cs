using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameStore.Classes;

namespace GameStore
{
    public partial class UserControlPublishGame : UserControl
    {
        Store store;
        string coverImageMoveFrom;
        string boxImageMoveFrom;
        string coverImage;
        string boxImage; 
        public UserControlPublishGame()
        {
            InitializeComponent();
        }
        public UserControlPublishGame(Store store)
        {
            this.store = store;
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonPublishgame_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "" && textBoxSystemRequirement.Text == "" && textBoxPrice.Text == "" && textBoxDescription.Text == "" && textBoxType.Text == "")
            {
                MessageBox.Show("You have to enter data's");
            }

            else if (textBoxTitle.Text == "")
            {
                MessageBox.Show("title cant be empty");
            }
            else if (textBoxSystemRequirement.Text == "")
            {
                MessageBox.Show("system requirements cant be empty");
            }
            else if (textBoxPrice.Text == "")
            {
                MessageBox.Show("price can't be empty");
            }
            else if (textBoxDescription.Text == "")
            {
                MessageBox.Show("description can't be empty");
            }
            else if (textBoxType.Text == "")
            {
                MessageBox.Show("producttype can't be empty");
            }
            else
            {
                boxImage = textBoxTitle.Text + "_box.jpg";
                coverImage = textBoxTitle.Text + "_cover.jpg";
                string sql = "insert into Products (name,price,description,productType,systemRequirments, imageCover, imageBox, published) values ('" + textBoxTitle.Text + "','" + textBoxPrice.Text + "','" + textBoxDescription.Text + "','" + textBoxType.Text + "','" + textBoxSystemRequirement.Text + "', '"+coverImage+"', '"+boxImage+"', '"+false+"')";
                int result = store.Uda.ExecuteQuery(sql);
                if (result > 0)
                {
                    /*if (File.Exists(store.ProjectDirectory + @"\DatabaseResources\" + boxImage))
                        File.Delete(store.ProjectDirectory + @"\DatabaseResources\" + boxImage);
                    File.Move(boxImageMoveFrom, store.ProjectDirectory+ @"\DatabaseResources\"+boxImage);

                    if (File.Exists(store.ProjectDirectory + @"\DatabaseResources\" + coverImage))
                        File.Delete(store.ProjectDirectory + @"\DatabaseResources\" + coverImage);
                    File.Move(boxImageMoveFrom, store.ProjectDirectory + @"\DatabaseResources\" + coverImage);

                    MessageBox.Show("Sucessfully requested ,wait for admin to approve");*/
                }
                else
                {
                    MessageBox.Show("error in requesting");
                }
            }
        }

        private void labelPrice_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelectCoverImage_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog fileDialogueBox = new OpenFileDialog();
            if (fileDialogueBox.ShowDialog() == DialogResult.OK)
            {
                this.coverImageMoveFrom = fileDialogueBox.FileName;
                textBoxImageCover.Text = coverImageMoveFrom;
            }*/
        }

        private void buttonSelectBoxImage_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog fileDialogueBox = new OpenFileDialog();
            if (fileDialogueBox.ShowDialog() == DialogResult.OK)
            {
                this.boxImageMoveFrom = fileDialogueBox.FileName;
                textBoxImageCover.Text = boxImageMoveFrom;
            }*/
        }
    }
}

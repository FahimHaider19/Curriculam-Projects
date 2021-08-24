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
using System.Data.SqlClient;
using System.Configuration;
using GameStore.DataAccess;


namespace GameStore
{
    public partial class UserControlgameManageMentcs : UserControl
    {
        Store store;
        string coverImageMoveFrom;
        string boxImageMoveFrom;
        string coverImage;
        string boxImage;

        public UserControlgameManageMentcs()
        {
            InitializeComponent();
        }

        public UserControlgameManageMentcs(Store store)
        {
            this.store = store;
            InitializeComponent();
            foreach (Game game in store.Games)
            {
                comboBoxGamemagement.Items.Add(game.Name);

            }
        }

        private void panelgameManagements_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxGamemagement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSelectmageBox_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog fileDialogueBox = new OpenFileDialog();
            if (fileDialogueBox.ShowDialog() == DialogResult.OK)
            {
                this.boxImageMoveFrom = fileDialogueBox.FileName;
                this.boxImage = fileDialogueBox.SafeFileName;
                textBoxImageBox.Text = boxImageMoveFrom;
            }*/
        }

        private void buttonSelectImageCover_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog fileDialogueBox = new OpenFileDialog();
            if (fileDialogueBox.ShowDialog() == DialogResult.OK)
            {
                this.coverImageMoveFrom = fileDialogueBox.FileName;
                this.coverImage = fileDialogueBox.SafeFileName;
                textBoxImageCover.Text = coverImageMoveFrom;
            }*/
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            string sql = "Update Products set name='" + textBoxTitle.Text + "',price='" + textBoxPrice.Text + "',systemRequirments='" + textBoxSystemRequirement.Text + "',description='" + textBoxDescription.Text + "', imageBox='" + this.boxImage + "', imageCover='" + this.coverImage + "' where name='" + comboBoxGamemagement.Text + "'";
            int result = store.Uda.ExecuteQuery(sql);
            if (result > 0)
            {
                Game g = store.getGame(comboBoxGamemagement.Text);
                g.Name = textBoxTitle.Text;
                g.Price = Double.Parse(textBoxPrice.Text);
                g.SystemRequirements = textBoxSystemRequirement.Text;
                g.Description = textBoxDescription.Text;
                MessageBox.Show("sucessfully updated");

            }
            else
            {
                MessageBox.Show("ERROR!!Can't update ");
            }
        }
    }
}

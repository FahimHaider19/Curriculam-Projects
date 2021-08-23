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

namespace GameStore
{
    public partial class FormDeveloper : Form
    {
        Store store;
        public FormDeveloper()
        {
            InitializeComponent();
        }
        public FormDeveloper(Store store)
        {
            this.store = store;
            InitializeComponent();
        }

        private void FormDeveloper_Load(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {

        }

        private void buttonNews_Click(object sender, EventArgs e)
        {

        }

        private void buttonDashBoard_Click(object sender, EventArgs e)
        {

        }

        private void buttonMyProfile_Click(object sender, EventArgs e)
        {

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {

        }

        private void buttonGameManagement_Click(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            UserControlgameManageMentcs game = new UserControlgameManageMentcs(store);
            panelCenter.Controls.Add(game);
            game.Dock = DockStyle.Fill;

        }

        

        private void buttonPublishGames_Click(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            UserControlPublishGame pubcgames = new UserControlPublishGame(store);
            panelCenter.Controls.Add(pubcgames);
            pubcgames.Dock = DockStyle.Fill;
        }

        private void buttonPublishNews_Click(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            UserControlPublishNews publishnew = new UserControlPublishNews(store);
            panelCenter.Controls.Add(publishnew);
            publishnew.Dock = DockStyle.Fill;
        }
    }
}

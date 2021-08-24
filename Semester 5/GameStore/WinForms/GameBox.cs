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

namespace GameStore
{
    public partial class GameBox : UserControl
    {
        Game game;
        Panel panel;
        Store store;
        public GameBox()
        {
            InitializeComponent();
        }
        public GameBox(Game game, Panel panel, Store store)
        {
            this.game = game;
            this.panel = panel;
            this.store = store;
            InitializeComponent();
            pictureBox.Image = Image.FromFile(store.ProjectDirectory + @"\Resources\" + game.ImageBox);
            labelGameboxGameName.Text = game.Name;
            labelpriceTag.Text = game.Price + "$";
        }
        public Game Game
        {
            set { this.game = value; }
            get { return game; }
        }
        public PictureBox PictureBox
        {
            set { this.pictureBox = value; }
            get { return pictureBox; }
        }
        public Label LabelGameboxGameName
        {
            get { return labelGameboxGameName; }
            set { this.labelGameboxGameName = value; }
        }
        public Label LabelpriceTag
        {
            get { return labelpriceTag; }
            set { this.labelpriceTag = value; }
        }
        public Store Store
        {
            set { this.store = value; }
            get { return store; }
        }
        public Panel Panel
        {
            set { this.panel = value; }
            get { return panel; }
        }
        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new UserControlGamePage(store, game));
        }
    }
}

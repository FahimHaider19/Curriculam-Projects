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
    public partial class UserControlLibrary : UserControl
    {
        public UserControlLibrary()
        {
            InitializeComponent();
        }
        public GameBox GameBox1
        {
            get { return gameBox1; }
            set { this.gameBox1 = value; }
        }
        public GameBox GameBox2
        {
            get { return gameBox2; }
            set { this.gameBox2 = value; }
        }
        public GameBox GameBox3
        {
            get { return gameBox3; }
            set { this.gameBox3 = value; }
        }
        public GameBox GameBox4
        {
            get { return gameBox4; }
            set { this.gameBox4 = value; }
        }
        public GameBox GameBox5
        {
            get { return gameBox5; }
            set { this.gameBox5 = value; }
        }
        public GameBox GameBox6
        {
            get { return gameBox6; }
            set { this.gameBox6 = value; }
        }
        public bool Add(Store store,Panel panel, Game game)
        {
            if (GameBox1.LabelGameboxGameName.Text == "")
            {
                GameBox1.PictureBox.Visible = true;
                GameBox1.Game = game;
                GameBox1.Store = store;
                GameBox1.Panel = panel;
                GameBox1.LabelGameboxGameName.Text = game.Name;
                //GameBox1.PictureBox.Image = Image.FromFile(store.ProjectDirectory + @"\Resources\" + game.ImageBox);
                GameBox1.LabelpriceTag.Text = game.Price + "$";
                return true;
            }
            else if (GameBox2.LabelGameboxGameName.Text == "")
            {
                GameBox2.PictureBox.Visible = true;
                GameBox2.Game = game;
                GameBox2.Store = store;
                GameBox2.Panel = panel;
                GameBox2.LabelGameboxGameName.Text = game.Name;
                //GameBox2.PictureBox.Image = Image.FromFile(store.ProjectDirectory + @"\Resources\" + game.ImageBox);
                GameBox2.LabelpriceTag.Text = game.Price + "$";
                return true;
            }
            else if (GameBox3.LabelGameboxGameName.Text == "")
            {
                GameBox3.PictureBox.Visible = true;
                GameBox3.Game = game;
                GameBox3.Store = store;
                GameBox3.Panel = panel;
                GameBox3.LabelGameboxGameName.Text = game.Name;
                //GameBox3.PictureBox.Image = Image.FromFile(store.ProjectDirectory + @"\Resources\" + game.ImageBox);
                GameBox3.LabelpriceTag.Text = game.Price + "$";
                return true;
            }
            else if (GameBox4.LabelGameboxGameName.Text == "")
            {
                GameBox4.PictureBox.Visible = true;
                GameBox4.Game = game;
                GameBox4.Store = store;
                GameBox4.Panel = panel;
                GameBox4.LabelGameboxGameName.Text = game.Name;
                //GameBox4.PictureBox.Image = Image.FromFile(store.ProjectDirectory + @"\Resources\" + game.ImageBox);
                GameBox4.LabelpriceTag.Text = game.Price + "$";
                return true;
            }
            else if (GameBox5.LabelGameboxGameName.Text == "")
            {
                GameBox5.PictureBox.Visible = true;
                GameBox5.Game = game;
                GameBox5.Store = store;
                GameBox5.Panel = panel;
                GameBox5.LabelGameboxGameName.Text = game.Name;
                //GameBox5.PictureBox.Image = Image.FromFile(store.ProjectDirectory + @"\Resources\" + game.ImageBox);
                GameBox5.LabelpriceTag.Text = game.Price + "$";
                return true;
            }
            else if (GameBox6.LabelGameboxGameName.Text == "")
            {
                GameBox6.PictureBox.Visible = true;
                GameBox6.Game = game;
                GameBox6.Store = store;
                GameBox6.Panel = panel;
                GameBox6.LabelGameboxGameName.Text = game.Name;
                //GameBox6.PictureBox.Image = Image.FromFile(store.ProjectDirectory + @"\Resources\" + game.ImageBox);
                GameBox6.LabelpriceTag.Text = game.Price + "$";
                return true;
            }
            else
                return false;
        }
    }
}

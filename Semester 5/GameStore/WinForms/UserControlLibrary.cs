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
        public bool Add(Game game)
        {
            if (GameBox1.LabelGameboxGameName.Text == "GameName")
            {
                GameBox1.LabelGameboxGameName.Text = game.Name;
                //GameBox1.PictureBox.Image = "Image Location";
                GameBox1.LabelpriceTag.Text = game.Price + "$";
                return true;
            }
            else if (GameBox2.LabelGameboxGameName.Text == "GameName")
            {
                GameBox2.LabelGameboxGameName.Text = game.Name;
                //GameBox2.PictureBox.Image = "Image Location";
                GameBox2.LabelpriceTag.Text = game.Price + "$";
                return true;
            }
            else if (GameBox3.LabelGameboxGameName.Text == "GameName")
            {
                GameBox3.LabelGameboxGameName.Text = game.Name;
                //GameBox3.PictureBox.Image = "Image Location";
                GameBox3.LabelpriceTag.Text = game.Price + "$";
                return true;
            }
            else if (GameBox3.LabelGameboxGameName.Text == "GameName")
            {
                GameBox4.LabelGameboxGameName.Text = game.Name;
                //GameBox4.PictureBox.Image = "Image Location";
                GameBox4.LabelpriceTag.Text = game.Price + "$";
                return true;
            }
            else if (GameBox4.LabelGameboxGameName.Text == "GameName")
            {
                GameBox4.LabelGameboxGameName.Text = game.Name;
                //GameBox4.PictureBox.Image = "Image Location";
                GameBox4.LabelpriceTag.Text = game.Price + "$";
                return true;
            }
            else if (GameBox5.LabelGameboxGameName.Text == "GameName")
            {
                GameBox5.LabelGameboxGameName.Text = game.Name;
                //GameBox5.PictureBox.Image = "Image Location";
                GameBox5.LabelpriceTag.Text = game.Price + "$";
                return true;
            }
            else if (GameBox6.LabelGameboxGameName.Text == "GameName")
            {
                GameBox6.LabelGameboxGameName.Text = game.Name;
                //GameBox6.PictureBox.Image = "Image Location";
                GameBox6.LabelpriceTag.Text = game.Price + "$";
                return true;
            }
            else
                return false;
        }
    }
}

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
    public partial class GameBox : UserControl
    {
        public GameBox()
        {
            InitializeComponent();
        }
        public GameBox(Game game)
        {
            InitializeComponent();
            //picturebox;
            labelGameboxGameName.Text = game.Name;
            labelpriceTag.Text = game.Price + "$";
        }
        public GameBox(string title) //delete later, for test purpose only
        {
            InitializeComponent();
            this.pictureBox.Image = GameStore.Resource.RedDeadRedemption2;
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.labelGameboxGameName.Text = title;
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStore
{
    public partial class GameBox : UserControl
    {
        public GameBox()
        {
            InitializeComponent();
        }
        public GameBox(string title)
        {
            InitializeComponent();
            this.pictureBox.Image = GameStore.Resource.RedDeadRedemption2;
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.labelGameboxGameName.Text = title;
        }
        public PictureBox PictureBox
        {
            get;
            set;
        }
        public Label LabelGameboxGameName
        {
            get{ return labelGameboxGameName; }
            set { this.labelGameboxGameName = value; }
        }
        public Label LabelpriceTag
        {
            get { return labelpriceTag; }
            set { this.labelpriceTag = value; }
        }
    }
}

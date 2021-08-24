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
    public partial class UserControlReview : UserControl
    {
        public UserControlReview(Review review)
        {
            InitializeComponent();
            labelRating.Text = review.Rating.ToString();
            labelReview.Text = review.Revieew;
            //labelUsername.Text = review.User;
            labelUsername.Text = "WolfEye19";

        }
    }
}

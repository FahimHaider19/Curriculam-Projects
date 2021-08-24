using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameStore.WinForms;
using GameStore.Classes;
using System.Data.SqlClient;
using System.Configuration;

namespace GameStore
{
    public partial class UserControlCart : UserControl
    {
        double total=0;
        Gamer gamer;
        public UserControlCart()
        {
            InitializeComponent();
        }
        public UserControlCart(Gamer gamer)
        {
            this.gamer = gamer;
            InitializeComponent();
            foreach(Product p in gamer.Cart)
            {
                total += p.Price;
                UserControlWishlist ucw = new UserControlWishlist(p, gamer.Cart);
                panelTop.Controls.Add(ucw);
                ucw.Dock = DockStyle.Top;
            }
            if (gamer.Cart.Count!=0) labelCartEmpty.Hide();
            labelTotalBill.Text = total + "$";
        }

        private void testUC_Load(object sender, EventArgs e)
        {

        }

        private void gameBox5_Load(object sender, EventArgs e)
        {

        }

        private void gameBox2_Load(object sender, EventArgs e)
        {

        }

        private void gameBox3_Load(object sender, EventArgs e)
        {

        }

        private void gameBox4_Load(object sender, EventArgs e)
        {

        }

        private void gameBox1_Load(object sender, EventArgs e)
        {

        }

        private void gameBox6_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelProducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTotalTag_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfirmPurchase_Click(object sender, EventArgs e)
        {
            if (radioButtonCard.Checked==true)
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Bank"].ConnectionString);
                connection.Open();
                string sqlRead = "select * from PaymentCard";
                SqlCommand command = new SqlCommand(sqlRead, connection);
                SqlDataReader reader = command.ExecuteReader();
                double balance = 0;
                if (reader.Read())
                {
                    balance = Double.Parse(reader["balance"].ToString());
                    if (balance >= total) ;
                    {
                        balance -= total;
                    }
                }
                else
                    MessageBox.Show("Invalid card info");
                string sqlwrite = "update PaymentCard set balance = '" + balance + "' where cardNumber = '" + textBoxCardNumber.Text + "'";
                SqlCommand command2 = new SqlCommand(sqlwrite, connection);
                int result = command2.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Purchase successful");
                    foreach (Product p in gamer.Cart)
                    {
                        gamer.PurchasedGames.Add((Game)p);
                    }
                    gamer.Cart.Clear();
                }
                else if (radioButtonStoreCredit.Checked == true){
                    if(gamer.StoreCredit >= total)
                    {
                        gamer.StoreCredit -= total;
                        SqlConnection connection3 = new SqlConnection(ConfigurationManager.ConnectionStrings["Hexa"].ConnectionString);
                        connection3.Open();
                        string sql3 = "update Users set store_credit='"+gamer.StoreCredit+"' where userID ='" + gamer.UserId + "' ";
                    }
                }
            }
        }
    }
}

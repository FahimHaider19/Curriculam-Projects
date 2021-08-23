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
    public partial class UserControlPublishGame : UserControl
    {
        Store store;
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
            if(textBoxTitle.Text == "" && textBoxSystemRequirement.Text == "" && textBoxPrice.Text == "" && textBoxDescription.Text == "" && textBoxType.Text == "")
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
            else if(textBoxType.Text=="")
            {
                MessageBox.Show("producttype can't be empty");
            }
            else
            {
                string sql = "insert into Products (name,price,description,productType,systemRequirments) values ('" + textBoxTitle.Text + "','" + textBoxPrice.Text + "','" + textBoxDescription.Text + "','" + textBoxType.Text + "','" + textBoxSystemRequirement.Text + "')";
                int result = store.Uda.ExecuteQuery(sql);
                if (result > 0)
                {

                    MessageBox.Show("sucessfully requested ,wait for admin to approve");
                }
                else
                {
                    MessageBox.Show("error in requesting");
                }
            }
        }
    }
}

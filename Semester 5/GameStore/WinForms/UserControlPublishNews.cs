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

namespace GameStore
{
    public partial class UserControlPublishNews : UserControl
    {
        Store store;
        public UserControlPublishNews()
        {
            InitializeComponent();
        }
        public UserControlPublishNews(Store store)
        {
            this.store = store;
            InitializeComponent();

        }
        private void buttonInsertNews_Click(object sender, EventArgs e)
        {
            if(textBoxGameTopic.Text == "" && textBoxDescription.Text == "" && textBoxTitle.Text == "")
            {
                MessageBox.Show("you have to give data's");
            }
            else if (textBoxGameTopic.Text == "")
            {
                MessageBox.Show("You have to give game name");
            }
            else if (textBoxDescription.Text == "")
            {
                MessageBox.Show("You have to give description");
            }
            else if (textBoxTitle.Text == "")
            {
                MessageBox.Show("you have to give tittle");
            }
            else
            {
                long id = store.getGame(textBoxGameTopic.Text).ProductId;
                string sql = "insert into News (title,description,productId) values ('" + textBoxTitle.Text + "','" + textBoxDescription.Text + "','" + id + "')";
                int result = store.Uda.ExecuteQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show("inserted news sucessfully");
                }
                else
                {
                    MessageBox.Show("error in inserting");
                }
            }

        }
    }
}

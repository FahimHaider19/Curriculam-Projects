using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameStore.Classes;

namespace GameStore
{
    public partial class UserControlDeveloperManagement : UserControl
    {
        Store store;
        public UserControlDeveloperManagement()
        {
            InitializeComponent();
        }
        public UserControlDeveloperManagement(Store store)
        {
            this.store = store;
            InitializeComponent();
        }
        private void labelPublishRequest_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string checksql = "select email from Users where email='" + textBoxEmail.Text + "'";
            SqlDataReader reader = store.Uda.GetData(checksql);
            if (reader.HasRows)
            {
                MessageBox.Show("already have a email account in same name");

            }
            else
            {
                string sql = "insert into Users(user_type, username, email, password)  values('developer', '" + textBoxName.Text + "', '" + textBoxEmail.Text + "', '" + textBoxPassword.Text + "')";
                int result = store.Uda.ExecuteQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show("developer added sucessfully");
                }
                else
                {
                    MessageBox.Show("error adding developer");
                }

            }
        }
    }
}

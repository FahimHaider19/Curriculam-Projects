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
    public partial class UserControlgameManageMentcs : UserControl
    {
        Store store;
        public UserControlgameManageMentcs()
        {
            InitializeComponent();
        }

        public UserControlgameManageMentcs(Store store)
        {
            this.store = store;
            InitializeComponent();
            foreach (Game game in store.Games)
            {
                comboBoxGamemagement.Items.Add(game.Name);

            }
        }

        private void panelgameManagements_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string sql = "Update Products set name='" + textBoxTitle.Text + "',price='" + textBoxPrice.Text + "',systemRequirments='" + textBoxSystemRequirement.Text + "',description='" + textBoxDescription.Text + "' where name='"+comboBoxGamemagement.Text+"'";
            int result = store.Uda.ExecuteQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("sucessfully updated");

            }
            else
            {
                MessageBox.Show("ERROR!!Can't update ");
            }
        }

        private void comboBoxGamemagement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FormAdmin : Form
    {
        Store store;
        public FormAdmin()
        {
            InitializeComponent();
        }
        public FormAdmin(Store store)
        {
            this.store = store;
            InitializeComponent();
        }

        private void buttonUserManagement_Click(object sender, EventArgs e)
        {
            UserControlUserManagement management = new UserControlUserManagement(store);
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(management);
        }

        private void buttonDeveloperManagement_Click(object sender, EventArgs e)
        {
            UserControlDeveloperManagement developermanagements = new UserControlDeveloperManagement(store);
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(developermanagements);
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

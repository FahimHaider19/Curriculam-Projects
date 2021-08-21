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
    

    public partial class Register : Form
    {
       
        string password="1234";
        string confirmpassword;
        public Register()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
           if(passwordBox.Text==confirmPasswordBox.Text)
            {
                MessageBox.Show("sucessfully registered");
                LogIn log = new LogIn();
                log.Show();
                this.Hide();
            }
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using GameStore.DataAccess;

namespace GameStore
{
    

    public partial class Register : Form
    {
       
      
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
            if (textBoxEmail.Text == "" && usernameBox.Text == "")
            {
                MessageBox.Show("enter email and username");
            }

            else if (textBoxEmail.Text == "")
            {
                MessageBox.Show("enter valid email");
            }
            else if (usernameBox.Text == "")
            {
                MessageBox.Show("enter username");
            }
            else if (passwordBox.Text == "")
            { 
                MessageBox.Show("enter password");
            }
            else if (confirmPasswordBox.Text=="")
            {
                MessageBox.Show("enter confirm password");
            }
            else if (passwordBox.Text == "" && confirmPasswordBox.Text == "")
            {
               MessageBox.Show("enter password and confirm password");

            }
            else if(passwordBox.Text!=confirmPasswordBox.Text)
            {
                MessageBox.Show("password and confirm password do not match");
            }

           else 
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hexa"].ConnectionString);
                connection.Open();
                string sql="insert into Users(username,email,user_type,password)  values('"+usernameBox.Text+"','"+textBoxEmail.Text+"','gamer','"+passwordBox.Text+"')";
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sucessfully Registered");
                    LogIn log = new LogIn();
                    log.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("ERROR!Registration not successful");
               
            }
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void showPassCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheckbox1.Checked == true)
            {
                passwordBox.PasswordChar = '\0';
            }
            else
                passwordBox.PasswordChar = '*';
        }

        private void showPassCheckbox2_CheckedChanged(object sender, EventArgs e)
        {
            if(showPassCheckbox2.Checked==true)
            {
                confirmPasswordBox.PasswordChar = '\0';

            }
            else
            {
                confirmPasswordBox.PasswordChar = '*';
            }
        }
    }
}

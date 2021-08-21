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
using GameStore.Classes;

namespace GameStore
{
    public partial class LogIn : Form
    {
        string username;
        string password;
        UsersDataAccess uda;
        Store store;
        
        public LogIn()
        {
            InitializeComponent();
        }
        public LogIn(Store store)
        {
            this.store = store;
            InitializeComponent();
        }
        private void LoginBanner_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hexa"].ConnectionString);
            connection.Open();

            if (textBoxUserName.Text=="")
            {
                MessageBox.Show("Enter Email");
            }
            else if(textBoxPassword.Text == "")
            {
                MessageBox.Show("Enter password");
            }
            else
            {
                string sql = "SELECT * FROM Users WHERE email = '" + textBoxUserName.Text + "' AND password = '" + textBoxPassword.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader["user_type"].ToString() == "gamer")
                    {
                        //store.LoggedInUser = store.Uda.getGamer(reader);
                        foreach(Gamer g in store.Gamers)
                        {
                            if(g.Email == reader["email"].ToString())
                            {
                                store.LoggedInUser = g;
                            }
                        }
                    }
                    else if (reader["user_type"].ToString() == "admin")
                    {
                        store.LoggedInUser = store.Uda.getAdmin(reader);
                    }
                    else if (reader["user_type"].ToString() == "developer")
                    {
                        //store.LoggedInUser = store.Uda.getGamer(reader);
                        foreach (Developer d in store.Developers)
                        {
                            if (d.Email == reader["email"].ToString())
                            {
                                store.LoggedInUser = d;
                            }
                        }
                    }
                    /*
                    username = reader["email"].ToString();
                    password = reader["password"].ToString();

                    if (textBoxUserName.Text == username && textBoxPassword.Text == password)
                    {
                        //MessageBox.Show("Login successful");
                        // Application.Exit();
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        this.Hide();

                        //next form
                    } */
                    username = textBoxUserName.Text;
                    password = textBoxPassword.Text;

                    MainWindow mainWindow = new MainWindow(store);
                    mainWindow.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                }
            }
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxShowCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowCheckbox.Checked == true)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
                textBoxPassword.PasswordChar = '*';
        }

        private void labelRegistered_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();

        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

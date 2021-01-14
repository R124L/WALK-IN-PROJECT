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

namespace WALK_IN_PROJECT
{
    public partial class Login : Form
    {
        SqlConnection connection;
        string connectionString = "Data Source=WHO-KNOWS;Initial Catalog=hotel;Integrated Security=True";

        public Login()
        {
            InitializeComponent();
        }

        private void password_OnValueChanged(object sender, EventArgs e)
        {
            password.isPassword = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT username, password FROM Admin";
            try
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if ((username.Text == reader["username"].ToString()) && (password.Text == reader["password"].ToString()))
                            {
                                MainForm mainForm = new MainForm();
                                this.Hide();
                                mainForm.username = reader["username"].ToString();
                                mainForm.ShowDialog();
                                if (mainForm.logout)
                                {
                                    this.Show();
                                    username.Text = "Username";
                                    password.Text = "Password";
                                    password.isPassword = false;
                                }
                                else
                                {
                                    this.Close();
                                }
                                return;
                            }
                        }
                        MessageBox.Show("Username atau Password SALAH!", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Informasi");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

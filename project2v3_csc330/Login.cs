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

namespace project2v3_csc330
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateAccount a1 = new CreateAccount();
            a1.Show();
            this.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(global::project2v3_csc330.Properties.Settings.Default.PropertyDBConnectionString); 
           
            try
            {
                string sql = "SELECT * FROM CustomerTable WHERE Customer_UserName = @username AND Customer_Password = @password";
                SqlCommand checkPassword = new SqlCommand(sql, connection);
                checkPassword.Parameters.AddWithValue("@username", txt_UserName.Text);
                checkPassword.Parameters.AddWithValue("@password", txt_Password.Text);
                connection.Open(); 

                using (SqlDataReader reader = checkPassword.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MessageBox.Show("Welcome to Real Estate System, " + reader["Customer_FirstName"].ToString());
                        Customer f1 = new Customer();
                        f1.Show();
                        this.Close(); 
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid password, enter again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

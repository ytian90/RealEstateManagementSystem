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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_Phone.Text = "";
            txt_Email.Text = ""; 
        }

        
        private void button_Add_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(global::project2v3_csc330.Properties.Settings.Default.PropertyDBConnectionString);
            try
            {
                string sql = "INSERT INTO CustomerTable(Customer_FirstName, Customer_LastName, Customer_Phone, Customer_Email, Customer_UserName, Customer_Password) VALUES ('" + txt_FirstName.Text + "', '" + txt_LastName.Text + "', '" + txt_Phone.Text + "', '" + txt_Email.Text + "', '" + txt_UserName.Text + "', '" + txt_Password1.Text + "')";
                SqlCommand commandInsert = new SqlCommand(sql, connection);
                connection.Open();
                commandInsert.ExecuteNonQuery();


                int customerid = 0;
                string sql2 = "SELECT * FROM CustomerTable WHERE Customer_UserName = @username";

                SqlCommand getStatuscmd = new SqlCommand(sql2, connection);
                getStatuscmd.Parameters.AddWithValue("@username", txt_UserName.Text);

                //connection.Open();
                using (SqlDataReader reader = getStatuscmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customerid = Convert.ToInt32(reader["Customer_Id"].ToString());
                    }
                }
                
                MessageBox.Show("Add new account successfully!\nYour CustomerID is " + customerid, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            finally
            {
                connection.Close();
                this.Close();
                Login a1 = new Login();
                //a1.MdiParent = project2v3_csc330.MainForm; 
                a1.Show(); 
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(global::project2v3_csc330.Properties.Settings.Default.PropertyDBConnectionString);
            try
            {
                int index = 0; 
                string sql = "SELECT * FROM CustomerTable WHERE Customer_UserName = @username";
                SqlCommand checkcmd = new SqlCommand(sql, connection);
                checkcmd.Parameters.AddWithValue("@username", txt_UserName.Text);
                connection.Open();

                using (SqlDataReader reader = checkcmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        index += 1; 
                    }
                }
                if (index == 0)
                    MessageBox.Show("User Name is available.", "", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                else if (index == 1)
                    MessageBox.Show("Someone got the name", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            finally
            {
                connection.Close(); 
            }
        }

    }
}

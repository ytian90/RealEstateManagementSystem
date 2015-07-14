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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void propertyTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.propertyTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.propertyDBDataSet);

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'propertyDBDataSet.OfferTable' table. You can move, or remove it, as needed.
            this.offerTableTableAdapter.Fill(this.propertyDBDataSet.OfferTable);
            // TODO: This line of code loads data into the 'propertyDBDataSet.PropertyTable' table. You can move, or remove it, as needed.
            this.propertyTableTableAdapter.Fill(this.propertyDBDataSet.PropertyTable);

        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(global::project2v3_csc330.Properties.Settings.Default.PropertyDBConnectionString); 
            try
            {
                string sql = "INSERT INTO OfferTable(Property_Id, Customer_Id, Offer) VALUES (" + property_IdTextBox.Text + ", " + txt_CustomerID.Text + ", " + txt_Offer.Text + " )";
                SqlCommand InsertOffer = new SqlCommand(sql, connection);
                connection.Open();
                InsertOffer.ExecuteNonQuery();

                MessageBox.Show("Offer Submitted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error"); 
            }
            finally
            {
                connection.Close(); 
            }
        }

        private void button_Status_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(global::project2v3_csc330.Properties.Settings.Default.PropertyDBConnectionString); 
            try
            {
                int offerid = 4; 
                string sql = "SELECT * FROM OfferTable WHERE Property_Id = @propertyid AND Customer_Id = @customerid";
                
                SqlCommand getStatuscmd = new SqlCommand(sql, connection);
                getStatuscmd.Parameters.AddWithValue("@propertyid", txt_PropertyId.Text);
                getStatuscmd.Parameters.AddWithValue("@customerid", text_CustomerId2.Text);
                connection.Open();
                using (SqlDataReader reader = getStatuscmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        offerid = Convert.ToInt32(reader["Offer_Status"].ToString());
                    }
                }
                if (offerid == 1)
                    MessageBox.Show("Congratulation! You got the house.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                else if (offerid == 2)
                    MessageBox.Show("Sorry, your offer was rejected.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                else
                    MessageBox.Show("Your offer is still pending", "Undecided", MessageBoxButtons.OK, MessageBoxIcon.Information); 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connection.Close();
            }
            



        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'propertyDBDataSet.OfferTable' table. You can move, or remove it, as needed.
            this.offerTableTableAdapter.Fill(this.propertyDBDataSet.OfferTable);
            // TODO: This line of code loads data into the 'propertyDBDataSet.PropertyTable' table. You can move, or remove it, as needed.
            this.propertyTableTableAdapter.Fill(this.propertyDBDataSet.PropertyTable);
        }
    }
}

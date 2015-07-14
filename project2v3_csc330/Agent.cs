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
using System.Data.Sql; 

namespace project2v3_csc330
{
    public partial class Agent : Form
    {
       
        public Agent()
        {
            InitializeComponent();
        }

        private void propertyTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.propertyTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.propertyDBDataSet);/////////

            // TODO: This line of code loads data into the 'propertyDBDataSet.OfferTable' table. You can move, or remove it, as needed.
            this.offerTableTableAdapter.Fill(this.propertyDBDataSet.OfferTable);
            // TODO: This line of code loads data into the 'propertyDBDataSet.PropertyTable' table. You can move, or remove it, as needed.
            this.propertyTableTableAdapter.Fill(this.propertyDBDataSet.PropertyTable);

            
        }

        private void Agent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'propertyDBDataSet.OfferTable' table. You can move, or remove it, as needed.
            this.offerTableTableAdapter.Fill(this.propertyDBDataSet.OfferTable);
            // TODO: This line of code loads data into the 'propertyDBDataSet.PropertyTable' table. You can move, or remove it, as needed.
            this.propertyTableTableAdapter.Fill(this.propertyDBDataSet.PropertyTable);

            //SQLFunction.Refresh(this.propertyTableDataGridView); 


        }

        private void property_IdTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(global::project2v3_csc330.Properties.Settings.Default.PropertyDBConnectionString); 

            try
            {
                string sql = "SELECT * FROM OfferTable WHERE Property_Id = @propertyid";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@propertyid", property_IdTextBox.Text);
                connection.Open();
                string output = ""; 
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    output += "OfferID    CustomerID\tOffer\n"; 
                    while(reader.Read())
                    {
                        output += reader["Offer_Id"].ToString();
                        output += "\t"; 
                        output += reader["Customer_Id"].ToString();
                        output += "\t\t";
                        output += reader["Offer"].ToString();
                        output += "\n"; 
                    }
                }
                richTextOffers.Text = output; 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error"); 
            }
            finally
            {
                connection.Close(); 
            }

        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(global::project2v3_csc330.Properties.Settings.Default.PropertyDBConnectionString);

            try
            {
                string sql = "UPDATE OfferTable SET  Offer_Status = 1 WHERE Offer_Id =  '" + offer_IdComboBox.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();


                MessageBox.Show("Accept offer successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); 

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

        private void button_Decline_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(global::project2v3_csc330.Properties.Settings.Default.PropertyDBConnectionString);

            try
            {
                string sql = "UPDATE OfferTable SET  Offer_Status = 2 WHERE Offer_Id =  '" + offer_IdComboBox.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();


                MessageBox.Show("Decline offer successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void richTextOffers_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(global::project2v3_csc330.Properties.Settings.Default.PropertyDBConnectionString);

            try
            {
                

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

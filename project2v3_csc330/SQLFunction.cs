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
    class SQLFunction
    {
        static private SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=\"F:\\Visual Studio 2013\\Projects\\project2v3_csc330\\project2v3_csc330\\PropertyDB.mdf\";Integrated Security=True");

        static public void Refresh(DataGridView _dataGridView)
        {
            try
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [PropertyTable]", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                _dataGridView.DataSource = dataTable;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        static public void CustomerInsert(string _firstName, string _lastName, string _phone, string _email)
        {
            try
            {
                connection.Open();
                //SqlConnection commandInsert = new SqlConnection("INSERT INTO CustomerTable (Customer_FirstName, Customer_LastName, Customer_Phone, Customer_Email) VALUES (@_firstName, @_lastName, @_phone, @_email)", connection); 
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
            finally
            {
                connection.Close(); 
            }
        }

    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management
{
    public partial class Return_Book : Form
    {
        public Return_Book()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtmname.Text != "")
            {
                panel5.Visible = true;
                string member_name = txtmname.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-Q25QI8B\\SQLEXPRESS; database = library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from BR_Table where member_name = '" + member_name + "' and return_date IS NULL";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtbname.Text = ds.Tables[0].Rows[0][2].ToString();
                    dateTimePickerborrow.Text = ds.Tables[0].Rows[0][4].ToString();
                }
                else
                {
                    txtmname.Clear();
                    MessageBox.Show("Invalid Member Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Return_Book_Load(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-Q25QI8B\\SQLEXPRESS; database = library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();*/

            // Correct the connection string
            /*SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q25QI8B\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");
            string query = "UPDATE BR_Table SET return_date = @return_date WHERE member_name = @member_name AND book_name = @book_name";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // Use try-catch for error handling
                try
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("@return_date", dateTimePickerreturn.Text);

                    int i = cmd.ExecuteNonQuery();

                    // Check the affected rows to determine if the data was inserted successfully
                    if (i != 0)
                    {
                        MessageBox.Show("Book Returned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Empty Fields Aren't Allowed", "Warning");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error");
                }
                finally
                {
                    con.Close();
                }


            }*/

 
                // Validate that required fields are not empty
                if (string.IsNullOrWhiteSpace(dateTimePickerreturn.Text))
                {
                    MessageBox.Show("Please fill in the return date", "Warning");
                    return;
                }

                // Correct the connection string
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q25QI8B\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");

                string query = "UPDATE BR_Table SET return_date = @return_date WHERE member_name = @member_name AND book_name = @book_name";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Use try-catch for error handling
                    try
                    {
                        con.Open();

                    cmd.Parameters.AddWithValue("@return_date", dateTimePickerreturn.Value);

                    cmd.Parameters.AddWithValue("@member_name", txtmname.Text); // Add member_name parameter
                        cmd.Parameters.AddWithValue("@book_name", txtbname.Text); // Add book_name parameter

                        int i = cmd.ExecuteNonQuery();

                        // Check the affected rows to determine if the data was updated successfully
                        if (i != 0)
                        {
                            MessageBox.Show("Book Returned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No matching record found to update", "Warning");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            

        }
    }
}

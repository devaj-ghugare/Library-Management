using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class Sign_up : Form
    {
        private string query;

        public Sign_up()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            // Validate that required fields are not empty
            if (string.IsNullOrWhiteSpace(txtuser.Text) ||
                string.IsNullOrWhiteSpace(txtpass.Text) ||
                string.IsNullOrWhiteSpace(txtfirst.Text) ||
                string.IsNullOrWhiteSpace(txtlast.Text) ||
                string.IsNullOrWhiteSpace(txtemail.Text) ||
                string.IsNullOrWhiteSpace(txtmob.Text))
            {
                MessageBox.Show("Please fill in all required fields", "Warning");
                return;
            }

            // Correct the connection string
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q25QI8B\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");

                string query = "INSERT INTO Logintable (Username, Password, First_name, Last_name, Email_id, Mobile_no) VALUES (@Username, @Password, @First_name, @Last_name, @Email_id, @Mobile_no)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Use try-catch for error handling
                    try
                    {
                        con.Open();

                        cmd.Parameters.AddWithValue("@username", txtuser.Text);
                        cmd.Parameters.AddWithValue("@password", txtpass.Text);
                        cmd.Parameters.AddWithValue("@first_name", txtfirst.Text);
                        cmd.Parameters.AddWithValue("@last_name", txtlast.Text);
                        cmd.Parameters.AddWithValue("@email_id", txtemail.Text);
                        cmd.Parameters.AddWithValue("@Mobile_no", txtmob.Text);

                        int i = cmd.ExecuteNonQuery();

                        // Check the affected rows to determine if the data was inserted successfully
                        if (i != 0)
                        {
                            MessageBox.Show("DATA Saved", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
                }
            }

        }

    }
   


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
using System.Xml.Linq;

namespace Library_Management
{
    public partial class Add_Book : Form
    {
        private string query;

        public Add_Book()
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
            if (string.IsNullOrWhiteSpace(txtbname.Text) ||
                string.IsNullOrWhiteSpace(txtauthor.Text) ||
                string.IsNullOrWhiteSpace(txtisbn.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(txtquantity.Text))
            {
                MessageBox.Show("Please fill in all required fields", "Warning");
                return;
            }

            // Correct the connection string
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q25QI8B\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");

            string query = "INSERT INTO Add_Book (Book_name, Author_name, ISBN, Book_genre, Quantity) VALUES (@Book_name, @Author_name, @ISBN, @Book_genre, @Quantity)";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // Use try-catch for error handling
                try
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("@Book_name", txtbname.Text);
                    cmd.Parameters.AddWithValue("@Author_name", txtauthor.Text);
                    cmd.Parameters.AddWithValue("@ISBN", txtisbn.Text);
                    cmd.Parameters.AddWithValue("@Book_genre", comboBox1.Text);  // Assuming ComboBox is used for Book_genre
                    cmd.Parameters.AddWithValue("@Quantity", txtquantity.Text);

                    int i = cmd.ExecuteNonQuery();

                    // Check the affected rows to determine if the data was inserted successfully
                    if (i != 0)
                    {
                        MessageBox.Show("DATA Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtisbn_TextChanged(object sender, EventArgs e)
        {
            // Get the entered ISBN from the TextBox
            string enteredISBN = txtisbn.Text;

            // Check if the entered ISBN already exists
            if (IsISBNAlreadyExists(enteredISBN))
            {
                MessageBox.Show("Entered ISBN already exists. Please enter a unique ISBN.", "Warning");

                // Optionally, you can also provide additional instructions or highlight the TextBox.
                txtisbn.Focus(); // Set focus to the TextBox
                txtisbn.BackColor = Color.Red; // Highlight the TextBox

                // You may consider disabling other controls or providing instructions based on your design.
                // For example:
                // btnSubmit.Enabled = false;
                // labelInstructions.Text = "Please enter a unique ISBN.";
            }
            else
            {
                // If the entered ISBN is unique, reset the background color and enable other controls.
                txtisbn.BackColor = SystemColors.Window; // Reset to the default background color

                // Optionally, enable other controls or reset instructions.
                // For example:
                // btnSubmit.Enabled = true;
                // labelInstructions.Text = "Enter the ISBN and proceed.";
            }
        }

        private bool IsISBNAlreadyExists(string isbn)
        {
            // Implement your logic to check if the ISBN already exists in the database.
            // You can use a similar approach as in the previous examples.

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-Q25QI8B\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True"))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Add_Book WHERE ISBN = @ISBN";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ISBN", isbn);

                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        }

    } 
    
}

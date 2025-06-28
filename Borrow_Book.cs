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

namespace Library_Management
{
    public partial class Borrow_Book : Form
    {
        public Borrow_Book()
        {
            InitializeComponent();
        }

        private void Borrow_Book_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-Q25QI8B\\SQLEXPRESS; database = library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select Book_name from Add_Book", con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    comboBox1.Items.Add(Sdr.GetString(i));

                }
            }
            Sdr.Close();
            con.Close();

        }
        private bool HasBorrowedBook(string memberName)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q25QI8B\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");

            // Check if the member has an open borrow record (return_date is null)
            string query = "SELECT COUNT(*) FROM BR_Table WHERE member_name = @member_name AND return_date IS NULL";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();

                cmd.Parameters.AddWithValue("@member_name", memberName);

                int count = (int)cmd.ExecuteScalar();

                con.Close();

                // If count is greater than 0, member has an open borrow record
                return count > 0;
            }
        }

        private void btnborrow_Click(object sender, EventArgs e)
        {
            // Validate that required fields are not empty
            if (string.IsNullOrWhiteSpace(txtmname.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(txtcno.Text) ||
                string.IsNullOrWhiteSpace(dateTimePickerborrow.Text))
            {
                MessageBox.Show("Please fill in all required fields", "Warning");
                return;
            }

            // Check if the member has already borrowed a book
            string memberName = txtmname.Text;
            if (HasBorrowedBook(memberName))
            {
                MessageBox.Show("Member already has a borrowed book. Only one book per member is allowed", "Warning");
                return;
            }

            // Correct the connection string
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q25QI8B\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");

            // Proceed with the borrowing operation
            string query = "INSERT INTO BR_Table (member_name, book_name, contact_no, borrow_date) VALUES (@member_name, @book_name, @contact_no, @borrow_date)";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // Use try-catch for error handling
                try
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("@member_name", txtmname.Text);
                    cmd.Parameters.AddWithValue("@book_name", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@contact_no", txtcno.Text);
                    //cmd.Parameters.AddWithValue("@borrow_date", dateTimePickerborrow.Text);
                    cmd.Parameters.AddWithValue("@borrow_date", dateTimePickerborrow.Value);

                    int i = cmd.ExecuteNonQuery();

                    // Check the affected rows to determine if the data was inserted successfully
                    if (i != 0)
                    {
                        MessageBox.Show("Book Issued", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

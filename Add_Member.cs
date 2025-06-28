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
//using System.Runtime.InteropServices;

namespace Library_Management
{
    public partial class Add_Member : Form
    {
            public Add_Member()
            {
                InitializeComponent();
               
            }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            // Validate that required fields are not empty
            if (string.IsNullOrWhiteSpace(txtfirst.Text) ||
                string.IsNullOrWhiteSpace(txtlast.Text) ||
                dateTimePickerdob.Value == DateTimePicker.MinimumDateTime ||  // Check if a valid date is selected
                string.IsNullOrWhiteSpace(txtaddress.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                dateTimePickerstart.Value == DateTimePicker.MinimumDateTime ||  // Check if a valid date is selected
                dateTimePickerend.Value == DateTimePicker.MinimumDateTime)     // Check if a valid date is selected

            {
                MessageBox.Show("Please fill in all required fields", "Warning");
                return;
            }

            // Correct the connection string
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q25QI8B\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");

            string query = "INSERT INTO Add_Member (First_Name, Last_Name, Date_Of_Birth, Address, Membership_Type, Membership_Start_Date, Membership_End_Date) VALUES (@First_Name, @Last_Name, @Date_Of_Birth, @Address, @Membership_Type, @Membership_Start_Date, @Membership_End_Date)";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // Use try-catch for error handling
                try
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("@First_Name", txtfirst.Text);
                    cmd.Parameters.AddWithValue("@Last_Name", txtlast.Text);
                    cmd.Parameters.AddWithValue("@Date_Of_Birth", dateTimePickerdob.Value);
                    cmd.Parameters.AddWithValue("@Address", txtaddress.Text);  
                    cmd.Parameters.AddWithValue("@Membership_Type", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Membership_Start_Date", dateTimePickerstart.Value);
                    cmd.Parameters.AddWithValue("@Membership_End_Date", dateTimePickerend.Value);

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
    }
}

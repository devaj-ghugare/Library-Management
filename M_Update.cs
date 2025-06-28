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
    public partial class M_Update : Form
    {
        public M_Update()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void M_Update_Load(object sender, EventArgs e)
        {
            panel6.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-Q25QI8B\\SQLEXPRESS; database = library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Add_Member";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        int Member_ID;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Member_ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            panel6.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-Q25QI8B\\SQLEXPRESS; database = library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Add_Member where Member_ID = " + Member_ID + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtfirst.Text = ds.Tables[0].Rows[0][1].ToString();
            txtlast.Text = ds.Tables[0].Rows[0][2].ToString();
            dateTimePickerdob.Value = Convert.ToDateTime(ds.Tables[0].Rows[0][3]);
            txtaddress.Text = ds.Tables[0].Rows[0][4].ToString();
            comboBox1.Text = ds.Tables[0].Rows[0][5].ToString();           
            dateTimePickerstart.Value = Convert.ToDateTime(ds.Tables[0].Rows[0][6]);
            dateTimePickerend.Value = Convert.ToDateTime(ds.Tables[0].Rows[0][7]);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-Q25QI8B\\SQLEXPRESS; database = library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Add_Member where First_name LIKE '" + txtsearch.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-Q25QI8B\\SQLEXPRESS; database = library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Add_Member";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {

            txtsearch.Clear();
            panel6.Visible = false;
            ReloadForm();
        }

        private void ReloadForm()
        {
            /*this.Close();
            B_Update addBookForm = new B_Update();
            addBookForm.Show();*/
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    string connectionString = "Data Source=DESKTOP-Q25QI8B\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        string updateQuery = "UPDATE Add_Member SET First_Name=@First_Name, Last_Name=@Last_Name, Date_Of_Birth=@Date_Of_Birth, Address=@Address, Membership_Type=@Membership_Type, Membership_Start_Date=@Membership_Start_Date, Membership_End_Date=@Membership_End_Date WHERE Member_ID = @Member_ID";

                        using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                        {
                            // Set parameters using SqlParameter to avoid SQL injection
                            cmd.Parameters.AddWithValue("@First_Name", txtfirst.Text);
                            cmd.Parameters.AddWithValue("@Last_Name", txtlast.Text);
                            cmd.Parameters.AddWithValue("@Date_Of_Birth", dateTimePickerdob.Value);
                            cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                            cmd.Parameters.AddWithValue("@Membership_Type", comboBox1.Text);
                            cmd.Parameters.AddWithValue("@Membership_Start_Date", dateTimePickerstart.Value);
                            cmd.Parameters.AddWithValue("@Membership_End_Date", dateTimePickerend.Value);
                            cmd.Parameters.AddWithValue("@Member_ID", rowid);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Update failed. Make sure the record exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Deleted. Confirm?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    string connectionString = "Data Source=DESKTOP-Q25QI8B\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        string deleteQuery = "DELETE FROM Add_Member WHERE Member_ID = @Member_ID";

                        using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                        {
                            // Set the parameter using SqlParameter to avoid SQL injection
                            cmd.Parameters.AddWithValue("@Member_ID", rowid);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Delete failed. Make sure the record exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    
    
    
}

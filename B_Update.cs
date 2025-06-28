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
    public partial class B_Update : Form
    {
        public B_Update()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void B_Update_Load(object sender, EventArgs e)
        {
            panel4.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-Q25QI8B\\SQLEXPRESS; database = library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Add_Book";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        int Id;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            panel4.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-Q25QI8B\\SQLEXPRESS; database = library; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Add_Book where Id = "+Id+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtbname.Text = ds.Tables[0].Rows[0][1].ToString();
            txtauthor.Text = ds.Tables[0].Rows[0][2].ToString();
            txtisbn.Text = ds.Tables[0].Rows[0][3].ToString();
            comboBox1.Text = ds.Tables[0].Rows[0][4].ToString();
            txtquantity.Text = ds.Tables[0].Rows[0][5].ToString();
            

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if(txtsearch.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-Q25QI8B\\SQLEXPRESS; database = library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Add_Book where Book_name LIKE '"+txtsearch.Text+"%'";
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

                cmd.CommandText = "select * from Add_Book";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtsearch.Clear();
            panel4.Visible = false;
            ReloadForm();
        }

        private void ReloadForm()
        {
            /*this.Close();
            openpanelmain(new B_Update());
        }

        private void openpanelmain(B_Update b_Update)
        {
            throw new NotImplementedException();*/
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            /* if (MessageBox.Show("Data Will Be Updated. Conform?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string Book_name = txtbname.Text;
                string Author_name = txtauthor.Text;
                Int64 ISBN = Int64.Parse(txtisbn.Text);
                string Book_genre = comboBox1.Text;
                Int64 Quantity = Int64.Parse(txtquantity.Text);


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-Q25QI8B\\SQLEXPRESS; database = library; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update Add_Book set Book_name ='" + Book_name + "', Author_name ='" + Author_name + "', ISBN =" + ISBN + ", Book_genre ='" + Book_genre + "', Quantity =" + Quantity + " where Id = " + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }*/

            if (MessageBox.Show("Data Will Be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    string connectionString = "Data Source=DESKTOP-Q25QI8B\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        string updateQuery = "UPDATE Add_Book SET Book_name = @Book_name, Author_name = @Author_name, ISBN = @ISBN, Book_genre = @Book_genre, Quantity = @Quantity WHERE Id = @Id";

                        using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                        {
                            // Set parameters using SqlParameter to avoid SQL injection
                            cmd.Parameters.AddWithValue("@Book_name", txtbname.Text);
                            cmd.Parameters.AddWithValue("@Author_name", txtauthor.Text);
                            cmd.Parameters.AddWithValue("@ISBN", Int64.Parse(txtisbn.Text));
                            cmd.Parameters.AddWithValue("@Book_genre", comboBox1.Text);
                            cmd.Parameters.AddWithValue("@Quantity", Int64.Parse(txtquantity.Text));
                            cmd.Parameters.AddWithValue("@Id", rowid);

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

                        string deleteQuery = "DELETE FROM Add_Book WHERE Id = @Id";

                        using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                        {
                            // Set the parameter using SqlParameter to avoid SQL injection
                            cmd.Parameters.AddWithValue("@Id", rowid);

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

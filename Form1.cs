using Microsoft.Data.SqlClient;

namespace DatabaseDemoWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        public void Insert(string query)
        {
            try
            {
                SqlConnection con = new Connection().GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                int row = cmd.ExecuteNonQuery();

                //if (row > 0)
                //{
                //    MessageBox.Show("Data Inserted");
                //}
                //else { MessageBox.Show("Data Not Inserted"); }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            Display();
        }
        public int Display(string query = "select *from student")
        {
            try
            {
                // Clear existing data
                dataGridView1.Rows.Clear();

                using (SqlConnection con = new Connection().GetConnection())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader row = cmd.ExecuteReader())
                        {
                            // Read data from the database and add to the BindingList
                            while (row.Read())
                            {
                                int roll = row.GetInt32(0);
                                string name = row.GetString(1);
                                string address = row.GetString(2);
                                string phone = row.GetString(3);



                                dataGridView1.Rows.Add(roll, name, address, phone);

                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            return dataGridView1.Rows.Count;
        }

        private void InsertOrUpdate(object sender, EventArgs e)
        {
            int roll = Convert.ToInt32(txtRoll.Text);
            string name = txtName.Text;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;
            string query = $"insert into student values({roll},'{name}','{address}','{phone}')";
            Insert(query);
            txtName.Clear();
            txtRoll.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }

        
        private void SearchRow(object sender, EventArgs e)
        {
            String key = searchbox.Text.Trim();
            if (key.Equals(""))
            {
                Display();
                return;
            }
            try
            {
                int roll = Convert.ToInt32(key);
                string query = $"select *from student where roll={roll}";
                if (Display(query) > 0)
                {
                    return;
                }
            }
            catch { }
            try
            {
                string query = $"select *from student where name='{key}' or address='{key}' or phone='{key}'";
                Display(query);
            }
            catch { }
        }



        private void UpdateItem(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            int roll = Convert.ToInt32(row.Cells["Roll"].Value);
            if (e.RowIndex >= 0)
            {
                var newValue = row.Cells[e.ColumnIndex].Value.ToString();
                string colName = dataGridView1.Columns[e.ColumnIndex].Name;
                string query = $"update student set {colName} = '{newValue}' where roll = {roll}";
                using (SqlConnection con = new Connection().GetConnection())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Update Successfull");
                            Display();
                        }
                    }
                }

            }

        }

        private void Delete(object sender, DataGridViewCellEventArgs e)
        {
            int colNum = e.ColumnIndex;
            if (e.ColumnIndex == 4)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int roll = Convert.ToInt32(row.Cells["Roll"].Value);
                string query = $"delete from student where roll = {roll}";
                using (SqlConnection con = new Connection().GetConnection())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Delete Successfull");
                            Display();
                        }
                    }
                }
            }
        }
    }
}

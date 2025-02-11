using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class EditService : Form
    {
        public EditService()
        {
            InitializeComponent();
            try
            {
                string ConnectString = null;
                MySqlConnection conn;
                MySqlCommand command;

                string sql = $"Select taxi_brand, taxi_model, number_plate, service_id from service";
                ConnectString = "datasource = localhost; username = root; password =; database = taxi_app";
                conn = new MySqlConnection(ConnectString);
                conn.Open();

                command = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox1.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox1.Items.Add(dr["number_plate"].ToString() + " " + dr["taxi_brand"].ToString() + "    " + dr["taxi_model"].ToString() + " " + dr["service_id"].ToString());
                }

                command.ExecuteNonQuery();
                command.Dispose();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Τα Δεδομένα Δεν Εισήχθησαν." + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectString = "datasource=localhost;username=root;password=;database=taxi_app";

                using (MySqlConnection conn = new MySqlConnection(ConnectString))
                {
                    conn.Open();

                    // Get the selected item from the combo box
                    string selectedString = comboBox1.SelectedItem.ToString();

                    // Split the selected string to extract the ID
                    string[] parts = selectedString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string id = parts[parts.Length - 1]; // Assuming the ID is at the last index

                    // Retrieve existing values from the database
                    string selectQuery = "SELECT * FROM service WHERE service_id = @id";
                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn);
                    selectCommand.Parameters.AddWithValue("@id", id);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];

                        // Extract other values needed for the update
                        string comment = string.IsNullOrEmpty(textBox1.Text) ? row["comment"].ToString() : textBox1.Text;
                        string price = string.IsNullOrEmpty(textBox3.Text) ? row["price"].ToString() : textBox3.Text;
                        string service_date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                        // Construct the update query
                        string updateQuery = @"UPDATE service
                                             SET comment = @comment,
                                             price = @price,
                                             service_date = @service_date                                   
                                             WHERE service_id = @id";

                        // Execute the update query
                        using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, conn))
                        {
                            updateCommand.Parameters.AddWithValue("@comment", comment);
                            updateCommand.Parameters.AddWithValue("@price", price);
                            updateCommand.Parameters.AddWithValue("@service_date", service_date);
                            updateCommand.Parameters.AddWithValue("@id", id);

                            updateCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Τα Δεδομένα Ενημερώθηκαν Επιτυχώς.");
                    }
                    else
                    {
                        MessageBox.Show("No data found for the selected item.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectString = null;

                ConnectString = "datasource = localhost; username = root; password =; database = taxi_app";
                MySqlConnection conn = new MySqlConnection(ConnectString);
                conn.Open();

                string sql = $"SELECT taxi_id AS 'ID_ΤΑΞΙ', " +
                             $"number_plate AS 'ΑΡΙΘΜΟΣ_ΠΙΝΑΚΙΔΑΣ', " +
                             $"taxi_brand AS 'ΜΑΡΚΑ_ΤΑΞΙ', " +
                             $"taxi_model AS 'ΜΟΝΤΕΛΟ_ΤΑΞΙ', " +
                             $"comment AS 'ΣΧΟΛΙΟ', " +
                             $"price AS 'ΤΙΜΗ', " +
                             $"service_date AS 'ΗΜΕΡΟΜΗΝΙΑ_ΥΠΗΡΕΣΙΑΣ' " +
                             $"FROM service";

                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                conn.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Τα Δεδομένα Δεν Εμφανίζονται Στον Πίνακα Επιτυχώς." + ex.Message);
            }
        }

        private void EditService_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectString = "datasource=localhost;username=root;password=;database=taxi_app";

                using (MySqlConnection conn = new MySqlConnection(ConnectString))
                {
                    conn.Open();

                    // Get the selected item from the combo box
                    string selectedString = comboBox1.SelectedItem.ToString();

                    // Split the selected string to extract the ID
                    string[] parts = selectedString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string id = parts[parts.Length - 1]; // Assuming the ID is at the last index

                    // Construct the delete query
                    string deleteQuery = @"DELETE FROM service
                                            WHERE service_id = @id";

                    // Execute the delete query
                    using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, conn))
                    {
                        deleteCommand.Parameters.AddWithValue("@id", id);

                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Row deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No rows were deleted.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class EditExpensesCal : Form
    {
        public EditExpensesCal()
        {
            InitializeComponent();
            try
            {
                string ConnectString = null;
                MySqlConnection conn;
                MySqlCommand command;

                string sql = $"SELECT t.number_plate, t.taxi_brand, t.taxi_model, taxiexp.id " +
                             $"FROM taxi t " +
                             $"JOIN taxiexpenses taxiexp ON t.taxi_id = taxiexp.taxi_id";

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
                    comboBox1.Items.Add(dr["taxi_brand"].ToString() + " " + dr["taxi_model"].ToString() + " " + dr["number_plate"].ToString() + " " + dr["id"].ToString());
                }

                command.ExecuteNonQuery();
                command.Dispose();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Τα Δεδομένα Δεν Εμφανίζονται Στον Πίνακα Επιτυχώς." + ex.Message);
            }
        }

        private void EditExpensesCal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExpensesCal expensesCal = new ExpensesCal();
            expensesCal.Show();
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

                    string selectedString = comboBox1.SelectedItem.ToString();
                    string[] parts = selectedString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string id = parts[parts.Length - 1];

                    // Retrieve existing values from the database
                    string selectQuery = "SELECT * FROM taxiexpenses WHERE id = @id";
                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn);
                    selectCommand.Parameters.AddWithValue("@id", id);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];

                        // Extract other values needed for the update
                        string VehicleExp = string.IsNullOrEmpty(textBox2.Text) ? row["VehicleExp"].ToString() : textBox2.Text;
                        string Kteo = string.IsNullOrEmpty(textBox3.Text) ? row["Kteo"].ToString() : textBox3.Text;
                        string driver1 = string.IsNullOrEmpty(textBox4.Text) ? row["driver1"].ToString() : textBox4.Text;
                        string driver2 = string.IsNullOrEmpty(textBox1.Text) ? row["driver2"].ToString() : textBox1.Text;
                        string enoikio = string.IsNullOrEmpty(textBox7.Text) ? row["enoikio"].ToString() : textBox7.Text;
                        string insurance = dateTimePicker3.Value.ToString("yyyy-MM-dd");
                        string KteoDate = dateTimePicker4.Value.ToString("yyyy-MM-dd");
                        string date = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                        // Construct the update query
                        string updateQuery = @"UPDATE taxiexpenses
                                       SET VehicleExp = @VehicleExp,
                                            Kteo = @Kteo,
                                            driver1 = @driver1,                                                                                     
                                            KteoDate = @KteoDate,
                                            insurance = @insurance,
                                            driver2 = @driver2,
                                            enoikio = @enoikio,
                                            date = @date,
                                            sunolo_exp = @VehicleExp + @Kteo + @enoikio - @driver1 - @driver2
                                       WHERE id = @id";

                        // Execute the update query
                        using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, conn))
                        {
                            updateCommand.Parameters.AddWithValue("@VehicleExp", VehicleExp);
                            updateCommand.Parameters.AddWithValue("@Kteo", Kteo);
                            updateCommand.Parameters.AddWithValue("@driver1", driver1);
                            updateCommand.Parameters.AddWithValue("@KteoDate", KteoDate);
                            updateCommand.Parameters.AddWithValue("@insurance", insurance);
                            updateCommand.Parameters.AddWithValue("@driver2", driver2);
                            updateCommand.Parameters.AddWithValue("@enoikio", enoikio);
                            updateCommand.Parameters.AddWithValue("@date", date);
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

                string sql = $"SELECT taxiexpenses.id AS 'ID', " +
                             $"taxiexpenses.VehicleExp AS 'ΕΞΟΔΑ_ΟΧΗΜΑΤΟΣ', " +
                             $"taxiexpenses.Kteo AS 'ΚΤΕΟ', " +
                             $"taxiexpenses.driver1 AS 'ΟΔΗΓΟΣ1', " +
                             $"taxiexpenses.KteoDate AS 'ΗΜΕΡΟΜΗΝΙΑ_ΚΤΕΟ', " +
                             $"taxiexpenses.insurance AS 'ΑΣΦΑΛΙΣΗ', " +
                             $"taxiexpenses.driver2 AS 'ΟΔΗΓΟΣ2', " +
                             $"taxiexpenses.enoikio AS 'ΕΝΟΙΚΙΟ', " +
                             $"taxiexpenses.date AS 'ΗΜΕΡΟΜΗΝΙΑ', " +
                             $"taxiexpenses.taxi_id AS 'ID_ΤΑΞΙ', " +
                             $"taxiexpenses.sunolo_exp AS 'ΣΥΝΟΛΟ_ΕΞΟΔΩΝ', " +
                             $"taxi.number_plate AS 'ΑΡΙΘΜΟΣ_ΠΙΝΑΚΙΔΑΣ' " +
                             $"FROM taxiexpenses LEFT JOIN taxi ON taxiexpenses.taxi_id = taxi.taxi_id";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                    string deleteQuery = @"DELETE FROM taxiexpenses
                                            WHERE id = @id";

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

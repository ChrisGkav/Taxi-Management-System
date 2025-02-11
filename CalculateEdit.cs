using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class CalculateEdit : Form
    {
        public CalculateEdit()
        {
            InitializeComponent();
            try
            {
                string ConnectString = "datasource=localhost; username=root; password=; database=taxi_app";
                MySqlConnection conn = new MySqlConnection(ConnectString);
                conn.Open();

                string sql = "SELECT t.taxi_id, t.number_plate, t.taxi_brand, t.taxi_model, tc.employee_id, em.firstname, em.lastname " +
                             "FROM taxi t " +
                             "JOIN taxicalculate tc ON t.taxi_id = tc.taxi_id " +
                             "JOIN employees em ON tc.employee_id = em.employee_id";

                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboBox1.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    string item = $"{dr["taxi_brand"]} {dr["taxi_model"]} {dr["number_plate"]} {dr["firstname"]} {dr["lastname"]} {dr["taxi_id"]}";
                    comboBox1.Items.Add(item);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Unable to populate data in the combo box.\n" + ex.Message);
            }
        }

        private void CalculateEdit_Load(object sender, EventArgs e)
        {

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

                    // Split the selected string to extract the taxi_id
                    string[] parts = selectedString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string taxi_id = parts[parts.Length - 1]; // Assuming taxi_id is at the last index

                    // Retrieve existing values from the database
                    string selectQuery = "SELECT * FROM taxicalculate WHERE taxi_id = @taxi_id";
                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn);
                    selectCommand.Parameters.AddWithValue("@taxi_id", taxi_id);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];

                        // Extract other values needed for the update
                        string FromDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                        string ToDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                        string enoikio = string.IsNullOrEmpty(textBox1.Text) ? row["Enoikio"].ToString() : textBox1.Text;
                        string expenses = string.IsNullOrEmpty(textBox2.Text) ? row["Expenses"].ToString() : textBox2.Text;
                        string freenow = string.IsNullOrEmpty(textBox3.Text) ? row["FreeNow"].ToString() : textBox3.Text;
                        string uber = string.IsNullOrEmpty(textBox4.Text) ? row["Uber"].ToString() : textBox4.Text;
                        string fpa = string.IsNullOrEmpty(textBox6.Text) ? row["fpa"].ToString() : textBox6.Text;
                        string ensima = string.IsNullOrEmpty(textBox7.Text) ? row["ensima"].ToString() : textBox7.Text;

                        // Construct the update query
                        string updateQuery = @"UPDATE taxicalculate
                                     SET FromDate = @FromDate,
                                         ToDate = @ToDate,
                                         Enoikio = @Enoikio,
                                         Expenses = @Expenses,
                                         FreeNow = @FreeNow,
                                         Uber = @Uber,
                                         fpa = @fpa,
                                         ensima = @ensima,
                                         sunolo = @Enoikio - @Expenses - @FreeNow - @Uber + COALESCE(@fpa, 0) + COALESCE(@ensima, 0)
                                     WHERE taxi_id = @taxi_id";

                        // Execute the update query
                        using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, conn))
                        {
                            updateCommand.Parameters.AddWithValue("@FromDate", FromDate);
                            updateCommand.Parameters.AddWithValue("@ToDate", ToDate);
                            updateCommand.Parameters.AddWithValue("@Enoikio", enoikio);
                            updateCommand.Parameters.AddWithValue("@Expenses", expenses);
                            updateCommand.Parameters.AddWithValue("@FreeNow", freenow);
                            updateCommand.Parameters.AddWithValue("@Uber", uber);
                            updateCommand.Parameters.AddWithValue("@fpa", fpa);
                            updateCommand.Parameters.AddWithValue("@ensima", ensima);
                            updateCommand.Parameters.AddWithValue("@taxi_id", taxi_id);

                            updateCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Τα Δεδομένα Ενημερώθηκαν Επιτυχώς.");
                    }
                    else
                    {
                        MessageBox.Show("Δεν βρέθηκαν δεδομένα για το επιλεγμένο ταξί.");
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

                string sql = $"SELECT taxicalculate.id AS 'ID', " +
                             $"taxicalculate.taxi_id AS 'ID_ΤΑΞΙ', " +
                             $"taxicalculate.FromDate AS 'ΑΠΟ_ΗΜΕΡΟΜΗΝΙΑ', " +
                             $"taxicalculate.ToDate AS 'ΕΩΣ_ΗΜΕΡΟΜΗΝΙΑ', " +
                             $"taxicalculate.Enoikio AS 'ΕΝΟΙΚΙΟ', " +
                             $"taxicalculate.Expenses AS 'ΕΞΟΔΑ', " +
                             $"taxicalculate.FreeNow AS 'ΕΛΕΥΘΕΡΟ', " +
                             $"taxicalculate.Uber AS 'UBER', " +
                             $"taxicalculate.fpa AS 'ΦΠΑ', " +
                             $"taxicalculate.ensima AS 'ΕΝΣΗΜΑ', " +
                             $"taxicalculate.sunolo AS 'ΣΥΝΟΛΟ', " +
                             $"taxi.number_plate AS 'ΑΡΙΘΜΟΣ_ΠΙΝΑΚΙΔΑΣ' " +
                             $"FROM taxicalculate LEFT JOIN taxi ON taxicalculate.taxi_id = taxi.taxi_id";

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

                    // Split the selected string to extract the taxi_id
                    string[] parts = selectedString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string taxi_id = parts[parts.Length - 1]; // Assuming taxi_id is at the last index

                    // Construct the delete query
                    string deleteQuery = "DELETE FROM taxicalculate WHERE taxi_id = @taxi_id";

                    // Execute the delete query
                    using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, conn))
                    {
                        deleteCommand.Parameters.AddWithValue("@taxi_id", taxi_id);

                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Τα Δεδομένα Διαγράφτηκαν Επιτυχώς.");
                            // Optional: Clear comboBox1 and refresh data if needed
                            comboBox1.Items.Clear();
                            // Refactor to a method that populates comboBox1
                        }
                        else
                        {
                            MessageBox.Show("Τα Δεδομένα Δεν Διαγράφτηκαν Επιτυχώς.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Calculate calculate = new Calculate();
            calculate.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

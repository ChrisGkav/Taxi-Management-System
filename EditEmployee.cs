using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class EditEmployee : Form
    {
        public EditEmployee()
        {
            InitializeComponent();
            try
            {
                string ConnectString = null;
                MySqlConnection conn;
                MySqlCommand command;

                string sql = $"SELECT t.taxi_id, t.number_plate, t.taxi_brand, t.taxi_model, em.employee_id, em.firstname, em.lastname FROM taxi t JOIN employees em ON t.taxi_id = em.taxi_id";

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
                    string item = $"{dr["taxi_brand"]} {dr["taxi_model"]} {dr["number_plate"]} {dr["firstname"]} {dr["lastname"]} {dr["taxi_id"]}";
                    comboBox1.Items.Add(item);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
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
                    string selectQuery = "SELECT * FROM taxi t JOIN employees em ON t.taxi_id = em.taxi_id WHERE t.taxi_id = @taxi_id";

                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn);
                    selectCommand.Parameters.AddWithValue("@taxi_id", taxi_id);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];

                        // Extract other values needed for the update              
                        string numberPlate = string.IsNullOrEmpty(textBox1.Text) ? row["number_plate"].ToString() : textBox1.Text;
                        string taxiBrand = string.IsNullOrEmpty(textBox2.Text) ? row["taxi_brand"].ToString() : textBox2.Text;
                        string taxiModel = string.IsNullOrEmpty(textBox3.Text) ? row["taxi_model"].ToString() : textBox3.Text;
                        string employeeFirstname = string.IsNullOrEmpty(textBox4.Text) ? row["firstname"].ToString() : textBox4.Text;
                        string employeeLastname = string.IsNullOrEmpty(textBox5.Text) ? row["lastname"].ToString() : textBox5.Text;
                        string employeeAge = string.IsNullOrEmpty(textBox6.Text) ? row["age"].ToString() : textBox6.Text;
                        string employeeAFM = string.IsNullOrEmpty(textBox7.Text) ? row["AFM"].ToString() : textBox7.Text;
                        string employeeHours = string.IsNullOrEmpty(textBox8.Text) ? row["comment"].ToString() : textBox8.Text;
                        string startShift = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                        string endShift = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                        string updateQuery = $"UPDATE taxi t JOIN employees em ON t.taxi_id = em.taxi_id SET t.number_plate = @number_plate, t.taxi_brand = @taxi_brand, t.taxi_model = @taxi_model, em.firstname = @firstname, em.lastname = @lastname, em.age = @age, em.AFM = @AFM, em.startShift = @startShift, em.endShift = @endShift, em.comment = @comment WHERE t.taxi_id = @taxi_id";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                        {
                            // Add parameters
                            cmd.Parameters.AddWithValue("@taxi_id", taxi_id);
                            cmd.Parameters.AddWithValue("@number_plate", numberPlate);
                            cmd.Parameters.AddWithValue("@taxi_brand", taxiBrand);
                            cmd.Parameters.AddWithValue("@taxi_model", taxiModel);
                            cmd.Parameters.AddWithValue("@firstname", employeeFirstname);
                            cmd.Parameters.AddWithValue("@lastname", employeeLastname);
                            cmd.Parameters.AddWithValue("@age", employeeAge);
                            cmd.Parameters.AddWithValue("@AFM", employeeAFM);
                            cmd.Parameters.AddWithValue("@startShift", startShift);
                            cmd.Parameters.AddWithValue("@endShift", endShift);
                            cmd.Parameters.AddWithValue("@comment", employeeHours);

                            cmd.ExecuteNonQuery();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectString = null;

                ConnectString = "datasource = localhost; username = root; password =; database = taxi_app";
                MySqlConnection conn = new MySqlConnection(ConnectString);
                conn.Open();

                string sql = "SELECT taxi.number_plate AS 'ΑΡΙΘΜΟΣ ΠΙΝΑΚΙΔΑΣ', taxi.taxi_brand AS 'ΜΑΡΚΑ ΤΑΞΙ', taxi.taxi_model AS 'ΜΟΝΤΕΛΟ ΤΑΞΙ', " +
                             "employees.firstname AS 'ΟΝΟΜΑ', employees.lastname AS 'ΕΠΩΝΥΜΟ', employees.AFM AS 'ΑΦΜ', employees.age AS 'ΗΛΙΚΙΑ', " +
                             "employees.startShift AS 'ΕΝΑΡΞΗ ΒΑΡΔΙΑΣ', employees.endShift AS 'ΛΗΞΗ ΒΑΡΔΙΑΣ', employees.comment AS 'ΣΧΟΛΙΟ' " +
                             "FROM taxi JOIN employees ON taxi.taxi_id = employees.taxi_id";

                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Τα Δεδομένα Δεν Εμφανίζονται Στον Πίνακα Επιτυχώς." + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TaxiDrivers taxiDrivers = new TaxiDrivers();
            taxiDrivers.Show();
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
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
                    string deleteQuery = $"DELETE taxi, employees FROM employees JOIN taxi ON employees.taxi_id = taxi.taxi_id WHERE employees.taxi_id = @taxi_id";

                    // Execute the delete query
                    using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, conn))
                    {
                        deleteCommand.Parameters.AddWithValue("@taxi_id", taxi_id);

                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Τα Δεδομένα Διαγράφτηκαν Επιτυχώς.");                           
                            comboBox1.Items.Clear();
                            
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

        private void EditEmployee_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

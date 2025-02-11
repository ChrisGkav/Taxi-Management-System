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
    public partial class StandByEdit : Form
    {
        public StandByEdit()
        {
            InitializeComponent();
            try
            {
                string ConnectString = null;
                MySqlConnection conn;
                MySqlCommand command;

                string sql = $"SELECT e.firstname, e.lastname, e.AFM, s.id " +
                             $"FROM employees e " +
                             $"JOIN standbytable s ON e.employee_id = s.employee_id";

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
                    comboBox1.Items.Add(dr["firstname"].ToString() + "  " + dr["lastname"].ToString() + "  " + dr["AFM"].ToString() + "  " + dr["id"].ToString());
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

        private void StandByEdit_Load(object sender, EventArgs e)
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

                string sql = $"SELECT s.id AS 'ID', " +
                             $"s.employee_id AS 'ID_ΥΠΑΛΛΗΛΟΥ', " +
                             $"emp.firstname AS 'ΟΝΟΜΑ', " +
                             $"emp.lastname AS 'ΕΠΩΝΥΜΟ', " +
                             $"s.VacationFrom AS 'ΑΠΟ_ΑΔΕΙΑ', " +
                             $"s.VacationEnd AS 'ΕΩΣ_ΑΔΕΙΑ', " +
                             $"DATEDIFF(s.VacationEnd, s.VacationFrom) AS 'ΗΜΕΡΕΣ_ΑΔΕΙΑΣ', " +
                             $"s.CovidFrom AS 'ΑΠΟ_COVID', " +
                             $"s.CovidEnd AS 'ΕΩΣ_COVID', " +
                             $"DATEDIFF(s.CovidEnd, s.CovidFrom) AS 'ΗΜΕΡΕΣ_COVID', " +
                             $"s.SickFrom AS 'ΑΠΟ_ΑΣΘΕΝΕΙΑ', " +
                             $"s.SickEnd AS 'ΕΩΣ_ΑΣΘΕΝΕΙΑ', " +
                             $"DATEDIFF(s.SickEnd, s.SickFrom) AS 'ΗΜΕΡΕΣ_ΑΣΘΕΝΕΙΑΣ', " +
                             $"DATEDIFF(s.VacationEnd, s.VacationFrom) + DATEDIFF(s.CovidEnd, s.CovidFrom) + DATEDIFF(s.SickEnd, s.SickFrom) AS 'ΣΥΝΟΛΙΚΕΣ_ΑΠΟΥΣΙΕΣ' " +
                             $"FROM standbytable s JOIN employees emp ON s.employee_id = emp.employee_id";

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

        private void button3_Click(object sender, EventArgs e)
        {
            StandBy standBy = new StandBy();
            standBy.Show();
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
                    string selectQuery = "SELECT * FROM standbytable WHERE id = @id";
                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn);
                    selectCommand.Parameters.AddWithValue("@id", id);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];

                        // Extract other values needed for the update
                        string vacationFrom = dateTimePicker7.Value.ToString("yyyy-MM-dd");
                        string vacationEnd = dateTimePicker8.Value.ToString("yyyy-MM-dd");
                        string covidFrom = dateTimePicker3.Value.ToString("yyyy-MM-dd");
                        string covidEnd = dateTimePicker4.Value.ToString("yyyy-MM-dd");
                        string sickFrom = dateTimePicker5.Value.ToString("yyyy-MM-dd");
                        string sickEnd = dateTimePicker6.Value.ToString("yyyy-MM-dd");

                        // Construct the update query
                        string updateQuery = @"UPDATE standbytable
                               SET VacationFrom = @vacationFrom,
                                   VacationEnd = @vacationEnd,
                                   CovidFrom = @covidFrom,
                                   CovidEnd = @covidEnd,
                                   SickFrom = @sickFrom,
                                   SickEnd = @sickEnd,
                                   DaysOff = DATEDIFF(@vacationEnd, @vacationFrom),
                                   CovidOff = DATEDIFF(@covidEnd, @covidFrom),
                                   SickOff = DATEDIFF(@sickEnd, @sickFrom),
                                   total_DaysOff = DATEDIFF(@vacationEnd, @vacationFrom) + DATEDIFF(@covidEnd, @covidFrom) + DATEDIFF(@sickEnd, @sickFrom)
                               WHERE id = @id";

                        // Execute the update query
                        using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, conn))
                        {
                            updateCommand.Parameters.AddWithValue("@vacationFrom", vacationFrom);
                            updateCommand.Parameters.AddWithValue("@vacationEnd", vacationEnd);
                            updateCommand.Parameters.AddWithValue("@covidFrom", covidFrom);
                            updateCommand.Parameters.AddWithValue("@covidEnd", covidEnd);
                            updateCommand.Parameters.AddWithValue("@sickFrom", sickFrom);
                            updateCommand.Parameters.AddWithValue("@sickEnd", sickEnd);
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

                    // Split the selected string to extract the ID
                    string[] parts = selectedString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string id = parts[parts.Length - 1]; // Assuming the ID is at the last index

                    // Construct the delete query
                    string deleteQuery = @"DELETE FROM standbytable
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

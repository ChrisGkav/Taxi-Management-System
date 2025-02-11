using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp1
{
    public partial class Calculate : Form
    {
        public Calculate()
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
                    string item = $"{dr["taxi_id"]} {dr["number_plate"]} {dr["taxi_brand"]} {dr["taxi_model"]} {dr["employee_id"]} {dr["firstname"]} {dr["lastname"]}";
                    comboBox1.Items.Add(item);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectString = "datasource = localhost; username = root; password =; database = taxi_app";
                MySqlConnection conn = new MySqlConnection(ConnectString);
                conn.Open();

                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Παρακαλώ Επιλέξτε Ταξί Από Την Λίστα.");
                    conn.Close();
                    return;
                }

                string fullname = comboBox1.SelectedItem.ToString();
                string[] nameParts = fullname.Split(' ');
                string taxi_id = nameParts[0];
                string numberPlate = nameParts[1];
                string taxiBrand = nameParts[2];
                string taxiModel = nameParts[3];
                string employeeId = nameParts[4];
                string employeeFirstname = nameParts[5];
                string employeeLastname = nameParts[6];
               
                int taxiId, empId;
                if (!int.TryParse(taxi_id, out taxiId) || !int.TryParse(employeeId, out empId))
                {
                    MessageBox.Show("Επιλέχθηκε μη έγκυρο αναγνωριστικό ταξί ή αναγνωριστικό υπαλλήλου.");
                    conn.Close();
                    return;
                }

                string startDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string endDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                string enoikio = textBox1.Text;
                string expenses = textBox2.Text;
                string freenow = textBox3.Text;
                string uber = textBox4.Text;
                string fpa = textBox6.Text;
                string ensima = textBox7.Text;

                // Check if the selected taxi_id and employee_id exist in the database
                string selectQuery = $"SELECT taxi_id FROM taxi WHERE number_plate = '{numberPlate}'";
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn);
                object taxiIdResult = selectCommand.ExecuteScalar();

                string selectEmployeeQuery = $"SELECT employee_id FROM employees WHERE employee_id = {empId}";
                MySqlCommand selectEmployeeCommand = new MySqlCommand(selectEmployeeQuery, conn);
                object employeeIdResult = selectEmployeeCommand.ExecuteScalar();

                if (taxiIdResult != null && int.TryParse(taxiIdResult.ToString(), out int validTaxiId) &&
                    employeeIdResult != null && int.TryParse(employeeIdResult.ToString(), out int validEmployeeId))
                {
                    if (validTaxiId == taxiId && validEmployeeId == empId) 
                    {
                        string insertQuery = $"INSERT INTO taxicalculate (taxi_id, employee_id, FromDate, ToDate, Enoikio, Expenses, FreeNow, Uber, fpa, ensima) " +
                                             $"VALUES ('{taxiId}', '{empId}', '{startDate}', '{endDate}', '{enoikio}', '{expenses}', '{freenow}', '{uber}', '{fpa}', '{ensima}')";

                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn);
                        insertCommand.ExecuteNonQuery();

                        MessageBox.Show("Data saved successfully.");

                        // Update the 'sunolo' column based on the inserted values
                        string updateQuery = "UPDATE taxicalculate SET sunolo = Enoikio - Expenses - FreeNow - Uber + IFNULL(fpa, 0) + IFNULL(ensima, 0)";
                        MySqlCommand updateCommand = new MySqlCommand(updateQuery, conn);
                        updateCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Το επιλεγμένο αναγνωριστικό ταξί ή αναγνωριστικό υπαλλήλου δεν ταιριάζει με αυτό που ανακτήθηκε από τη βάση δεδομένων.");
                    }
                }
                else
                {
                    MessageBox.Show("Το επιλεγμένο αναγνωριστικό ταξί ή αναγνωριστικό υπαλλήλου δεν βρέθηκε στη βάση δεδομένων.");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Αποτυχία εισαγωγής δεδομένων." + ex.Message);
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                             $"taxicalculate.FreeNow AS 'FREENOW', " +
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalculateEdit editcalculate = new CalculateEdit();
            editcalculate.Show();
            this.Close();
        }

        private void Calculate_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectString = null;

                ConnectString = "datasource = localhost; username = root; password =; database = taxi_app";
                MySqlConnection conn = new MySqlConnection(ConnectString);
                conn.Open();

                string numberPlateSearch = textBox9.Text.Trim();
                string startDate = dateTimePicker3.Value.ToString("yyyy-MM-dd");
                string endDate = dateTimePicker4.Value.ToString("yyyy-MM-dd");

                string sql = "SELECT taxi.number_plate AS 'ΑΡΙΘΜΟΣ ΠΙΝΑΚΙΔΑΣ', taxi.taxi_brand AS 'ΜΑΡΚΑ ΑΥΤΟΚΙΝΗΤΟΥ', taxi.taxi_model AS 'ΜΟΝΤΕΛΟ ΑΥΤΟΚΙΝΗΤΟΥ', taxicalculate.FromDate AS 'ΑΠΟ_ΗΜΕΡΟΜΗΝΙΑ', taxicalculate.ToDate AS 'ΕΩΣ_ΗΜΕΡΟΜΗΝΙΑ', taxicalculate.Enoikio AS 'ΕΝΟΙΚΙΟ', taxicalculate.Expenses AS 'ΕΞΟΔΑ', taxicalculate.FreeNow AS 'FREENOW', taxicalculate.Uber AS 'UBER', taxicalculate.fpa AS 'ΦΠΑ', taxicalculate.ensima AS 'ΕΝΣΗΜΑ', taxicalculate.sunolo AS 'ΣΥΝΟΛΟ'" +
                             "FROM taxi " +
                             "LEFT JOIN taxicalculate ON taxi.taxi_id = taxicalculate.taxi_id " +
                             "WHERE number_plate LIKE @numberPlateSearch AND taxicalculate.FromDate <= @endDate AND taxicalculate.ToDate >= @startDate";

                MySqlCommand command = new MySqlCommand(sql, conn);

                command.Parameters.AddWithValue("@numberPlateSearch", "%" + numberPlateSearch + "%");
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);

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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler(PrintPage);

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Αδυναμία Εκτύπωσης." + ex.Message);
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle rectArea = dataGridView1.DisplayRectangle;

            Bitmap bmp = new Bitmap(rectArea.Width, rectArea.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));

            float ratio = (float)bmp.Height / (float)bmp.Width;
            int desiredWidth = e.PageBounds.Width - 50;
            int desiredHeight = (int)(desiredWidth * ratio);

            e.Graphics.DrawImage(bmp, new Rectangle(25, 25, desiredWidth, desiredHeight));
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

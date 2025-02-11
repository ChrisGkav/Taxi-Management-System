using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;

namespace WinFormsApp1
{
    public partial class TaxiDrivers : Form
    {
        public TaxiDrivers()
        {
            InitializeComponent();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numberplate = textBox2.Text;
            string taxibrand = textBox3.Text;
            string taximodel = textBox4.Text;
            string employeename = textBox5.Text;
            string employeesurname = textBox6.Text;
            string Age = textBox7.Text;
            string afm = textBox8.Text;
            string comment = textBox1.Text;
            string shiftstart = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string shiftend = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            try
            {
                string ConnectString = null;
                MySqlConnection conn;
                MySqlCommand command;
      
                ConnectString = "datasource = localhost; username = root; password =; database = taxi_app";
                conn = new MySqlConnection(ConnectString);
                conn.Open();

                string insertQuery = $"INSERT INTO taxi(number_plate, taxi_brand, taxi_model)" +
                                     $"VALUES('{numberplate}', '{taxibrand}', '{taximodel}')";
                MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn);
                insertCommand.ExecuteNonQuery();

                string selectQuery = $"SELECT LAST_INSERT_ID()";
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn);
                object result = selectCommand.ExecuteScalar();
                int taxiId;

                if (result != null && int.TryParse(result.ToString(), out taxiId))
                {
                    string insertQuery1 = $"INSERT INTO employees (taxi_id, firstname, lastname, AFM, age, startShift, endShift, comment)" +
                                          $"VALUES('{taxiId}', '{employeename}', '{employeesurname}', '{afm}', '{Age}', '{shiftstart}', '{shiftend}', '{comment}')";

                    MySqlCommand insertCommand1 = new MySqlCommand(insertQuery1, conn);
                    insertCommand1.ExecuteNonQuery();

                    MessageBox.Show("Τα Δεδομένα Αποθηκεύτηκαν Επιτυχώς.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Τα Δεδομένα Δεν Εισήχθησαν." + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectString = "datasource = localhost; username = root; password =; database = taxi_app";
                MySqlConnection conn = new MySqlConnection(ConnectString);
                conn.Open();

                string sqlQuery = "SELECT taxi.number_plate AS 'ΑΡΙΘΜΟΣ ΠΙΝΑΚΙΔΑΣ', taxi.taxi_brand AS 'ΜΑΡΚΑ ΤΑΞΙ', taxi.taxi_model AS 'ΜΟΝΤΕΛΟ ΤΑΞΙ', " +
                                 "employees.firstname AS 'ΟΝΟΜΑ', employees.lastname AS 'ΕΠΩΝΥΜΟ', employees.AFM AS 'ΑΦΜ', employees.age AS 'ΗΛΙΚΙΑ', " +
                                 "employees.startShift AS 'ΕΝΑΡΞΗ ΒΑΡΔΙΑΣ', employees.endShift AS 'ΛΗΞΗ ΒΑΡΔΙΑΣ', employees.comment AS 'ΣΧΟΛΙΟ' " +
                                 "FROM taxi JOIN employees ON taxi.taxi_id = employees.taxi_id";

                MySqlCommand command = new MySqlCommand(sqlQuery, conn);
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

        private void button4_Click(object sender, EventArgs e)
        {
            EditEmployee editEmployee = new EditEmployee();
            editEmployee.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void TaxiDrivers_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
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

                string sql = "SELECT taxi.*, employees.firstname, employees.lastname, employees.AFM, employees.age, employees.startShift, employees.endShift, employees.comment FROM taxi" +
                             " LEFT JOIN employees ON taxi.taxi_id = employees.taxi_id WHERE number_plate LIKE @numberPlateSearch AND startShift <= @endDate AND endShift >= @startDate";
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

    }
}

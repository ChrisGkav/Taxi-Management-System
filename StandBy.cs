using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class StandBy : Form
    {
        public StandBy()
        {
            InitializeComponent();
            try
            {
                string ConnectString = null;
                MySqlConnection conn;
                MySqlCommand command;

                string sql = $"Select firstname, lastname, AFM from employees";
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
                    comboBox1.Items.Add(dr["firstname"].ToString() + " " + dr["lastname"].ToString() + "    " + dr["AFM"].ToString());
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

        private void StandBy_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectString = null;
                ConnectString = "datasource = localhost; username = root; password =; database = taxi_app";
                MySqlConnection conn = new MySqlConnection(ConnectString);
                conn.Open();

                string fullname = comboBox1.SelectedItem.ToString();
                string[] nameParts = fullname.Split(' ');
                string firstname = nameParts[0];
                string lastname = nameParts[1];
                string afm = nameParts[2];
              
                string vacationFrom = dateTimePicker7.Value.ToString("yyyy-MM-dd");
                string vacationEnd = dateTimePicker8.Value.ToString("yyyy-MM-dd");
                string covidFrom = dateTimePicker3.Value.ToString("yyyy-MM-dd");
                string covidEnd = dateTimePicker4.Value.ToString("yyyy-MM-dd");
                string sickFrom = dateTimePicker5.Value.ToString("yyyy-MM-dd");
                string sickEnd = dateTimePicker6.Value.ToString("yyyy-MM-dd");

                string selectQuery = $"SELECT employee_id FROM employees WHERE firstname = '{firstname}' AND lastname = '{lastname}'";

                MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn);                 
                object result = selectCommand.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int empl_id))
                {
                    string insertQuery = $"INSERT INTO standbytable (employee_id, VacationFrom, VacationEnd, CovidFrom, CovidEnd, SickFrom, SickEnd) " +
                                         $"VALUES ('{empl_id}', '{vacationFrom}', '{vacationEnd}', '{covidFrom}', '{covidEnd}', '{sickFrom}', '{sickEnd}')";

                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn);
                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Τα Δεδομένα Αποθηκεύτηκαν Επιτυχώς.");
                  
                }
                else
                {
                    MessageBox.Show("Error: Τα Δεδομένα Δεν Αποθηκεύτηκαν Επιτυχώς.");
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Τα Δεδομένα Δεν Εισήχθησαν." + ex.Message);
            }
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
            this.Hide();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StandByEdit standByEdit = new StandByEdit();
            standByEdit.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectString = null;

                ConnectString = "datasource = localhost; username = root; password =; database = taxi_app";
                MySqlConnection conn = new MySqlConnection(ConnectString);
                conn.Open();
                
                string startDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string endDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                string sql = $"SELECT s.id, s.employee_id, emp.firstname, emp.lastname, s.VacationFrom, s.VacationEnd, DATEDIFF(s.VacationEnd, s.VacationFrom) AS DaysOff," +
                             $"s.CovidFrom, s.CovidEnd, DATEDIFF(s.CovidEnd, s.CovidFrom) AS CovidOff, s.SickFrom, s.SickEnd, DATEDIFF(s.SickEnd, s.SickFrom) AS SickOff," +
                             $"DATEDIFF(s.VacationEnd, s.VacationFrom) + DATEDIFF(s.CovidEnd, s.CovidFrom) + DATEDIFF(s.SickEnd, s.SickFrom) AS total_DaysOff " +
                             $"FROM standbytable s JOIN employees emp ON s.employee_id = emp.employee_id WHERE s.VacationFrom >= @startDate AND s.VacationEnd <= @endDate";

                MySqlCommand command = new MySqlCommand(sql, conn);
           
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

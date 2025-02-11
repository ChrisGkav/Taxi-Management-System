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
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class ExpensesCal : Form
    {
        public ExpensesCal()
        {
            InitializeComponent();
            try
            {
                string ConnectString = null;
                MySqlConnection conn;
                MySqlCommand command;

                string sql = $"SELECT number_plate, taxi_brand, taxi_model FROM taxi";
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
                    comboBox1.Items.Add(dr["taxi_brand"].ToString() + " " + dr["taxi_model"].ToString() + " " + dr["number_plate"].ToString());
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

        private void ExpensesCal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectString = null;
                ConnectString = "datasource = localhost; username = root; password =; database = taxi_app";
                MySqlConnection conn = new MySqlConnection(ConnectString);
                conn.Open();

                string fullname = comboBox1.SelectedItem.ToString();
                string[] nameParts = fullname.Split(' ');
                string taxi_brand = nameParts[0];
                string taxi_model = nameParts[1];
                string number_plate = nameParts[2];

                string expenses = textBox2.Text;
                string kteo = textBox3.Text;
                string driver1 = textBox4.Text;
                string driver2 = textBox1.Text;
                string enoikio = textBox7.Text;
                string kteoDate = dateTimePicker3.Value.ToString("yyyy-MM-dd");
                string asfalDate = dateTimePicker4.Value.ToString("yyyy-MM-dd");
                string date = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                string selectQuery = $"SELECT taxi_id FROM taxi WHERE number_plate = '{number_plate}'";

                MySqlCommand selectCommand = new MySqlCommand(selectQuery, conn);
                object result = selectCommand.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int taxiId))
                {
                    string insertQuery = $"INSERT INTO taxiexpenses (taxi_id, VehicleExp, Kteo, driver1, KteoDate, insurance, driver2, enoikio, date) " +
                                         $"VALUES ('{taxiId}', '{expenses}', '{kteo}', '{driver1}', '{kteoDate}', '{asfalDate}', '{driver2}', '{enoikio}', '{date}')";

                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn);
                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Τα Δεδομένα Αποθηκεύτηκαν Επιτυχώς.");

                    string updateQuery1 = "UPDATE taxiexpenses SET sunolo_exp = VehicleExp + Kteo + enoikio - driver1 - driver2";
                    MySqlCommand updateCommand1 = new MySqlCommand(updateQuery1, conn);
                    updateCommand1.ExecuteNonQuery();

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditExpensesCal editExpensesCal = new EditExpensesCal();
            editExpensesCal.Show();
            this.Close();
        }

        private void dateTimePicker6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
                string startDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                
                string sql = "SELECT taxi.*, taxiexpenses.VehicleExp, taxiexpenses.Kteo, taxiexpenses.driver1, taxiexpenses.KteoDate, taxiexpenses.insurance, taxiexpenses.driver2, taxiexpenses.enoikio, taxiexpenses.date " +
                             "FROM taxi " +
                             "LEFT JOIN taxiexpenses ON taxi.taxi_id = taxiexpenses.taxi_id " +
                             "WHERE number_plate LIKE @numberPlateSearch AND taxiexpenses.date = @startDate";

                MySqlCommand command = new MySqlCommand(sql, conn);

                command.Parameters.AddWithValue("@numberPlateSearch", "%" + numberPlateSearch + "%");
                command.Parameters.AddWithValue("@startDate", startDate);
                
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

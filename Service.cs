using MySql.Data.MySqlClient;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Service : Form
    {
        public Service()
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
                    comboBox1.Items.Add(dr["number_plate"].ToString() + " " + dr["taxi_brand"].ToString() + " " + dr["taxi_model"].ToString());
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
            this.Hide();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullname = comboBox1.SelectedItem.ToString();
            string[] nameParts = fullname.Split(' ');
            string numberplate = nameParts[0];
            string taxibrand = nameParts[1];
            string taximodel = nameParts[2];

            string comment = textBox1.Text;
            string price = textBox3.Text;
            string service_date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            string ConnectString = null;
            MySqlConnection conn;
            MySqlCommand command;
            ConnectString = "datasource = localhost; username = root; password =; database = taxi_app";
            conn = new MySqlConnection(ConnectString);
            conn.Open();

            string sql = $"SELECT taxi_id FROM taxi WHERE number_plate = '{numberplate}';";
            command = new MySqlCommand(sql, conn);

            object result = command.ExecuteScalar();
            int taxiId;

            if (result != null && int.TryParse(result.ToString(), out taxiId))
            {
                string insertQuery = $"INSERT INTO service (taxi_id, number_plate, taxi_brand, taxi_model, comment, price, service_date) " +
                                     $"VALUES ({taxiId}, '{numberplate}', '{taxibrand}', '{taximodel}', '{comment}', '{price}', '{service_date}')";
                MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn);
                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Τα Δεδομένα Αποθηκεύτηκαν Επιτυχώς.");
            }
            else
            {
                MessageBox.Show("Error: Επιλέχθηκε Λάθος Ταξί.");
            }

            command.Dispose();
            conn.Close();

        }

        private void button4_Click(object sender, EventArgs e)
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditService editserv = new EditService();
            editserv.Show();
            this.Close();
        }

        private void Service_Load(object sender, EventArgs e)
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
                string startDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                string sql = "SELECT * FROM service WHERE number_plate LIKE @numberPlateSearch AND service_date = @startDate";
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

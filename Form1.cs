using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private DateTime expirationDate = new DateTime(2300, 12, 12, 23, 59, 59);
        private Timer expirationTimer;

        public Form1()
        {
            InitializeComponent();
            CheckExpirationDate();
            InitializeExpirationTimer();
        }

        private void InitializeExpirationTimer()
        {
            expirationTimer = new Timer();
            expirationTimer.Interval = 10000; // Check every 10 Sec (10000 milliseconds)
            expirationTimer.Tick += ExpirationTimer_Tick;
            expirationTimer.Start();
        }

        private void ExpirationTimer_Tick(object sender, EventArgs e)
        {
            CheckExpirationDate();
        }

        private void CheckExpirationDate()
        {
            // Get Greece local time
            TimeZoneInfo greeceTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GTB Standard Time");
            DateTime currentTimeInGreece = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, greeceTimeZone);

            if (currentTimeInGreece > expirationDate)
            {
                MessageBox.Show("Η εφαρμογή έχει λήξει και θα τερματιστεί τώρα.", "Τερματισμός Εφαρμογής", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CloseApplication();
            }
        }

        private void CloseApplication() { 
        
            Application.Exit();
            Environment.Exit(0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnection();
            TaxiDrivers taxiDrivers = new TaxiDrivers();
            taxiDrivers.Show();

        }

        private void DBConnection()
        {
            string ConnectString = "datasource = localhost; username= root; password=; database = taxi_app";
            MySqlConnection conn = new MySqlConnection(ConnectString);
            try
            {
                conn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Database Not Connected" + ex.Message);
            }
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculate calculate = new Calculate();
            calculate.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExpensesCal expensescal = new ExpensesCal();
            expensescal.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StandBy standBy = new StandBy();
            standBy.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.Show();
        }
    }
}
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

namespace JKMParkingSystem
{
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
            timer1.Start();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //getting the time and time of parking in
            MilitaryTimeIN.Text = DateTime.Now.ToString("HH:mm");
            Time3.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToLongDateString();
            // making of string query for database connection

            string connectionString = "Server=127.0.0.1; database=car_monitoring; UID=riodan; password=zyroalphabet; SslMode = none";
                //query to insert to database
                string query = "INSERT INTO information(`car_entry_id`,`car_driver`, `car_platenumber`, `car_type`, `Date`, `TimeIN`, `MilitaryTimeIN`, `Status`) VALUES (NULL, '" + Driver.Text + "', '" + PlateNumber.Text + "', '" + CarType.Text + "', '" + Date.Text + "', '" + Time3.Text + "', '" + MilitaryTimeIN.Text + "', '" + Status.Text + "')";

                //this is to prepare and initiate the database connection
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
            if (MessageBox.Show("Do You Want To Add? "+"\n Driver's Name: \t "+Driver.Text +"\n With PlateNumber: \t "+ PlateNumber.Text +"\n Car Type: \t "+ CarType.Text, "AddCar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Driver.Text != "" && PlateNumber.Text != "" && CarType.Text != "")
                {


                    try
                    {
                        //adding of cars in the parking area
                        databaseConnection.Open();
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        MessageBox.Show(Driver.Text +" "+ PlateNumber.Text +" "+ CarType.Text + " was added to park list");
                        View View = new View();
                        this.Hide();
                        View.Show();
                        databaseConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);

                    }
                }
                else
                {
                    MessageBox.Show("Please Fill Up All The Fields");
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.Time.Text = datetime.ToString();
        }

        private void AddCar_Load(object sender, EventArgs e)
        {
            
        }
    }
}

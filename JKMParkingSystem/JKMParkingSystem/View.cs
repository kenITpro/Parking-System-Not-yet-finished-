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
using System.Data.Odbc;

namespace JKMParkingSystem
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void View_Load(object sender, EventArgs e)
        {
            //prepare and initiate the connection to the database
            MySqlConnection connection = new MySqlConnection("Server=127.0.0.1; database=car_monitoring; UID=root; password=; SslMode = none");
            //query to select all the cars in the database that are active in parking space
            connection.Open();
            string query = "Select `car_entry_id`,`car_driver`, `car_platenumber`, `car_type` from information where Status = 1";
            MySqlDataAdapter MSDA = new MySqlDataAdapter(query, connection);
            //show to the table the retrive data
            DataTable table = new DataTable();
            MSDA.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }
       


        private void button1_Click(object sender, EventArgs e)
        {
            //go back to the main menu
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //connect to the database 
            MySqlConnection connection = new MySqlConnection("Server=127.0.0.1; database=car_monitoring; UID=riodan; password=zyroalphabet; SslMode = none");
            MySqlCommand cmd;
            //create a command 
            string query = "SELECT COUNT(car_entry_id)FROM information WHERE Status = 1"; 
            try
            {
                connection.Open();               
                cmd = new MySqlCommand(query, connection);
                //read from db 
                label3.Text = "out of 100 free space";
                Int32 rows_count = 100 - Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose(); connection.Close();
                //Display data on the page 
                label2.Text = rows_count.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
               if (connection.State == ConnectionState.Open) { connection.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.Time.Text = datetime.ToString();
        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            timer1.Start();
        }
        //this is to connect to database
        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1; database=car_monitoring; UID=riodan; password=zyroalphabet; SslMode = none");
        private void button1_Click(object sender, EventArgs e)
        {
            //this button is to search for the text in the textbox
            connection.Open();
            string query = "Select `car_entry_id`,`car_driver`, `car_platenumber`, `car_type` from information where car_platenumber OR car_driver LIKE '%" + textBox1.Text + "%'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable table = new DataTable();
 
                SDA.Fill(table);
                dataGridView1.DataSource = table;
                connection.Close();
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this is to go back to main menu
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.Time.Text = datetime.ToString();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }
    }
}

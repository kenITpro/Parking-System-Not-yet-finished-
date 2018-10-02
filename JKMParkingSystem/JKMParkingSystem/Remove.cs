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
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
            timer1.Start();
            this.Refresh();

        }
        //this is to connect to database
        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1; database=car_monitoring; UID=root; password=; SslMode = none");
        private void button2_Click(object sender, EventArgs e)
        {
            //this is to show the car park in the premises
            connection.Open();
            string query = "Select `car_entry_id`,`car_driver`, `car_platenumber`, `car_type`, `MilitaryTimeIN` from information where car_platenumber LIKE '%" + textBox1.Text + "%' and status = 1";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            SDA.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get the MilitaryTimeIN
            connection.Open();
            string query2 = "Select `MilitaryTimeIN` from information where car_platenumber LIKE '%" + textBox1.Text + "%' and status = 1";
            MySqlCommand com = new MySqlCommand(query2, connection);
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            MilitaryTimeIN.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString(); //reader["MilitaryTimeIN"].ToString();
            

            //getting the time of out
            MilitaryTimeOUT.Text = DateTime.Now.ToString("HH:mm");
            Time2.Text = DateTime.Now.ToLongTimeString();


            //computation of time consume
            DateTime startTime = Convert.ToDateTime(MilitaryTimeIN.Text);
            DateTime endtime = Convert.ToDateTime(MilitaryTimeOUT.Text);
            TimeSpan duration = endtime - startTime;
            TimeConsume.Text = duration.ToString();

            //COMPUTATION OF PAYMENTS
            String payment1 = (Convert.ToDecimal(duration.TotalHours*30).ToString("#.00"));            
            double payment = double.Parse(payment1);
            label3.Text = payment.ToString();

            if (payment <= 30)
            {
                Payment.Text = "30.00";
            }
            else if(payment <= 40)
            {
                Payment.Text = "45.00";
            }
            else if (payment <= 50)
            {
                Payment.Text = "60.00";
            }
            else if (payment <= 60)
            {
                Payment.Text = "75.00";
            }
            else if (payment <= 70)
            {
                Payment.Text = "90.00";
            }else
            {
                Payment.Text = "100.00";
            }
            connection.Close();


            //this is to delete the existing car in the premises
            connection.Open();            
            string query = "Update information Set Status ='0', TimeOUT ='" + Time2.Text + "', MilitaryTimeOUT ='" + MilitaryTimeOUT.Text + "', TimeSpan ='" + TimeConsume.Text + "', Payment ='" + Payment.Text + "' where car_platenumber = '" + status2.Text+"'";            
            MySqlDataAdapter MSDA = new MySqlDataAdapter(query, connection);
            DataTable table = new DataTable();

            if (status2.Text == "")
            {
                MessageBox.Show("Please DoubleClick the Car that You Want to Remove");
                connection.Close();
            }
            else
            {
                //this is the message box that prompt to remove a car
                if (

                MessageBox.Show("Remove Client? \n " + "\n Driver's Name:\t " + Driver.Text + "\n With PlateNumber:\t " + PlateNumber.Text + "\n Car Type: \t " + CarType.Text, "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    MSDA.Fill(table);
                    dataGridView1.DataSource = table;
                    MessageBox.Show("Car With PlateNumber: " + status2.Text + " has exited.. Thank You For Using Our Parking");
                    connection.Close();
                    
                }
                connection.Close();
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (status2.Text != null)
            {
                //this is to get the information of the car 
                status2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                Driver.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                PlateNumber.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                CarType.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                //Time2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("no car was selected");
            }
            
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // this is to go back to main menu
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }

        private void Remove_Load(object sender, EventArgs e)
        {
            if (status2.Text != null)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }


        }

        private void status2_Click(object sender, EventArgs e)
        {

        }
        //This is to get the realtime and date
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.Time.Text = datetime.ToString();
        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

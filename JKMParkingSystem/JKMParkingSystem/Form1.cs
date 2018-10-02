using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JKMParkingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            //puta military time nakuha ko din
            label2.Text = DateTime.Now.ToString("HH:mm"); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // go to search
            Search Search = new Search();
            this.Hide();
            Search.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //go to view
            View View = new View();
            this.Hide();
            View.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //go to add car
            AddCar AddCar = new AddCar();
            this.Hide();
            AddCar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //go to remove
            Remove Remove = new Remove();
            this.Hide();
            Remove.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.Time.Text = datetime.ToString();
        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
   
}

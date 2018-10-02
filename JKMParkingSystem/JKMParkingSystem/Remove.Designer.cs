namespace JKMParkingSystem
{
    partial class Remove
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.status2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Driver = new System.Windows.Forms.Label();
            this.CarType = new System.Windows.Forms.Label();
            this.PlateNumber = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Time = new System.Windows.Forms.Label();
            this.Time2 = new System.Windows.Forms.Label();
            this.MilitaryTimeOUT = new System.Windows.Forms.Label();
            this.TimeConsume = new System.Windows.Forms.Label();
            this.MilitaryTimeIN = new System.Windows.Forms.Label();
            this.Payment = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Sketch Block", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(365, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "REMOVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(434, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.textBox1.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(138, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sketch Block", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Remove Car";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(345, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "SEARCH";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Lime;
            this.button3.Location = new System.Drawing.Point(6, 557);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 25);
            this.button3.TabIndex = 5;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // status2
            // 
            this.status2.AutoSize = true;
            this.status2.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status2.ForeColor = System.Drawing.Color.Lime;
            this.status2.Location = new System.Drawing.Point(280, 405);
            this.status2.Name = "status2";
            this.status2.Size = new System.Drawing.Size(36, 20);
            this.status2.TabIndex = 7;
            this.status2.Text = "???";
            this.status2.Visible = false;
            this.status2.Click += new System.EventHandler(this.status2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Remove Car w/ PlateNo:";
            this.label2.Visible = false;
            // 
            // Driver
            // 
            this.Driver.AutoSize = true;
            this.Driver.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Driver.ForeColor = System.Drawing.Color.Lime;
            this.Driver.Location = new System.Drawing.Point(280, 345);
            this.Driver.Name = "Driver";
            this.Driver.Size = new System.Drawing.Size(36, 20);
            this.Driver.TabIndex = 9;
            this.Driver.Text = "???";
            // 
            // CarType
            // 
            this.CarType.AutoSize = true;
            this.CarType.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarType.ForeColor = System.Drawing.Color.Lime;
            this.CarType.Location = new System.Drawing.Point(280, 385);
            this.CarType.Name = "CarType";
            this.CarType.Size = new System.Drawing.Size(36, 20);
            this.CarType.TabIndex = 10;
            this.CarType.Text = "???";
            // 
            // PlateNumber
            // 
            this.PlateNumber.AutoSize = true;
            this.PlateNumber.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlateNumber.ForeColor = System.Drawing.Color.Lime;
            this.PlateNumber.Location = new System.Drawing.Point(280, 365);
            this.PlateNumber.Name = "PlateNumber";
            this.PlateNumber.Size = new System.Drawing.Size(36, 20);
            this.PlateNumber.TabIndex = 11;
            this.PlateNumber.Text = "???";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Sketch Block", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(110, 49);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(85, 29);
            this.Time.TabIndex = 12;
            this.Time.Text = "Time:";
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // Time2
            // 
            this.Time2.AutoSize = true;
            this.Time2.Location = new System.Drawing.Point(204, 570);
            this.Time2.Name = "Time2";
            this.Time2.Size = new System.Drawing.Size(39, 13);
            this.Time2.TabIndex = 13;
            this.Time2.Text = "Time2:";
            this.Time2.Visible = false;
            // 
            // MilitaryTimeOUT
            // 
            this.MilitaryTimeOUT.AutoSize = true;
            this.MilitaryTimeOUT.Location = new System.Drawing.Point(170, 557);
            this.MilitaryTimeOUT.Name = "MilitaryTimeOUT";
            this.MilitaryTimeOUT.Size = new System.Drawing.Size(85, 13);
            this.MilitaryTimeOUT.TabIndex = 14;
            this.MilitaryTimeOUT.Text = "MilitaryTimeOUT";
            this.MilitaryTimeOUT.Visible = false;
            // 
            // TimeConsume
            // 
            this.TimeConsume.AutoSize = true;
            this.TimeConsume.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeConsume.ForeColor = System.Drawing.Color.Lime;
            this.TimeConsume.Location = new System.Drawing.Point(281, 478);
            this.TimeConsume.Name = "TimeConsume";
            this.TimeConsume.Size = new System.Drawing.Size(36, 20);
            this.TimeConsume.TabIndex = 15;
            this.TimeConsume.Text = "???";
            // 
            // MilitaryTimeIN
            // 
            this.MilitaryTimeIN.AutoSize = true;
            this.MilitaryTimeIN.Location = new System.Drawing.Point(170, 544);
            this.MilitaryTimeIN.Name = "MilitaryTimeIN";
            this.MilitaryTimeIN.Size = new System.Drawing.Size(73, 13);
            this.MilitaryTimeIN.TabIndex = 16;
            this.MilitaryTimeIN.Text = "MilitaryTimeIN";
            this.MilitaryTimeIN.Visible = false;
            // 
            // Payment
            // 
            this.Payment.AutoSize = true;
            this.Payment.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment.ForeColor = System.Drawing.Color.Lime;
            this.Payment.Location = new System.Drawing.Point(281, 503);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(36, 20);
            this.Payment.TabIndex = 17;
            this.Payment.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "PlateNumber:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(7, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Driver\'s Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(7, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Car Plate No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(7, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Car Class Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(7, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Details:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(7, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Payment:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(7, 478);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Time Consume:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(7, 503);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Amount:";
            // 
            // Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(456, 594);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.MilitaryTimeIN);
            this.Controls.Add(this.TimeConsume);
            this.Controls.Add(this.MilitaryTimeOUT);
            this.Controls.Add(this.Time2);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.PlateNumber);
            this.Controls.Add(this.CarType);
            this.Controls.Add(this.Driver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.status2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Remove";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove";
            this.Load += new System.EventHandler(this.Remove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label status2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Driver;
        private System.Windows.Forms.Label CarType;
        private System.Windows.Forms.Label PlateNumber;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Time2;
        private System.Windows.Forms.Label MilitaryTimeOUT;
        private System.Windows.Forms.Label TimeConsume;
        private System.Windows.Forms.Label MilitaryTimeIN;
        private System.Windows.Forms.Label Payment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
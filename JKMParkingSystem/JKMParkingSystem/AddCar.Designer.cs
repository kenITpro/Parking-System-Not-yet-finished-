namespace JKMParkingSystem
{
    partial class AddCar
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
            this.Driver = new System.Windows.Forms.TextBox();
            this.PlateNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.CarType = new System.Windows.Forms.ComboBox();
            this.Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Time3 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.MilitaryTimeIN = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Driver
            // 
            this.Driver.BackColor = System.Drawing.Color.DimGray;
            this.Driver.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Driver.ForeColor = System.Drawing.Color.Lime;
            this.Driver.Location = new System.Drawing.Point(60, 138);
            this.Driver.Name = "Driver";
            this.Driver.Size = new System.Drawing.Size(169, 26);
            this.Driver.TabIndex = 0;
            // 
            // PlateNumber
            // 
            this.PlateNumber.BackColor = System.Drawing.Color.DimGray;
            this.PlateNumber.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlateNumber.ForeColor = System.Drawing.Color.Lime;
            this.PlateNumber.Location = new System.Drawing.Point(60, 190);
            this.PlateNumber.Name = "PlateNumber";
            this.PlateNumber.Size = new System.Drawing.Size(169, 26);
            this.PlateNumber.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(214, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(81, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Driver\'s Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(81, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "PlateNumber:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(97, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Car Type:";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(148, 320);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(13, 13);
            this.Status.TabIndex = 7;
            this.Status.Text = "1";
            this.Status.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(12, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 25);
            this.button2.TabIndex = 8;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CarType
            // 
            this.CarType.BackColor = System.Drawing.Color.DimGray;
            this.CarType.Font = new System.Drawing.Font("Sketch Block", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarType.ForeColor = System.Drawing.Color.Lime;
            this.CarType.FormattingEnabled = true;
            this.CarType.Items.AddRange(new object[] {
            "Class A",
            "Class B",
            "Class C"});
            this.CarType.Location = new System.Drawing.Point(85, 242);
            this.CarType.Name = "CarType";
            this.CarType.Size = new System.Drawing.Size(134, 28);
            this.CarType.TabIndex = 9;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Sketch Block", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.Lime;
            this.Time.Location = new System.Drawing.Point(31, 57);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(85, 29);
            this.Time.TabIndex = 10;
            this.Time.Text = "Time:";
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Time3
            // 
            this.Time3.AutoSize = true;
            this.Time3.Location = new System.Drawing.Point(119, 320);
            this.Time3.Name = "Time3";
            this.Time3.Size = new System.Drawing.Size(30, 13);
            this.Time3.TabIndex = 11;
            this.Time3.Text = "Time";
            this.Time3.Visible = false;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(162, 320);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 13);
            this.Date.TabIndex = 12;
            this.Date.Text = "Date";
            this.Date.Visible = false;
            // 
            // MilitaryTimeIN
            // 
            this.MilitaryTimeIN.AutoSize = true;
            this.MilitaryTimeIN.Location = new System.Drawing.Point(119, 307);
            this.MilitaryTimeIN.Name = "MilitaryTimeIN";
            this.MilitaryTimeIN.Size = new System.Drawing.Size(73, 13);
            this.MilitaryTimeIN.TabIndex = 13;
            this.MilitaryTimeIN.Text = "MilitaryTimeIN";
            this.MilitaryTimeIN.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sketch Block", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(79, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 33);
            this.label4.TabIndex = 14;
            this.label4.Text = "Add Cars";
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(306, 345);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MilitaryTimeIN);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Time3);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.CarType);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlateNumber);
            this.Controls.Add(this.Driver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddCar";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCar";
            this.Load += new System.EventHandler(this.AddCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Driver;
        private System.Windows.Forms.TextBox PlateNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CarType;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Time3;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label MilitaryTimeIN;
        private System.Windows.Forms.Label label4;
    }
}
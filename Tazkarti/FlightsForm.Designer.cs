namespace Tazkarti
{
    partial class FlightsForm
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
            this.btn_insertFlight = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_insertFlight = new System.Windows.Forms.TabPage();
            this.dtpkr_FlightArrTime = new System.Windows.Forms.DateTimePicker();
            this.dtpkr_FlightDepTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_flightAirplane = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_flightCompany = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_flightPrice = new System.Windows.Forms.TextBox();
            this.txt_flightDep = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_flightSeats = new System.Windows.Forms.TextBox();
            this.txt_flightDest = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tab_updateFlight = new System.Windows.Forms.TabPage();
            this.lbl_flightDelete = new System.Windows.Forms.Label();
            this.lbl_flightEdit = new System.Windows.Forms.Label();
            this.pnl_updateFlight = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txt_flightDestUpd = new System.Windows.Forms.TextBox();
            this.txt_flightTotSeatsUpd = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.btn_updateFlight = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.txt_flightPriceUpd = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txt_flightDepUpd = new System.Windows.Forms.TextBox();
            this.dtpkr_flightArrUpd = new System.Windows.Forms.DateTimePicker();
            this.txt_flightAvaSeatsUpd = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.dtpkr_flightDepUpd = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_flightCompanyUpd = new System.Windows.Forms.TextBox();
            this.txt_flightAirplaneUpd = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txt_flightFlightUpd = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_flightBack = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label39 = new System.Windows.Forms.Label();
            this.btn_flightsShowReport = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_insertFlight.SuspendLayout();
            this.tab_updateFlight.SuspendLayout();
            this.pnl_updateFlight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_insertFlight
            // 
            this.btn_insertFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(100)))), ((int)(((byte)(88)))));
            this.btn_insertFlight.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertFlight.Location = new System.Drawing.Point(558, 274);
            this.btn_insertFlight.Name = "btn_insertFlight";
            this.btn_insertFlight.Size = new System.Drawing.Size(146, 53);
            this.btn_insertFlight.TabIndex = 85;
            this.btn_insertFlight.Text = "INSERT";
            this.btn_insertFlight.UseVisualStyleBackColor = false;
            this.btn_insertFlight.Click += new System.EventHandler(this.btn_insertFlight_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_insertFlight);
            this.tabControl1.Controls.Add(this.tab_updateFlight);
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(71, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 402);
            this.tabControl1.TabIndex = 88;
            // 
            // tab_insertFlight
            // 
            this.tab_insertFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.tab_insertFlight.Controls.Add(this.dtpkr_FlightArrTime);
            this.tab_insertFlight.Controls.Add(this.btn_insertFlight);
            this.tab_insertFlight.Controls.Add(this.dtpkr_FlightDepTime);
            this.tab_insertFlight.Controls.Add(this.label7);
            this.tab_insertFlight.Controls.Add(this.label8);
            this.tab_insertFlight.Controls.Add(this.label9);
            this.tab_insertFlight.Controls.Add(this.label10);
            this.tab_insertFlight.Controls.Add(this.txt_flightAirplane);
            this.tab_insertFlight.Controls.Add(this.label15);
            this.tab_insertFlight.Controls.Add(this.label16);
            this.tab_insertFlight.Controls.Add(this.label17);
            this.tab_insertFlight.Controls.Add(this.txt_flightCompany);
            this.tab_insertFlight.Controls.Add(this.label18);
            this.tab_insertFlight.Controls.Add(this.label6);
            this.tab_insertFlight.Controls.Add(this.label4);
            this.tab_insertFlight.Controls.Add(this.label3);
            this.tab_insertFlight.Controls.Add(this.label5);
            this.tab_insertFlight.Controls.Add(this.txt_flightPrice);
            this.tab_insertFlight.Controls.Add(this.txt_flightDep);
            this.tab_insertFlight.Controls.Add(this.label14);
            this.tab_insertFlight.Controls.Add(this.label11);
            this.tab_insertFlight.Controls.Add(this.label13);
            this.tab_insertFlight.Controls.Add(this.txt_flightSeats);
            this.tab_insertFlight.Controls.Add(this.txt_flightDest);
            this.tab_insertFlight.Controls.Add(this.label12);
            this.tab_insertFlight.Location = new System.Drawing.Point(4, 32);
            this.tab_insertFlight.Name = "tab_insertFlight";
            this.tab_insertFlight.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_insertFlight.Size = new System.Drawing.Size(768, 366);
            this.tab_insertFlight.TabIndex = 0;
            this.tab_insertFlight.Text = "Insert Flight";
            // 
            // dtpkr_FlightArrTime
            // 
            this.dtpkr_FlightArrTime.CalendarFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkr_FlightArrTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkr_FlightArrTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkr_FlightArrTime.Location = new System.Drawing.Point(520, 104);
            this.dtpkr_FlightArrTime.Name = "dtpkr_FlightArrTime";
            this.dtpkr_FlightArrTime.Size = new System.Drawing.Size(183, 30);
            this.dtpkr_FlightArrTime.TabIndex = 132;
            // 
            // dtpkr_FlightDepTime
            // 
            this.dtpkr_FlightDepTime.CalendarFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkr_FlightDepTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkr_FlightDepTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkr_FlightDepTime.Location = new System.Drawing.Point(520, 55);
            this.dtpkr_FlightDepTime.Name = "dtpkr_FlightDepTime";
            this.dtpkr_FlightDepTime.Size = new System.Drawing.Size(183, 30);
            this.dtpkr_FlightDepTime.TabIndex = 131;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(501, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 23);
            this.label7.TabIndex = 130;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(501, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 23);
            this.label8.TabIndex = 129;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(501, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 23);
            this.label9.TabIndex = 128;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(501, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 23);
            this.label10.TabIndex = 121;
            this.label10.Text = "*";
            // 
            // txt_flightAirplane
            // 
            this.txt_flightAirplane.Location = new System.Drawing.Point(520, 203);
            this.txt_flightAirplane.Multiline = true;
            this.txt_flightAirplane.Name = "txt_flightAirplane";
            this.txt_flightAirplane.Size = new System.Drawing.Size(184, 30);
            this.txt_flightAirplane.TabIndex = 127;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(381, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 23);
            this.label15.TabIndex = 123;
            this.label15.Text = "Company Name:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(387, 204);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 23);
            this.label16.TabIndex = 126;
            this.label16.Text = "Airplane ID:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(373, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(131, 23);
            this.label17.TabIndex = 122;
            this.label17.Text = "Departure Time:";
            // 
            // txt_flightCompany
            // 
            this.txt_flightCompany.Location = new System.Drawing.Point(520, 155);
            this.txt_flightCompany.Multiline = true;
            this.txt_flightCompany.Name = "txt_flightCompany";
            this.txt_flightCompany.Size = new System.Drawing.Size(184, 30);
            this.txt_flightCompany.TabIndex = 124;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(387, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 23);
            this.label18.TabIndex = 125;
            this.label18.Text = "Arrival Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(151, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 23);
            this.label6.TabIndex = 120;
            this.label6.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(151, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 23);
            this.label4.TabIndex = 119;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(151, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 23);
            this.label3.TabIndex = 118;
            this.label3.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(151, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 23);
            this.label5.TabIndex = 109;
            this.label5.Text = "*";
            // 
            // txt_flightPrice
            // 
            this.txt_flightPrice.Location = new System.Drawing.Point(170, 200);
            this.txt_flightPrice.Multiline = true;
            this.txt_flightPrice.Name = "txt_flightPrice";
            this.txt_flightPrice.Size = new System.Drawing.Size(184, 30);
            this.txt_flightPrice.TabIndex = 117;
            // 
            // txt_flightDep
            // 
            this.txt_flightDep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_flightDep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_flightDep.Location = new System.Drawing.Point(170, 52);
            this.txt_flightDep.Multiline = true;
            this.txt_flightDep.Name = "txt_flightDep";
            this.txt_flightDep.Size = new System.Drawing.Size(184, 30);
            this.txt_flightDep.TabIndex = 112;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(39, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 111;
            this.label14.Text = "Total Seats:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(60, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 23);
            this.label11.TabIndex = 116;
            this.label11.Text = "Price:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(47, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 23);
            this.label13.TabIndex = 110;
            this.label13.Text = "Departure:";
            // 
            // txt_flightSeats
            // 
            this.txt_flightSeats.Location = new System.Drawing.Point(170, 152);
            this.txt_flightSeats.Multiline = true;
            this.txt_flightSeats.Name = "txt_flightSeats";
            this.txt_flightSeats.Size = new System.Drawing.Size(184, 30);
            this.txt_flightSeats.TabIndex = 113;
            // 
            // txt_flightDest
            // 
            this.txt_flightDest.Location = new System.Drawing.Point(170, 101);
            this.txt_flightDest.Multiline = true;
            this.txt_flightDest.Name = "txt_flightDest";
            this.txt_flightDest.Size = new System.Drawing.Size(184, 30);
            this.txt_flightDest.TabIndex = 115;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(40, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 23);
            this.label12.TabIndex = 114;
            this.label12.Text = "Destination:";
            // 
            // tab_updateFlight
            // 
            this.tab_updateFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.tab_updateFlight.Controls.Add(this.lbl_flightDelete);
            this.tab_updateFlight.Controls.Add(this.lbl_flightEdit);
            this.tab_updateFlight.Controls.Add(this.pnl_updateFlight);
            this.tab_updateFlight.Controls.Add(this.label33);
            this.tab_updateFlight.Controls.Add(this.txt_flightFlightUpd);
            this.tab_updateFlight.Controls.Add(this.label34);
            this.tab_updateFlight.Location = new System.Drawing.Point(4, 32);
            this.tab_updateFlight.Name = "tab_updateFlight";
            this.tab_updateFlight.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_updateFlight.Size = new System.Drawing.Size(768, 366);
            this.tab_updateFlight.TabIndex = 1;
            this.tab_updateFlight.Text = "Update/Delete Flight";
            // 
            // lbl_flightDelete
            // 
            this.lbl_flightDelete.Image = global::Tazkarti.Properties.Resources.delete;
            this.lbl_flightDelete.Location = new System.Drawing.Point(267, 56);
            this.lbl_flightDelete.Name = "lbl_flightDelete";
            this.lbl_flightDelete.Size = new System.Drawing.Size(30, 29);
            this.lbl_flightDelete.TabIndex = 166;
            this.lbl_flightDelete.Click += new System.EventHandler(this.lbl_flightDelete_Click);
            // 
            // lbl_flightEdit
            // 
            this.lbl_flightEdit.Image = global::Tazkarti.Properties.Resources.edit;
            this.lbl_flightEdit.Location = new System.Drawing.Point(234, 56);
            this.lbl_flightEdit.Name = "lbl_flightEdit";
            this.lbl_flightEdit.Size = new System.Drawing.Size(30, 29);
            this.lbl_flightEdit.TabIndex = 165;
            this.lbl_flightEdit.Click += new System.EventHandler(this.lbl_flightEdit_Click);
            // 
            // pnl_updateFlight
            // 
            this.pnl_updateFlight.Controls.Add(this.label31);
            this.pnl_updateFlight.Controls.Add(this.label32);
            this.pnl_updateFlight.Controls.Add(this.txt_flightDestUpd);
            this.pnl_updateFlight.Controls.Add(this.txt_flightTotSeatsUpd);
            this.pnl_updateFlight.Controls.Add(this.label35);
            this.pnl_updateFlight.Controls.Add(this.btn_updateFlight);
            this.pnl_updateFlight.Controls.Add(this.label30);
            this.pnl_updateFlight.Controls.Add(this.txt_flightPriceUpd);
            this.pnl_updateFlight.Controls.Add(this.label36);
            this.pnl_updateFlight.Controls.Add(this.label29);
            this.pnl_updateFlight.Controls.Add(this.txt_flightDepUpd);
            this.pnl_updateFlight.Controls.Add(this.dtpkr_flightArrUpd);
            this.pnl_updateFlight.Controls.Add(this.txt_flightAvaSeatsUpd);
            this.pnl_updateFlight.Controls.Add(this.label28);
            this.pnl_updateFlight.Controls.Add(this.dtpkr_flightDepUpd);
            this.pnl_updateFlight.Controls.Add(this.label27);
            this.pnl_updateFlight.Controls.Add(this.label1);
            this.pnl_updateFlight.Controls.Add(this.label26);
            this.pnl_updateFlight.Controls.Add(this.label2);
            this.pnl_updateFlight.Controls.Add(this.label25);
            this.pnl_updateFlight.Controls.Add(this.label19);
            this.pnl_updateFlight.Controls.Add(this.label24);
            this.pnl_updateFlight.Controls.Add(this.label20);
            this.pnl_updateFlight.Controls.Add(this.txt_flightCompanyUpd);
            this.pnl_updateFlight.Controls.Add(this.txt_flightAirplaneUpd);
            this.pnl_updateFlight.Controls.Add(this.label23);
            this.pnl_updateFlight.Controls.Add(this.label21);
            this.pnl_updateFlight.Controls.Add(this.label22);
            this.pnl_updateFlight.Location = new System.Drawing.Point(6, 92);
            this.pnl_updateFlight.Name = "pnl_updateFlight";
            this.pnl_updateFlight.Size = new System.Drawing.Size(756, 275);
            this.pnl_updateFlight.TabIndex = 164;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.label31.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(57, 20);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(91, 23);
            this.label31.TabIndex = 135;
            this.label31.Text = "Departure:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.label32.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(50, 69);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(98, 23);
            this.label32.TabIndex = 139;
            this.label32.Text = "Destination:";
            // 
            // txt_flightDestUpd
            // 
            this.txt_flightDestUpd.Location = new System.Drawing.Point(180, 66);
            this.txt_flightDestUpd.Multiline = true;
            this.txt_flightDestUpd.Name = "txt_flightDestUpd";
            this.txt_flightDestUpd.Size = new System.Drawing.Size(184, 30);
            this.txt_flightDestUpd.TabIndex = 140;
            // 
            // txt_flightTotSeatsUpd
            // 
            this.txt_flightTotSeatsUpd.Location = new System.Drawing.Point(180, 117);
            this.txt_flightTotSeatsUpd.Multiline = true;
            this.txt_flightTotSeatsUpd.Name = "txt_flightTotSeatsUpd";
            this.txt_flightTotSeatsUpd.Size = new System.Drawing.Size(184, 30);
            this.txt_flightTotSeatsUpd.TabIndex = 138;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Red;
            this.label35.Location = new System.Drawing.Point(161, 209);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(19, 23);
            this.label35.TabIndex = 160;
            this.label35.Text = "*";
            // 
            // btn_updateFlight
            // 
            this.btn_updateFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(100)))), ((int)(((byte)(88)))));
            this.btn_updateFlight.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateFlight.Location = new System.Drawing.Point(530, 209);
            this.btn_updateFlight.Name = "btn_updateFlight";
            this.btn_updateFlight.Size = new System.Drawing.Size(146, 53);
            this.btn_updateFlight.TabIndex = 133;
            this.btn_updateFlight.Text = "UPDATE";
            this.btn_updateFlight.UseVisualStyleBackColor = false;
            this.btn_updateFlight.Click += new System.EventHandler(this.btn_updateFlight_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.label30.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(25, 169);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(130, 23);
            this.label30.TabIndex = 141;
            this.label30.Text = "Available Seats:";
            // 
            // txt_flightPriceUpd
            // 
            this.txt_flightPriceUpd.Location = new System.Drawing.Point(180, 209);
            this.txt_flightPriceUpd.Multiline = true;
            this.txt_flightPriceUpd.Name = "txt_flightPriceUpd";
            this.txt_flightPriceUpd.Size = new System.Drawing.Size(184, 30);
            this.txt_flightPriceUpd.TabIndex = 159;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.label36.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(70, 213);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(52, 23);
            this.label36.TabIndex = 158;
            this.label36.Text = "Price:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.label29.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(49, 120);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(100, 23);
            this.label29.TabIndex = 136;
            this.label29.Text = "Total Seats:";
            // 
            // txt_flightDepUpd
            // 
            this.txt_flightDepUpd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_flightDepUpd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_flightDepUpd.Location = new System.Drawing.Point(180, 17);
            this.txt_flightDepUpd.Multiline = true;
            this.txt_flightDepUpd.Name = "txt_flightDepUpd";
            this.txt_flightDepUpd.Size = new System.Drawing.Size(184, 30);
            this.txt_flightDepUpd.TabIndex = 137;
            // 
            // dtpkr_flightArrUpd
            // 
            this.dtpkr_flightArrUpd.CalendarFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkr_flightArrUpd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkr_flightArrUpd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkr_flightArrUpd.Location = new System.Drawing.Point(530, 69);
            this.dtpkr_flightArrUpd.Name = "dtpkr_flightArrUpd";
            this.dtpkr_flightArrUpd.Size = new System.Drawing.Size(183, 30);
            this.dtpkr_flightArrUpd.TabIndex = 157;
            // 
            // txt_flightAvaSeatsUpd
            // 
            this.txt_flightAvaSeatsUpd.Location = new System.Drawing.Point(180, 165);
            this.txt_flightAvaSeatsUpd.Multiline = true;
            this.txt_flightAvaSeatsUpd.Name = "txt_flightAvaSeatsUpd";
            this.txt_flightAvaSeatsUpd.Size = new System.Drawing.Size(184, 30);
            this.txt_flightAvaSeatsUpd.TabIndex = 142;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Red;
            this.label28.Location = new System.Drawing.Point(161, 17);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(19, 23);
            this.label28.TabIndex = 134;
            this.label28.Text = "*";
            // 
            // dtpkr_flightDepUpd
            // 
            this.dtpkr_flightDepUpd.CalendarFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkr_flightDepUpd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkr_flightDepUpd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkr_flightDepUpd.Location = new System.Drawing.Point(530, 20);
            this.dtpkr_flightDepUpd.Name = "dtpkr_flightDepUpd";
            this.dtpkr_flightDepUpd.Size = new System.Drawing.Size(183, 30);
            this.dtpkr_flightDepUpd.TabIndex = 156;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(161, 165);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(19, 23);
            this.label27.TabIndex = 143;
            this.label27.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(511, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 23);
            this.label1.TabIndex = 155;
            this.label1.Text = "*";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(161, 117);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(19, 23);
            this.label26.TabIndex = 144;
            this.label26.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(511, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 23);
            this.label2.TabIndex = 154;
            this.label2.Text = "*";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(161, 66);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(19, 23);
            this.label25.TabIndex = 145;
            this.label25.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(511, 168);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 23);
            this.label19.TabIndex = 153;
            this.label19.Text = "*";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.label24.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(397, 73);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(109, 23);
            this.label24.TabIndex = 150;
            this.label24.Text = "Arrival Time:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(511, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 23);
            this.label20.TabIndex = 146;
            this.label20.Text = "*";
            // 
            // txt_flightCompanyUpd
            // 
            this.txt_flightCompanyUpd.Location = new System.Drawing.Point(530, 120);
            this.txt_flightCompanyUpd.Multiline = true;
            this.txt_flightCompanyUpd.Name = "txt_flightCompanyUpd";
            this.txt_flightCompanyUpd.Size = new System.Drawing.Size(184, 30);
            this.txt_flightCompanyUpd.TabIndex = 149;
            // 
            // txt_flightAirplaneUpd
            // 
            this.txt_flightAirplaneUpd.Location = new System.Drawing.Point(530, 168);
            this.txt_flightAirplaneUpd.Multiline = true;
            this.txt_flightAirplaneUpd.Name = "txt_flightAirplaneUpd";
            this.txt_flightAirplaneUpd.Size = new System.Drawing.Size(184, 30);
            this.txt_flightAirplaneUpd.TabIndex = 152;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.label23.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(383, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(131, 23);
            this.label23.TabIndex = 147;
            this.label23.Text = "Departure Time:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.label21.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(391, 124);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(123, 23);
            this.label21.TabIndex = 148;
            this.label21.Text = "Company Name:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.label22.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(397, 169);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(104, 23);
            this.label22.TabIndex = 151;
            this.label22.Text = "Airplane ID:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Red;
            this.label33.Location = new System.Drawing.Point(167, 56);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(19, 23);
            this.label33.TabIndex = 163;
            this.label33.Text = "*";
            // 
            // txt_flightFlightUpd
            // 
            this.txt_flightFlightUpd.Location = new System.Drawing.Point(186, 56);
            this.txt_flightFlightUpd.Multiline = true;
            this.txt_flightFlightUpd.Name = "txt_flightFlightUpd";
            this.txt_flightFlightUpd.Size = new System.Drawing.Size(43, 30);
            this.txt_flightFlightUpd.TabIndex = 162;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.label34.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(66, 57);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(84, 23);
            this.label34.TabIndex = 161;
            this.label34.Text = "Flight ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tazkarti.Properties.Resources.tayara;
            this.pictureBox1.Location = new System.Drawing.Point(870, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 198);
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_flightBack
            // 
            this.lbl_flightBack.Image = global::Tazkarti.Properties.Resources.back2;
            this.lbl_flightBack.Location = new System.Drawing.Point(12, 24);
            this.lbl_flightBack.Name = "lbl_flightBack";
            this.lbl_flightBack.Size = new System.Drawing.Size(53, 34);
            this.lbl_flightBack.TabIndex = 80;
            this.lbl_flightBack.Click += new System.EventHandler(this.lbl_flightBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 476);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1003, 267);
            this.dataGridView1.TabIndex = 89;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(137, 438);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(182, 26);
            this.label39.TabIndex = 90;
            this.label39.Text = "Flights Information";
            // 
            // btn_flightsShowReport
            // 
            this.btn_flightsShowReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(100)))), ((int)(((byte)(88)))));
            this.btn_flightsShowReport.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_flightsShowReport.Location = new System.Drawing.Point(908, 370);
            this.btn_flightsShowReport.Name = "btn_flightsShowReport";
            this.btn_flightsShowReport.Size = new System.Drawing.Size(146, 53);
            this.btn_flightsShowReport.TabIndex = 91;
            this.btn_flightsShowReport.Text = "SHOW REPORT";
            this.btn_flightsShowReport.UseVisualStyleBackColor = false;
            this.btn_flightsShowReport.Click += new System.EventHandler(this.Btn_flightsShowReport_Click);
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(1053, 777);
            this.Controls.Add(this.btn_flightsShowReport);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_flightBack);
            this.Name = "FlightsForm";
            this.Text = "FlightsForm";
            this.Load += new System.EventHandler(this.FlightsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_insertFlight.ResumeLayout(false);
            this.tab_insertFlight.PerformLayout();
            this.tab_updateFlight.ResumeLayout(false);
            this.tab_updateFlight.PerformLayout();
            this.pnl_updateFlight.ResumeLayout(false);
            this.pnl_updateFlight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_flightBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_insertFlight;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_insertFlight;
        private System.Windows.Forms.TabPage tab_updateFlight;
        private System.Windows.Forms.DateTimePicker dtpkr_FlightArrTime;
        private System.Windows.Forms.DateTimePicker dtpkr_FlightDepTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_flightAirplane;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_flightCompany;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_flightPrice;
        private System.Windows.Forms.TextBox txt_flightDep;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_flightSeats;
        private System.Windows.Forms.TextBox txt_flightDest;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txt_flightFlightUpd;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txt_flightPriceUpd;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.DateTimePicker dtpkr_flightArrUpd;
        private System.Windows.Forms.Button btn_updateFlight;
        private System.Windows.Forms.DateTimePicker dtpkr_flightDepUpd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_flightAirplaneUpd;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_flightCompanyUpd;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txt_flightAvaSeatsUpd;
        private System.Windows.Forms.TextBox txt_flightDepUpd;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txt_flightTotSeatsUpd;
        private System.Windows.Forms.TextBox txt_flightDestUpd;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lbl_flightEdit;
        private System.Windows.Forms.Panel pnl_updateFlight;
        private System.Windows.Forms.Label lbl_flightDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button btn_flightsShowReport;
    }
}
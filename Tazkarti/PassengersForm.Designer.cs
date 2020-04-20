namespace Tazkarti
{
    partial class PassengersForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_passengerSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_passengersBack = new System.Windows.Forms.Label();
            this.Btn_ShowPassReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(15, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1015, 427);
            this.dataGridView1.TabIndex = 77;
            // 
            // txt_passengerSearch
            // 
            this.txt_passengerSearch.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passengerSearch.Location = new System.Drawing.Point(328, 156);
            this.txt_passengerSearch.Multiline = true;
            this.txt_passengerSearch.Name = "txt_passengerSearch";
            this.txt_passengerSearch.Size = new System.Drawing.Size(395, 43);
            this.txt_passengerSearch.TabIndex = 81;
            this.txt_passengerSearch.TextChanged += new System.EventHandler(this.txt_passengerSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 82;
            this.label1.Text = "Search by Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tazkarti.Properties.Resources.passenger;
            this.pictureBox1.Location = new System.Drawing.Point(870, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 198);
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Image = global::Tazkarti.Properties.Resources.icons8_search_30;
            this.label2.Location = new System.Drawing.Point(682, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 35);
            this.label2.TabIndex = 83;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_passengersBack
            // 
            this.lbl_passengersBack.Image = global::Tazkarti.Properties.Resources.back2;
            this.lbl_passengersBack.Location = new System.Drawing.Point(12, 24);
            this.lbl_passengersBack.Name = "lbl_passengersBack";
            this.lbl_passengersBack.Size = new System.Drawing.Size(53, 34);
            this.lbl_passengersBack.TabIndex = 80;
            this.lbl_passengersBack.Click += new System.EventHandler(this.lbl_passengersBack_Click);
            // 
            // Btn_ShowPassReport
            // 
            this.Btn_ShowPassReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(100)))), ((int)(((byte)(88)))));
            this.Btn_ShowPassReport.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ShowPassReport.Location = new System.Drawing.Point(102, 147);
            this.Btn_ShowPassReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_ShowPassReport.Name = "Btn_ShowPassReport";
            this.Btn_ShowPassReport.Size = new System.Drawing.Size(150, 52);
            this.Btn_ShowPassReport.TabIndex = 85;
            this.Btn_ShowPassReport.Text = "SHOW REPORT";
            this.Btn_ShowPassReport.UseVisualStyleBackColor = false;
            this.Btn_ShowPassReport.Click += new System.EventHandler(this.Btn_ShowPassReport_Click);
            // 
            // PassengersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(1053, 730);
            this.Controls.Add(this.Btn_ShowPassReport);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_passengerSearch);
            this.Controls.Add(this.lbl_passengersBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PassengersForm";
            this.Text = "PassengersForm";
            this.Load += new System.EventHandler(this.PassengersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_passengersBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_passengerSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_ShowPassReport;
    }
}
namespace Tazkarti
{
    partial class UserTicket
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
            this.label39 = new System.Windows.Forms.Label();
            this.pnl_updateTicket = new System.Windows.Forms.Panel();
            this.chk_regular = new System.Windows.Forms.CheckBox();
            this.chk_vip = new System.Windows.Forms.CheckBox();
            this.btn_updateTicket = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.txt_ticketID = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.lbl_ticketDelete = new System.Windows.Forms.Label();
            this.lbl_ticketEdit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_ticketBack = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ticketShowReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_updateTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(27, 337);
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
            this.label39.Location = new System.Drawing.Point(118, 297);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(123, 26);
            this.label39.TabIndex = 90;
            this.label39.Text = "Your Tickets";
            // 
            // pnl_updateTicket
            // 
            this.pnl_updateTicket.Controls.Add(this.chk_regular);
            this.pnl_updateTicket.Controls.Add(this.chk_vip);
            this.pnl_updateTicket.Controls.Add(this.btn_updateTicket);
            this.pnl_updateTicket.Location = new System.Drawing.Point(6, 66);
            this.pnl_updateTicket.Name = "pnl_updateTicket";
            this.pnl_updateTicket.Size = new System.Drawing.Size(291, 155);
            this.pnl_updateTicket.TabIndex = 170;
            // 
            // chk_regular
            // 
            this.chk_regular.AutoSize = true;
            this.chk_regular.Location = new System.Drawing.Point(57, 59);
            this.chk_regular.Name = "chk_regular";
            this.chk_regular.Size = new System.Drawing.Size(150, 30);
            this.chk_regular.TabIndex = 135;
            this.chk_regular.Text = "Make Regular";
            this.chk_regular.UseVisualStyleBackColor = true;
            // 
            // chk_vip
            // 
            this.chk_vip.AutoSize = true;
            this.chk_vip.Location = new System.Drawing.Point(57, 23);
            this.chk_vip.Name = "chk_vip";
            this.chk_vip.Size = new System.Drawing.Size(116, 30);
            this.chk_vip.TabIndex = 134;
            this.chk_vip.Text = "Make VIP";
            this.chk_vip.UseVisualStyleBackColor = true;
            this.chk_vip.CheckedChanged += new System.EventHandler(this.chk_vip_CheckedChanged);
            // 
            // btn_updateTicket
            // 
            this.btn_updateTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(100)))), ((int)(((byte)(88)))));
            this.btn_updateTicket.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateTicket.Location = new System.Drawing.Point(57, 95);
            this.btn_updateTicket.Name = "btn_updateTicket";
            this.btn_updateTicket.Size = new System.Drawing.Size(146, 53);
            this.btn_updateTicket.TabIndex = 133;
            this.btn_updateTicket.Text = "UPDATE";
            this.btn_updateTicket.UseVisualStyleBackColor = false;
            this.btn_updateTicket.Click += new System.EventHandler(this.btn_updateTicket_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Red;
            this.label33.Location = new System.Drawing.Point(167, 30);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(19, 23);
            this.label33.TabIndex = 169;
            this.label33.Text = "*";
            // 
            // txt_ticketID
            // 
            this.txt_ticketID.Location = new System.Drawing.Point(186, 30);
            this.txt_ticketID.Multiline = true;
            this.txt_ticketID.Name = "txt_ticketID";
            this.txt_ticketID.Size = new System.Drawing.Size(43, 30);
            this.txt_ticketID.TabIndex = 168;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.label34.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(66, 31);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(89, 23);
            this.label34.TabIndex = 167;
            this.label34.Text = "Ticket ID:";
            // 
            // lbl_ticketDelete
            // 
            this.lbl_ticketDelete.Image = global::Tazkarti.Properties.Resources.delete;
            this.lbl_ticketDelete.Location = new System.Drawing.Point(267, 30);
            this.lbl_ticketDelete.Name = "lbl_ticketDelete";
            this.lbl_ticketDelete.Size = new System.Drawing.Size(30, 29);
            this.lbl_ticketDelete.TabIndex = 172;
            this.lbl_ticketDelete.Click += new System.EventHandler(this.lbl_ticketDelete_Click);
            // 
            // lbl_ticketEdit
            // 
            this.lbl_ticketEdit.Image = global::Tazkarti.Properties.Resources.edit;
            this.lbl_ticketEdit.Location = new System.Drawing.Point(234, 30);
            this.lbl_ticketEdit.Name = "lbl_ticketEdit";
            this.lbl_ticketEdit.Size = new System.Drawing.Size(30, 29);
            this.lbl_ticketEdit.TabIndex = 171;
            this.lbl_ticketEdit.Click += new System.EventHandler(this.lbl_ticketEdit_Click);
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
            // lbl_ticketBack
            // 
            this.lbl_ticketBack.Image = global::Tazkarti.Properties.Resources.back2;
            this.lbl_ticketBack.Location = new System.Drawing.Point(12, 24);
            this.lbl_ticketBack.Name = "lbl_ticketBack";
            this.lbl_ticketBack.Size = new System.Drawing.Size(53, 34);
            this.lbl_ticketBack.TabIndex = 80;
            this.lbl_ticketBack.Click += new System.EventHandler(this.lbl_ticketBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_ticketDelete);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.lbl_ticketEdit);
            this.groupBox1.Controls.Add(this.txt_ticketID);
            this.groupBox1.Controls.Add(this.pnl_updateTicket);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(354, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 225);
            this.groupBox1.TabIndex = 173;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Information";
            // 
            // btn_ticketShowReport
            // 
            this.btn_ticketShowReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(100)))), ((int)(((byte)(88)))));
            this.btn_ticketShowReport.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ticketShowReport.Location = new System.Drawing.Point(137, 102);
            this.btn_ticketShowReport.Name = "btn_ticketShowReport";
            this.btn_ticketShowReport.Size = new System.Drawing.Size(146, 53);
            this.btn_ticketShowReport.TabIndex = 174;
            this.btn_ticketShowReport.Text = "SHOW REPORT";
            this.btn_ticketShowReport.UseVisualStyleBackColor = false;
            this.btn_ticketShowReport.Click += new System.EventHandler(this.Btn_ticketShowReport_Click);
            // 
            // UserTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(1053, 777);
            this.Controls.Add(this.btn_ticketShowReport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_ticketBack);
            this.Name = "UserTicket";
            this.Text = "UserTicket";
            this.Load += new System.EventHandler(this.UserTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_updateTicket.ResumeLayout(false);
            this.pnl_updateTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_ticketBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label lbl_ticketDelete;
        private System.Windows.Forms.Label lbl_ticketEdit;
        private System.Windows.Forms.Panel pnl_updateTicket;
        private System.Windows.Forms.Button btn_updateTicket;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txt_ticketID;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.CheckBox chk_regular;
        private System.Windows.Forms.CheckBox chk_vip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ticketShowReport;
    }
}
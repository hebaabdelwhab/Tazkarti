namespace Tazkarti
{
    partial class AdminTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ticketUsername = new System.Windows.Forms.TextBox();
            this.lbl_searchTicket = new System.Windows.Forms.Label();
            this.btn_saveTicket = new System.Windows.Forms.Button();
            this.lbl_ticketBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.dataGridView1.Location = new System.Drawing.Point(253, 153);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(883, 478);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 33);
            this.label1.TabIndex = 85;
            this.label1.Text = "Search by Passenger Username";
            // 
            // txt_ticketUsername
            // 
            this.txt_ticketUsername.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ticketUsername.Location = new System.Drawing.Point(437, 64);
            this.txt_ticketUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ticketUsername.Multiline = true;
            this.txt_ticketUsername.Name = "txt_ticketUsername";
            this.txt_ticketUsername.Size = new System.Drawing.Size(525, 52);
            this.txt_ticketUsername.TabIndex = 84;
            // 
            // lbl_searchTicket
            // 
            this.lbl_searchTicket.BackColor = System.Drawing.Color.White;
            this.lbl_searchTicket.Image = global::Tazkarti.Properties.Resources.icons8_search_30;
            this.lbl_searchTicket.Location = new System.Drawing.Point(909, 66);
            this.lbl_searchTicket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_searchTicket.Name = "lbl_searchTicket";
            this.lbl_searchTicket.Size = new System.Drawing.Size(47, 43);
            this.lbl_searchTicket.TabIndex = 86;
            this.lbl_searchTicket.Click += new System.EventHandler(this.lbl_searchTicket_Click);
            // 
            // btn_saveTicket
            // 
            this.btn_saveTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(100)))), ((int)(((byte)(88)))));
            this.btn_saveTicket.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveTicket.Location = new System.Drawing.Point(1083, 665);
            this.btn_saveTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_saveTicket.Name = "btn_saveTicket";
            this.btn_saveTicket.Size = new System.Drawing.Size(195, 65);
            this.btn_saveTicket.TabIndex = 134;
            this.btn_saveTicket.Text = "SAVE";
            this.btn_saveTicket.UseVisualStyleBackColor = false;
            this.btn_saveTicket.Click += new System.EventHandler(this.btn_saveTicket_Click);
            // 
            // lbl_ticketBack
            // 
            this.lbl_ticketBack.Image = global::Tazkarti.Properties.Resources.back2;
            this.lbl_ticketBack.Location = new System.Drawing.Point(17, 31);
            this.lbl_ticketBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ticketBack.Name = "lbl_ticketBack";
            this.lbl_ticketBack.Size = new System.Drawing.Size(71, 42);
            this.lbl_ticketBack.TabIndex = 136;
            this.lbl_ticketBack.Click += new System.EventHandler(this.lbl_ticketBack_Click);
            // 
            // AdminTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(1360, 794);
            this.Controls.Add(this.lbl_ticketBack);
            this.Controls.Add(this.btn_saveTicket);
            this.Controls.Add(this.lbl_searchTicket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ticketUsername);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminTicket";
            this.Text = "AdminTicket";
            this.Load += new System.EventHandler(this.AdminTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_searchTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ticketUsername;
        private System.Windows.Forms.Button btn_saveTicket;
        private System.Windows.Forms.Label lbl_ticketBack;
    }
}
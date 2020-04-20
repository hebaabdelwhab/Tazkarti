namespace Tazkarti
{
    partial class FlightsReportForm
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
            this.CMB_CompanyName = new System.Windows.Forms.ComboBox();
            this.CMB_FlightDate = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.BTN_ShowReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_passenegerBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CMB_CompanyName
            // 
            this.CMB_CompanyName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_CompanyName.FormattingEnabled = true;
            this.CMB_CompanyName.Location = new System.Drawing.Point(244, 18);
            this.CMB_CompanyName.Margin = new System.Windows.Forms.Padding(2);
            this.CMB_CompanyName.Name = "CMB_CompanyName";
            this.CMB_CompanyName.Size = new System.Drawing.Size(169, 31);
            this.CMB_CompanyName.TabIndex = 0;
            this.CMB_CompanyName.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // CMB_FlightDate
            // 
            this.CMB_FlightDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_FlightDate.FormattingEnabled = true;
            this.CMB_FlightDate.Location = new System.Drawing.Point(535, 18);
            this.CMB_FlightDate.Margin = new System.Windows.Forms.Padding(2);
            this.CMB_FlightDate.Name = "CMB_FlightDate";
            this.CMB_FlightDate.Size = new System.Drawing.Size(169, 31);
            this.CMB_FlightDate.TabIndex = 1;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-2, 74);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(879, 576);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ToolPanelWidth = 150;
            // 
            // BTN_ShowReport
            // 
            this.BTN_ShowReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(100)))), ((int)(((byte)(88)))));
            this.BTN_ShowReport.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ShowReport.Location = new System.Drawing.Point(717, 11);
            this.BTN_ShowReport.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_ShowReport.Name = "BTN_ShowReport";
            this.BTN_ShowReport.Size = new System.Drawing.Size(112, 43);
            this.BTN_ShowReport.TabIndex = 3;
            this.BTN_ShowReport.Text = "SHOW";
            this.BTN_ShowReport.UseVisualStyleBackColor = false;
            this.BTN_ShowReport.Click += new System.EventHandler(this.BTN_ShowReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Company Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Flight Date:";
            // 
            // lbl_passenegerBack
            // 
            this.lbl_passenegerBack.Image = global::Tazkarti.Properties.Resources.back2;
            this.lbl_passenegerBack.Location = new System.Drawing.Point(26, 20);
            this.lbl_passenegerBack.Name = "lbl_passenegerBack";
            this.lbl_passenegerBack.Size = new System.Drawing.Size(40, 34);
            this.lbl_passenegerBack.TabIndex = 74;
            this.lbl_passenegerBack.Click += new System.EventHandler(this.lbl_passenegerBack_Click);
            // 
            // FlightsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(877, 652);
            this.Controls.Add(this.lbl_passenegerBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_ShowReport);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.CMB_FlightDate);
            this.Controls.Add(this.CMB_CompanyName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FlightsReportForm";
            this.Text = "FlightsReportForm";
            this.Load += new System.EventHandler(this.FlightsReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CMB_CompanyName;
        private System.Windows.Forms.ComboBox CMB_FlightDate;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button BTN_ShowReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_passenegerBack;
    }
}
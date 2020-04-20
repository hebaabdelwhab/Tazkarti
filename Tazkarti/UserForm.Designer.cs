namespace Tazkarti
{
    partial class UserForm
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
            this.pnl_userMenu = new System.Windows.Forms.Panel();
            this.btn_userMenu = new System.Windows.Forms.Button();
            this.pnl_userSidebar = new System.Windows.Forms.Panel();
            this.lbl_userLogout = new System.Windows.Forms.Label();
            this.lbl_userTickets = new System.Windows.Forms.Label();
            this.lbl_userProfile = new System.Windows.Forms.Label();
            this.lbl_userReserve = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_userMenu.SuspendLayout();
            this.pnl_userSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_userMenu
            // 
            this.pnl_userMenu.BackColor = System.Drawing.Color.White;
            this.pnl_userMenu.Controls.Add(this.btn_userMenu);
            this.pnl_userMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_userMenu.Location = new System.Drawing.Point(0, 0);
            this.pnl_userMenu.Name = "pnl_userMenu";
            this.pnl_userMenu.Size = new System.Drawing.Size(40, 649);
            this.pnl_userMenu.TabIndex = 1;
            // 
            // btn_userMenu
            // 
            this.btn_userMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_userMenu.Image = global::Tazkarti.Properties.Resources.menu3;
            this.btn_userMenu.Location = new System.Drawing.Point(0, 0);
            this.btn_userMenu.Name = "btn_userMenu";
            this.btn_userMenu.Size = new System.Drawing.Size(40, 44);
            this.btn_userMenu.TabIndex = 0;
            this.btn_userMenu.UseVisualStyleBackColor = true;
            this.btn_userMenu.Click += new System.EventHandler(this.btn_userMenu_Click);
            // 
            // pnl_userSidebar
            // 
            this.pnl_userSidebar.BackColor = System.Drawing.Color.White;
            this.pnl_userSidebar.Controls.Add(this.lbl_userLogout);
            this.pnl_userSidebar.Controls.Add(this.lbl_userTickets);
            this.pnl_userSidebar.Controls.Add(this.lbl_userProfile);
            this.pnl_userSidebar.Controls.Add(this.lbl_userReserve);
            this.pnl_userSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_userSidebar.Location = new System.Drawing.Point(40, 0);
            this.pnl_userSidebar.Name = "pnl_userSidebar";
            this.pnl_userSidebar.Size = new System.Drawing.Size(200, 649);
            this.pnl_userSidebar.TabIndex = 2;
            // 
            // lbl_userLogout
            // 
            this.lbl_userLogout.BackColor = System.Drawing.Color.White;
            this.lbl_userLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_userLogout.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userLogout.Image = global::Tazkarti.Properties.Resources.logout;
            this.lbl_userLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_userLogout.Location = new System.Drawing.Point(0, 123);
            this.lbl_userLogout.Name = "lbl_userLogout";
            this.lbl_userLogout.Size = new System.Drawing.Size(200, 41);
            this.lbl_userLogout.TabIndex = 5;
            this.lbl_userLogout.Text = "LOGOUT";
            this.lbl_userLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_userLogout.Click += new System.EventHandler(this.lbl_userLogout_Click);
            this.lbl_userLogout.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // lbl_userTickets
            // 
            this.lbl_userTickets.BackColor = System.Drawing.Color.White;
            this.lbl_userTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_userTickets.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_userTickets.Location = new System.Drawing.Point(0, 82);
            this.lbl_userTickets.Name = "lbl_userTickets";
            this.lbl_userTickets.Size = new System.Drawing.Size(200, 41);
            this.lbl_userTickets.TabIndex = 4;
            this.lbl_userTickets.Text = "MY TICKETS";
            this.lbl_userTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_userTickets.Click += new System.EventHandler(this.lbl_userTickets_Click);
            this.lbl_userTickets.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // lbl_userProfile
            // 
            this.lbl_userProfile.BackColor = System.Drawing.Color.White;
            this.lbl_userProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_userProfile.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userProfile.Location = new System.Drawing.Point(0, 41);
            this.lbl_userProfile.Name = "lbl_userProfile";
            this.lbl_userProfile.Size = new System.Drawing.Size(200, 41);
            this.lbl_userProfile.TabIndex = 3;
            this.lbl_userProfile.Text = "PROFILE";
            this.lbl_userProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_userProfile.Click += new System.EventHandler(this.lbl_userProfile_Click);
            this.lbl_userProfile.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // lbl_userReserve
            // 
            this.lbl_userReserve.BackColor = System.Drawing.Color.White;
            this.lbl_userReserve.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_userReserve.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userReserve.Location = new System.Drawing.Point(0, 0);
            this.lbl_userReserve.Name = "lbl_userReserve";
            this.lbl_userReserve.Size = new System.Drawing.Size(200, 41);
            this.lbl_userReserve.TabIndex = 2;
            this.lbl_userReserve.Text = "RESERVE TICKET";
            this.lbl_userReserve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_userReserve.Click += new System.EventHandler(this.lbl_userReserve_Click);
            this.lbl_userReserve.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tazkarti.Properties.Resources.MW_HE536_airpla_20190225131547_ZG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 649);
            this.Controls.Add(this.pnl_userSidebar);
            this.Controls.Add(this.pnl_userMenu);
            this.Name = "UserForm";
            this.Text = "   ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.pnl_userMenu.ResumeLayout(false);
            this.pnl_userSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_userMenu;
        private System.Windows.Forms.Button btn_userMenu;
        private System.Windows.Forms.Panel pnl_userSidebar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_userTickets;
        private System.Windows.Forms.Label lbl_userProfile;
        private System.Windows.Forms.Label lbl_userReserve;
        private System.Windows.Forms.Label lbl_userLogout;
    }
}
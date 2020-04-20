namespace Tazkarti
{
    partial class ChangePassword
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
            this.txt_newPass = new System.Windows.Forms.TextBox();
            this.txt_conPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_CPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_newPass
            // 
            this.txt_newPass.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.txt_newPass.Location = new System.Drawing.Point(206, 26);
            this.txt_newPass.Multiline = true;
            this.txt_newPass.Name = "txt_newPass";
            this.txt_newPass.PasswordChar = '*';
            this.txt_newPass.Size = new System.Drawing.Size(241, 39);
            this.txt_newPass.TabIndex = 0;
            // 
            // txt_conPass
            // 
            this.txt_conPass.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_conPass.Location = new System.Drawing.Point(206, 91);
            this.txt_conPass.Multiline = true;
            this.txt_conPass.Name = "txt_conPass";
            this.txt_conPass.PasswordChar = '*';
            this.txt_conPass.Size = new System.Drawing.Size(241, 39);
            this.txt_conPass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label2.Location = new System.Drawing.Point(32, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirm Password:";
            // 
            // btn_CPass
            // 
            this.btn_CPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(100)))), ((int)(((byte)(88)))));
            this.btn_CPass.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CPass.Location = new System.Drawing.Point(329, 159);
            this.btn_CPass.Name = "btn_CPass";
            this.btn_CPass.Size = new System.Drawing.Size(146, 53);
            this.btn_CPass.TabIndex = 73;
            this.btn_CPass.Text = "DONE";
            this.btn_CPass.UseVisualStyleBackColor = false;
            this.btn_CPass.Click += new System.EventHandler(this.btn_CPass_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(185)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(504, 230);
            this.Controls.Add(this.btn_CPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_conPass);
            this.Controls.Add(this.txt_newPass);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_newPass;
        private System.Windows.Forms.TextBox txt_conPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_CPass;
    }
}
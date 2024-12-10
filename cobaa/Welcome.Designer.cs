namespace cobaa
{
    partial class Welcome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_registerHere = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.login_cloce = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_showPassword = new System.Windows.Forms.CheckBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.login_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Walcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.login_registerHere);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.login_cloce);
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Controls.Add(this.login_showPassword);
            this.panel1.Controls.Add(this.login_password);
            this.panel1.Controls.Add(this.login_username);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Walcome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 557);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // login_registerHere
            // 
            this.login_registerHere.AutoSize = true;
            this.login_registerHere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_registerHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_registerHere.ForeColor = System.Drawing.Color.DarkGray;
            this.login_registerHere.Location = new System.Drawing.Point(628, 512);
            this.login_registerHere.Name = "login_registerHere";
            this.login_registerHere.Size = new System.Drawing.Size(134, 22);
            this.login_registerHere.TabIndex = 11;
            this.login_registerHere.Text = "Register Here";
            this.login_registerHere.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(423, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Don\'t have an account?";
            // 
            // login_cloce
            // 
            this.login_cloce.AutoSize = true;
            this.login_cloce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_cloce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_cloce.Location = new System.Drawing.Point(844, 12);
            this.login_cloce.Name = "login_cloce";
            this.login_cloce.Size = new System.Drawing.Size(26, 25);
            this.login_cloce.TabIndex = 9;
            this.login_cloce.Text = "X";
            this.login_cloce.Click += new System.EventHandler(this.label4_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.ForeColor = System.Drawing.Color.Transparent;
            this.login_btn.Location = new System.Drawing.Point(399, 424);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(126, 52);
            this.login_btn.TabIndex = 8;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_showPassword
            // 
            this.login_showPassword.AutoSize = true;
            this.login_showPassword.BackColor = System.Drawing.Color.Transparent;
            this.login_showPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_showPassword.ForeColor = System.Drawing.Color.Gray;
            this.login_showPassword.Location = new System.Drawing.Point(684, 372);
            this.login_showPassword.Name = "login_showPassword";
            this.login_showPassword.Size = new System.Drawing.Size(148, 24);
            this.login_showPassword.TabIndex = 7;
            this.login_showPassword.Text = "Show Password";
            this.login_showPassword.UseVisualStyleBackColor = false;
            // 
            // login_password
            // 
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.Location = new System.Drawing.Point(399, 285);
            this.login_password.Multiline = true;
            this.login_password.Name = "login_password";
            this.login_password.Size = new System.Drawing.Size(433, 57);
            this.login_password.TabIndex = 6;
            // 
            // login_username
            // 
            this.login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username.Location = new System.Drawing.Point(399, 190);
            this.login_username.Multiline = true;
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(433, 57);
            this.login_username.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sarastya Intership Academy";
            // 
            // Walcome
            // 
            this.Walcome.AutoSize = true;
            this.Walcome.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Walcome.Location = new System.Drawing.Point(371, 49);
            this.Walcome.Name = "Walcome";
            this.Walcome.Size = new System.Drawing.Size(141, 33);
            this.Walcome.TabIndex = 1;
            this.Walcome.Text = "Welcome";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 554);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cobaa.Properties.Resources.icons8_user_90;
            this.pictureBox1.Location = new System.Drawing.Point(94, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(86, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 34);
            this.label4.TabIndex = 12;
            this.label4.Text = "MarcoMan";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 554);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Walcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox login_showPassword;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label login_cloce;
        private System.Windows.Forms.Label login_registerHere;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}


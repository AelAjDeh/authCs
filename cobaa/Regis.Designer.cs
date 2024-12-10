namespace cobaa
{
    partial class Regis
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
            this.register_loginHere = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.register_cloce = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.register_showPassword = new System.Windows.Forms.CheckBox();
            this.register_password = new System.Windows.Forms.TextBox();
            this.register_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Walcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.register_emailAddreas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.register_confirmPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.register_confirmPassword);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.register_emailAddreas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.register_loginHere);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.register_cloce);
            this.panel1.Controls.Add(this.register_btn);
            this.panel1.Controls.Add(this.register_showPassword);
            this.panel1.Controls.Add(this.register_password);
            this.panel1.Controls.Add(this.register_username);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Walcome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 557);
            this.panel1.TabIndex = 1;
            // 
            // register_loginHere
            // 
            this.register_loginHere.AutoSize = true;
            this.register_loginHere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_loginHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_loginHere.ForeColor = System.Drawing.Color.DarkGray;
            this.register_loginHere.Location = new System.Drawing.Point(628, 517);
            this.register_loginHere.Name = "register_loginHere";
            this.register_loginHere.Size = new System.Drawing.Size(108, 22);
            this.register_loginHere.TabIndex = 11;
            this.register_loginHere.Text = "Login Here";
            this.register_loginHere.Click += new System.EventHandler(this.register_loginHere_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(423, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Don\'t have an account?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // register_cloce
            // 
            this.register_cloce.AutoSize = true;
            this.register_cloce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_cloce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_cloce.Location = new System.Drawing.Point(844, 12);
            this.register_cloce.Name = "register_cloce";
            this.register_cloce.Size = new System.Drawing.Size(26, 25);
            this.register_cloce.TabIndex = 9;
            this.register_cloce.Text = "X";
            this.register_cloce.Click += new System.EventHandler(this.register_cloce_Click);
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.register_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_btn.ForeColor = System.Drawing.Color.Transparent;
            this.register_btn.Location = new System.Drawing.Point(368, 454);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(126, 52);
            this.register_btn.TabIndex = 8;
            this.register_btn.Text = "LOGIN";
            this.register_btn.UseVisualStyleBackColor = false;
            // 
            // register_showPassword
            // 
            this.register_showPassword.AutoSize = true;
            this.register_showPassword.BackColor = System.Drawing.Color.Transparent;
            this.register_showPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_showPassword.ForeColor = System.Drawing.Color.Gray;
            this.register_showPassword.Location = new System.Drawing.Point(653, 429);
            this.register_showPassword.Name = "register_showPassword";
            this.register_showPassword.Size = new System.Drawing.Size(148, 24);
            this.register_showPassword.TabIndex = 7;
            this.register_showPassword.Text = "Show Password";
            this.register_showPassword.UseVisualStyleBackColor = false;
            this.register_showPassword.CheckedChanged += new System.EventHandler(this.login_showPassword_CheckedChanged);
            // 
            // register_password
            // 
            this.register_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_password.Location = new System.Drawing.Point(368, 272);
            this.register_password.Multiline = true;
            this.register_password.Name = "register_password";
            this.register_password.Size = new System.Drawing.Size(433, 57);
            this.register_password.TabIndex = 6;
            this.register_password.TextChanged += new System.EventHandler(this.login_password_TextChanged);
            // 
            // register_username
            // 
            this.register_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_username.Location = new System.Drawing.Point(368, 186);
            this.register_username.Multiline = true;
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(433, 57);
            this.register_username.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // Walcome
            // 
            this.Walcome.AutoSize = true;
            this.Walcome.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Walcome.Location = new System.Drawing.Point(334, 31);
            this.Walcome.Name = "Walcome";
            this.Walcome.Size = new System.Drawing.Size(152, 28);
            this.Walcome.TabIndex = 1;
            this.Walcome.Text = "Get Started";
            this.Walcome.Click += new System.EventHandler(this.Walcome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 557);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(68, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 34);
            this.label4.TabIndex = 12;
            this.label4.Text = "MarcoMan";
            // 
            // register_emailAddreas
            // 
            this.register_emailAddreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_emailAddreas.Location = new System.Drawing.Point(368, 93);
            this.register_emailAddreas.Multiline = true;
            this.register_emailAddreas.Name = "register_emailAddreas";
            this.register_emailAddreas.Size = new System.Drawing.Size(433, 57);
            this.register_emailAddreas.TabIndex = 13;
            this.register_emailAddreas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // register_confirmPassword
            // 
            this.register_confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_confirmPassword.Location = new System.Drawing.Point(368, 356);
            this.register_confirmPassword.Multiline = true;
            this.register_confirmPassword.Name = "register_confirmPassword";
            this.register_confirmPassword.Size = new System.Drawing.Size(433, 57);
            this.register_confirmPassword.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(363, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Confirm Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cobaa.Properties.Resources.icons8_user_90;
            this.pictureBox1.Location = new System.Drawing.Point(81, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 554);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label register_loginHere;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label register_cloce;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.CheckBox register_showPassword;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.TextBox register_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Walcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox register_emailAddreas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox register_confirmPassword;
        private System.Windows.Forms.Label label6;
    }
}
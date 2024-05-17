namespace WinFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            txt_username = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            btn_clear = new Button();
            btn_exit = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(76, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 392);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(516, 64);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(327, 134);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(516, 235);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(49, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(516, 307);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(49, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.Location = new Point(570, 243);
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "Enter your username";
            txt_username.Size = new Size(273, 30);
            txt_username.TabIndex = 4;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(570, 315);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.PlaceholderText = "Enter your password";
            txt_password.Size = new Size(273, 30);
            txt_password.TabIndex = 5;
            txt_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            btn_login.Image = (Image)resources.GetObject("btn_login.Image");
            btn_login.ImageAlign = ContentAlignment.MiddleLeft;
            btn_login.Location = new Point(526, 415);
            btn_login.Name = "btn_login";
            btn_login.RightToLeft = RightToLeft.Yes;
            btn_login.Size = new Size(104, 41);
            btn_login.TabIndex = 6;
            btn_login.Text = "Login";
            btn_login.TextAlign = ContentAlignment.MiddleRight;
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_clear
            // 
            btn_clear.Image = (Image)resources.GetObject("btn_clear.Image");
            btn_clear.ImageAlign = ContentAlignment.MiddleLeft;
            btn_clear.Location = new Point(647, 415);
            btn_clear.Name = "btn_clear";
            btn_clear.RightToLeft = RightToLeft.Yes;
            btn_clear.Size = new Size(104, 41);
            btn_clear.TabIndex = 7;
            btn_clear.Text = "Clear All";
            btn_clear.TextAlign = ContentAlignment.MiddleRight;
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_exit
            // 
            btn_exit.Image = (Image)resources.GetObject("btn_exit.Image");
            btn_exit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_exit.Location = new Point(764, 415);
            btn_exit.Name = "btn_exit";
            btn_exit.RightToLeft = RightToLeft.Yes;
            btn_exit.Size = new Size(104, 41);
            btn_exit.TabIndex = 8;
            btn_exit.Text = "Exit";
            btn_exit.TextAlign = ContentAlignment.MiddleRight;
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(201, 9);
            label1.Name = "label1";
            label1.Size = new Size(533, 44);
            label1.TabIndex = 9;
            label1.Text = "Inventory Management System";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 529);
            Controls.Add(label1);
            Controls.Add(btn_exit);
            Controls.Add(btn_clear);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txt_username);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button btn_login;
        private Button btn_clear;
        private Button btn_exit;
        private Label label1;
    }
}
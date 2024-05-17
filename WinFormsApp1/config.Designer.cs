namespace WinFormsApp1
{
    partial class config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(config));
            btn_home = new Button();
            splitter1 = new Splitter();
            btn_delete = new Button();
            btn_add = new Button();
            label2 = new Label();
            label1 = new Label();
            txt_pw = new TextBox();
            txt_name = new TextBox();
            txt_email = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txt_age = new TextBox();
            txt_fullname = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txt_tp = new TextBox();
            SuspendLayout();
            // 
            // btn_home
            // 
            btn_home.BackgroundImage = (Image)resources.GetObject("btn_home.BackgroundImage");
            btn_home.BackgroundImageLayout = ImageLayout.Zoom;
            btn_home.Location = new Point(1, 1);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(334, 138);
            btn_home.TabIndex = 26;
            btn_home.UseVisualStyleBackColor = true;
            btn_home.Click += btn_home_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(334, 529);
            splitter1.TabIndex = 25;
            splitter1.TabStop = false;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(699, 449);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(158, 46);
            btn_delete.TabIndex = 23;
            btn_delete.Text = "Delete User";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(528, 449);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(158, 46);
            btn_add.TabIndex = 24;
            btn_add.Text = "Add New User";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(431, 103);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 21;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(431, 38);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 22;
            label1.Text = "User Name";
            // 
            // txt_pw
            // 
            txt_pw.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pw.Location = new Point(629, 100);
            txt_pw.Name = "txt_pw";
            txt_pw.Size = new Size(245, 30);
            txt_pw.TabIndex = 18;
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(629, 35);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(245, 30);
            txt_name.TabIndex = 27;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(629, 163);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(245, 30);
            txt_email.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(431, 231);
            label3.Name = "label3";
            label3.Size = new Size(40, 23);
            label3.TabIndex = 29;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(431, 166);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 30;
            label4.Text = "Email";
            // 
            // txt_age
            // 
            txt_age.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_age.Location = new Point(629, 228);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(245, 30);
            txt_age.TabIndex = 28;
            // 
            // txt_fullname
            // 
            txt_fullname.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_fullname.Location = new Point(629, 280);
            txt_fullname.Name = "txt_fullname";
            txt_fullname.Size = new Size(245, 30);
            txt_fullname.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(431, 348);
            label5.Name = "label5";
            label5.Size = new Size(156, 23);
            label5.TabIndex = 33;
            label5.Text = "Telephone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(431, 283);
            label6.Name = "label6";
            label6.Size = new Size(87, 23);
            label6.TabIndex = 34;
            label6.Text = "Full Name";
            // 
            // txt_tp
            // 
            txt_tp.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tp.Location = new Point(629, 345);
            txt_tp.Name = "txt_tp";
            txt_tp.Size = new Size(245, 30);
            txt_tp.TabIndex = 32;
            // 
            // config
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 529);
            Controls.Add(txt_fullname);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txt_tp);
            Controls.Add(txt_email);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txt_age);
            Controls.Add(txt_name);
            Controls.Add(btn_home);
            Controls.Add(splitter1);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_pw);
            Name = "config";
            Text = "config";
            Load += config_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_home;
        private Splitter splitter1;
        private Button btn_delete;
        private Button btn_add;
        private Label label2;
        private Label label1;
        private TextBox txt_pw;
        private TextBox txt_name;
        private TextBox txt_email;
        private Label label3;
        private Label label4;
        private TextBox txt_age;
        private TextBox txt_fullname;
        private Label label5;
        private Label label6;
        private TextBox txt_tp;
    }
}
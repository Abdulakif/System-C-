namespace WinFormsApp1
{
    partial class Add_quantity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_quantity));
            btn_home = new Button();
            splitter1 = new Splitter();
            btn_clear = new Button();
            btn_add = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_quantity = new TextBox();
            txt_code = new TextBox();
            txt_name = new TextBox();
            SuspendLayout();
            // 
            // btn_home
            // 
            btn_home.BackgroundImage = (Image)resources.GetObject("btn_home.BackgroundImage");
            btn_home.BackgroundImageLayout = ImageLayout.Zoom;
            btn_home.Location = new Point(0, 0);
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
            // btn_clear
            // 
            btn_clear.Location = new Point(715, 334);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(158, 46);
            btn_clear.TabIndex = 23;
            btn_clear.Text = "Clear All";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(544, 334);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(158, 46);
            btn_add.TabIndex = 24;
            btn_add.Text = "Add Quantity";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(430, 209);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 20;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(430, 139);
            label2.Name = "label2";
            label2.Size = new Size(101, 23);
            label2.TabIndex = 21;
            label2.Text = "Stock Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(430, 74);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 22;
            label1.Text = "Stock Code";
            // 
            // txt_quantity
            // 
            txt_quantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_quantity.Location = new Point(544, 206);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(245, 30);
            txt_quantity.TabIndex = 17;
            txt_quantity.TextChanged += txt_quantity_TextChanged;
            // 
            // txt_code
            // 
            txt_code.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_code.Location = new Point(544, 71);
            txt_code.Name = "txt_code";
            txt_code.Size = new Size(245, 30);
            txt_code.TabIndex = 19;
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(544, 136);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(245, 30);
            txt_name.TabIndex = 19;
            // 
            // Add_quantity
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 529);
            Controls.Add(btn_home);
            Controls.Add(splitter1);
            Controls.Add(btn_clear);
            Controls.Add(btn_add);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_quantity);
            Controls.Add(txt_name);
            Controls.Add(txt_code);
            Name = "Add_quantity";
            Text = "Add_quantity";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_home;
        private Splitter splitter1;
        private Button btn_clear;
        private Button btn_add;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_quantity;
        private TextBox txt_code;
        private TextBox txt_name;
    }
}
namespace WinFormsApp1
{
    partial class New_Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Stock));
            txt_name = new TextBox();
            txt_quantity = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btn_add = new Button();
            btn_clear = new Button();
            splitter1 = new Splitter();
            btn_home = new Button();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(543, 136);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(245, 30);
            txt_name.TabIndex = 0;
            txt_name.TextChanged += txt_name_TextChanged;
            // 
            // txt_quantity
            // 
            txt_quantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_quantity.Location = new Point(543, 206);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(245, 30);
            txt_quantity.TabIndex = 0;
            txt_quantity.TextChanged += txt_quantity_TextChanged;
            txt_quantity.KeyPress += txt_quantity_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(429, 139);
            label2.Name = "label2";
            label2.Size = new Size(101, 23);
            label2.TabIndex = 1;
            label2.Text = "Stock Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(429, 209);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 1;
            label3.Text = "Quantity";
            label3.Click += label3_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(543, 334);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(158, 46);
            btn_add.TabIndex = 2;
            btn_add.Text = "Add New Stock";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(714, 334);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(158, 46);
            btn_clear.TabIndex = 2;
            btn_clear.Text = "Clear All";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(334, 529);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            splitter1.SplitterMoved += splitter1_SplitterMoved;
            // 
            // btn_home
            // 
            btn_home.BackgroundImage = (Image)resources.GetObject("btn_home.BackgroundImage");
            btn_home.BackgroundImageLayout = ImageLayout.Zoom;
            btn_home.Location = new Point(0, 0);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(334, 138);
            btn_home.TabIndex = 16;
            btn_home.UseVisualStyleBackColor = true;
            btn_home.Click += btn_home_Click;
            // 
            // New_Stock
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
            Controls.Add(txt_quantity);
            Controls.Add(txt_name);
            Name = "New_Stock";
            Text = "New_Stock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_name;
        private TextBox txt_quantity;
        private Label label2;
        private Label label3;
        private Button btn_add;
        private Button btn_clear;
        private Splitter splitter1;
        private Button btn_home;
    }
}
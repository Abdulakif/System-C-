namespace WinFormsApp1
{
    partial class Del_stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Del_stock));
            btn_home = new Button();
            splitter1 = new Splitter();
            btn_clear = new Button();
            btn_rem = new Button();
            label2 = new Label();
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
            splitter1.Size = new Size(334, 553);
            splitter1.TabIndex = 25;
            splitter1.TabStop = false;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(714, 334);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(158, 46);
            btn_clear.TabIndex = 23;
            btn_clear.Text = "Clear All";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_rem
            // 
            btn_rem.Location = new Point(543, 334);
            btn_rem.Name = "btn_rem";
            btn_rem.Size = new Size(158, 46);
            btn_rem.TabIndex = 24;
            btn_rem.Text = "Remove Stock";
            btn_rem.UseVisualStyleBackColor = true;
            btn_rem.Click += btn_rem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(480, 158);
            label2.Name = "label2";
            label2.Size = new Size(101, 23);
            label2.TabIndex = 21;
            label2.Text = "Stock Name";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(594, 155);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(245, 30);
            txt_name.TabIndex = 18;
            // 
            // Del_stock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 553);
            Controls.Add(btn_home);
            Controls.Add(splitter1);
            Controls.Add(btn_clear);
            Controls.Add(btn_rem);
            Controls.Add(label2);
            Controls.Add(txt_name);
            Name = "Del_stock";
            Text = "Del_stock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_home;
        private Splitter splitter1;
        private Button btn_clear;
        private Button btn_rem;
        private Label label2;
        private TextBox txt_name;
    }
}
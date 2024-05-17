namespace WinFormsApp1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btn_AddNewStock = new Button();
            btn_RemQuantity = new Button();
            btn_ViewTransaction = new Button();
            btn_ViewStockLevel = new Button();
            btn_logout = new Button();
            btn_DelStock = new Button();
            splitter1 = new Splitter();
            btn_home = new Button();
            btn_AddQuantity = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_AddNewStock
            // 
            btn_AddNewStock.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AddNewStock.Image = (Image)resources.GetObject("btn_AddNewStock.Image");
            btn_AddNewStock.ImageAlign = ContentAlignment.TopCenter;
            btn_AddNewStock.Location = new Point(395, 10);
            btn_AddNewStock.Name = "btn_AddNewStock";
            btn_AddNewStock.Size = new Size(156, 143);
            btn_AddNewStock.TabIndex = 0;
            btn_AddNewStock.Text = "Add New Item";
            btn_AddNewStock.TextAlign = ContentAlignment.BottomCenter;
            btn_AddNewStock.UseVisualStyleBackColor = true;
            btn_AddNewStock.Click += btn_AddNewStock_Click;
            // 
            // btn_RemQuantity
            // 
            btn_RemQuantity.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_RemQuantity.Image = (Image)resources.GetObject("btn_RemQuantity.Image");
            btn_RemQuantity.ImageAlign = ContentAlignment.TopCenter;
            btn_RemQuantity.Location = new Point(395, 170);
            btn_RemQuantity.Name = "btn_RemQuantity";
            btn_RemQuantity.Size = new Size(156, 143);
            btn_RemQuantity.TabIndex = 2;
            btn_RemQuantity.Text = "Remove quantity";
            btn_RemQuantity.TextAlign = ContentAlignment.BottomCenter;
            btn_RemQuantity.UseVisualStyleBackColor = true;
            btn_RemQuantity.Click += btn_RemQuantity_Click;
            // 
            // btn_ViewTransaction
            // 
            btn_ViewTransaction.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ViewTransaction.Image = (Image)resources.GetObject("btn_ViewTransaction.Image");
            btn_ViewTransaction.ImageAlign = ContentAlignment.TopCenter;
            btn_ViewTransaction.Location = new Point(395, 334);
            btn_ViewTransaction.Name = "btn_ViewTransaction";
            btn_ViewTransaction.Size = new Size(156, 143);
            btn_ViewTransaction.TabIndex = 4;
            btn_ViewTransaction.Text = "View Transaction Log";
            btn_ViewTransaction.TextAlign = ContentAlignment.BottomCenter;
            btn_ViewTransaction.UseVisualStyleBackColor = true;
            btn_ViewTransaction.Click += btn_ViewTransaction_Click;
            // 
            // btn_ViewStockLevel
            // 
            btn_ViewStockLevel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ViewStockLevel.Image = (Image)resources.GetObject("btn_ViewStockLevel.Image");
            btn_ViewStockLevel.ImageAlign = ContentAlignment.TopCenter;
            btn_ViewStockLevel.Location = new Point(637, 334);
            btn_ViewStockLevel.Name = "btn_ViewStockLevel";
            btn_ViewStockLevel.Size = new Size(156, 143);
            btn_ViewStockLevel.TabIndex = 5;
            btn_ViewStockLevel.Text = "View Stock Levels";
            btn_ViewStockLevel.TextAlign = ContentAlignment.BottomCenter;
            btn_ViewStockLevel.UseVisualStyleBackColor = true;
            btn_ViewStockLevel.Click += btn_ViewStockLevel_Click;
            // 
            // btn_logout
            // 
            btn_logout.Image = (Image)resources.GetObject("btn_logout.Image");
            btn_logout.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout.Location = new Point(823, 470);
            btn_logout.Name = "btn_logout";
            btn_logout.RightToLeft = RightToLeft.Yes;
            btn_logout.Size = new Size(120, 54);
            btn_logout.TabIndex = 6;
            btn_logout.Text = "Log Out";
            btn_logout.TextAlign = ContentAlignment.MiddleRight;
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_DelStock
            // 
            btn_DelStock.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_DelStock.Image = (Image)resources.GetObject("btn_DelStock.Image");
            btn_DelStock.ImageAlign = ContentAlignment.TopCenter;
            btn_DelStock.Location = new Point(637, 170);
            btn_DelStock.Name = "btn_DelStock";
            btn_DelStock.Size = new Size(156, 143);
            btn_DelStock.TabIndex = 3;
            btn_DelStock.Text = "Delete Stock";
            btn_DelStock.TextAlign = ContentAlignment.BottomCenter;
            btn_DelStock.UseVisualStyleBackColor = true;
            btn_DelStock.Click += btn_DelStock_Click_1;
            // 
            // splitter1
            // 
            splitter1.BackColor = SystemColors.Control;
            splitter1.BorderStyle = BorderStyle.Fixed3D;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(334, 533);
            splitter1.TabIndex = 7;
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
            btn_home.TabIndex = 15;
            btn_home.UseVisualStyleBackColor = true;
            btn_home.Click += btn_home_Click;
            // 
            // btn_AddQuantity
            // 
            btn_AddQuantity.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_AddQuantity.Image = (Image)resources.GetObject("btn_AddQuantity.Image");
            btn_AddQuantity.ImageAlign = ContentAlignment.TopCenter;
            btn_AddQuantity.Location = new Point(637, 10);
            btn_AddQuantity.Name = "btn_AddQuantity";
            btn_AddQuantity.Size = new Size(156, 143);
            btn_AddQuantity.TabIndex = 1;
            btn_AddQuantity.Text = "Add quantity";
            btn_AddQuantity.TextAlign = ContentAlignment.BottomCenter;
            btn_AddQuantity.UseVisualStyleBackColor = true;
            btn_AddQuantity.Click += btn_AddQuantity_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(12, 362);
            button1.Name = "button1";
            button1.Size = new Size(138, 81);
            button1.TabIndex = 16;
            button1.Text = "User Config";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 533);
            Controls.Add(button1);
            Controls.Add(btn_home);
            Controls.Add(btn_logout);
            Controls.Add(btn_ViewStockLevel);
            Controls.Add(btn_ViewTransaction);
            Controls.Add(btn_DelStock);
            Controls.Add(btn_RemQuantity);
            Controls.Add(btn_AddQuantity);
            Controls.Add(btn_AddNewStock);
            Controls.Add(splitter1);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_AddNewStock;
        private Button btn_RemQuantity;
        private Button btn_ViewTransaction;
        private Button btn_ViewStockLevel;
        private Button btn_logout;
        private Button btn_DelStock;
        private Splitter splitter1;
        private Button btn_home;
        private Button btn_AddQuantity;
        private Button button1;
    }
}
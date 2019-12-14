namespace wf_CanteenManagement
{
    partial class fAdmin
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
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbSearchFoodName = new System.Windows.Forms.TextBox();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbFoodID = new System.Windows.Forms.TextBox();
            this.lbIDFood = new System.Windows.Forms.Label();
            this.tpFoodCategory = new System.Windows.Forms.TabPage();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txbCategoryName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txbCategoryID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txbSearchCategoryName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnShowCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tcAdmin.SuspendLayout();
            this.tpBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.panel2.SuspendLayout();
            this.tpFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tpFoodCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel18.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Controls.Add(this.tpFood);
            this.tcAdmin.Controls.Add(this.tpFoodCategory);
            this.tcAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tcAdmin.Location = new System.Drawing.Point(0, 0);
            this.tcAdmin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1943, 1182);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.dtgvBill);
            this.tpBill.Controls.Add(this.panel2);
            this.tpBill.Location = new System.Drawing.Point(4, 45);
            this.tpBill.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tpBill.Size = new System.Drawing.Size(1935, 1133);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // dtgvBill
            // 
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(185, 116);
            this.dtgvBill.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.Size = new System.Drawing.Size(1503, 930);
            this.dtgvBill.TabIndex = 0;
            this.dtgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBill_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnViewBill);
            this.panel2.Controls.Add(this.dtpkToDate);
            this.panel2.Controls.Add(this.dtpkFromDate);
            this.panel2.Location = new System.Drawing.Point(179, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1503, 92);
            this.panel2.TabIndex = 2;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Location = new System.Drawing.Point(705, 16);
            this.btnViewBill.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(176, 58);
            this.btnViewBill.TabIndex = 2;
            this.btnViewBill.Text = "Thống kê";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.CustomFormat = "dd-MM-yyyy";
            this.dtpkToDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkToDate.Location = new System.Drawing.Point(389, 24);
            this.dtpkToDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(272, 40);
            this.dtpkToDate.TabIndex = 1;
            this.dtpkToDate.Value = new System.DateTime(2019, 12, 14, 0, 0, 0, 0);
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.AllowDrop = true;
            this.dtpkFromDate.CustomFormat = "dd-MM-yyyy";
            this.dtpkFromDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkFromDate.Location = new System.Drawing.Point(20, 24);
            this.dtpkFromDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(272, 40);
            this.dtpkFromDate.TabIndex = 0;
            this.dtpkFromDate.Value = new System.DateTime(2019, 12, 14, 0, 0, 0, 0);
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.dtgvFood);
            this.tpFood.Controls.Add(this.panel3);
            this.tpFood.Controls.Add(this.panel4);
            this.tpFood.Controls.Add(this.panel6);
            this.tpFood.Location = new System.Drawing.Point(4, 45);
            this.tpFood.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tpFood.Size = new System.Drawing.Size(1935, 1133);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Thức ăn";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // dtgvFood
            // 
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(48, 151);
            this.dtgvFood.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.Size = new System.Drawing.Size(1129, 895);
            this.dtgvFood.TabIndex = 0;
            this.dtgvFood.SelectionChanged += new System.EventHandler(this.dtgvFood_SelectionChanged);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(1225, 18);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 129);
            this.panel3.TabIndex = 1;
            // 
            // btnShowFood
            // 
            this.btnShowFood.Location = new System.Drawing.Point(363, 631);
            this.btnShowFood.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(255, 78);
            this.btnShowFood.TabIndex = 3;
            this.btnShowFood.Text = "Xem";
            this.btnShowFood.UseVisualStyleBackColor = true;
            this.btnShowFood.Click += new System.EventHandler(this.BtnShowFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(31, 482);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(252, 77);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.BtnAddFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(363, 482);
            this.btnDeleteFood.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(255, 77);
            this.btnDeleteFood.TabIndex = 1;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.BtnDeleteFood_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.Location = new System.Drawing.Point(41, 631);
            this.btnEditFood.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(242, 78);
            this.btnEditFood.TabIndex = 2;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.BtnEditFood_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbSearchFoodName);
            this.panel4.Controls.Add(this.btnSearchFood);
            this.panel4.Location = new System.Drawing.Point(48, 11);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1129, 129);
            this.panel4.TabIndex = 2;
            // 
            // txbSearchFoodName
            // 
            this.txbSearchFoodName.Location = new System.Drawing.Point(0, 50);
            this.txbSearchFoodName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbSearchFoodName.Name = "txbSearchFoodName";
            this.txbSearchFoodName.Size = new System.Drawing.Size(936, 42);
            this.txbSearchFoodName.TabIndex = 5;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.Location = new System.Drawing.Point(960, 48);
            this.btnSearchFood.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(130, 44);
            this.btnSearchFood.TabIndex = 4;
            this.btnSearchFood.Text = "Tìm";
            this.btnSearchFood.UseVisualStyleBackColor = true;
            this.btnSearchFood.Click += new System.EventHandler(this.BtnSearchFood_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnShowFood);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.btnEditFood);
            this.panel6.Controls.Add(this.btnDeleteFood);
            this.panel6.Controls.Add(this.btnAddFood);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(1225, 151);
            this.panel6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(638, 895);
            this.panel6.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.nmFoodPrice);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Location = new System.Drawing.Point(6, 321);
            this.panel10.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(627, 85);
            this.panel10.TabIndex = 4;
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Location = new System.Drawing.Point(193, 24);
            this.nmFoodPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(424, 42);
            this.nmFoodPrice.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbCategory);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Location = new System.Drawing.Point(6, 225);
            this.panel9.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(627, 85);
            this.panel9.TabIndex = 3;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(193, 22);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(420, 44);
            this.cbCategory.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh mục:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txbFoodName);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Location = new System.Drawing.Point(6, 129);
            this.panel8.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(627, 85);
            this.panel8.TabIndex = 2;
            // 
            // txbFoodName
            // 
            this.txbFoodName.Location = new System.Drawing.Point(193, 26);
            this.txbFoodName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.ReadOnly = true;
            this.txbFoodName.Size = new System.Drawing.Size(420, 42);
            this.txbFoodName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên món:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbFoodID);
            this.panel7.Controls.Add(this.lbIDFood);
            this.panel7.Location = new System.Drawing.Point(6, 33);
            this.panel7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(627, 85);
            this.panel7.TabIndex = 1;
            // 
            // txbFoodID
            // 
            this.txbFoodID.Location = new System.Drawing.Point(193, 26);
            this.txbFoodID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.ReadOnly = true;
            this.txbFoodID.Size = new System.Drawing.Size(420, 42);
            this.txbFoodID.TabIndex = 1;
            // 
            // lbIDFood
            // 
            this.lbIDFood.AutoSize = true;
            this.lbIDFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDFood.Location = new System.Drawing.Point(6, 26);
            this.lbIDFood.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbIDFood.Name = "lbIDFood";
            this.lbIDFood.Size = new System.Drawing.Size(53, 32);
            this.lbIDFood.TabIndex = 0;
            this.lbIDFood.Text = "ID:";
            // 
            // tpFoodCategory
            // 
            this.tpFoodCategory.Controls.Add(this.dtgvCategory);
            this.tpFoodCategory.Controls.Add(this.panel11);
            this.tpFoodCategory.Controls.Add(this.panel17);
            this.tpFoodCategory.Controls.Add(this.panel18);
            this.tpFoodCategory.Location = new System.Drawing.Point(4, 45);
            this.tpFoodCategory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tpFoodCategory.Name = "tpFoodCategory";
            this.tpFoodCategory.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tpFoodCategory.Size = new System.Drawing.Size(1935, 1133);
            this.tpFoodCategory.TabIndex = 2;
            this.tpFoodCategory.Text = "Danh mục";
            this.tpFoodCategory.UseVisualStyleBackColor = true;
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Location = new System.Drawing.Point(15, 188);
            this.dtgvCategory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.Size = new System.Drawing.Size(1162, 858);
            this.dtgvCategory.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnShowCategory);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Controls.Add(this.btnDeleteCategory);
            this.panel11.Controls.Add(this.btnEditCategory);
            this.panel11.Controls.Add(this.panel15);
            this.panel11.Controls.Add(this.btnAddCategory);
            this.panel11.Location = new System.Drawing.Point(1188, 188);
            this.panel11.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(691, 858);
            this.panel11.TabIndex = 7;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.txbCategoryName);
            this.panel14.Controls.Add(this.label6);
            this.panel14.Location = new System.Drawing.Point(28, 126);
            this.panel14.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(640, 85);
            this.panel14.TabIndex = 2;
            // 
            // txbCategoryName
            // 
            this.txbCategoryName.Location = new System.Drawing.Point(249, 26);
            this.txbCategoryName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.ReadOnly = true;
            this.txbCategoryName.Size = new System.Drawing.Size(382, 42);
            this.txbCategoryName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên danh mục:";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txbCategoryID);
            this.panel15.Controls.Add(this.label7);
            this.panel15.Location = new System.Drawing.Point(28, 30);
            this.panel15.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(640, 85);
            this.panel15.TabIndex = 1;
            // 
            // txbCategoryID
            // 
            this.txbCategoryID.Location = new System.Drawing.Point(249, 26);
            this.txbCategoryID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbCategoryID.Name = "txbCategoryID";
            this.txbCategoryID.ReadOnly = true;
            this.txbCategoryID.Size = new System.Drawing.Size(382, 42);
            this.txbCategoryID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID:";
            // 
            // panel17
            // 
            this.panel17.Location = new System.Drawing.Point(1188, 18);
            this.panel17.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(691, 159);
            this.panel17.TabIndex = 5;
            // 
            // txbSearchCategoryName
            // 
            this.txbSearchCategoryName.Location = new System.Drawing.Point(6, 60);
            this.txbSearchCategoryName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbSearchCategoryName.Name = "txbSearchCategoryName";
            this.txbSearchCategoryName.Size = new System.Drawing.Size(886, 42);
            this.txbSearchCategoryName.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(925, 56);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.button1);
            this.panel18.Controls.Add(this.txbSearchCategoryName);
            this.panel18.Location = new System.Drawing.Point(15, 11);
            this.panel18.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1162, 166);
            this.panel18.TabIndex = 4;
            // 
            // btnShowCategory
            // 
            this.btnShowCategory.Location = new System.Drawing.Point(396, 418);
            this.btnShowCategory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnShowCategory.Name = "btnShowCategory";
            this.btnShowCategory.Size = new System.Drawing.Size(271, 71);
            this.btnShowCategory.TabIndex = 3;
            this.btnShowCategory.Text = "Xem";
            this.btnShowCategory.UseVisualStyleBackColor = true;
            this.btnShowCategory.Click += new System.EventHandler(this.BtnShowCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(396, 319);
            this.btnEditCategory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(271, 67);
            this.btnEditCategory.TabIndex = 2;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(28, 418);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(273, 71);
            this.btnDeleteCategory.TabIndex = 1;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(28, 319);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(273, 67);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1987, 1214);
            this.Controls.Add(this.tcAdmin);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            this.tcAdmin.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tpFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tpFoodCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TabPage tpFoodCategory;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txbFoodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbFoodID;
        private System.Windows.Forms.Label lbIDFood;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown nmFoodPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txbCategoryName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txbCategoryID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgvCategory;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txbSearchCategoryName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button btnShowCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnShowFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbSearchFoodName;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.DataGridView dtgvFood;
    }
}
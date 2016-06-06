namespace IPT_Milk_Company_UI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tmr_Refresh = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Subtext = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_takeOrder = new System.Windows.Forms.Button();
            this.btn_addEmployee = new System.Windows.Forms.Button();
            this.btn_addFarmer = new System.Windows.Forms.Button();
            this.btn_addDealer = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btn_addFactory = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_addTruck = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.tab_Orders = new MetroFramework.Controls.MetroTabPage();
            this.ordersView = new System.Windows.Forms.DataGridView();
            this.tab_Employees = new MetroFramework.Controls.MetroTabPage();
            this.employeesView = new System.Windows.Forms.DataGridView();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.officesView = new System.Windows.Forms.DataGridView();
            this.tab_Dealer = new MetroFramework.Controls.MetroTabPage();
            this.dealerView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tab_Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersView)).BeginInit();
            this.tab_Employees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesView)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officesView)).BeginInit();
            this.tab_Dealer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealerView)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_Refresh
            // 
            this.tmr_Refresh.Enabled = true;
            this.tmr_Refresh.Interval = 10000;
            this.tmr_Refresh.Tick += new System.EventHandler(this.tmr_Refresh_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Subtext, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroTabControl1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 30);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.32015F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.12496F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.55489F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 526);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lbl_Subtext
            // 
            this.lbl_Subtext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Subtext.AutoSize = true;
            this.lbl_Subtext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subtext.Location = new System.Drawing.Point(3, 507);
            this.lbl_Subtext.Name = "lbl_Subtext";
            this.lbl_Subtext.Size = new System.Drawing.Size(86, 15);
            this.lbl_Subtext.TabIndex = 11;
            this.lbl_Subtext.Text = "Welcome Rohyl";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(295, 42);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Management Panel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(748, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "ALUNA MILK";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.tab_Orders);
            this.metroTabControl1.Controls.Add(this.tab_Employees);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.tab_Dealer);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(3, 70);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(748, 431);
            this.metroTabControl1.TabIndex = 8;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.tableLayoutPanel2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Padding = new System.Windows.Forms.Padding(1);
            this.metroTabPage1.Size = new System.Drawing.Size(740, 389);
            this.metroTabPage1.TabIndex = 2;
            this.metroTabPage1.Text = "Management";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btn_takeOrder, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_addEmployee, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_addFarmer, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_addDealer, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.button8, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_addFactory, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button7, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_addTruck, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_addProduct, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(738, 387);
            this.tableLayoutPanel2.TabIndex = 24;
            // 
            // btn_takeOrder
            // 
            this.btn_takeOrder.BackColor = System.Drawing.Color.Teal;
            this.tableLayoutPanel2.SetColumnSpan(this.btn_takeOrder, 3);
            this.btn_takeOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_takeOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_takeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_takeOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btn_takeOrder.ForeColor = System.Drawing.Color.White;
            this.btn_takeOrder.Image = ((System.Drawing.Image)(resources.GetObject("btn_takeOrder.Image")));
            this.btn_takeOrder.Location = new System.Drawing.Point(3, 3);
            this.btn_takeOrder.Name = "btn_takeOrder";
            this.btn_takeOrder.Size = new System.Drawing.Size(546, 123);
            this.btn_takeOrder.TabIndex = 16;
            this.btn_takeOrder.Text = "Take Order";
            this.btn_takeOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_takeOrder.UseVisualStyleBackColor = false;
            this.btn_takeOrder.Click += new System.EventHandler(this.btn_addOrder_Click);
            // 
            // btn_addEmployee
            // 
            this.btn_addEmployee.BackColor = System.Drawing.Color.Teal;
            this.btn_addEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_addEmployee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_addEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btn_addEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_addEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btn_addEmployee.Image")));
            this.btn_addEmployee.Location = new System.Drawing.Point(555, 3);
            this.btn_addEmployee.Name = "btn_addEmployee";
            this.btn_addEmployee.Size = new System.Drawing.Size(180, 123);
            this.btn_addEmployee.TabIndex = 14;
            this.btn_addEmployee.Text = "Employee";
            this.btn_addEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_addEmployee.UseVisualStyleBackColor = false;
            this.btn_addEmployee.Click += new System.EventHandler(this.btn_addEmployee_Click);
            // 
            // btn_addFarmer
            // 
            this.btn_addFarmer.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_addFarmer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_addFarmer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_addFarmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addFarmer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btn_addFarmer.ForeColor = System.Drawing.Color.White;
            this.btn_addFarmer.Image = ((System.Drawing.Image)(resources.GetObject("btn_addFarmer.Image")));
            this.btn_addFarmer.Location = new System.Drawing.Point(555, 261);
            this.btn_addFarmer.Name = "btn_addFarmer";
            this.btn_addFarmer.Size = new System.Drawing.Size(180, 123);
            this.btn_addFarmer.TabIndex = 23;
            this.btn_addFarmer.Text = "Farmer";
            this.btn_addFarmer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_addFarmer.UseVisualStyleBackColor = false;
            this.btn_addFarmer.Click += new System.EventHandler(this.btn_noFunction);
            // 
            // btn_addDealer
            // 
            this.btn_addDealer.BackColor = System.Drawing.Color.Teal;
            this.btn_addDealer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_addDealer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_addDealer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addDealer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btn_addDealer.ForeColor = System.Drawing.Color.White;
            this.btn_addDealer.Image = ((System.Drawing.Image)(resources.GetObject("btn_addDealer.Image")));
            this.btn_addDealer.Location = new System.Drawing.Point(555, 132);
            this.btn_addDealer.Name = "btn_addDealer";
            this.btn_addDealer.Size = new System.Drawing.Size(180, 123);
            this.btn_addDealer.TabIndex = 19;
            this.btn_addDealer.Text = "Dealer";
            this.btn_addDealer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_addDealer.UseVisualStyleBackColor = false;
            this.btn_addDealer.Click += new System.EventHandler(this.btn_addDealer_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(371, 261);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(178, 123);
            this.button8.TabIndex = 22;
            this.button8.Text = "Location";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btn_noFunction);
            // 
            // btn_addFactory
            // 
            this.btn_addFactory.BackColor = System.Drawing.Color.Teal;
            this.btn_addFactory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_addFactory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_addFactory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addFactory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btn_addFactory.ForeColor = System.Drawing.Color.White;
            this.btn_addFactory.Image = ((System.Drawing.Image)(resources.GetObject("btn_addFactory.Image")));
            this.btn_addFactory.Location = new System.Drawing.Point(3, 132);
            this.btn_addFactory.Name = "btn_addFactory";
            this.btn_addFactory.Size = new System.Drawing.Size(178, 123);
            this.btn_addFactory.TabIndex = 16;
            this.btn_addFactory.Text = "Factory";
            this.btn_addFactory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_addFactory.UseVisualStyleBackColor = false;
            this.btn_addFactory.Click += new System.EventHandler(this.btn_addFactory_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(187, 261);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(178, 123);
            this.button7.TabIndex = 21;
            this.button7.Text = "Cooling Centers";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btn_noFunction);
            // 
            // btn_addTruck
            // 
            this.btn_addTruck.BackColor = System.Drawing.Color.Teal;
            this.btn_addTruck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_addTruck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_addTruck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addTruck.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btn_addTruck.ForeColor = System.Drawing.Color.White;
            this.btn_addTruck.Image = ((System.Drawing.Image)(resources.GetObject("btn_addTruck.Image")));
            this.btn_addTruck.Location = new System.Drawing.Point(187, 132);
            this.btn_addTruck.Name = "btn_addTruck";
            this.btn_addTruck.Size = new System.Drawing.Size(178, 123);
            this.btn_addTruck.TabIndex = 18;
            this.btn_addTruck.Text = "Truck";
            this.btn_addTruck.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_addTruck.UseVisualStyleBackColor = false;
            this.btn_addTruck.Click += new System.EventHandler(this.btn_addTruck_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(3, 261);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(178, 123);
            this.button6.TabIndex = 20;
            this.button6.Text = "Farm";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btn_noFunction);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.BackColor = System.Drawing.Color.Teal;
            this.btn_addProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_addProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btn_addProduct.ForeColor = System.Drawing.Color.White;
            this.btn_addProduct.Image = ((System.Drawing.Image)(resources.GetObject("btn_addProduct.Image")));
            this.btn_addProduct.Location = new System.Drawing.Point(371, 132);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(178, 123);
            this.btn_addProduct.TabIndex = 17;
            this.btn_addProduct.Text = "Product";
            this.btn_addProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_addProduct.UseVisualStyleBackColor = false;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // tab_Orders
            // 
            this.tab_Orders.Controls.Add(this.ordersView);
            this.tab_Orders.HorizontalScrollbarBarColor = true;
            this.tab_Orders.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_Orders.HorizontalScrollbarSize = 10;
            this.tab_Orders.Location = new System.Drawing.Point(4, 38);
            this.tab_Orders.Name = "tab_Orders";
            this.tab_Orders.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.tab_Orders.Size = new System.Drawing.Size(740, 389);
            this.tab_Orders.TabIndex = 0;
            this.tab_Orders.Text = "Orders";
            this.tab_Orders.VerticalScrollbarBarColor = true;
            this.tab_Orders.VerticalScrollbarHighlightOnWheel = false;
            this.tab_Orders.VerticalScrollbarSize = 10;
            // 
            // ordersView
            // 
            this.ordersView.AllowUserToAddRows = false;
            this.ordersView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ordersView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ordersView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersView.BackgroundColor = System.Drawing.Color.White;
            this.ordersView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordersView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ordersView.ColumnHeadersHeight = 25;
            this.ordersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ordersView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersView.EnableHeadersVisualStyles = false;
            this.ordersView.GridColor = System.Drawing.Color.Black;
            this.ordersView.Location = new System.Drawing.Point(1, 1);
            this.ordersView.Margin = new System.Windows.Forms.Padding(0);
            this.ordersView.MultiSelect = false;
            this.ordersView.Name = "ordersView";
            this.ordersView.ReadOnly = true;
            this.ordersView.RowHeadersVisible = false;
            this.ordersView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersView.Size = new System.Drawing.Size(739, 388);
            this.ordersView.TabIndex = 4;
            // 
            // tab_Employees
            // 
            this.tab_Employees.Controls.Add(this.employeesView);
            this.tab_Employees.HorizontalScrollbarBarColor = true;
            this.tab_Employees.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_Employees.HorizontalScrollbarSize = 10;
            this.tab_Employees.Location = new System.Drawing.Point(4, 38);
            this.tab_Employees.Name = "tab_Employees";
            this.tab_Employees.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.tab_Employees.Size = new System.Drawing.Size(770, 389);
            this.tab_Employees.TabIndex = 1;
            this.tab_Employees.Text = "Employees";
            this.tab_Employees.VerticalScrollbarBarColor = true;
            this.tab_Employees.VerticalScrollbarHighlightOnWheel = false;
            this.tab_Employees.VerticalScrollbarSize = 10;
            // 
            // employeesView
            // 
            this.employeesView.AllowUserToAddRows = false;
            this.employeesView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.employeesView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.employeesView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeesView.BackgroundColor = System.Drawing.Color.White;
            this.employeesView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeesView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeesView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.employeesView.ColumnHeadersHeight = 25;
            this.employeesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeesView.DefaultCellStyle = dataGridViewCellStyle6;
            this.employeesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesView.EnableHeadersVisualStyles = false;
            this.employeesView.GridColor = System.Drawing.Color.Black;
            this.employeesView.Location = new System.Drawing.Point(0, 1);
            this.employeesView.MultiSelect = false;
            this.employeesView.Name = "employeesView";
            this.employeesView.ReadOnly = true;
            this.employeesView.RowHeadersVisible = false;
            this.employeesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesView.Size = new System.Drawing.Size(770, 388);
            this.employeesView.TabIndex = 6;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.officesView);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.metroTabPage2.Size = new System.Drawing.Size(770, 389);
            this.metroTabPage2.TabIndex = 3;
            this.metroTabPage2.Text = "Offices";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // officesView
            // 
            this.officesView.AllowUserToAddRows = false;
            this.officesView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.officesView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.officesView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.officesView.BackgroundColor = System.Drawing.Color.White;
            this.officesView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.officesView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.officesView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.officesView.ColumnHeadersHeight = 25;
            this.officesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.officesView.DefaultCellStyle = dataGridViewCellStyle9;
            this.officesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.officesView.EnableHeadersVisualStyles = false;
            this.officesView.GridColor = System.Drawing.Color.Black;
            this.officesView.Location = new System.Drawing.Point(1, 1);
            this.officesView.MultiSelect = false;
            this.officesView.Name = "officesView";
            this.officesView.ReadOnly = true;
            this.officesView.RowHeadersVisible = false;
            this.officesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.officesView.Size = new System.Drawing.Size(769, 388);
            this.officesView.TabIndex = 4;
            // 
            // tab_Dealer
            // 
            this.tab_Dealer.Controls.Add(this.dealerView);
            this.tab_Dealer.HorizontalScrollbarBarColor = true;
            this.tab_Dealer.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_Dealer.HorizontalScrollbarSize = 10;
            this.tab_Dealer.Location = new System.Drawing.Point(4, 38);
            this.tab_Dealer.Name = "tab_Dealer";
            this.tab_Dealer.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.tab_Dealer.Size = new System.Drawing.Size(770, 389);
            this.tab_Dealer.TabIndex = 4;
            this.tab_Dealer.Text = "Dealer";
            this.tab_Dealer.VerticalScrollbarBarColor = true;
            this.tab_Dealer.VerticalScrollbarHighlightOnWheel = false;
            this.tab_Dealer.VerticalScrollbarSize = 10;
            // 
            // dealerView
            // 
            this.dealerView.AllowUserToAddRows = false;
            this.dealerView.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dealerView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dealerView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dealerView.BackgroundColor = System.Drawing.Color.White;
            this.dealerView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dealerView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dealerView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dealerView.ColumnHeadersHeight = 25;
            this.dealerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dealerView.DefaultCellStyle = dataGridViewCellStyle12;
            this.dealerView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dealerView.EnableHeadersVisualStyles = false;
            this.dealerView.GridColor = System.Drawing.Color.Black;
            this.dealerView.Location = new System.Drawing.Point(0, 1);
            this.dealerView.MultiSelect = false;
            this.dealerView.Name = "dealerView";
            this.dealerView.ReadOnly = true;
            this.dealerView.RowHeadersVisible = false;
            this.dealerView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dealerView.Size = new System.Drawing.Size(770, 388);
            this.dealerView.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 556);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DisplayHeader = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15, 30, 15, 0);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tab_Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersView)).EndInit();
            this.tab_Employees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesView)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.officesView)).EndInit();
            this.tab_Dealer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dealerView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmr_Refresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Button btn_addFarmer;
        private System.Windows.Forms.Button btn_addDealer;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Button btn_addTruck;
        private System.Windows.Forms.Button btn_addFactory;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_addEmployee;
        private MetroFramework.Controls.MetroTabPage tab_Orders;
        private MetroFramework.Controls.MetroTabPage tab_Employees;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage tab_Dealer;
        private System.Windows.Forms.DataGridView employeesView;
        private System.Windows.Forms.DataGridView ordersView;
        private System.Windows.Forms.DataGridView officesView;
        private System.Windows.Forms.DataGridView dealerView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_takeOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Subtext;
    }
}


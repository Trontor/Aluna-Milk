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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tab_Orders = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ordersView = new System.Windows.Forms.DataGridView();
            this.tab_Employees = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.employeesView = new System.Windows.Forms.DataGridView();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btn_addDealer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_addEmployee = new System.Windows.Forms.Button();
            this.tmr_Refresh = new System.Windows.Forms.Timer(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Subtext = new System.Windows.Forms.Label();
            this.metroTabControl1.SuspendLayout();
            this.tab_Orders.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersView)).BeginInit();
            this.tab_Employees.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesView)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.tab_Orders);
            this.metroTabControl1.Controls.Add(this.tab_Employees);
            this.metroTabControl1.Location = new System.Drawing.Point(26, 81);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(715, 416);
            this.metroTabControl1.TabIndex = 5;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tab_Orders
            // 
            this.tab_Orders.Controls.Add(this.panel1);
            this.tab_Orders.HorizontalScrollbarBarColor = true;
            this.tab_Orders.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_Orders.HorizontalScrollbarSize = 10;
            this.tab_Orders.Location = new System.Drawing.Point(4, 38);
            this.tab_Orders.Name = "tab_Orders";
            this.tab_Orders.Size = new System.Drawing.Size(707, 374);
            this.tab_Orders.TabIndex = 0;
            this.tab_Orders.Text = "Orders";
            this.tab_Orders.VerticalScrollbarBarColor = true;
            this.tab_Orders.VerticalScrollbarHighlightOnWheel = false;
            this.tab_Orders.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ordersView);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 368);
            this.panel1.TabIndex = 4;
            // 
            // ordersView
            // 
            this.ordersView.AllowUserToAddRows = false;
            this.ordersView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ordersView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ordersView.BackgroundColor = System.Drawing.Color.White;
            this.ordersView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordersView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ordersView.ColumnHeadersHeight = 25;
            this.ordersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersView.DefaultCellStyle = dataGridViewCellStyle9;
            this.ordersView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersView.EnableHeadersVisualStyles = false;
            this.ordersView.GridColor = System.Drawing.Color.Black;
            this.ordersView.Location = new System.Drawing.Point(0, 0);
            this.ordersView.MultiSelect = false;
            this.ordersView.Name = "ordersView";
            this.ordersView.ReadOnly = true;
            this.ordersView.RowHeadersVisible = false;
            this.ordersView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersView.Size = new System.Drawing.Size(704, 368);
            this.ordersView.TabIndex = 3;
            this.ordersView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ordersView_MouseClick);
            // 
            // tab_Employees
            // 
            this.tab_Employees.Controls.Add(this.panel2);
            this.tab_Employees.HorizontalScrollbarBarColor = true;
            this.tab_Employees.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_Employees.HorizontalScrollbarSize = 10;
            this.tab_Employees.Location = new System.Drawing.Point(4, 38);
            this.tab_Employees.Name = "tab_Employees";
            this.tab_Employees.Size = new System.Drawing.Size(707, 374);
            this.tab_Employees.TabIndex = 1;
            this.tab_Employees.Text = "Employees";
            this.tab_Employees.VerticalScrollbarBarColor = true;
            this.tab_Employees.VerticalScrollbarHighlightOnWheel = false;
            this.tab_Employees.VerticalScrollbarSize = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.employeesView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 371);
            this.panel2.TabIndex = 5;
            // 
            // employeesView
            // 
            this.employeesView.AllowUserToAddRows = false;
            this.employeesView.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.employeesView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.employeesView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeesView.BackgroundColor = System.Drawing.Color.White;
            this.employeesView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeesView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeesView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.employeesView.ColumnHeadersHeight = 25;
            this.employeesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeesView.DefaultCellStyle = dataGridViewCellStyle12;
            this.employeesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesView.EnableHeadersVisualStyles = false;
            this.employeesView.GridColor = System.Drawing.Color.Black;
            this.employeesView.Location = new System.Drawing.Point(0, 0);
            this.employeesView.MultiSelect = false;
            this.employeesView.Name = "employeesView";
            this.employeesView.ReadOnly = true;
            this.employeesView.RowHeadersVisible = false;
            this.employeesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesView.Size = new System.Drawing.Size(707, 371);
            this.employeesView.TabIndex = 4;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btn_addDealer);
            this.metroTabPage1.Controls.Add(this.button5);
            this.metroTabPage1.Controls.Add(this.button1);
            this.metroTabPage1.Controls.Add(this.button4);
            this.metroTabPage1.Controls.Add(this.button8);
            this.metroTabPage1.Controls.Add(this.button7);
            this.metroTabPage1.Controls.Add(this.button6);
            this.metroTabPage1.Controls.Add(this.button2);
            this.metroTabPage1.Controls.Add(this.btn_addEmployee);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(707, 374);
            this.metroTabPage1.TabIndex = 2;
            this.metroTabPage1.Text = "Management";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // btn_addDealer
            // 
            this.btn_addDealer.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_addDealer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_addDealer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addDealer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btn_addDealer.ForeColor = System.Drawing.Color.White;
            this.btn_addDealer.Image = ((System.Drawing.Image)(resources.GetObject("btn_addDealer.Image")));
            this.btn_addDealer.Location = new System.Drawing.Point(531, 85);
            this.btn_addDealer.Name = "btn_addDealer";
            this.btn_addDealer.Size = new System.Drawing.Size(169, 125);
            this.btn_addDealer.TabIndex = 19;
            this.btn_addDealer.Text = "Dealer";
            this.btn_addDealer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_addDealer.UseVisualStyleBackColor = false;
            this.btn_addDealer.Click += new System.EventHandler(this.btn_addDealer_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(181, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 125);
            this.button1.TabIndex = 18;
            this.button1.Text = "Truck";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_addTruck_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkCyan;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(356, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 125);
            this.button5.TabIndex = 17;
            this.button5.Text = "Product";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkCyan;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(6, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 125);
            this.button4.TabIndex = 16;
            this.button4.Text = "Factory";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btn_addFactory_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(6, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(694, 76);
            this.button2.TabIndex = 15;
            this.button2.Text = "Take Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_addOrder_Click);
            // 
            // btn_addEmployee
            // 
            this.btn_addEmployee.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_addEmployee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_addEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btn_addEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_addEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btn_addEmployee.Image")));
            this.btn_addEmployee.Location = new System.Drawing.Point(531, 217);
            this.btn_addEmployee.Name = "btn_addEmployee";
            this.btn_addEmployee.Size = new System.Drawing.Size(169, 125);
            this.btn_addEmployee.TabIndex = 14;
            this.btn_addEmployee.Text = "Employee";
            this.btn_addEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_addEmployee.UseVisualStyleBackColor = false;
            this.btn_addEmployee.Click += new System.EventHandler(this.btn_addEmployee_Click);
            // 
            // tmr_Refresh
            // 
            this.tmr_Refresh.Enabled = true;
            this.tmr_Refresh.Interval = 10000;
            this.tmr_Refresh.Tick += new System.EventHandler(this.tmr_Refresh_Tick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkCyan;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(6, 216);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(169, 125);
            this.button6.TabIndex = 20;
            this.button6.Text = "Farm";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkCyan;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(181, 217);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(169, 125);
            this.button7.TabIndex = 21;
            this.button7.Text = "Cooling Centers";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkCyan;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(356, 217);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(169, 125);
            this.button8.TabIndex = 22;
            this.button8.Text = "Location";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(272, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 44);
            this.label2.TabIndex = 6;
            this.label2.Text = "ALUNA MILK";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(306, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Management Panel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Subtext
            // 
            this.lbl_Subtext.AutoSize = true;
            this.lbl_Subtext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subtext.Location = new System.Drawing.Point(32, 496);
            this.lbl_Subtext.Name = "lbl_Subtext";
            this.lbl_Subtext.Size = new System.Drawing.Size(86, 15);
            this.lbl_Subtext.TabIndex = 8;
            this.lbl_Subtext.Text = "Welcome Rohyl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 520);
            this.Controls.Add(this.lbl_Subtext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Form1";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tab_Orders.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersView)).EndInit();
            this.tab_Employees.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesView)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tab_Orders;
        private System.Windows.Forms.DataGridView ordersView;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabPage tab_Employees;
        private System.Windows.Forms.DataGridView employeesView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer tmr_Refresh;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Button btn_addEmployee;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_addDealer;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Subtext;
    }
}


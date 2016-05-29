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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Subtext = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tab_Orders = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ordersView = new System.Windows.Forms.DataGridView();
            this.tab_Employees = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.employeesView = new System.Windows.Forms.DataGridView();
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_addFactory = new System.Windows.Forms.Button();
            this.btn_addEmployee = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.metroTabControl1.SuspendLayout();
            this.tab_Orders.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersView)).BeginInit();
            this.tab_Employees.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Subtext
            // 
            this.lbl_Subtext.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subtext.Location = new System.Drawing.Point(23, 55);
            this.lbl_Subtext.Name = "lbl_Subtext";
            this.lbl_Subtext.Size = new System.Drawing.Size(624, 23);
            this.lbl_Subtext.TabIndex = 4;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tab_Orders);
            this.metroTabControl1.Controls.Add(this.tab_Employees);
            this.metroTabControl1.Location = new System.Drawing.Point(26, 81);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(621, 291);
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
            this.tab_Orders.Size = new System.Drawing.Size(613, 249);
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
            this.panel1.Size = new System.Drawing.Size(613, 243);
            this.panel1.TabIndex = 4;
            // 
            // ordersView
            // 
            this.ordersView.AllowUserToAddRows = false;
            this.ordersView.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ordersView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.ordersView.BackgroundColor = System.Drawing.Color.White;
            this.ordersView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordersView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.ordersView.ColumnHeadersHeight = 25;
            this.ordersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersView.DefaultCellStyle = dataGridViewCellStyle27;
            this.ordersView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersView.EnableHeadersVisualStyles = false;
            this.ordersView.GridColor = System.Drawing.Color.Black;
            this.ordersView.Location = new System.Drawing.Point(0, 0);
            this.ordersView.MultiSelect = false;
            this.ordersView.Name = "ordersView";
            this.ordersView.ReadOnly = true;
            this.ordersView.RowHeadersVisible = false;
            this.ordersView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersView.Size = new System.Drawing.Size(613, 243);
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
            this.tab_Employees.Size = new System.Drawing.Size(613, 249);
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
            this.panel2.Size = new System.Drawing.Size(613, 246);
            this.panel2.TabIndex = 5;
            // 
            // employeesView
            // 
            this.employeesView.AllowUserToAddRows = false;
            this.employeesView.AllowUserToResizeRows = false;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.employeesView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.employeesView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeesView.BackgroundColor = System.Drawing.Color.White;
            this.employeesView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeesView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeesView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.employeesView.ColumnHeadersHeight = 25;
            this.employeesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeesView.DefaultCellStyle = dataGridViewCellStyle30;
            this.employeesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesView.EnableHeadersVisualStyles = false;
            this.employeesView.GridColor = System.Drawing.Color.Black;
            this.employeesView.Location = new System.Drawing.Point(0, 0);
            this.employeesView.MultiSelect = false;
            this.employeesView.Name = "employeesView";
            this.employeesView.ReadOnly = true;
            this.employeesView.RowHeadersVisible = false;
            this.employeesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesView.Size = new System.Drawing.Size(613, 246);
            this.employeesView.TabIndex = 4;
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btn_addOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addOrder.Location = new System.Drawing.Point(149, 393);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(92, 39);
            this.btn_addOrder.TabIndex = 6;
            this.btn_addOrder.Text = "Add Order";
            this.btn_addOrder.UseVisualStyleBackColor = true;
            this.btn_addOrder.Click += new System.EventHandler(this.btn_addOrder_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(345, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_addFactory
            // 
            this.btn_addFactory.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btn_addFactory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addFactory.Location = new System.Drawing.Point(247, 393);
            this.btn_addFactory.Name = "btn_addFactory";
            this.btn_addFactory.Size = new System.Drawing.Size(92, 39);
            this.btn_addFactory.TabIndex = 8;
            this.btn_addFactory.Text = "Add Factory";
            this.btn_addFactory.UseVisualStyleBackColor = true;
            this.btn_addFactory.Click += new System.EventHandler(this.btn_addFactory_Click);
            // 
            // btn_addEmployee
            // 
            this.btn_addEmployee.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btn_addEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addEmployee.Location = new System.Drawing.Point(51, 393);
            this.btn_addEmployee.Name = "btn_addEmployee";
            this.btn_addEmployee.Size = new System.Drawing.Size(92, 39);
            this.btn_addEmployee.TabIndex = 10;
            this.btn_addEmployee.Text = "Add Employee";
            this.btn_addEmployee.UseVisualStyleBackColor = true;
            this.btn_addEmployee.Click += new System.EventHandler(this.btn_addEmployee_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(447, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 39);
            this.button3.TabIndex = 11;
            this.button3.Text = "Add Truck";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 481);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_addEmployee);
            this.Controls.Add(this.btn_addOrder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_addFactory);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.lbl_Subtext);
            this.Name = "Form1";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Management Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tab_Orders.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersView)).EndInit();
            this.tab_Employees.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Subtext;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tab_Orders;
        private System.Windows.Forms.Button btn_addOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_addFactory;
        private System.Windows.Forms.DataGridView ordersView;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabPage tab_Employees;
        private System.Windows.Forms.DataGridView employeesView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_addEmployee;
        private System.Windows.Forms.Button button3;
    }
}


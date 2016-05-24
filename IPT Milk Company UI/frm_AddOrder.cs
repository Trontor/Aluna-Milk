// Decompiled with JetBrains decompiler
// Type: IPT_Milk_Company_UI.frm_AddOrder
// Assembly: IPT Milk Company UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B024A5FB-939A-443C-BE4D-1C5D1A7C5AB3
// Assembly location: C:\Users\Rohyl Joshi\Documents\IPT Milk Company UI.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using MetroFramework.Forms;

namespace IPT_Milk_Company_UI
{
    public class frm_AddOrder : MetroForm
    {
        private IContainer components = (IContainer)null;
        private Button btn_addProduct;
        private Label label1;
        private ComboBox cmb_Dealer;
        private Label label2;
        private DateTimePicker dtp_Order_Date;
        private Label label3;
        private Label lbl_servicedEmployee;
        private Label lbl_totalPrice;
        private FlowLayoutPanel flw_Products;
        private Button btn_Place_Order;

        public frm_AddOrder()
        {
            this.InitializeComponent();
            this.flw_Products.AutoScroll = false;
            this.flw_Products.HorizontalScroll.Enabled = false;
            this.flw_Products.AutoScroll = true;
        }

        private void UpdatePrice()
        {
            double num = new double();
            foreach (Control control in (ArrangedElementCollection)this.flw_Products.Controls)
            {
                ProductItem productItem = control as ProductItem;
                num += productItem.totalPrice;
            }
            this.lbl_totalPrice.Text = "Total Price: " + string.Format("{0:C}", (object)num);
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            ProductItem product = new ProductItem();
            product.numericUpDown1.ValueChanged += (EventHandler)((u, d) => this.UpdatePrice());
            product.btn_removeProduct.Click += (EventHandler)((z, y) =>
            {
                if (this.flw_Products.Controls.Contains((Control)product))
                    this.flw_Products.Controls.Remove((Control)product);
                this.UpdatePrice();
            });
            this.flw_Products.Controls.Add((Control)product);
        }

        private void flw_Products_SizeChanged(object sender, EventArgs e)
        {
            this.flw_Products.SuspendLayout();
            foreach (Control control in (ArrangedElementCollection)this.flw_Products.Controls)
                control.Width = this.flw_Products.ClientSize.Width;
            this.flw_Products.ResumeLayout();
        }

        private void flw_Products_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.Width = this.flw_Products.ClientSize.Width;
        }

        private void frm_AddOrder_Load(object sender, EventArgs e)
        {
            table = DatabaseHelper.GetTable("Dealer");
            List<string> list = new List<string>();
            for (int index = 0; index < table.Rows.Count; ++index)
            {
                DataRow person = DatabaseHelper.GetPerson(int.Parse(table.Rows[index]["Person ID"].ToString()));
                string str1 = person["First Name"].ToString();
                string str2 = person["Last Name"].ToString();
                string str3 = table.Rows[index]["Company"].ToString();
                list.Add(str1 + " " + str2 + " (" + str3 + ")");
                dealerDict.Add(list[index], int.Parse(table.Rows[index]["Dealer ID"].ToString()));
            }
            this.cmb_Dealer.DataSource = (object)list;
            DataRow dataRow = LoggedInEmployee.EmployeeInformation();
            this.lbl_servicedEmployee.Text = dataRow["First Name"].ToString() + " " + dataRow["Last Name"].ToString() + " (You)";
        }

        private void flw_Products_ControlRemoved(object sender, ControlEventArgs e)
        {
        }

        private void btn_Place_Order_Click(object sender, EventArgs e)
        {

            ValidityChecker validityChecker = new ValidityChecker(dtp_Order_Date, cmb_Dealer);
            if (validityChecker.InvalidFields().Count == 0)
            {
                PlaceOrder();
            }
        }

        private DataTable table = new DataTable();
        Dictionary<string, int> dealerDict = new Dictionary<string, int>();
        private void PlaceOrder()
        {
            //Create entry in Orders table
            int empID = LoggedInEmployee.ID;
            DateTime orderDate = DateTime.Now;
            DataRow dataRow = LoggedInEmployee.EmployeeInformation();
            this.lbl_servicedEmployee.Text = dataRow["First Name"].ToString() + " " + dataRow["Last Name"].ToString() + " (You)";
            int dealerID = dealerDict[cmb_Dealer.SelectedItem.ToString()];

            string orderQuery = string.Format("INSERT INTO Orders([Dealer ID],[Order Date], [Serviced Employee ID]) VALUES ({0},#{1}#,{2})", dealerID, orderDate, empID);
            var rdr = DatabaseHelper.ExecuteQuery(orderQuery);

            DataTable orderTable = DatabaseHelper.GetTable("Orders");

            DataTable productTable = DatabaseHelper.GetTable("Products");
            int orderID = int.Parse(orderTable.Rows[orderTable.Rows.Count - 1]["Order ID"].ToString());

            foreach (ProductItem item in flw_Products.Controls)
            {
                string query = string.Format("INSERT INTO [Order Details]([Order ID], [Product Name], Quantity) VALUES " +
                    "({0},'{1}',{2})", orderID, item.comboBox2.SelectedItem.ToString(),  item.numericUpDown1.Value);
                OleDbDataReader reader = DatabaseHelper.ExecuteQuery(query);
            }
            MessageBox.Show("Order Succesfully Added");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Dealer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_Order_Date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_servicedEmployee = new System.Windows.Forms.Label();
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.flw_Products = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Place_Order = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btn_addProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btn_addProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btn_addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProduct.Location = new System.Drawing.Point(23, 152);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(561, 23);
            this.btn_addProduct.TabIndex = 3;
            this.btn_addProduct.Text = "Add Product";
            this.btn_addProduct.UseVisualStyleBackColor = false;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dealer";
            // 
            // cmb_Dealer
            // 
            this.cmb_Dealer.FormattingEnabled = true;
            this.cmb_Dealer.Location = new System.Drawing.Point(99, 63);
            this.cmb_Dealer.Name = "cmb_Dealer";
            this.cmb_Dealer.Size = new System.Drawing.Size(486, 21);
            this.cmb_Dealer.TabIndex = 5;
            this.cmb_Dealer.SelectedIndexChanged += new System.EventHandler(this.cmb_Dealer_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Required Date";
            // 
            // dtp_Order_Date
            // 
            this.dtp_Order_Date.Location = new System.Drawing.Point(99, 91);
            this.dtp_Order_Date.Name = "dtp_Order_Date";
            this.dtp_Order_Date.Size = new System.Drawing.Size(485, 20);
            this.dtp_Order_Date.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Serviced By";
            // 
            // lbl_servicedEmployee
            // 
            this.lbl_servicedEmployee.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lbl_servicedEmployee.Location = new System.Drawing.Point(95, 121);
            this.lbl_servicedEmployee.Name = "lbl_servicedEmployee";
            this.lbl_servicedEmployee.Size = new System.Drawing.Size(489, 19);
            this.lbl_servicedEmployee.TabIndex = 9;
            this.lbl_servicedEmployee.Text = "label4";
            this.lbl_servicedEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lbl_totalPrice.Location = new System.Drawing.Point(24, 500);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(560, 19);
            this.lbl_totalPrice.TabIndex = 10;
            this.lbl_totalPrice.Text = "Total Price:";
            this.lbl_totalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flw_Products
            // 
            this.flw_Products.AutoScroll = true;
            this.flw_Products.BackColor = System.Drawing.Color.White;
            this.flw_Products.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flw_Products.Location = new System.Drawing.Point(24, 180);
            this.flw_Products.Name = "flw_Products";
            this.flw_Products.Size = new System.Drawing.Size(560, 317);
            this.flw_Products.TabIndex = 11;
            this.flw_Products.WrapContents = false;
            this.flw_Products.SizeChanged += new System.EventHandler(this.flw_Products_SizeChanged);
            this.flw_Products.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flw_Products_ControlAdded);
            this.flw_Products.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flw_Products_ControlRemoved);
            // 
            // btn_Place_Order
            // 
            this.btn_Place_Order.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Place_Order.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btn_Place_Order.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btn_Place_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Place_Order.Location = new System.Drawing.Point(23, 523);
            this.btn_Place_Order.Name = "btn_Place_Order";
            this.btn_Place_Order.Size = new System.Drawing.Size(561, 31);
            this.btn_Place_Order.TabIndex = 12;
            this.btn_Place_Order.Text = "Place Order";
            this.btn_Place_Order.UseVisualStyleBackColor = false;
            this.btn_Place_Order.Click += new System.EventHandler(this.btn_Place_Order_Click);
            // 
            // frm_AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 567);
            this.Controls.Add(this.btn_Place_Order);
            this.Controls.Add(this.flw_Products);
            this.Controls.Add(this.lbl_totalPrice);
            this.Controls.Add(this.lbl_servicedEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_Order_Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Dealer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addProduct);
            this.Name = "frm_AddOrder";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Process Order";
            this.Load += new System.EventHandler(this.frm_AddOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cmb_Dealer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

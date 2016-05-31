using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Threading;

namespace IPT_Milk_Company_UI
{
    public partial class Form1 : MetroForm
    {
        private DataTable table_Employees = new DataTable();
        private DataTable table_Persons = new DataTable();
        private int person_Id = -1;
        public Form1(int emp_ID)
        {
            InitializeComponent();

            table_Employees = DatabaseHelper.GetTable("Employees");
            table_Persons = DatabaseHelper.GetTable("Person");
            person_Id = int.Parse(table_Employees.Rows[emp_ID - 1]["Person ID"].ToString());
            LoggedInEmployee.ID = person_Id;
            string name = LoggedInEmployee.EmployeeInformation()["First Name"].ToString() + " " + LoggedInEmployee.EmployeeInformation()["Last Name"].ToString();///table_Persons.Rows[person_Id - 1]["First Name"].ToString();
            lbl_Subtext.Text = "Welcome " + name;
        }

        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            new frm_AddOrder().Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new frm_AddProduct().Show();
        }

        private void btn_addFactory_Click(object sender, EventArgs e)
        {
            new frm_AddFactory().Show();
        }

        private string NormalizeDate(DateTime endDate)
        {
            var totalDays = (DateTime.Now - endDate).TotalDays;
            var totalYears = Math.Truncate(totalDays / 365);
            var totalMonths = Math.Truncate((totalDays % 365) / 30);
            var remainingDays = Math.Truncate((totalDays % 365) % 30);
            string dstr = "";
            if (totalYears > 0)
            {
                dstr = totalYears.ToString() + " year ago.";
            }
            else if (totalMonths > 0)
            {
                dstr = totalMonths.ToString() + " month ago.";
            }
            else if (remainingDays == 0)
            {
                dstr = "Today";
            }
            else if (remainingDays == 1)
            {
                dstr = "Yesterday";
            }
            else if (remainingDays > 0)
                dstr = remainingDays.ToString() + " day" + (remainingDays > 1 ? "s" : "") + " ago.";
            return dstr;

        }

        private void LoadOrders()
        {
            string query = "SELECT [Order ID], [Last Updated By], [Order Date] AS Ordered, Person.[First Name] & \" \" & Person.[Last Name] AS [Servicer],[Required Date],  TruckPersonID.[First Name] & \" \" & TruckPersonID.[Last Name] AS [Dealer Name], [Company],  [Required Time] as [Required], lmao.Person.[First Name] & \" \" & lmao.Person.[Last Name] AS [Truck Driver], [Sent Date]  FROM (SELECT * FROM (SELECT * FROM (SELECT * FROM (SELECT * FROM (SELECT * FROM  (SELECT * FROM Orders INNER JOIN (SELECT * FROM Dealer INNER JOIN Person ON Dealer.[Person ID] = Person.[Person ID]) DealerInformation ON Orders.[Dealer ID] = DealerInformation.[Dealer ID]) TruckID LEFT JOIN [Truck Drivers] ON TruckID.[Truck ID] = [Truck Drivers].[Truck ID]) TruckEmployeeID LEFT JOIN Employees ON TruckEmployeeID.[Employee ID] = Employees.[Employee ID]) TruckPersonID LEFT JOIN Person ON TruckPersonID.Employees.[Person ID] = Person.[Person ID]) ServicingPerson LEFT JOIN Employees ON ServicingPerson.[Serviced Employee ID] = Employees.[Employee ID]) EmployeePerson LEFT JOIN Person ON EmployeePerson.ServicingPerson.Person.[Person ID] = Person.[Person ID]) lmao LEFT JOIN Person ON lmao.EmployeePerson.Employees.[Person ID] = Person.[Person ID]";
            DataTable dtb = DatabaseHelper.GetTable(null, null, query);
            DataTable clone = dtb.Clone();

            Invoke(new Action(() =>
            {
                clone.Columns["Sent Date"].DataType = typeof(string);
                clone.Columns["Ordered"].DataType = typeof(string);
                clone.Columns["Required"].DataType = typeof(string);
                ordersView.DataSource = clone;
                foreach (DataRow row in dtb.Rows)
                {
                    clone.ImportRow(row);
                }

                for (int i = 0; i < clone.Rows.Count; i++)
                {
                    string str = "";
                    DataRow row = clone.Rows[i];
                    DateTime time = DateTime.Parse(row["Ordered"].ToString());
                    if (ordersView.Rows[i].Cells["Sent Date"].Value.ToString() == "")
                    {
                        //    DataGridViewCellStyle style = new DataGridViewCellStyle();
                        //    style.BackColor = Color.FromArgb(255, 238, 118);
                        //    style.SelectionBackColor = style.BackColor;
                        //    ordersView.Rows[i].Cells["Sent Date"].Style = style;
                        ordersView.Rows[i].Cells["Sent Date"].Value = "Not Sent";
                    }
                    ordersView.Rows[i].Cells["Ordered"].Value = NormalizeDate(time);
                    ordersView.Rows[i].Cells["Ordered"].ToolTipText = time.ToString();
                    switch (row["Required"].ToString())
                    {
                        case "0":
                            str = "Anytime";
                            break;
                        case "1":
                            str = "Morning";
                            break;
                        case "2":
                            str = "Afternoon";
                            break;
                    }
                    ordersView.Rows[i].Cells["Required"].ToolTipText = row["Required"].ToString();
                    clone.Rows[i]["Required"] = str;
                }

                ordersView.Columns["Last Updated By"].Visible = false;
                ordersView.Columns["Order ID"].Visible = false;
                ordersView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                ordersView.AutoResizeColumns();
            }));
        }

        private void LoadEmployees()
        {
            string query = "SELECT [First Name], [Last Name], [Date of Birth], [EmpPos] FROM Employees INNER JOIN Person ON Employees.[Person ID] = Person.[Person ID]";
            DataTable dtb = DatabaseHelper.GetTable(null, null, query);
            //DataTable clone = new DataTable();
            //clone.Columns.Add("Age");
            //foreach (DataRow row in dtb.Rows)
            //{
            //    clone.ImportRow(row);
            //    clone.Rows[clone.Rows.Count - 1]["Age"] = (DateTime.Now-DateTime.Parse(clone.Rows[clone.Rows.Count-1]["Date of Birth"].ToString())).TotalDays.ToString();
            //}
            //for (int i = 0; i < clone.Rows.Count; i++)
            //{

            //}
            Invoke(new Action(() =>
            {
                employeesView.DataSource = dtb;
                employeesView.AutoResizeColumns();
            }));
        }
        private void LoadOffices()
        {
            string query = "SELECT [Office Name], [Landline] as Phone, [Address] & \", \"  & [City] AS Location FROM Office LEFT JOIN Location ON Office.[Location ID] = Location.[Location ID]";
            DataTable dtb = DatabaseHelper.GetTable(null, null, query);
            Invoke(new Action(() =>
            {
                officesView.DataSource = dtb;
                officesView.AutoResizeColumns();
            }));
        }
        private void LoadDealers()
        { 
            string query = "SELECT [First Name] & \", \"  & [Last Name] AS Name, [Company], [Address] & \", \" & [City] AS Location FROM (SELECT * FROM Dealer LEFT JOIN Person ON Dealer.[Person ID] = Person.[Person ID]) xD LEFT JOIN Location ON Location.[Location ID] = xD.[Location ID]";
            DataTable dtb = DatabaseHelper.GetTable(null, null, query);
            Invoke(new Action(() =>
            {
                dealerView.DataSource = dtb;
                dealerView.AutoResizeColumns();
            }));
        }
        private void LoadGridViews()
        {
            LoadOrders();
            LoadEmployees();
            LoadOffices();
            LoadDealers();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGridViews();

            //    DatabaseHelper orderQuery = DatabaseHelper.ExecuteQuery(
        }

        private void ordersView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                MenuItem viewOrders = new MenuItem("View Order");
                viewOrders.Click += (z, y) =>
                {
                    new frm_AddOrder(int.Parse(ordersView.Rows[ordersView.HitTest(e.X, e.Y).RowIndex].Cells["Order ID"].Value.ToString()), ordersView.Rows[ordersView.HitTest(e.X, e.Y).RowIndex]).ShowDialog();
                };
                MenuItem deleteOrder = new MenuItem("Delete Order");
                int currentMouseOverRow = ordersView.HitTest(e.X, e.Y).RowIndex;
                deleteOrder.Click += (a, f) =>
                  {
                      if (MessageBox.Show("Are you sure you want to delete the order for " + ordersView.Rows[currentMouseOverRow].Cells["Dealer Name"].Value.ToString()) == DialogResult.OK)
                      {
                          DatabaseHelper.DeleteRow("Orders", "Order ID", ordersView.Rows[currentMouseOverRow].Cells["Order ID"].Value.ToString());
                      }
                  };
                m.MenuItems.Add(viewOrders);
                m.MenuItems.Add(deleteOrder);

                if (currentMouseOverRow > 0)
                    ordersView.Rows[currentMouseOverRow].Selected = true;
                m.Show(ordersView, new Point(e.X, e.Y));

            }
        }

        private void btn_addEmployee_Click(object sender, EventArgs e)
        {
            new frm_AddEmployee().ShowDialog();
        }

        private void tmr_Refresh_Tick(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                LoadGridViews();
            }).Start();
        }

        private void btn_addDealer_Click(object sender, EventArgs e)
        {
            new frm_AddDealer().ShowDialog();
        }

        private void btn_addTruck_Click(object sender, EventArgs e)
        {
            new frm_AddTruck().ShowDialog();
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
            string name = DatabaseHelper.GetPerson(LoggedInEmployee.ID)["First Name"].ToString();//table_Persons.Rows[person_Id - 1]["First Name"].ToString();
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

        private void LoadOrders()
        {
            string query =
                "SELECT [Order ID], [Order Date], [Required Date],  TruckPersonID.[First Name] & \" \" & TruckPersonID.[Last Name] AS [Serviced By], [Required], Person.[First Name] & \" \" & Person.[Last Name] AS [Truck Driver], [Sent Date] FROM (SELECT * FROM (SELECT * FROM (SELECT * FROM (SELECT * FROM  (SELECT * FROM Orders INNER JOIN (SELECT * FROM Dealer INNER JOIN Person ON Dealer.[Person ID] = Person.[Person ID]) DealerInformation ON Orders.[Dealer ID] = DealerInformation.[Dealer ID]) TruckID LEFT JOIN [Truck Driving Employee] ON TruckID.[Truck ID] = [Truck Driving Employee].[Truck ID]) TruckEmployeeID LEFT JOIN Employees ON TruckEmployeeID.[Employee ID] = Employees.[Employee ID]) TruckPersonID LEFT JOIN Person ON TruckPersonID.Employees.[Person ID] = Person.[Person ID]) ServicingPerson INNER JOIN Employees ON ServicingPerson.[Serviced Employee ID] = Employees.[Employee ID]) EmployeePerson LEFT JOIN Person ON EmployeePerson.ServicingPerson.Person.[Person ID] = Person.[Person ID]";
            DataTable dtb = DatabaseHelper.GetTable(null, null, query);
            ordersView.DataSource = dtb;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadOrders();

            //    DatabaseHelper orderQuery = DatabaseHelper.ExecuteQuery(
        }

        private void tab_Orders_Click(object sender, EventArgs e)
        {

        }
    }
}

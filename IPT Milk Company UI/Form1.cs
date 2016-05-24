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
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = System.IO.Path.GetDirectoryName(executable);
#if DEBUG
            path = Directory.GetParent(Directory.GetParent(System.IO.Path.GetDirectoryName(executable)).ToString()).ToString();
#endif 
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            table_Employees = DatabaseHelper.GetTable("Employees");
            table_Persons = DatabaseHelper.GetTable("Person");
            person_Id = int.Parse(table_Employees.Rows[emp_ID - 1]["Person ID"].ToString());
            string name = table_Persons.Rows[person_Id - 1]["First Name"].ToString();
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

        private void Form1_Load(object sender, EventArgs e)
        {
        //    DatabaseHelper orderQuery = DatabaseHelper.ExecuteQuery(
        }

        private void tab_Orders_Click(object sender, EventArgs e)
        {

        }
    }
}

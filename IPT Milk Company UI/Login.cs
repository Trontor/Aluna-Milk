using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using IPT_Milk_Company_UI;
using MetroFramework.Forms;
using System.Diagnostics;

namespace IPT_Milk_Company_UI
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Proceed()
        {
            DatabaseHelper.RefreshTables();
            this.Hide();
            var form2 = new Form1(Employee_ID);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void Fail()
        {
            MessageBox.Show("Sorry, your login details are incorrect");
        }

        private int Employee_ID = -1;
        private void ValidateLogin()
        {
            Debug.WriteLine(DatabaseHelper.CalculateMD5Hash(txt_Password.Text));

            bool loggedIn = false;
            ValidityChecker checker = new ValidityChecker(txt_Password, txt_Username);
            var list = checker.InvalidFields();
            if (list.Count == 0)
            {
                DataTable employeeTable = DatabaseHelper.GetTable("Employees");
                foreach (DataRow item in employeeTable.Rows)
                {
                    if (item != null && item["PC Username"].ToString() == txt_Username.Text)
                    {
                        string MD5hash = DatabaseHelper.CalculateMD5Hash(txt_Password.Text);
                        Debug.WriteLine(MD5hash);
                        if (MD5hash == item["PC Password MD5"].ToString())
                        {
                            Employee_ID = int.Parse(item["Person ID"].ToString());
                            LoggedInEmployee.ID = Employee_ID;
                            loggedIn = true;
                            Proceed();
                        }
                    }
                }
                if (!loggedIn)
                    Fail();
            }
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            ValidateLogin();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_Username.Focus();
#if DEBUG
            txt_Username.Text = "rjoshi";
            txt_Password.Text = "PASSWORD";
            //ValidateLogin();
#endif

        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ValidateLogin();
        }

        private void txt_Username_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                ValidateLogin();
        }
    }
}

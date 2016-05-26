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

namespace IPT_Milk_Company_UI
{
    public partial class Login : MetroForm
    {
        public string CalculateMD5Hash(string input)

        {

            // step 1, calculate MD5 hash from input

            MD5 md5 = System.Security.Cryptography.MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);

            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)

            {

                sb.Append(hash[i].ToString("x2"));

            }

            return sb.ToString();

        }
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
                        string MD5hash = CalculateMD5Hash(txt_Password.Text);
                        if (MD5hash == item["PC Password MD5"].ToString())
                        {
                            Employee_ID = int.Parse(item["Employee ID"].ToString());
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
            txt_Username.Text = "rohyl";
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

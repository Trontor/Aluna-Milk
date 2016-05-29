using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPT_Milk_Company_UI
{
    public partial class frm_AddEmployee : MetroForm
    {
        public frm_AddEmployee()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        int Location = -1;
        private void AddEmployee()
        {
            int personID = 0;

            string personQuery = "INSERT INTO Person " +
                "([Date of Birth],[First Name], [Last Name], [Gender], [Personal Email])" + " VALUES (" +
                string.Format("#{0}#,'{1}','{2}','{3}','{4}')",
                dtp_Birth_Date.Value,
                txt_First_Name.Text,
                txt_Last_Name.Text,
                rad_Male.Checked ? "Male" : "Female",
                txt_Tax_File_Number.Text);
            DatabaseHelper.ExecuteQuery(personQuery);
            personID = DatabaseHelper.GetRowID("Person", "Personal Email", "Person ID", txt_Tax_File_Number.Text);

            string query = "INSERT INTO Employees " +
                "([Tax File Number], EmpPos, Salary, [PC Username], [PC Password MD5], [Person ID], [Hire Date], [Location ID], Temp) VALUES (" +
                string.Format("{0},'{1}',{2},'{3}','{4}',{5},#{6}#,{7},{8})",
                txt_Tax_File_Number.Text,
                cmb_Positions.Text,
                numericUpDown1.Value,
                txt_User_Name.Text,
                DatabaseHelper.CalculateMD5Hash(txt_Password.Text),
                personID,
                dtp_Hire_Date.Value.Date,
                Location,
                chk_Temporary.Checked ? "Yes" : "No");
            DatabaseHelper.ExecuteQuery(query);
            MessageBox.Show("Employee added successfully.");

        }

        private void btn_addEmployee_Click(object sender, EventArgs e)
        {   
            ValidityChecker checker = new ValidityChecker(txt_First_Name, txt_Last_Name, txt_Password, txt_Tax_File_Number, txt_User_Name);
            if (checker.InvalidFields().Count == 0)
            {
                AddEmployee();
            }
        }

        private void frm_AddEmployee_Load(object sender, EventArgs e)
        {
            foreach (DataRow positionRow in DatabaseHelper.GetTable("Positions").Rows)
            {
                cmb_Positions.Items.Add(positionRow["Position"]);

            }
        }

        private void btn_dtpHire_Today_Click(object sender, EventArgs e)
        {
            dtp_Hire_Date.Value = DateTime.Now;
        }

        private void btn_addLocation_Click(object sender, EventArgs e)
        {
            frm_AddLocation frm = new frm_AddLocation();
            frm.ShowDialog();
            Location = frm.locID;

            foreach (DataRow row in DatabaseHelper.GetTable("Location").Rows)
            {
                if (row["Location ID"].ToString() == Location.ToString())
                    txt_Location.Text = row["Address"].ToString() + ", " + row["City"].ToString();
            }
        }
    }
}

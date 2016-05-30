using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace IPT_Milk_Company_UI
{
    public partial class frm_AddTruck : MetroForm
    {
        public frm_AddTruck()
        {
            InitializeComponent();
        }

        private void AddTruck()
        {
            string query = string.Format("INSERT INTO Trucks([Rego Numbers], [Rego Letters]) VALUES (\"{0}\",\"{1}\")", txt_Registration_Numbers.Text, txt_Registration_Letters.Text);
            OleDbDataReader reader = DatabaseHelper.ExecuteQuery(query);
            MessageBox.Show("Truck registration added.");
            Close();
        }
        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            ValidityChecker checker = new ValidityChecker(txt_Registration_Letters, txt_Registration_Numbers);
            List<string> invalidFieldNames = checker.InvalidFields();
            if (invalidFieldNames.Count == 0)
            {
                AddTruck();
            }
        }

        private void txt_Registration_Letters_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_Registration_Letters.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                txt_Registration_Letters.Text.Remove(txt_Registration_Letters.Text.Length - 1);
            }
        }
    }
}

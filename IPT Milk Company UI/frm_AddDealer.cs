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
    public partial class frm_AddDealer : MetroForm
    {
        public frm_AddDealer()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        DatabaseHelper.LocationStruct Loc = new DatabaseHelper.LocationStruct();
        private void AddDealer()
        {
            int newLocationID = DatabaseHelper.AddLocation(Loc);
            int personID = 0;

            string personQuery = "INSERT INTO Person " +
                "([Date of Birth],[First Name], [Last Name], [Gender], [Personal Email])" + " VALUES (" +
                string.Format("#{0}#,'{1}','{2}','{3}','{4}')",
                DateTime.MinValue,
                txt_First_Name.Text,
                txt_Last_Name.Text,
                rad_Male.Checked ? "Male" : "Female",
                txt_Email.Text);
            DatabaseHelper.ExecuteQuery(personQuery);
            personID = DatabaseHelper.GetRowID("Person", "Personal Email", "Person ID", txt_Email.Text);

            string query = "INSERT INTO Dealer " +
                "([Person ID], Company, [Location ID]) VALUES (" +
                string.Format("{0},\"{1}\",{2})",
                personID, txt_Company.Text, newLocationID);
            DatabaseHelper.ExecuteQuery(query);
            MessageBox.Show("Dealer added successfully.");

        }

        private void btn_addDealer_Click(object sender, EventArgs e)
        {
            ValidityChecker checker = new ValidityChecker(txt_First_Name, txt_Last_Name, txt_Location, txt_Company);
            if (checker.InvalidFields().Count == 0)
            {
                AddDealer();
            }
        }

        private void btn_addLocation_Click(object sender, EventArgs e)
        {
            frm_AddLocation frm = new frm_AddLocation();
            frm.ShowDialog();
            Loc = frm.locID;
            txt_Location.Text = Loc.ToLocationString();
        }
    }
}

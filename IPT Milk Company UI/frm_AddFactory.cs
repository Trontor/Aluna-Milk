using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace IPT_Milk_Company_UI
{
    public partial class frm_AddFactory : MetroForm
    {
        public frm_AddFactory()
        {
            InitializeComponent();
        }

        private string imagePath = "";
        private void AddFactory()
        {
            var myDataSet = DatabaseHelper.LoadProductList();
            officeID = DatabaseHelper.GetRowID("Office", "Office Name","Office ID", cmb_Office.SelectedItem.ToString());
            string query =
                string.Format(
                    "INSERT INTO Factory([Office ID],[Factory Name], [Registration], [Location ID]) VALUES ({0},'{1}','{2}', {3})",
                    officeID, txt_Factory_Name.Text, txt_Registration.Text, locationID); 
            Clipboard.SetText(query);
            OleDbDataReader reader = DatabaseHelper.ExecuteQuery(query);
            MessageBox.Show("Query succesfully processed. " + reader.RecordsAffected + " records inserted.");

        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            ValidityChecker checker = new ValidityChecker(cmb_Office, txt_Registration, txt_Factory_Name);
            if (checker.InvalidFields().Count == 0)
            {
                AddFactory();
            }

        }

        private void UpdateFields()
        {
            List<string> off = DatabaseHelper.GetColumnItems("Office", "Office Name");;
            cmb_Office.DataSource = off;
            foreach (DataRow row in DatabaseHelper.GetTable("Office").Rows)
            {
                if (row["Office ID"].ToString() == officeID.ToString())
                    cmb_Office.SelectedText = row["Office Name"].ToString();
            }
            foreach (DataRow row in DatabaseHelper.GetTable("Location").Rows)
            {
                if (row["Location ID"].ToString() == locationID.ToString())
                    txt_Location.Text = row["Address"].ToString() + ", " + row["City"].ToString() + ", " + row["Postcode"];
            }
        }

        private int locationID = -1;
        private void btn_AddLocation_Click(object sender, EventArgs e)
        {
            frm_AddLocation frm = new frm_AddLocation();
            frm.ShowDialog();
            locationID = frm.locID;
            UpdateFields();
        }

        private void txt_Location_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frm_AddFactory_Load(object sender, EventArgs e)
        {
            UpdateFields();
        }

        private int officeID = -1;
        private void btn_Add_Office_Click(object sender, EventArgs e)
        {
            if (locationID < 0)
            {
                MessageBox.Show("You first must set a location before attaching a new office to this factory.");
                return;
            }
            frm_AddOffice frm = new frm_AddOffice(locationID);
            frm.ShowDialog();
            officeID = frm.officeID;
            UpdateFields();

        }
    }
}

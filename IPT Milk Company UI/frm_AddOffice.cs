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
    public partial class frm_AddOffice : MetroForm
    {
        public int officeID = -1;
        public frm_AddOffice(DatabaseHelper.LocationStruct str)
        {
            InitializeComponent();
            this.locationID = str;
            if (DatabaseHelper.IsValidLocation(locationID))
                txt_Location.Text = locationID.ToLocationString();
                    //foreach (DataRow row in DatabaseHelper.GetTable("Location").Rows)
                //{
                //    if (row["Location ID"].ToString() == locationID.ToString())
                //    {
                //        txt_Location.Text = row["Address"].ToString() + ", " + row["City"].ToString() + ", " +
                //                          row["Postcode"];
                //        btn_AddLocation.Enabled = false;
                //    }
                //}
        }

        private void AddOffice()
        {
            int newLocationID = DatabaseHelper.AddLocation(locationID);
            string query = string.Format("INSERT INTO Office(Landline, [Office Name], [Location ID]) VALUES ({0},'{1}',{2})", int.Parse(txt_Landline.Text), txt_Name.Text, newLocationID);
            officeID = DatabaseHelper.GetRowID("Office", "Office Name", "Office ID", txt_Name.Text);
            OleDbDataReader reader = DatabaseHelper.ExecuteQuery(query);
            //DataTable tbl = DatabaseHelper.GetTable("Location");
            //foreach (DataRow row in tbl.Rows)
            //{
            //    if (row["Address"].ToString() == txt_Name.Text)
            //        newLocationID = int.Parse(row["Location ID"].ToString());
            //}
            Close();

        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            ValidityChecker checker = new ValidityChecker(txt_Landline, txt_Name, txt_Location);
            List<string> invalidFieldNames = checker.InvalidFields();
            if (invalidFieldNames.Count == 0)
            {
                AddOffice();
            }
        }
        private DatabaseHelper.LocationStruct locationID = new DatabaseHelper.LocationStruct();
        private void btn_AddLocation_Click(object sender, EventArgs e)
        {
            frm_AddLocation frm = new frm_AddLocation();
            frm.ShowDialog();
            locationID = frm.locID;
            txt_Location.Text = locationID.ToLocationString();
        }

        private void frm_AddOffice_Load(object sender, EventArgs e)
        {

        }

        private void txt_Landline_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}

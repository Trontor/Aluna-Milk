﻿using System;
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
using static IPT_Milk_Company_UI.DatabaseHelper;

namespace IPT_Milk_Company_UI
{
    public partial class frm_AddLocation : MetroForm
    {
        internal DatabaseHelper.LocationStruct locID = new DatabaseHelper.LocationStruct();
        public frm_AddLocation()
        {
            InitializeComponent();
            LoadExistingLocations();
        }

        Dictionary<DatabaseHelper.LocationStruct, int> locCmbRelationship = new Dictionary<DatabaseHelper.LocationStruct, int>();
        private void LoadExistingLocations()
        {
            locCmbRelationship.Clear();
            cmb_Location.Items.Clear();
            DataTable locationTable = DatabaseHelper.GetTable("Location", null, null, true);
            foreach (DataRow dtr in locationTable.Rows)
            {
                int postcode = int.Parse(dtr["Postcode"].ToString());
                string address = dtr["Address"].ToString();
                string city = dtr["City"].ToString();
                cmb_Location.Items.Add(string.Format("{0},{1},({2})", address, city, postcode));
                locCmbRelationship.Add(new DatabaseHelper.LocationStruct(postcode, address, city), cmb_Location.Items.Count - 1);
            }
            if (cmb_Location.Items.Count == 0)
            {
                cmb_Location.Enabled = false;
                btn_prexistingLocation.Enabled = false;
                btn_prexistingLocation.Text = "No Locations Yet";
            }
            cmb_Location.SelectedIndex = 0;

        }
        private void SetLocation()
        {
            LocationStruct loc = new LocationStruct(int.Parse(txt_Postcode.Text), txt_Address.Text, txt_City.Text);
            if (locCmbRelationship.ContainsKey(loc))
                MessageBox.Show("This location already exists. Please use the dropdown box to select this pre-existing location");
            else
                locID = loc;
            //string query = string.Format("INSERT INTO Location(Postcode,City, Address) VALUES ({0},'{1}','{2}')", int.Parse(txt_Postcode.Text), txt_City.Text, txt_Address.Text);
            //OleDbDataReader reader = DatabaseHelper.ExecuteQuery(query);
            //DataTable tbl = DatabaseHelper.GetTable("Location", null, null, true);
            //foreach (DataRow row in tbl.Rows)
            //{
            //    if (row["Address"].ToString() == txt_Address.Text)
            //        locID = int.Parse(row["Location ID"].ToString());
            //}
            Close();
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            ValidityChecker checker = new ValidityChecker(txt_Postcode, txt_City, txt_Address);
            List<string> invalidFieldNames = checker.InvalidFields();
            if (invalidFieldNames.Count == 0)
            {
                SetLocation();
            }
        }

        private void txt_Postcode_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Postcode_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btn_prexistingLocation_Click(object sender, EventArgs e)
        {
            locID = locCmbRelationship.FirstOrDefault(x => x.Value == cmb_Location.SelectedIndex).Key;
            Close();
        }

        private void frm_AddLocation_Load(object sender, EventArgs e)
        {
            LoadExistingLocations();
        }
    }
}

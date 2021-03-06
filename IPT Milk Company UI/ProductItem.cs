﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.IO;

namespace IPT_Milk_Company_UI
{
    partial class ProductItem : UserControl
    {
        public ProductItem()
        {
            InitializeComponent();
            LoadProductList();
        }
        DataTable table = new DataTable();
        private List<string> productDescriptions;
        private List<string> productNames;
        public void LoadProductList(List<string> exceptions = null)
        {
            string lastSelectedItem = "";
            if (comboBox2.Items.Count > 0)
                lastSelectedItem = comboBox2.SelectedItem.ToString();
            table = DatabaseHelper.GetTable("Products");
            if (exceptions == null)
                exceptions = new List<string>();
            productNames = DatabaseHelper.GetColumnItems("Products", "Product Name").Except(exceptions).ToList();
            productDescriptions = DatabaseHelper.GetColumnItems("Products", "Description");

            comboBox2.DataSource = productNames;
            if (comboBox2.Items.Contains(lastSelectedItem))
                comboBox2.SelectedItem = lastSelectedItem;
        }
        private void ProductItem_Load(object sender, EventArgs e)
        {
        }
        Dictionary<string, string> descriptions = new Dictionary<string, string>();
        public double totalPrice = 0;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void UpdatePrice()
        {

            //string.Format("{0:#.00}", Convert.ToDecimal(myMoneyString) / 100); 
            if (comboBox2.SelectedIndex >= 0)
            {
                double price = (double)table.Rows[comboBox2.SelectedIndex]["Price"];
                totalPrice = Convert.ToDouble(price * (double)numericUpDown1.Value);
                label4.Text = string.Format("{0:C}", totalPrice);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex < 0)
                return;
            string imagePath = table.Rows[comboBox2.SelectedIndex]["ImagePath"].ToString();
            if (File.Exists(imagePath))
            {
                pictureBox1.Image = ImageHelper.ResizeImage(Image.FromFile(imagePath), pictureBox1.Width, pictureBox1.Height);
            }
            else
                pictureBox1.Image = ImageHelper.ResizeImage(Properties.Resources.question, pictureBox1.Width, pictureBox1.Height);
            UpdatePrice();
        }

        private void btn_description_Click(object sender, EventArgs e)
        {
            int index = 0;
            List<string> str = productNames.Where(x => x == comboBox2.SelectedItem.ToString()).ToList();
            if (str.Count > 0)
            {
                index = productNames.IndexOf(comboBox2.SelectedItem.ToString());
                MessageBox.Show(productDescriptions[index], "Product Description for " + str[0], MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

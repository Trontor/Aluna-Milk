using System;
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
        }
        DataTable table = new DataTable();
        private void LoadProductList()
        {
            table = DatabaseHelper.GetTable("Products");
            foreach (DataRow item in table.Rows)
            {
                comboBox2.Items.Add(item["Product Name"]);
            }
        }
        private void ProductItem_Load(object sender, EventArgs e)
        {
            LoadProductList();
        }

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
                pictureBox1.Image = ImageHelper.ResizeImage(Image.FromFile(imagePath), 100, 100);
            }
            else
                pictureBox1.Image = ImageHelper.ResizeImage(Properties.Resources.question, 100, 100);
            UpdatePrice();
        }
    }
}

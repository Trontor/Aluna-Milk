// Decompiled with JetBrains decompiler
// Type: IPT_Milk_Company_UI.frm_AddProduct
// Assembly: IPT Milk Company UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B024A5FB-939A-443C-BE4D-1C5D1A7C5AB3
// Assembly location: C:\Users\Rohyl Joshi\Documents\IPT Milk Company UI.exe

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace IPT_Milk_Company_UI
{
    public partial class frm_AddProduct : Form
    {
        private string imageDirectory = Path.Combine(Application.StartupPath, "Aluna Product Images");
        private string imagePath = "";
        private IContainer components = (IContainer)null;
        private Label label1;
        private ComboBox cmb_Factory_Name;
        private Label label4;
        private TextBox int_Cost;
        private Label label3;
        private TextBox int_Price;
        private TextBox txt_Description;
        private Label label2;
        private Label label5;
        private TextBox txt_Product_Name;
        private Button btn_addProduct;
        private PictureBox pictureBox1;
        private Label label6;
        private Button btn_browseImg;
        private Label label7;
        private Label lbl_imgPath;

        public frm_AddProduct()
        {
            this.InitializeComponent();
            this.UpdateImageLabel(null);
        }

        private void ProcessImage()
        {
            Directory.CreateDirectory(this.imageDirectory);
            Path.GetFileNameWithoutExtension(this.imagePath);
            this.pictureBox1.Image = (Image)ImageHelper.ResizeImage(Image.FromFile(this.imagePath), 100, 100);
        }

        private void AddProduct()
        {
            foreach (Milk_DatabaseDataSet.ProductsRow productsRow in (TypedTableBase<Milk_DatabaseDataSet.ProductsRow>)DatabaseHelper.LoadProductList()) ;
            string filename = Path.Combine(this.imageDirectory, this.txt_Product_Name.Text + ".bmp");
            ImageHelper.ResizeImage(Image.FromFile(this.imagePath), 100, 100).Save(filename);
            this.imagePath = filename;
            string str = string.Format("INSERT INTO Products([Product Name], [Factory ID], ImagePath, Description, [Last Updated], Price, Cost) VALUES ('{0}','{1}','{2}','{3}',#{4}#,{5},{6})",
               txt_Product_Name.Text, DatabaseHelper.GetRowID("Factory", "Factory Name", "Factory ID", cmb_Factory_Name.SelectedItem.ToString()), imagePath, txt_Description.Text, DateTime.Now, double.Parse(int_Price.Text), double.Parse(int_Cost.Text));
            Clipboard.SetText(str);
            int num = (int)MessageBox.Show("Query succesfully processed. " + DatabaseHelper.ExecuteQuery(str).RecordsAffected + " records inserted.");
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            if (new ValidityChecker(new Control[4]
            {
        (Control) this.cmb_Factory_Name,
        (Control) this.int_Price,
        (Control) this.int_Cost,
        (Control) this.txt_Product_Name
            }).InvalidFields(true).Count != 0)
                return;
            this.AddProduct();
        }

        private void UpdateImageLabel(Image customIMG)
        {
            string tempPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".bmp");
            if (customIMG != null)
            {
                customIMG.Save(tempPath);
                imagePath = tempPath;
            }
            if (this.imagePath == "")
                this.lbl_imgPath.Text = "No image selected. Click \"Browse\".";
            else if (!File.Exists(this.imagePath))
            {
                this.lbl_imgPath.Text = "Path to image is non-existent.";
            }
            else
            {
                this.ProcessImage();
                this.lbl_imgPath.Text = "Image succesfully processed.";
            }
        }

        private void btn_browseImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    this.imagePath = openFileDialog.FileName;
            }
            this.UpdateImageLabel(null);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmb_Factory_Name = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.int_Cost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.int_Price = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Product_Name = new System.Windows.Forms.TextBox();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_browseImg = new System.Windows.Forms.Button();
            this.lbl_imgPath = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Factory_Name
            // 
            this.cmb_Factory_Name.FormattingEnabled = true;
            this.cmb_Factory_Name.Location = new System.Drawing.Point(62, 221);
            this.cmb_Factory_Name.Name = "cmb_Factory_Name";
            this.cmb_Factory_Name.Size = new System.Drawing.Size(141, 21);
            this.cmb_Factory_Name.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cost";
            // 
            // int_Cost
            // 
            this.int_Cost.Location = new System.Drawing.Point(51, 400);
            this.int_Cost.Name = "int_Cost";
            this.int_Cost.Size = new System.Drawing.Size(152, 20);
            this.int_Cost.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Price";
            // 
            // int_Price
            // 
            this.int_Price.Location = new System.Drawing.Point(51, 374);
            this.int_Price.Name = "int_Price";
            this.int_Price.Size = new System.Drawing.Size(152, 20);
            this.int_Price.TabIndex = 4;
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(6, 262);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(197, 106);
            this.txt_Description.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Name";
            // 
            // txt_Product_Name
            // 
            this.txt_Product_Name.Location = new System.Drawing.Point(51, 6);
            this.txt_Product_Name.Name = "txt_Product_Name";
            this.txt_Product_Name.Size = new System.Drawing.Size(152, 20);
            this.txt_Product_Name.TabIndex = 2;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(6, 426);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(197, 23);
            this.btn_addProduct.TabIndex = 16;
            this.btn_addProduct.Text = "Commit";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(51, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Image";
            // 
            // btn_browseImg
            // 
            this.btn_browseImg.Location = new System.Drawing.Point(62, 163);
            this.btn_browseImg.Name = "btn_browseImg";
            this.btn_browseImg.Size = new System.Drawing.Size(75, 23);
            this.btn_browseImg.TabIndex = 19;
            this.btn_browseImg.Text = "Browse ";
            this.btn_browseImg.UseVisualStyleBackColor = true;
            this.btn_browseImg.Click += new System.EventHandler(this.btn_browseImg_Click);
            // 
            // lbl_imgPath
            // 
            this.lbl_imgPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_imgPath.Location = new System.Drawing.Point(6, 189);
            this.lbl_imgPath.Name = "lbl_imgPath";
            this.lbl_imgPath.Size = new System.Drawing.Size(197, 23);
            this.lbl_imgPath.TabIndex = 20;
            this.lbl_imgPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_imgPath.Click += new System.EventHandler(this.lbl_imgPath_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Factory";
            // 
            // frm_AddProduct
            // 
            this.AllowDrop = true;
            this.ClientSize = new System.Drawing.Size(215, 459);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_imgPath);
            this.Controls.Add(this.btn_browseImg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Product_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.int_Cost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.int_Price);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Factory_Name);
            this.Name = "frm_AddProduct";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.frm_AddProduct_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frm_AddProduct_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frm_AddProduct_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frm_AddProduct_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void frm_AddProduct_DragDrop(object sender, DragEventArgs e)
        {
            int x = this.PointToClient(new Point(e.X, e.Y)).X;

            int y = this.PointToClient(new Point(e.X, e.Y)).Y;

            if (x >= pictureBox1.Location.X && x <= pictureBox1.Location.X + pictureBox1.Width && y >= pictureBox1.Location.Y && y <= pictureBox1.Location.Y + pictureBox1.Height)
            {

                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files != null)
                {
                    UpdateImageLabel(Image.FromFile(files[0]));
                }
            }
        }

        private void lbl_imgPath_Click(object sender, EventArgs e)
        {

        }

        private void frm_AddProduct_Load(object sender, EventArgs e)
        {
            cmb_Factory_Name.DataSource = DatabaseHelper.GetColumnItems("Factory", "Factory Name");
        }
    }
}

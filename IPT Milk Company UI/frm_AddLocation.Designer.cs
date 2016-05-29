namespace IPT_Milk_Company_UI
{
    partial class frm_AddLocation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Postcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Location = new System.Windows.Forms.ComboBox();
            this.btn_prexistingLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Address";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(63, 168);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(142, 20);
            this.txt_Address.TabIndex = 2;
            this.txt_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProduct.Location = new System.Drawing.Point(8, 246);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(197, 23);
            this.btn_addProduct.TabIndex = 16;
            this.btn_addProduct.Text = "Use New Location";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "City";
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(63, 194);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(142, 20);
            this.txt_City.TabIndex = 17;
            this.txt_City.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Postcode";
            // 
            // txt_Postcode
            // 
            this.txt_Postcode.Location = new System.Drawing.Point(63, 220);
            this.txt_Postcode.Name = "txt_Postcode";
            this.txt_Postcode.Size = new System.Drawing.Size(142, 20);
            this.txt_Postcode.TabIndex = 19;
            this.txt_Postcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Postcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Postcode_KeyPress);
            this.txt_Postcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Postcode_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Search for an existing location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "or add your own";
            // 
            // cmb_Location
            // 
            this.cmb_Location.FormattingEnabled = true;
            this.cmb_Location.Location = new System.Drawing.Point(8, 86);
            this.cmb_Location.Name = "cmb_Location";
            this.cmb_Location.Size = new System.Drawing.Size(197, 21);
            this.cmb_Location.TabIndex = 23;
            // 
            // btn_prexistingLocation
            // 
            this.btn_prexistingLocation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_prexistingLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prexistingLocation.Location = new System.Drawing.Point(8, 113);
            this.btn_prexistingLocation.Name = "btn_prexistingLocation";
            this.btn_prexistingLocation.Size = new System.Drawing.Size(197, 23);
            this.btn_prexistingLocation.TabIndex = 24;
            this.btn_prexistingLocation.Text = "Use This Location";
            this.btn_prexistingLocation.UseVisualStyleBackColor = true;
            this.btn_prexistingLocation.Click += new System.EventHandler(this.btn_prexistingLocation_Click);
            // 
            // frm_AddLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 283);
            this.Controls.Add(this.btn_prexistingLocation);
            this.Controls.Add(this.cmb_Location);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Postcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Address);
            this.Name = "frm_AddLocation";
            this.Resizable = false;
            this.Text = "Add Location";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frm_AddLocation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Postcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Location;
        private System.Windows.Forms.Button btn_prexistingLocation;
    }
}
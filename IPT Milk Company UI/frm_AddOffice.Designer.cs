namespace IPT_Milk_Company_UI
{
    partial class frm_AddOffice
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Landline = new System.Windows.Forms.TextBox();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.btn_AddLocation = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(61, 6);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(142, 20);
            this.txt_Name.TabIndex = 2;
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(6, 115);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(197, 23);
            this.btn_addProduct.TabIndex = 16;
            this.btn_addProduct.Text = "Add Office";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Landline";
            // 
            // txt_Landline
            // 
            this.txt_Landline.Location = new System.Drawing.Point(61, 32);
            this.txt_Landline.Name = "txt_Landline";
            this.txt_Landline.Size = new System.Drawing.Size(142, 20);
            this.txt_Landline.TabIndex = 17;
            this.txt_Landline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Landline.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Landline_KeyPress);
            // 
            // txt_Location
            // 
            this.txt_Location.BackColor = System.Drawing.Color.White;
            this.txt_Location.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Location.Enabled = false;
            this.txt_Location.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txt_Location.Location = new System.Drawing.Point(61, 57);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(142, 19);
            this.txt_Location.TabIndex = 24;
            // 
            // btn_AddLocation
            // 
            this.btn_AddLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_AddLocation.Location = new System.Drawing.Point(61, 82);
            this.btn_AddLocation.Name = "btn_AddLocation";
            this.btn_AddLocation.Size = new System.Drawing.Size(142, 26);
            this.btn_AddLocation.TabIndex = 23;
            this.btn_AddLocation.Text = "Add New Location";
            this.btn_AddLocation.UseVisualStyleBackColor = true;
            this.btn_AddLocation.Click += new System.EventHandler(this.btn_AddLocation_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Location";
            // 
            // frm_AddOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 145);
            this.Controls.Add(this.txt_Location);
            this.Controls.Add(this.btn_AddLocation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Landline);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.label5);
            this.Name = "frm_AddOffice";
            this.Text = "Add Office";
            this.Load += new System.EventHandler(this.frm_AddOffice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Landline;
        private System.Windows.Forms.TextBox txt_Location;
        private System.Windows.Forms.Button btn_AddLocation;
        private System.Windows.Forms.Label label7;
    }
}
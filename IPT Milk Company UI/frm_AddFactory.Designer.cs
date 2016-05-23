namespace IPT_Milk_Company_UI
{
    partial class frm_AddFactory
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
            this.txt_Factory_Name = new System.Windows.Forms.TextBox();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Registration = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Add_Location = new System.Windows.Forms.Button();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.btn_Add_Office = new System.Windows.Forms.Button();
            this.cmb_Office = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Name";
            // 
            // txt_Factory_Name
            // 
            this.txt_Factory_Name.Location = new System.Drawing.Point(71, 66);
            this.txt_Factory_Name.Name = "txt_Factory_Name";
            this.txt_Factory_Name.Size = new System.Drawing.Size(152, 20);
            this.txt_Factory_Name.TabIndex = 2;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(26, 235);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(197, 23);
            this.btn_addProduct.TabIndex = 16;
            this.btn_addProduct.Text = "Commit";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Rego";
            // 
            // txt_Registration
            // 
            this.txt_Registration.Location = new System.Drawing.Point(71, 92);
            this.txt_Registration.Name = "txt_Registration";
            this.txt_Registration.Size = new System.Drawing.Size(152, 20);
            this.txt_Registration.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Location";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btn_Add_Location
            // 
            this.btn_Add_Location.Location = new System.Drawing.Point(71, 144);
            this.btn_Add_Location.Name = "btn_Add_Location";
            this.btn_Add_Location.Size = new System.Drawing.Size(152, 26);
            this.btn_Add_Location.TabIndex = 20;
            this.btn_Add_Location.Text = "Add New Location";
            this.btn_Add_Location.UseVisualStyleBackColor = true;
            this.btn_Add_Location.Click += new System.EventHandler(this.btn_AddLocation_Click);
            // 
            // txt_Location
            // 
            this.txt_Location.BackColor = System.Drawing.Color.White;
            this.txt_Location.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Location.Enabled = false;
            this.txt_Location.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txt_Location.Location = new System.Drawing.Point(71, 118);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(152, 19);
            this.txt_Location.TabIndex = 21;
            this.txt_Location.TextChanged += new System.EventHandler(this.txt_Location_TextChanged);
            // 
            // btn_Add_Office
            // 
            this.btn_Add_Office.Location = new System.Drawing.Point(71, 203);
            this.btn_Add_Office.Name = "btn_Add_Office";
            this.btn_Add_Office.Size = new System.Drawing.Size(152, 26);
            this.btn_Add_Office.TabIndex = 25;
            this.btn_Add_Office.Text = "Add New Office";
            this.btn_Add_Office.UseVisualStyleBackColor = true;
            this.btn_Add_Office.Click += new System.EventHandler(this.btn_Add_Office_Click);
            // 
            // cmb_Office
            // 
            this.cmb_Office.FormattingEnabled = true;
            this.cmb_Office.Location = new System.Drawing.Point(71, 176);
            this.cmb_Office.Name = "cmb_Office";
            this.cmb_Office.Size = new System.Drawing.Size(152, 21);
            this.cmb_Office.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Office";
            // 
            // frm_AddFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 281);
            this.Controls.Add(this.btn_Add_Office);
            this.Controls.Add(this.cmb_Office);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Location);
            this.Controls.Add(this.btn_Add_Location);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Registration);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Factory_Name);
            this.Name = "frm_AddFactory";
            this.Text = "Add Factory";
            this.Load += new System.EventHandler(this.frm_AddFactory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Factory_Name;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Registration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Add_Location;
        private System.Windows.Forms.TextBox txt_Location;
        private System.Windows.Forms.Button btn_Add_Office;
        private System.Windows.Forms.ComboBox cmb_Office;
        private System.Windows.Forms.Label label1;
    }
}
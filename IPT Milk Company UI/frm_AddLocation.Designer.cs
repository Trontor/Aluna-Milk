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
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Address";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(63, 63);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(142, 20);
            this.txt_Address.TabIndex = 2;
            this.txt_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProduct.Location = new System.Drawing.Point(8, 141);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(197, 23);
            this.btn_addProduct.TabIndex = 16;
            this.btn_addProduct.Text = "Add Location";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "City";
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(63, 89);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(142, 20);
            this.txt_City.TabIndex = 17;
            this.txt_City.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Postcode";
            // 
            // txt_Postcode
            // 
            this.txt_Postcode.Location = new System.Drawing.Point(63, 115);
            this.txt_Postcode.Name = "txt_Postcode";
            this.txt_Postcode.Size = new System.Drawing.Size(142, 20);
            this.txt_Postcode.TabIndex = 19;
            this.txt_Postcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Postcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Postcode_KeyPress);
            this.txt_Postcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Postcode_KeyUp);
            // 
            // frm_AddLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 178);
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
    }
}
namespace IPT_Milk_Company_UI
{
    partial class frm_AddTruck
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
            this.txt_Registration_Letters = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.txt_Registration_Numbers = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(23, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Rego Numbers";
            // 
            // txt_Registration_Letters
            // 
            this.txt_Registration_Letters.Location = new System.Drawing.Point(107, 89);
            this.txt_Registration_Letters.Name = "txt_Registration_Letters";
            this.txt_Registration_Letters.Size = new System.Drawing.Size(106, 20);
            this.txt_Registration_Letters.TabIndex = 18;
            this.txt_Registration_Letters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Registration_Letters.TextChanged += new System.EventHandler(this.txt_Registration_Letters_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Rego Letters";
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProduct.Location = new System.Drawing.Point(26, 115);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(187, 23);
            this.btn_addProduct.TabIndex = 20;
            this.btn_addProduct.Text = "Add Truck";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // txt_Registration_Numbers
            // 
            this.txt_Registration_Numbers.Location = new System.Drawing.Point(107, 63);
            this.txt_Registration_Numbers.Mask = "000";
            this.txt_Registration_Numbers.Name = "txt_Registration_Numbers";
            this.txt_Registration_Numbers.Size = new System.Drawing.Size(106, 20);
            this.txt_Registration_Numbers.TabIndex = 59;
            this.txt_Registration_Numbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_AddTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 163);
            this.Controls.Add(this.txt_Registration_Numbers);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.txt_Registration_Letters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "frm_AddTruck";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Add Truck";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Registration_Letters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.MaskedTextBox txt_Registration_Numbers;
    }
}
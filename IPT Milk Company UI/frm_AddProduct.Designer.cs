namespace IPT_Milk_Company_UI
{
    partial class frm_AddOrder
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
            this.flw_Products = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_addProduct =  new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // flw_Products
            // 
            this.flw_Products.Location = new System.Drawing.Point(1, 191);
            this.flw_Products.Name = "flw_Products";
            this.flw_Products.Size = new System.Drawing.Size(686, 160);
            this.flw_Products.TabIndex = 2;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(598, 162);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_addProduct.TabIndex = 3;
            this.btn_addProduct.Text = "Add Product";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // frm_AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 426);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.flw_Products);
            this.Name = "frm_AddOrder";
            this.Text = "frm_AddOrder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flw_Products;
        private MetroFramework.Controls.MetroButton btn_addProduct;
    }
}
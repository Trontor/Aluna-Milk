namespace IPT_Milk_Company_UI
{
    partial class Form1
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
            this.lbl_Subtext = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tab_Orders = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_addFactory = new System.Windows.Forms.Button();
            this.metroTabControl1.SuspendLayout();
            this.tab_Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Subtext
            // 
            this.lbl_Subtext.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subtext.Location = new System.Drawing.Point(23, 55);
            this.lbl_Subtext.Name = "lbl_Subtext";
            this.lbl_Subtext.Size = new System.Drawing.Size(624, 23);
            this.lbl_Subtext.TabIndex = 4;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tab_Orders);
            this.metroTabControl1.Location = new System.Drawing.Point(26, 81);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(621, 291);
            this.metroTabControl1.TabIndex = 5;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tab_Orders
            // 
            this.tab_Orders.Controls.Add(this.dataGridView1);
            this.tab_Orders.HorizontalScrollbarBarColor = true;
            this.tab_Orders.HorizontalScrollbarHighlightOnWheel = false;
            this.tab_Orders.HorizontalScrollbarSize = 10;
            this.tab_Orders.Location = new System.Drawing.Point(4, 38);
            this.tab_Orders.Name = "tab_Orders";
            this.tab_Orders.Size = new System.Drawing.Size(613, 249);
            this.tab_Orders.TabIndex = 0;
            this.tab_Orders.Text = "Orders";
            this.tab_Orders.VerticalScrollbarBarColor = true;
            this.tab_Orders.VerticalScrollbarHighlightOnWheel = false;
            this.tab_Orders.VerticalScrollbarSize = 10;
            this.tab_Orders.Click += new System.EventHandler(this.tab_Orders_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 249);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btn_addOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addOrder.Location = new System.Drawing.Point(149, 393);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(92, 39);
            this.btn_addOrder.TabIndex = 6;
            this.btn_addOrder.Text = "Add Order";
            this.btn_addOrder.UseVisualStyleBackColor = true;
            this.btn_addOrder.Click += new System.EventHandler(this.btn_addOrder_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(345, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(447, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "See Products";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_addFactory
            // 
            this.btn_addFactory.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btn_addFactory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addFactory.Location = new System.Drawing.Point(247, 393);
            this.btn_addFactory.Name = "btn_addFactory";
            this.btn_addFactory.Size = new System.Drawing.Size(92, 39);
            this.btn_addFactory.TabIndex = 8;
            this.btn_addFactory.Text = "Add Factory";
            this.btn_addFactory.UseVisualStyleBackColor = true;
            this.btn_addFactory.Click += new System.EventHandler(this.btn_addFactory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 481);
            this.Controls.Add(this.btn_addOrder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_addFactory);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.lbl_Subtext);
            this.Name = "Form1";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Management Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tab_Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Subtext;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tab_Orders;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_addOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_addFactory;
    }
}


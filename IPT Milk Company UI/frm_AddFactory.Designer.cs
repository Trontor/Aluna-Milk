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
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Registration = new System.Windows.Forms.TextBox();
            this.cmb_Office = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_prexistingLocation = new System.Windows.Forms.Button();
            this.btn_addFactory = new System.Windows.Forms.Button();
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
            // cmb_Office
            // 
            this.cmb_Office.FormattingEnabled = true;
            this.cmb_Office.Location = new System.Drawing.Point(71, 122);
            this.cmb_Office.Name = "cmb_Office";
            this.cmb_Office.Size = new System.Drawing.Size(152, 21);
            this.cmb_Office.TabIndex = 24;
            this.cmb_Office.SelectedIndexChanged += new System.EventHandler(this.cmb_Office_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Office";
            // 
            // btn_prexistingLocation
            // 
            this.btn_prexistingLocation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_prexistingLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prexistingLocation.Location = new System.Drawing.Point(71, 149);
            this.btn_prexistingLocation.Name = "btn_prexistingLocation";
            this.btn_prexistingLocation.Size = new System.Drawing.Size(152, 23);
            this.btn_prexistingLocation.TabIndex = 25;
            this.btn_prexistingLocation.Text = "Add Office";
            this.btn_prexistingLocation.UseVisualStyleBackColor = true;
            this.btn_prexistingLocation.Click += new System.EventHandler(this.btn_Add_Office_Click);
            // 
            // btn_addFactory
            // 
            this.btn_addFactory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_addFactory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addFactory.Location = new System.Drawing.Point(26, 178);
            this.btn_addFactory.Name = "btn_addFactory";
            this.btn_addFactory.Size = new System.Drawing.Size(197, 23);
            this.btn_addFactory.TabIndex = 26;
            this.btn_addFactory.Text = "Add Factory";
            this.btn_addFactory.UseVisualStyleBackColor = true;
            this.btn_addFactory.Click += new System.EventHandler(this.btn_addFactory_Click);
            // 
            // frm_AddFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 216);
            this.Controls.Add(this.btn_addFactory);
            this.Controls.Add(this.btn_prexistingLocation);
            this.Controls.Add(this.cmb_Office);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Registration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Factory_Name);
            this.Name = "frm_AddFactory";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Add Factory";
            this.Load += new System.EventHandler(this.frm_AddFactory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Factory_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Registration;
        private System.Windows.Forms.ComboBox cmb_Office;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_prexistingLocation;
        private System.Windows.Forms.Button btn_addFactory;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPT_Milk_Company_UI
{
    class ValidityChecker
    {
        List<Control> controls = new List<Control>();
        public ValidityChecker(params Control[] controls)
        {
            foreach (Control c in controls)
                this.controls.Add(c);
        }

        public List<string> InvalidFields(bool notifyUser = true)
        {
            List<string> invalidFields = new List<string>();
            foreach (Control c in controls)
            {
                if (c.Name.StartsWith("txt"))
                    if (string.IsNullOrEmpty(c.Text))
                        invalidFields.Add(c.Name.Replace("txt_", "").Replace("_", " ") + " needs some text.");
                if (c.Name.StartsWith("cmb"))
                    if (c is ComboBox)
                    {
                        ComboBox box = (c as ComboBox);
                        if (box.SelectedIndex < 0)
                            invalidFields.Add(c.Name.Replace("cmb_", "").Replace("_", "") + " needs a selected item.");
                    }
                if (c.Name.StartsWith("dtp_"))
                {
                    DateTimePicker picker = c as DateTimePicker;
                    if (picker.Value < DateTime.Now)
                    {
                        invalidFields.Add(c.Name.Replace("dtp_", "").Replace("_", "") + " needs a date in the future!");
                    }
                }
                    if (c.Name.StartsWith("int"))
                {
                    if (c is TextBox)
                    {
                        decimal result = 0;
                        if (!decimal.TryParse(c.Text, out result))
                            invalidFields.Add(c.Name.Replace("int_", "").Replace("_", " ") + " needs a valid number.");
                    }
                }
            }
            if (notifyUser && invalidFields.Count > 0)
            { 
                    string errorMsg = "You have some errors to fix up:" + Environment.NewLine + Environment.NewLine;
                    foreach (string s in invalidFields)
                        errorMsg += s + Environment.NewLine;
                    errorMsg += Environment.NewLine + "You will need to provide these in order to add a product to the database.";
                    MessageBox.Show(errorMsg, "Mandatory Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            return invalidFields;
        }
    }
}

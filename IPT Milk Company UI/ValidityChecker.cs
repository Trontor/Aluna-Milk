using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPT_Milk_Company_UI
{
    class ValidityChecker
    {
        List<object> controls = new List<object>();
        enum ValidationType
        {
            DateFuture,
            DatePast
        }
        public ValidityChecker(params object[] controls)
        {
            foreach (object c in controls)
                this.controls.Add(c);
        }

        public List<string> InvalidFields(bool notifyUser = true)
        {
            List<string> invalidFields = new List<string>();
            foreach (object c in controls)
            {
                if (c is Control)
                {
                    Control contr = c as Control;
                    if (contr.Name.StartsWith("txt"))
                        if (string.IsNullOrEmpty(contr.Text))
                            invalidFields.Add(contr.Name.Replace("txt_", "").Replace("_", " ") + " needs some text.");
                    if (contr.Name.StartsWith("cmb"))
                        if (c is ComboBox)
                        {
                            ComboBox box = (c as ComboBox);
                            if (box.SelectedIndex < 0)
                                invalidFields.Add(contr.Name.Replace("cmb_", "").Replace("_", "") + " needs a selected item.");
                        }
                    if (contr.Name.StartsWith("dtp_"))
                    {
                        DateTimePicker picker = c as DateTimePicker;
                        if (picker.Value < DateTime.Now)
                        {
                            invalidFields.Add(contr.Name.Replace("dtp_", "").Replace("_", "") + " needs a date in the future!");
                        }
                    }
                    if (contr.Name.StartsWith("int"))
                    {
                        if (c is TextBox)
                        {
                            decimal result = 0;
                            if (!decimal.TryParse(contr.Text, out result))
                                invalidFields.Add(contr.Name.Replace("int_", "").Replace("_", " ") + " needs a valid number.");
                        }
                    }
                }
                else if (c is int)
                {
                    if ((int)c < 0)
                    {
                        //!!!!!!!!!!!!!!!!!
                       // invalidFields.Add(System.Reflection.)
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IPT_Milk_Company_UI
{
    static class LoggedInEmployee
    {
        public static int ID = -1;
        private static DataRow r;
        public static DataRow EmployeeInformation()
        {
            if (r == null)
                r = DatabaseHelper.GetPerson(ID);

            return r;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPT_Milk_Company_UI
{
    static class DatabaseHelper
    {
        public static int GetRowID(string table, string searchColumn, string idColumn, string value)
        {
            foreach (DataRow row in DatabaseHelper.GetTable(table).Rows)
            {
                if (row[searchColumn].ToString() == value)
                    return int.Parse(row[idColumn].ToString());
            }
            return -1; 
        }
        public static OleDbDataReader ExecuteQuery(string query)
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Milk Database.accdb;
Persist Security Info=False;");
            connection.Open();
            OleDbCommand command = new OleDbCommand(query, connection); Debug.WriteLine(query);
            OleDbDataReader reader = command.ExecuteReader();
            connection.Close();
            return reader;
        }

        public static DataRow GetPerson(int personID)
        {
            return GetTable("Person").Rows[personID - 1];
        }

        public static List<string> GetColumnItems(string tablename, string columnname)
        {
            List<string> items = new List<string>();
            DataTable table = GetTable(tablename);
            if (table.Columns.Contains(columnname))
                foreach (DataRow row in table.Rows)
                {
                    items.Add(row[columnname].ToString());
                }
            else
                MessageBox.Show(columnname + " does not exist in " + tablename);
            return items;
        }

        public static DataTable GetTable(string tablename)
        {
            DataTable dataTable = new DataTable();
            try
            {
                OleDbConnection connection =
                    new OleDbConnection(
                        @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Milk Database.accdb;
Persist Security Info=False;");
                connection.Open();
                OleDbDataAdapter dAdapter = new OleDbDataAdapter("select * from " + tablename, connection);
                dAdapter.Fill(dataTable);

                //foreach (DataRow s in dataTable.Rows)
                //{
                //    for (int i = 0; i < dataTable.Columns.Count; i++)
                //    {
                //        MessageBox.Show(s[i].ToString());

                //    }
                //}
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dataTable;

        }
        public static Milk_DatabaseDataSet.ProductsDataTable LoadProductList()
        {
            try
            {
                Milk_DatabaseDataSet.ProductsDataTable productsTable = new Milk_DatabaseDataSet.ProductsDataTable();
                List<Milk_DatabaseDataSet.ProductsDataTable> item = new List<Milk_DatabaseDataSet.ProductsDataTable>();
                productsTable.Rows.Clear();

                OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Milk Database.accdb;
Persist Security Info=False;");
                connection.Open();
                string queryString = "SELECT * FROM Products";
                OleDbCommand command = new OleDbCommand(queryString, connection);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int i = 1;
                    foreach (var v in productsTable)
                        productsTable.AddProductsRow((int)reader.GetValue(i), (string)reader.GetValue(++i), (DateTime)reader.GetValue(++i), (int)reader.GetValue(++i), (int)reader.GetValue(++i), (string)reader.GetValue(++i));
                }

                reader.Close();
                connection.Close();
                return productsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
                return null;
            }
        }
    }
}

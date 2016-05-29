using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace IPT_Milk_Company_UI
{
    static class DatabaseHelper
    {
        static Dictionary<string, DataTable> dtables = new Dictionary<string, DataTable>();

        static DateTime lastRefreshed = DateTime.MinValue;
        public static void RefreshTables(bool overrideCheck = false)
        {
            if (overrideCheck || (DateTime.Now - lastRefreshed).Seconds > 10)
            {
                dtables.Clear();
                OleDbConnection connection = new OleDbConnection(constr);
                connection.Open();
                Console.WriteLine("Information for each table contains:");
                DataTable tables = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                Console.WriteLine("The tables are:");
                foreach (DataRow row in tables.Rows)
                {
                    string tablename = row[2].ToString();
                    Console.WriteLine(tablename.ToString());
                    dtables.Add(tablename, GetTable(tablename, connection));
                }

                lastRefreshed = DateTime.Now;
            }
            else
                Debug.WriteLine("There has been {0} seconds before the last refresh, we've skipped it this time.", (DateTime.Now - lastRefreshed).Seconds);
        }
        public static int GetRowID(string table, string searchColumn, string idColumn, string value)
        {
            DataTable personTbl = GetTable(table, null, null, true);
            foreach (DataRow row in personTbl.Rows)
            {
                if (row[searchColumn].ToString() == value)
                    return int.Parse(row[idColumn].ToString());
            }
            return -1;
        }
        static string constr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Milk Database.accdb;
Persist Security Info=False;";  
        public static OleDbDataReader ExecuteQuery(string query)
        {
            RefreshTables();
            OleDbConnection connection = new OleDbConnection(constr);
            connection.Open();
            OleDbCommand command = new OleDbCommand(query, connection); Debug.WriteLine(query);
            OleDbDataReader reader = command.ExecuteReader();
            connection.Close();
            return reader;
        }

        public static int GetTableIndex(DataTable tbl, string columnName, int value)
        {
            for (int i = 0; i <= tbl.Rows.Count - 1; i++)
            {
                DataRow row = tbl.Rows[i];
                if (row[columnName].ToString() == value.ToString())
                {
                    return i;
                }
            }
            return -1;
        }
        public static OleDbDataReader DeleteRow(string tablename, string primaryName, string primaryValue)
        {
            return ExecuteQuery("DELETE FROM [" + tablename + "] WHERE [" + primaryName + "]=" + primaryValue);
            
        }
        public static DataRow GetPerson(int personID)
        {
            int rowid = GetRowID("Person", "Person ID", "Person ID", personID.ToString());
            return GetTable("Person").Rows[GetTableIndex(GetTable("Person"), "Person ID", rowid)];
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


        public static string CalculateMD5Hash(string input)

        {

            // step 1, calculate MD5 hash from input

            MD5 md5 = System.Security.Cryptography.MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);

            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)

            {

                sb.Append(hash[i].ToString("x2"));

            }

            return sb.ToString();

        }

        public static DataTable GetTable(string tablename, OleDbConnection con = null, string customQuery = "", bool bypassCache = false)
        {
            if (!string.IsNullOrEmpty(tablename) && dtables.ContainsKey(tablename) && !bypassCache)
                return dtables[tablename];
            if (con == null)
            {
                con = new OleDbConnection(constr);
                con.Open();

            }
            else
            {
                Debug.WriteLine("XD");
            }
            DataTable dataTable = new DataTable();
            try
            {
                string query;
                if (string.IsNullOrEmpty(customQuery))
                    query = ("select * from [" + tablename + "]");
                else query = customQuery;
                Debug.WriteLine(query);
                OleDbDataAdapter dAdapter = new OleDbDataAdapter(query, con);

                dAdapter.Fill(dataTable);

                //foreach (DataRow s in dataTable.Rows)
                //{
                //    for (int i = 0; i < dataTable.Columns.Count; i++)
                //    {
                //        MessageBox.Show(s[i].ToString());

                //    }
                //}
                con.Close();
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

                OleDbConnection connection = new OleDbConnection(constr);
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

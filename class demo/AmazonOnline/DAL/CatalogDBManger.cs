using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


using Catalog;
using System.Runtime.InteropServices;

namespace DAL
{
    public static class CatalogDBManger
    {

        //CRUD Operations against database


        //read
        public static  IEnumerable<Product> GetAllProducts()
        {
            //Invoke backend data into .NET application
            // needed database connectivity 
            // you need to use 
            //  1. ADO.NET Object Model ( JDBC) (Activex Data Object or 
            //  2. Entity Framework  (Hibernate)
            // 1.connect to database
            // query against database using SQL
            // get resultset from Query Processing
            // Create List of Products from resultset
            //return list of Products


            List<Product> allProducts = new List<Product>();
            IDbConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C - DAC Assignment\ASP.NET\ASP - DOT - NET\class demo\AmazonOnline\TesterApp\ECommerce.mdf;Integrated Security=True";
            IDbCommand cmd = new SqlCommand();
            string query = "SELECT * FROM flowers";
            cmd.Connection = con;
            cmd.CommandText = query;
            IDataReader reader = null;

            try
            {
                con.Open();
                reader=cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["ProductID"].ToString());
                    string title = reader["title"].ToString();
                    string description = reader["description"].ToString();
                    int unitPrice =int.Parse(reader["price"].ToString());
                    int quantity=int.Parse(reader["quantity"].ToString());

                    Product theProduct = new Product
                    {
                        ID = id,
                        Title = title,
                        Description = description,
                        UnitPrice = unitPrice,
                        Quantity = quantity
                    };
                    allProducts.Add(theProduct);
                }
                reader.Close();
            }
            catch (SqlException exp)
            { 
                string message = exp.Message;
            }

            finally 
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return allProducts;
        }

        //create
        public static bool Insert(Product theProduct)
        {
            bool status = false;

            // logic to insertion
            return status;
        }

        //update
        public static bool Update(Product theProduct)
        {
            bool status = false;

            // logic to updation
            return status;

        }

        //delte
        public static bool Delete(int  productID)
        {
            bool status = false;

            // logic to removal
            return status;
        }
    }
}

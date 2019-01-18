using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ShopInventoryManager
{
    public class ProductDataManager
    {

        public ProductDataManager()
        {

        }

        public List<Product> Search(string searchTerm)
        {
            List<Product> returnValue = new List<Product>();

            string connString = Properties.Settings.Default.connectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("ProductSearch", conn) { CommandType = CommandType.StoredProcedure })
                {

                    cmd.Parameters.AddWithValue("@value", searchTerm);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader(); // execute reader for more than one record else ExecuteScalar()

                    while (reader.Read())
                    {
                        // with every new result from the reader, add the result to the list returnValue
                        returnValue.Add(new Product
                        {
                            Id = (int)reader["ProductID"],
                            Name = reader["Name"].ToString(),
                            Price = (decimal)reader["Price"],
                            Description = reader["Description"].ToString(),
                            StockCount = (int)reader["StockCount"],
                            Location = new Location
                            {
                                LocationName = reader["LocationName"].ToString(),
                                LocationID = (int)reader["LocationId"]
                            }
                        });
                    }
                }
            }
            return returnValue;
        }

        public Product Create(Product product)
        {
            Product newProduct = new Product(product);
            string cmdString = "INSERT INTO Products(Name, Price, Description, StockCount, Location) VALUES (@name, @price, @description, @stockcount, @location)";
            string connString = Properties.Settings.Default.connectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = cmdString;
                    cmd.Parameters.AddWithValue("@name", newProduct.Name);
                    cmd.Parameters.AddWithValue("@price", newProduct.Price);
                    cmd.Parameters.AddWithValue("@description", newProduct.Description);
                    cmd.Parameters.AddWithValue("@stockcount", newProduct.StockCount);
                    cmd.Parameters.AddWithValue("@location", newProduct.Location.LocationID);

                    conn.Open();
                    cmd.ExecuteNonQuery(); // non query because the database is not being queried but modified. 

                    cmd.CommandText = "SELECT TOP(1) ProductId FROM Products ORDER BY ProductID DESC";
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        newProduct.Id = (int)reader["ProductID"];
                    }

                }
            }
            return newProduct;
        }

        public void Update(int id, Product product)
        {
            string cmdString = "UPDATE Products SET Name = @name, Price = @price, Description = @description, StockCount = @stockcount, Location = @location WHERE ProductID = @id";
            string connString = Properties.Settings.Default.connectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = cmdString;
                    cmd.Parameters.AddWithValue("@name", product.Name);
                    cmd.Parameters.AddWithValue("@price", product.Price);
                    cmd.Parameters.AddWithValue("@description", product.Description);
                    cmd.Parameters.AddWithValue("@stockcount", product.StockCount);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@location", product.Location.LocationID);

                    conn.Open();
                    cmd.ExecuteNonQuery(); // non query because the database is not being queried but modified.
                    conn.Close();

                }
            }
        }

        public void Delete(int id)
        {
            string cmdString = "DELETE FROM Products WHERE ProductID = @id";
            string connString = Properties.Settings.Default.connectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = cmdString;
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }
        }
    }
}

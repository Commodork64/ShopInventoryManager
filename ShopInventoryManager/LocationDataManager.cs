using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopInventoryManager
{
    class LocationDataManager
    {
        public List<Location> GetLocations()
        {
            var returnValue = new List<Location>();
            string cmdString = "SELECT * FROM Location";
            string connString = Properties.Settings.Default.connectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = cmdString;
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            returnValue.Add(new Location
                            {
                                LocationID = (int)reader["LocationID"],
                                LocationName = reader["LocationName"].ToString(),
                            });
                        }
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(e.Number.ToString());
                    }
                }
            }
            return returnValue;
        }
    }
}

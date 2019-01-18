using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInventoryManager
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int StockCount { get; set; }
        public Location Location { get; set; }

        public Product()
        {

        }

        public Product(Product copy)
        {
            this.Id = copy.Id;
            this.Name = copy.Name;
            this.Price = copy.Price;
            this.Description = copy.Description;
            this.StockCount = copy.StockCount;
            this.Location = copy.Location;
        }
    }
}

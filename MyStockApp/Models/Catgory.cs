using System;
using System.Collections.Generic;

#nullable disable

namespace MyStockApp.Models
{
    public partial class Catgory
    {
        public Catgory()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}

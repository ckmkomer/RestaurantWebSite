using Restaurant.CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.EntityLayer.Concrete
{
  public class Product :BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public string ImageUrl { get; set; }

        public bool Status { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Basket> Baskets { get; set; }
    }
}

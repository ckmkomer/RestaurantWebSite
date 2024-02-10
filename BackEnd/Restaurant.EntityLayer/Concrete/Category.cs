using Restaurant.CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.EntityLayer.Concrete
{
   public class Category :BaseEntity
    {
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}

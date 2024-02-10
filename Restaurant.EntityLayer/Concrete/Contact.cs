using Restaurant.CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.EntityLayer.Concrete
{
   public class Contact : BaseEntity
    {
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Email { get; set; }
       

    }
}

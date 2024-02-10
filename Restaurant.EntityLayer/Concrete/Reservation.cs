using Restaurant.CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.EntityLayer.Concrete
{
    public class Reservation :BaseEntity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string PersonCount { get; set; }

        public string Mail { get; set; }

        public DateTime Date { get; set; }
    }
}

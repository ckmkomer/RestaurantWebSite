using Restaurant.CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.EntityLayer.Concrete
{
   public class Footer :BaseEntity
    {
        public string? Desciription { get; set; }
        public string? OpeningHours { get; set; }

        public string Date { get; set; }
    }
}

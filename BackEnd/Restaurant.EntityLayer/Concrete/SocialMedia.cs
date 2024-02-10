using Restaurant.CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.EntityLayer.Concrete
{
   public class SocialMedia :BaseEntity
    {
        public string Title { get; set; }
        public string Url { get; set; }

        public string Icon { get; set; }
    }
}

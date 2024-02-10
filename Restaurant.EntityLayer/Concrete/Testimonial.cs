﻿using Restaurant.CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.EntityLayer.Concrete
{
  public class Testimonial :BaseEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }

        public string Imagerl { get; set; }

        public string Status { get; set; }
    }
}

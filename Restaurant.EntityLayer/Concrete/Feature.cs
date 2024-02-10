﻿using Restaurant.CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.EntityLayer.Concrete
{
    public class Feature:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

       
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DtoLayer.Dto.Footer
{
    public class CreateFooterDto
    {
        
        public string? Title { get; set; }
        public string? Desciription { get; set; }
        public string? OpeningHours { get; set; }

        public string Date { get; set; }
    }
}

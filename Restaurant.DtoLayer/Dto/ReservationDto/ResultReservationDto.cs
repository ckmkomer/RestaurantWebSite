﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DtoLayer.Dto.ReservationDto
{
    public class ResultReservationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string PersonCount { get; set; }

        public string Mail { get; set; }

        public DateTime Date { get; set; }
    }
}

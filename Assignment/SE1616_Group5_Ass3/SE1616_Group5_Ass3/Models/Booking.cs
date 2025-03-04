﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SE1616_Group5_Ass3.Models
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public int ShowId { get; set; }
        public string Name { get; set; }
        public string SeatStatus { get; set; }
        public decimal? Amount { get; set; }

        public virtual Show Show { get; set; }
    }
}

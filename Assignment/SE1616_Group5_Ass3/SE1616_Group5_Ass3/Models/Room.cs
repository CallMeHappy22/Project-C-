﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SE1616_Group5_Ass3.Models
{
    public partial class Room
    {
        public Room()
        {
            Shows = new HashSet<Show>();
        }

        public int RoomId { get; set; }
        public string Name { get; set; }
        public int? NumberRows { get; set; }
        public int? NumberCols { get; set; }

        public virtual ICollection<Show> Shows { get; set; }
    }
}

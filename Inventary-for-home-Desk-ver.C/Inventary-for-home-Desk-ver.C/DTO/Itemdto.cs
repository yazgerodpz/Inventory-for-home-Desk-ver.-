﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventary_for_home_Desk_ver.C.DTO
{
    public class Itemdto
    {
        public string ItemName { get; set; } = null!;

        public int Stock { get; set; }

        public int IdTypePrioritary { get; set; }

        public int IdTypeStock { get; set; }

        public DateTime PurchesDate { get; set; }

        public DateTime ExpirationDate { get; set; }
    }
}

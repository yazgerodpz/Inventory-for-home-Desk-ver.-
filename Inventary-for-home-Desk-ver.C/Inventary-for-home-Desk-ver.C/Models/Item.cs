using System;
using System.Collections.Generic;

namespace Inventary_for_home_Desk_ver.C.Models;

public partial class Item
{
    public int IdItem { get; set; }

    public string ItemName { get; set; } = null!;

    public int Stock { get; set; }

    public int IdTypePrioritary { get; set; }

    public int IdTypeStock { get; set; }

    public DateTime PurchesDate { get; set; }

    public DateTime ExpirationDate { get; set; }

    public bool Active { get; set; }
}

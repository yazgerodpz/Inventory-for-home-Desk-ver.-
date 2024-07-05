using System;
using System.Collections.Generic;

namespace Inventary_for_home_Desk_ver.C.Models;

public partial class CatTypePrioritary
{
    public int IdTypePrioritary { get; set; }

    public string TypePrioritaryName { get; set; } = null!;

    public string _Description { get; set; } = null!;

    public bool Active { get; set; }
}

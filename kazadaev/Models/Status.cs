using System;
using System.Collections.Generic;

namespace kazadaev.Models;

public partial class Status
{
    public int IdStatus { get; set; }

    public string Status1 { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}

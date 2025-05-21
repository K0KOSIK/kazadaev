using System;
using System.Collections.Generic;

namespace kazadaev.Models;

public partial class OrderDetail
{
    public int IdOrderDetails { get; set; }

    public string Quantity { get; set; } = null!;

    public int Price { get; set; }

    public int ProductIdProduct { get; set; }

    public int OrdersIdOrders { get; set; }

    public virtual Order OrdersIdOrdersNavigation { get; set; } = null!;

    public virtual Product ProductIdProductNavigation { get; set; } = null!;
}

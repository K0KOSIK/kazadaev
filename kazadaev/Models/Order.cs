using System;
using System.Collections.Generic;

namespace kazadaev.Models;

public partial class Order
{
    public int IdOrders { get; set; }

    public string Orderdate { get; set; } = null!;

    public int TotalAmount { get; set; }

    public int StatusIdStatus { get; set; }

    public int CustomersIdCustomers { get; set; }

    public virtual Customer CustomersIdCustomersNavigation { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Status StatusIdStatusNavigation { get; set; } = null!;
}

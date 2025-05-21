using System;
using System.Collections.Generic;

namespace kazadaev.Models;

public partial class Customer
{
    public int IdCustomers { get; set; }

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int UsersIdUsers { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual User UsersIdUsersNavigation { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace kazadaev.Models;

public partial class User
{
    public int IdUsers { get; set; }

    public string UsersName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Role { get; set; } = null!;

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}

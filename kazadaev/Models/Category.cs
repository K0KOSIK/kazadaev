using System;
using System.Collections.Generic;

namespace kazadaev.Models;

public partial class Category
{
    public int IdCategories { get; set; }

    public string CategoriesName { get; set; } = null!;

    public string Descriptions { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

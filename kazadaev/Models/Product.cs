using System;
using System.Collections.Generic;

namespace kazadaev.Models;

public partial class Product
{
    public int IdProduct { get; set; }

    public string Productname { get; set; } = null!;

    public int Price { get; set; }

    public int StockQuantity { get; set; }

    public int CategoriesIdCategories { get; set; }

    public virtual Category CategoriesIdCategoriesNavigation { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}

using System;
using System.Collections.Generic;

namespace Suhareva_UP.Models;

public partial class Productstype
{
    public int Producttypeid { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

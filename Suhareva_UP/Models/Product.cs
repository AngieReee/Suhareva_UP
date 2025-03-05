using System;
using System.Collections.Generic;

namespace Suhareva_UP.Models;

public partial class Product
{
    public int Productid { get; set; }

    public string? Article { get; set; }

    public int? Producttype { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string? Productimage { get; set; }

    public decimal Mincostforpartner { get; set; }

    public decimal? Height { get; set; }

    public decimal? Width { get; set; }

    public virtual ICollection<Partnersproduct> Partnersproducts { get; set; } = new List<Partnersproduct>();

    public virtual ICollection<Productsmaterial> Productsmaterials { get; set; } = new List<Productsmaterial>();

    public virtual Productstype? ProducttypeNavigation { get; set; }
}

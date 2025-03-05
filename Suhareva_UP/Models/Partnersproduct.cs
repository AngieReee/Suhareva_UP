using System;
using System.Collections.Generic;

namespace Suhareva_UP.Models;

public partial class Partnersproduct
{
    public int Partnersproductsid { get; set; }

    public int Productsid { get; set; }

    public int Partnersid { get; set; }

    public int Numberofproducts { get; set; }

    public DateOnly Saledate { get; set; }

    public virtual Partner Partners { get; set; } = null!;

    public virtual Product Products { get; set; } = null!;
}

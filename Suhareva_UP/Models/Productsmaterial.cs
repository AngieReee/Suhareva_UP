using System;
using System.Collections.Generic;

namespace Suhareva_UP.Models;

public partial class Productsmaterial
{
    public int Productsmaterialsid { get; set; }

    public int Materialid { get; set; }

    public int Productid { get; set; }

    public virtual Material Material { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}

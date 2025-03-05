using System;
using System.Collections.Generic;

namespace Suhareva_UP.Models;

public partial class Materialstype
{
    public int Materialtypeid { get; set; }

    public string Title { get; set; } = null!;

    public decimal Perofdefects { get; set; }

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}

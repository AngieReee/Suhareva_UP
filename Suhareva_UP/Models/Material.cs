using System;
using System.Collections.Generic;

namespace Suhareva_UP.Models;

public partial class Material
{
    public int Material1 { get; set; }

    public int? Materialtypeid { get; set; }

    public string Title { get; set; } = null!;

    public virtual Materialstype? Materialtype { get; set; }

    public virtual ICollection<Productsmaterial> Productsmaterials { get; set; } = new List<Productsmaterial>();
}

using System;
using System.Collections.Generic;

namespace Suhareva_UP.Models;

public partial class Partnerstype
{
    public int Partnerstypeid { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();
}

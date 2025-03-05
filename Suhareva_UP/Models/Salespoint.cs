using System;
using System.Collections.Generic;

namespace Suhareva_UP.Models;

public partial class Salespoint
{
    public int Salepointsid { get; set; }

    public string Title { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual ICollection<Partnerssalespoint> Partnerssalespoints { get; set; } = new List<Partnerssalespoint>();
}

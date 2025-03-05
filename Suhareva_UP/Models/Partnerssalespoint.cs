using System;
using System.Collections.Generic;

namespace Suhareva_UP.Models;

public partial class Partnerssalespoint
{
    public int Partnerssalespointsid { get; set; }

    public int Salepoint { get; set; }

    public int Partnersid { get; set; }

    public virtual Partner Partners { get; set; } = null!;

    public virtual Salespoint SalepointNavigation { get; set; } = null!;
}

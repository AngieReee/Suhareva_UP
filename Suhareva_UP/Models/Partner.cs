using System;
using System.Collections.Generic;

namespace Suhareva_UP.Models;

public partial class Partner
{
    public int Partnersid { get; set; }

    public int Partnerstypeid { get; set; }

    public string Title { get; set; } = null!;

    public string Legaladdress { get; set; } = null!;

    public string Inn { get; set; } = null!;

    public string Head { get; set; } = null!;

    public string Phonenumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Logo { get; set; }

    public int? Rating { get; set; }

    public virtual ICollection<Partnersproduct> Partnersproducts { get; set; } = new List<Partnersproduct>();

    public virtual ICollection<Partnerssalespoint> Partnerssalespoints { get; set; } = new List<Partnerssalespoint>();

    public virtual Partnerstype Partnerstype { get; set; } = null!;
}

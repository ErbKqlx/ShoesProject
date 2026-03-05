using System;
using System.Collections.Generic;

namespace ShoesProject;

public partial class Measure
{
    public int Id { get; set; }

    public string MeasureName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

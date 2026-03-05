using System;
using System.Collections.Generic;

namespace ShoesProject;

public partial class DeliveryPoint
{
    public int Id { get; set; }

    public string DeliveryAddress { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}

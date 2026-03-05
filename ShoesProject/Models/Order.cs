using ShoesProject.Models;
using System;
using System.Collections.Generic;

namespace ShoesProject;

public partial class Order
{
    public int Id { get; set; }

    public DateOnly OrderDate { get; set; }

    public DateOnly DeliveryDate { get; set; }

    public int IdDeliveryPoint { get; set; }

    public int IdUser { get; set; }

    public int Code { get; set; }

    public int IdStatuses { get; set; }

    public virtual DeliveryPoint IdDeliveryPointNavigation { get; set; } = null!;

    public virtual Status IdStatusesNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual ICollection<ProductsOrder> ProductsOrders { get; set; } = new List<ProductsOrder>();
}

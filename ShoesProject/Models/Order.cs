using ShoesProject.Models;

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

    public virtual DeliveryPoint DeliveryPoint { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual ICollection<ProductsOrder> ProductsOrders { get; set; } = new List<ProductsOrder>();
}

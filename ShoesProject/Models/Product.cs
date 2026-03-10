using ShoesProject.Models;

namespace ShoesProject;

public partial class Product
{
    public int Id { get; set; }

    public string Art { get; set; } = null!;

    public int IdType { get; set; }

    public int IdMeasure { get; set; }

    public decimal Price { get; set; }

    public int IdSupplier { get; set; }

    public int IdManufacturer { get; set; }

    public int IdCategory { get; set; }

    public int Discount { get; set; }

    public int CointInStock { get; set; }

    public string Description { get; set; } = null!;

    public string? PhotoUrl { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Manufacturer Manufacturer { get; set; } = null!;

    public virtual Measure Measure { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual ProductType ProductType { get; set; } = null!;

    public virtual ICollection<ProductsOrder> ProductsOrders { get; set; } = new List<ProductsOrder>();
}

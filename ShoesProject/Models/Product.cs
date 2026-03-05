using ShoesProject.Models;
using System;
using System.Collections.Generic;

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

    public virtual Category IdCategoryNavigation { get; set; } = null!;

    public virtual Manufacturer IdManufacturerNavigation { get; set; } = null!;

    public virtual Measure IdMeasureNavigation { get; set; } = null!;

    public virtual Supplier IdSupplierNavigation { get; set; } = null!;

    public virtual ProductType IdTypeNavigation { get; set; } = null!;

    public virtual ICollection<ProductsOrder> ProductsOrders { get; set; } = new List<ProductsOrder>();
}

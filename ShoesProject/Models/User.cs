namespace ShoesProject.Models;

public partial class User
{
    public int Id { get; set; }

    public int IdRole { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public string FullName => $"{LastName} {FirstName} {MiddleName}";
}

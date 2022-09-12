namespace Stuff.Domain.Entities;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;
    public int Age { get; set; }
    public string Login { get; set; } = String.Empty;
    public string MyProperty { get; set; } = String.Empty;
}

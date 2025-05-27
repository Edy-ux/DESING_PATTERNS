namespace App.src.SOLID.L.Users.Entities;
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void Validate()
    {
        if (string.IsNullOrWhiteSpace(Name))
            throw new ArgumentException("User name cannot be empty.");
    }
}
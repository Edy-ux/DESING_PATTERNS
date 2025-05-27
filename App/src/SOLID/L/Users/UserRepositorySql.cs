using App.src.SOLID.L.Users.Entities;
using App.src.SOLID.L.Users.Interfaces;

namespace App.src.SOLID.L.Users;
public class UsuarioRepositorioSql : IUserRepository
{
    // Simulação de conexão com banco de dados SQL
    public void Add(User usuario)
    {
        Console.WriteLine($"User {usuario.Name} added on db SQL.");
    }

    public User GetById(int id)
    {
        // Simulação
        return new User { Id = id, Name = "João (SQL)" };
    }
}

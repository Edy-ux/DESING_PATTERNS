using App.src.SOLID.L.Users.Entities;

namespace App.src.SOLID.L.Users.Interfaces;
public interface IUserRepository
{
    User GetById(int id);
    void Add(User user);
 
}
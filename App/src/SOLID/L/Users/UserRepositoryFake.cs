using App.src.SOLID.L.Users.Entities;
using App.src.SOLID.L.Users.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.src.SOLID.L.Users;
public class UserRepositoryFake : IUserRepository
{

    private readonly List<User> _users = new();
    public void Add(User user)
    {
        _users.Add(user);
    }

    public User GetById(int id)
    {
        if (_users.SingleOrDefault(u => u.Id == id) is not User user)
        {
            throw new ArgumentException($"User with id {id} not found.");

        }
        return user;
    }
}

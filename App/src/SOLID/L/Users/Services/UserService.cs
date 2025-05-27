using App.src.SOLID.L.Users.Entities;
using App.src.SOLID.L.Users.Interfaces;


namespace App.src.SOLID.L.Users.Services;
public class UserRegistrationService
{

    private readonly IUserRepository _userRepository;
    public UserRegistrationService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public void AddUser(User user)
    {
         user.Validate();
        _userRepository.Add(user);
    }
}

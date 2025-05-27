using App.src.SOLID.L.Users.Entities;
using App.src.SOLID.L.Users.Event.Contracts;
using App.src.SOLID.L.Users.Interfaces;


namespace App.src.SOLID.L.Users.Event;
public class UserRegistrationService
{
    private readonly IUserRepository _repository;
    private readonly IEventDispatcher _dispatcher;

    public UserRegistrationService(IUserRepository repository, IEventDispatcher dispatcher)
    {
        _repository = repository;
        _dispatcher = dispatcher;
    }

    public void RegisterUser(string name)
    {
        var user = new User { Name = name };
        user.Validate();

        _repository.Add(user);

        _dispatcher.Publish(new UserCreatedEvent(name));
    }

}
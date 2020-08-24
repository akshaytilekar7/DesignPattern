using NinjectDemo.Domain.Entities.DTOs;

namespace NinjectDemo.Domain.Interfaces
{
    public interface IUserService
    {
        string Add(UserDTO userDto);
    }
}


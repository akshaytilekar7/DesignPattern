using NinjectDemo.Domain.Entities.DTOs;
using NinjectDemo.Domain.Interfaces;

namespace NinjectDemo.Services
{
    public class UserServiceWindows : IUserService
    {
        public string Add(UserDTO clubDTO)
        {
            return "user added for :" + this.GetType().Name;
        }
    }
}



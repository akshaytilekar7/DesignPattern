using ExceptionHandling.ExceptionHelper;
using ExceptionHandling.ExceptionHelper.Enums;
using ExceptionHandling.Models;

namespace ExceptionHandling.Services
{
    public class UserServices
    {
        public void AddUser(User user)
        {
            if (user == null)
                throw new BusinessException(ErrorTypes.ValidationFault, ErrorCodes.InvalidUserId);

            if (!IsFeatureEnable())
            {
                throw new BusinessException(ErrorTypes.ConfigurationFault, ErrorCodes.FeatureNotEnable);
            }
        }

        private bool IsFeatureEnable()
        {
            return false;
        }
    }
}
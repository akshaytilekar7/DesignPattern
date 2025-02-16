using ExceptionHandling.ExceptionHelper;
using ExceptionHandling.ExceptionHelper.Enums;
using System.Web.Http;

namespace ExceptionHandling.Controllers.Api
{
    [ExceptionHandlingAttribute]

    public class HomeWebApi : ApiController
    {
        [Route("api/deliveryitems")]
        [HttpGet, HttpPost]
        public void GetDeliveryItemsTwo(string anyString = "default")
        {
            throw new BusinessException(ErrorTypes.ValidationFault, ErrorCodes.InvalidUserId);
        }

        [Route("api/deliveryitems/{anyString}")]
        [HttpGet, HttpPost]
        public void GetDeliveryItemsOne(string anyString)
        {
            throw new BusinessException(ErrorTypes.ValidationFault, ErrorCodes.InvalidUserId);
        }

    }
}
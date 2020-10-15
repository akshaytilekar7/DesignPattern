using ExceptionHandling.ExceptionHelper;
using ExceptionHandling.ExceptionHelper.Enums;
using ExceptionHandling.Services;
using System.Web.Mvc;

namespace ExceptionHandling.Controllers
{
    [ExceptionHandling]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            UserServices userServices = new UserServices();
            //userServices.AddUser(null);
            throw new BusinessException(ErrorTypes.ValidationFault, ErrorCodes.InvalidUserId);
            return View();
        }

        /*
         - once we send BusinessException (461) or UnhandledException (460)
         in client side we have wrapper on Ajax call like :

                        $.ajax(url, options).done(function () {
                            dfd.resolve.apply(this, arguments);
                        }).fail(function (jqXHR2, textStatus2, errorThrown2) {
                            test();
                        }

        test()
        {
         if (ajaxErrorHelper.isBusinessException(jqXhr)) // 461
                        this.notifyErrorInContainer(getErrorMessage(jqXhr, message));
        else if (ajaxErrorHelper.isForbidden(jqXhr)) { //403
                        this.showErrorDialog(translate('FlowHtml.Translations.Forbidden'), getErrorMessage(jqXhr, message), showCorrelationOnly);
        
        // generic
        this.showErrorDialog(getErrorTitleGeneric(jqXhr, title), getErrorMessage(jqXhr, message), showCorrelationOnly);
        }
         
         */
    }
}

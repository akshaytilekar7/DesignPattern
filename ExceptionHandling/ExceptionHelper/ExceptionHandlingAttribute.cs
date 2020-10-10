using ExceptionHandling.ExceptionHelper.Enums;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace ExceptionHandling.ExceptionHelper
{
    public class ExceptionHandlingAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            var businessError = actionExecutedContext.Exception as BusinessException;
            var unhandledError = actionExecutedContext.Exception as UnhandledException;

            if (businessError != null)
                HandleBusinessError(actionExecutedContext, businessError);
            else if (unhandledError != null)
                HandleUnexpectedError(actionExecutedContext, unhandledError);
            else
                HandleUnexpectedError(actionExecutedContext);
        }

        private void HandleBusinessError(HttpActionExecutedContext actionExecutedContext, BusinessException businessError)
        {
            // 461
            var errorKey = $"{businessError.ErrorCode.ToString()}";
            var errorMessage = errorKey + " Error occured at : " + DateTime.Now; // GET TRANSLATION FOR ERROR CODE
            var response = actionExecutedContext.Request.CreateResponse((HttpStatusCode)HTTPStatusCode.BusinessException, new
            {
                ExceptionMessage = errorMessage
            });

            actionExecutedContext.Response = response;
        }

        private static void HandleUnexpectedError(HttpActionExecutedContext actionExecutedContext, UnhandledException unhandledError = null)
        {
            // 460
            var message = "An unexpected error has occurred while servicing your request. Please contact the Service Administrator.";
            var commonError = unhandledError ?? actionExecutedContext.Exception;

            if (commonError != null)
            {
                var correlationId = ""; // ADD LOG AND GET ID
                message = message + " Id: " + correlationId;
            }

            var response = actionExecutedContext.Request.CreateResponse((HttpStatusCode)HTTPStatusCode.UnhandledException, new
            {
                ExceptionMessage = message,
                Title = ""
            });

            actionExecutedContext.Response = response;
        }

        public Task ExecuteExceptionFilterAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
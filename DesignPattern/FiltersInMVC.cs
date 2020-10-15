/*
 
    -   adds extra logic to be implemented into the request being processed

       IAuthorizationFilter.OnAuthorization

       IActionFilter.OnActionExecuted
       IActionFilter.OnActionExecuting

       IResultFilter.OnResultExecuted
       IResultFilter.OnResultExecuting

       IExceptionFilter.OnException
 
       ________________________________

    -   HTTPHandler and HTTPModule in ASP.NET

        -    HTTPHandlers [The Extension Based Preprocessor]
            : Inject pre-processing logic based on the extension of the file name requested

        -    HTTPModule [The Event Based Preprocessor]
            : can add own functionality working along with the default ASP.NET functionality

        -   MIME stands for Multipurpose Internet Mail Extensions. 
            It's a way of identifying files on the Internet according to their nature and format.

 */
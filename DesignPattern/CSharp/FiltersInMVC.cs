/*
    - web api and mvc controller difference 
    ans -   
        - Web API controllers do not return views, they return data.
        - ApiController action only return data that is serialized and sent to the client
        - Use Controller to render your normal views. 
 
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



        Func -	takes one/more input parameters and 
		    returns one out parameter
		
        Action - takes one/more input parameters and
		    returns nothing.		
		
 */


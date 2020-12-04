/*
 

    Authentication in Web API

    1] Forms Authentication
        - ticket base mechanism. (traditional approach)
        -  working : ticket gets created to authenticate logged in user and stored in cookies  
           and this ticket is used for all subsequent request to make sure the user is authentic
           - [Authorize(Roles = "StoreManager")]
           - [AllowAnonymous]

           Global Authorization Filter
                -   apply Authorize filter on every Web API controller
                -   config.Filters.Add(new AuthorizeAttribute);
        
        
    
    2] How to Enable HTTPS for ASP.Net Web API?
        - Using 

        public class HTTPSAttribute:AuthorizationFilterAttribute
        {
            public override void OnAuthorization(HttpActionContext actionContext)
            {
                if(actionContext.Request.RequestUri.Scheme != Uri.UriSchemeHttps)
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Found);
                    actionContext.Response.Content = new StringContent("<p>Use HTTPS only</p>");
                }
                base.OnAuthorization(actionContext);
            }
        }

        - use [HTTPSAttribute]  on your controller

    - https://www.sharepointcafe.net/2018/10/web-api2-crud-operations-using-entity-framework-and-mvc.html

 *  */

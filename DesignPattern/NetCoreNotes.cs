/*
ConfigureServices 
    -   send to configure the services that are used by the application
    -   add the services to the DI container

Configure 
    -   application will respond to each HTTP request
    -   IApplicationBuilder and optional - IHostingEnvironment ILoggerFactory
    -   configure built-in middleware such as routing, authentication, session, etc. as well as third-party middleware.

middleware 
    -   can perform some action before calling api method

    1.  services.AddSingleton<IHelloWorldService, HelloWorldService>();
        - Single instance of the service through the application life

    2.  services.AddTransient<IHelloWorldService, HelloWorldService>(); [every time]
        - instance of the service every time to the application when we ask for it

    3.  services.AddScoped<IHelloWorldService, HelloWorldService>();
        - instance of the service per request to the application.
        - use same instance within a scope of given HTTP req and new for across diff HTTP req

JWT token contains 
    - Header [contains the algorithms like RSA or HMACSHA256 and the information of the type of Token.]
    - Payload [user credentials and claims (Claims are user details or additional information)]
    - Signature [Combine base64 encoded Header , base64 encoded Payload with secret]

    COMBINATION OF ALL HEADERS, PAYLOAD AND SIGNATURES CONVERTS INTO JWT TOKEN. 

    payload types :
        1.  Registered
        2.  Public 
        3.  Private claims.

FLOW 
    -    The user enters the login credentials on the web application.
    -    The web application send the login credentials to JWT issuer and ask for a JWT claim.
    -    JWT issuer validates login credentials with user database.
    -    JWT issuers creates JWT based on claims and roles from user database and add the 'exp' (Expires) claim for limited lifetime (30 minutes).
    -    JWT issuer sends the JWT to web application.
    -    Web application receives JWT and stores it in an authentication cookie.
    -    Web application verifies JWT and parses payload for authentication and  authorization.
    -    Web application adds JWT to REST service calls.

   */

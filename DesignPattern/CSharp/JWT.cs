/*
https://medium.com/@evandro.ggomes/json-web-token-authentication-with-asp-net-core-2-0-b074b0cfc870

    JWT 
        -   json web token 
        -   server can generate, and can contain a payload of data.
        -   tokens are sent in headers of HTTP requests to access protected API endpoints

        1. Header
            -   contains alg and typ
        2. Payload [user credentials and claims (Claims are user details or additional information)]
            - Claims 
                -   contains user data needed for client applications 
                -   aud :   (audience) application that is requesting a token
                -   iss :   token issuer, ie, the application that is emitting the token
                -   exp :   expiration date;
                -   nbf :   token expiration date must be greater than or equal the specified date to be valid
        3. Signature
                -   composed of the header data, payload, a secret key and cryptography algorithm.
                -   If hacker gets the token and changes any data, the token will become invalid, 
                    since the signature will not match the expected one for the token.
        Access tokens
                -   sent in HTTP requests headers. contains claims  and client data
                -   
        refresh token
                -   allows the client application to request a new access token when a valid one expire

        work
            -    add nuget System.IdentityModel.Tokens.Jwt
       
__________________________________
JWT token contains 

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

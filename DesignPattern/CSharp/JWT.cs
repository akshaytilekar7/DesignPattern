/*
https://medium.com/@evandro.ggomes/json-web-token-authentication-with-asp-net-core-2-0-b074b0cfc870

    JWT 
        -   json web token 
        -   server can generate, and can contain a payload of data.
        -   tokens are sent in headers of HTTP requests to access protected API endpoints

        1. Header
            -   contains alg and typ
        2. Payload
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
            -   

 */

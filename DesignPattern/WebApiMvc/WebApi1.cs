/*
 https://medium.com/free-code-camp/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28

A] Service Oriented Architecture (SOA)
    - 2 or more component communicates with each other over a network through a defined protocol.

    Web Service?
        -   way to communicate between 2 machines via HTTP, 
            those 2 machines can be on a different platform.

    SOAP
        -   heavier than REST web service
        -   XML based web service (limitations)
        -   XML data require parsing to read, so it is slow and consumes more bandwidth.

    REST [not a protocol its an architectural style]
        -   architectural style to build and loosely couple 2 or more systems
        -   HTTP protocol using its verbs GET, POST, PUT and DELETE.
        -   All requests are mapped to actions using HTTP verbs.    
        -   HTML, XML, JSON, Plain Text format.
        -   REST IS A STYLE, SO IT CAN USE ANY PROTOCOL LIKE HTTP, SOAP.
        -   REST is stateless, cache able.
        -   Stateless 
            -   A fundamental principle of REST architecture is Stateless. 
            -   The Server does not store any state or information about the client. 
            -   It means every request is treated as unique and fresh.

        -   fast and less bandwidth
        -   RESTFUL WEB SERVICE CAN ALSO USE SOAP BECAUSE 
                SOAP IS A PROTOCOL AND REST IS AN ARCHITECTURAL STYLE.

        -   Supports XML, plain text, JSON as data exchange format.
        
        -   SOAP is an XML based protocol whereas REST is not a protocol, 
                but it is a resource-based architecture.
        -   SOAP has specifications for both stateless and state-full implementation, whereas REST is completely stateless.

    Q. Can SOAP be RESTful? NO
        -   SOAP is a protocol so it can NOT use REST, 
            whereas REST is a style and can use any protocol HTTP, SOAP etc.

    -   REST is an architectural style VS SOAP is an XML based protocol

    Advantage web API
        -   Filters
            OData
            Routing
            Model Binding
            Easy with MVC

    - Routing
        -  Convention based routing
        -  Attribute based routing 

    -   CORS issue in Web API? (Cross-Origin Resource Sharing)
        -   CORS resolve the SAME-ORIGIN RESTRICTION for JavaScript
        -   The same origin means that a JavaScript can only make AJAX call to the web pages within the same origin
        -   To enable CORS in Web API you must install CORS nuget package using Package Manager Console.
            -   in WebApiConfig.cs add : config.EnableCors();
            -   [EnableCors(origins: "<origin url>", headers: "*", methods: "*")] in controller

    -   How to make sure that Web API returns data in JSON format only?
        -   In WebApiConfig.cs" 
            : config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/json"))

    -   How to host Web API
            -   Self Hosting
            -   IIS hosting
        
    -   content negotiation [return type for respose]
        -   server-side :   determine the media type formatter to
                            return the response to an incoming request.

    -   Media Type?
        -   called a MIME type, which identifies the format of a piece of data sends over HTTP protocol

    - camelCasing in web api - how conversion done ([C#] UserName => [JS] userName)
        - add in Application_Start or WebApiConfig.cs
            
        -   json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        -   we can also add our own Converter

    - Validating the Request Body Using the Model State
        -   This property is filled during request execution before reaching our action execution
        -   Its a instance of ModelStateDictionary, 
            a class that contains information about request is valid and validation error messages

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveCategoryResource resource)
        {
	        if (!ModelState.IsValid)
		        return BadRequest(ModelState.GetErrorMessages());
        }

    - 6 architectural constraints for true RESTful API.
            1.  Uniform interface
                -   interface between clients and servers  
                -   HTTP Verbs (GET,POST,PUT,DELETE)
                -   URIs (resource name)
                -   HTTP response (status and body)
            2.  Client–server 
                -   servers and clients may also be replaced and developed independently,
                -   client should know only resource URIs, and that’s all
            3.  Stateless
                -   server will not store anything about HTTP request
                -   each request from the client should contain info need to service the request : authentication and authorization
            4.  Cache-able
                -   implemented on the server or client-side.
            5.  Layered system
                -    deploy the APIs on server A, and store data on server B and authenticate requests in Server C,
            6.  Code on demand (optional)
                -   you are free to return executable code to support a part of your application, 
                    e.g., clients may call your API to get a UI widget rendering code
 */

/*
 https://medium.com/free-code-camp/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28

A] Service Oriented Architecture (SOA)
    - 2 or more component communicates with each other over a network through a defined protocol.


    Web Service?
        -   way to communicate between 2 machines via HTTP, those 2 machines can be on a different platform.

    SOAP
        -   heavier than REST web service
        -   XML based web service (limitations)
        -   XML data require parsing to read, so it is slow and consumes more bandwidth.

    REST 
        -   architectural style to build and loosely couple 2 or more systems
        -   HTML, XML, JSON, Plain Text format.
        -   REST is a style, so it can use any protocol like HTTP, SOAP.
        -   REST is stateless, cache able.
        -   Stateless 
            -   A fundamental principle of REST architecture is Stateless. 
            -   The Server does not store any state or information about the client. 
            -   It means every request is treated as unique and fresh.

        -   fast and less bandwidth
        -   RESTFUL WEB SERVICE CAN ALSO USE SOAP BECAUSE SOAP IS A PROTOCOL AND REST IS AN ARCHITECTURAL STYLE.
        -   Supports XML, plain text, JSON as data exchange format.
        
    Q. Can SOAP be RESTful? NO
        -   SOAP is a protocol so it can not use REST, whereas REST is a style and can use any protocol HTTP, SOAP etc.

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
        -   CORS resolve the same-origin restriction for JavaScript
        -   The same Origin means that a JavaScript can only make AJAX call to the web pages within the same origin
        -   To enable CORS in Web API you must install CORS nuget package using Package Manager Console.
            -   in WebApiConfig.cs add : config.EnableCors();
            -   [EnableCors(origins: "<origin url>", headers: "*", methods: "*")] in controller

    -   How to make sure that Web API returns data in JSON format only?
        -   In WebApiConfig.cs" : config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/json"))

    -   How to host Web API
            -   Self Hosting
            -   IIS hosting
        
    -   content negotiation 
        -   server-side : determine the media type formatter to return the response to an incoming request.

    -   Media Type?
        -   called a MIME type, which identifies the format of a piece of data sends over HTTP protocol

    - camelCasing in web api - how conversion done ([C#] UserName => [JS] userName)
        - add in Application_Start or WebApiConfig.cs
            
        -   json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        -   we can also add our own Converter

    - Validating the Request Body Using the Model State
        -   This property is filled during request execution before reaching our action execution
        -   Its a instance of ModelStateDictionary, a class that contains infor about request is valid and validation error messages
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveCategoryResource resource)
        {
	        if (!ModelState.IsValid)
		        return BadRequest(ModelState.GetErrorMessages());
        }



 */

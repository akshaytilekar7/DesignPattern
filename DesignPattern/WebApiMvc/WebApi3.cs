/*
 
FromBody and FromUri

    default convention for binding parameter
        -   for simple primitive data : look in uri (route data or query string)
        -   complex data look in request body

    to change default conventions we use : fromBody and FromUri

Version-ing web api

    -   different client are using same application
    -   service need to change without breaking existing clients and 
        at same time satisfied new client also
    -   attribute or convention routing
    -   URI
    -   QueryString
    -   Version Header
    -   Accept Header
    -   Media type

    A]
        create 2 entity ex : studentV1 and StudentV2
        create 2 controller : StudentV1Controller and StudentV2Controller
        and user attribute or convention routing for version-ing
*/

/*
        C   Post
        R   Get
        U   Put
        D   Delete

why we need HTTP methods
    -   uniform naming conventions
    -   server side developer are responsible to use proper HTTP verbs


    put     -   new / update
    patch   -   how update

    post    -   new / never update
    delete  -   remove
    get     -   read / search


    idempotent  -   same behaviour for each request
                -   req and res url same    

    post and put
        -   post - non idempotent 
        -   put -   idempotent - if id is sent by client and if it is exist update ow create

    patch
        -   customize update ow throw an exception.


controller method overloading in MVC
    -   action method are invoke via url ir http protocol
    -   u cant have duplicate url
    -   solve by : [ActionName("otherName")]


*/
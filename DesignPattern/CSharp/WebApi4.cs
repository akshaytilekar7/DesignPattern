/*
 
FromBody and FromUri

    default convention for binding parameter
        -   simple primitive look in uri (route data or query string)
        -   complex data look in request body


    to change drfault conventions we use : fromBody and FromUri

Versioning web api

    -   diifrent client are using same application
    -   service need to change wothout breaking existing clients and at same time satisfied new client also
    -   attribute or convention routing
    -   URI
    -   QueryString
    -   Version Header
    -   Accept Header
    -   Media type

    A]
        create 2 entiry ex : studentV1 and StudentV2
        create 2 controller : StudentV1Controller and StudentV2Controller
        and user attribute or convention routing for versioning

        C   Post
        R   Get
        U   Put
        D   Delete




*/

/*

why we need HTTP methods
    -   uniform naming conventions
    -   server side developer are respocisibe to use proper HTTP verbs


    post    -   new / never update
    get     -   read / search
    put     -   new / update
    delete  -   remove
    patch   -   how update


    idempotent  -   same beaviour for each request
                -   req and res url same    

    post and put
        -   post - nonidempotent - 
        -   put -   idempotent - if id is sent by client then : exist update ow create

    patch
        -   customize update 
        -

*/ 
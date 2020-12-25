/*
Services 

    -   MS needs communication between each other
        so we need API and some protocol

    2 ways
        -   RPC - remote procedure invocation
            -   simple
            -   request/reply
            -   sync / async
            -   REST / SOAP / gRPC
        -   message / event 
            -   MS exchange event/message via channel or broker 
            -   for interaction MS1 publishes 1 EVENT and needed MS2 subscribe for such messages
            -   loosely couple
            -   RabbitMq

        -   Protocol exchange format
            -   text    :   xml / json / yaml (easy and readable)
            -   binary  :   gRPC (more compact)


        -   API and contracts 
                -   exposed by each MS
        -   what are MS
            -   scope of functionality
            -   identify sub domain 
            -   independently deploy our component means sub domain
            -   


*/

/*
    DISTRIBUTED SYSTEM
        -   each sub domain deploy as separate service
        -   NW address is dynamic they changes for each sub domain services frequently
            -   so we need a SERVICE REGISTRY like a phone book where logical names and number are there like INDEX page
        -   service will interact with other service : we need CORS support 
            -   we need to additional http headers to give permission from server from diff ORIGIN

        -   Service can be not available (coz of heavy load and other stuff)
            -   will stop our app as order will call purchase service which is down, so eventuality wholw app will down
            -   to avoid this use CIRCUIT BREAKER
                -   invoke call via proxy (Deviate call)
                -   after some count it will stop calling API
                    but any how it will reintroduced traffic


    Gateway  
        -   single gateway to access all MS like User + order + product
        -   single entry point
        -   unified interface 
    
    Security
        -   
{
  
}
*/
/*

Types of communication
    -   synchronous
        -   Request and response
        -   not related to async await
            -   we cant proceed further until we get response from call
        -   REST
        -   gRPC (higher speed)
            -   can provide streams of data
            -   .proto file
                -   contract-
                -   client n server code is auto generated
                -   define messages and services
        -   signalR
        -   TCP (fast)

        -   Disadvantages
            -   tight coupling
            -   one to many (publish event is harder)
            -   changes are hard
            -   error track is difficult in case if MS1 calls MS2 calls MS3 
            -   long chain of synchronous call (MS1 calls MS2 calls MS3) takes long time


    -   asynchronous
        -   




*/ 
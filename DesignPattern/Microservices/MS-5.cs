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
        -   sync call - contain request response where sender is waiting
        -   async call 
                    -   fact that we have broker 
                    -   messages sent from Micro services 
                    -   broker is facilitator for this
                    -   no wait for response 

        MS1     MS2     MS3

              broker

        MS4     MS5     MS6

        Communication Options :
            A]   POINT TO POINTS
                -   single receiver for the message that going through the pipe 
                -   and that message will proceeds only once
                -   flexible + scalable 
                -   Harder to "what going on" + need good log 


              initial   -         Shopping basket MS          --- [Queue]       --- Order MS
              step1 Get call  -   Shopping basket MS  -> msg  --- [Queue]       --- Order MS
              step2 Get call  -   Shopping basket MS  ->      --- [Queue(msg)]  --- Order MS
              step3 Get call  -   Shopping basket MS  ->      --- [Queue]       --- (msg)Order MS



            B]   PUBLISH SUBSCRIBER
                    -   AZURE service BUS
                    -   RABBIT MQ
                    -   NService BUS


              initial   -         Shopping basket MS          --- [Queue]       --- Shopping Basket 
                                                                                --- Order MS

              step1 Get call  -   Shopping basket MS  -> msg  --- [Queue]       --- Shopping Basket  
                                                                                --- Order MS

              step2 Get call  -   Shopping basket MS  ->      --- [Queue(msg)]   --- Shopping Basket
                                                                                 --- Order MS


              step3 Get call  -   Shopping basket MS  ->      --- [Queue]       --- (msg)Shopping Basket 
                                                                                --- (msg)Order MS

                                                                    
            -   each copy of msg goes to subscribe MS
            -   Ex : in event catalog price get updates then we have to inform other MS, so broadcast this update

            -   message is similar to request for another service
            -   event is just small notification - ex price update

            AZURE service BUS - messaging sys + cloud based + async + Dead lettering + scalable
                -   Queue - OneToOne
                -   Topics 
                    -   send message from MS will relay on TOPIC
                    -   to a TOPIC multiple subscriber can register
                    -   each receiving subscription to topics
                    -   copy of message arrive in each subscription
                    -   well - mini queue for each subscriber
                    -   when 1st subscriber has finish processing message and delete message of its own subscription
                    -   it does this only for its own copy
                    -   other subscriber has their own copy

                -   Subscriber 
            RABBIT MQ   
            NService BUS

*/ 
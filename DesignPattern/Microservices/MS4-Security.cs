/*

    security (IAM)
        -   auth is delegated to one service named as "Identity and Access management" 
        -   canT call gateway  
        -   access token exchange between services or cookies

    scalability and availability 
        -   VERTICAL 
            -   add more power to existing machines. increase CPU speed

        -   HORIZONTAL
            -   add more machine 
            -   ex : product MS get replicated into different machines


    Load balancing 
        -   when we have multiple instance of same service, lets say product
            then which instance should be used?

        -   remember we have service registry 
            so all instances are there in registry

        -   load balancer will choose our instance by algo : round robin , weight capacity

    Availability  (means operational at given time)
        -   Scaling up services (ex : when christmas arrives then we have heavy load)
        
    Single point of failure 
        -   Gateway
        -   Broker
        -   Registry
        -   IAM

        what happen when above services will down : it will leads to all App down
        so all SPOF should scaled HORIZONTAL 

    Monitoring
        -   dashboard
            -   health checks
        -   Logs
        -   Exception
        -   Metrics
            -   statistics which service has heavy load 
        -   Auditing (behaviour of users)
            -   login / logout
            -   visited pages
            -   browser products
            -   record user activity

        -   Rate limit
            -   3d party access 
            -   control API usage
            -   defend denial of services (DOS) 
            -   api call limit within specific period of time
    
    Deployment
        -   SEE AGAIN ??????



*/ 
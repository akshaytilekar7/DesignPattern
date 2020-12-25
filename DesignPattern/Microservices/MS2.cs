/*

    domain  -   e commerce app
    sub domain
        -   User
        -   Order
        -   Payment
    
    but now we have a dependency : we need User and Payment object in Order sub-domain
        sol -  duplicate entity
    and we have separate DB for each sub domain 

    Teams per sub domain 
        git
        sub version

    we have separate DB for each sub domain 
        one require heavy transaction
        other require read only
    
    - DATA SYNCHRONIZATION problem
        -   if email is changed in User sub domain has to reflected in Order sub domain
        -   so we need event based technique : Akka, Kafka, rabbitMq

    - develop works in ISOLATION 

*/
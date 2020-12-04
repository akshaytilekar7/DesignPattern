/*
 
If the Client sends data without any identifier 
    using the POST method then we will store it and assign a new identifier.

If the Client again sends the same data without any identifier using the POST method, then we will store it and assign a new identifier.
Note: Duplication is allowed here
PUT

If the Client Sends data with an identifier then we 
    will check whether that identifier exists. 
If the identifier exists we will update data else we will create 
    it and assign a new identifier.

PATCH
    If the Client Sends data with an identifier then we will check whether 
    that identifier exists. If the identifier exists we will update data else we will throw an exception.

POST 
    is always for creating a resource ( does not matter if it was duplicated )
PUT 
    is for checking if resource is exists then update , else create new resource
PATCH 
    is always for update a resource


*/
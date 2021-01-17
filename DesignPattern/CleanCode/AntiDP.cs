/*

singleton DP -
    -   use addSingleton
    -   not following SRP

 avoid throw ex ;
 use throw

 avoid catch (Exception x)
 use catch (IOException)

 if (i==3)
       return true;
else
       return false;

should be:
       return (i==3);

async void Method()
{
  // lack of call stack
  // caller have no control over result of async operation
}


.GetResult()
.Result()
.Wait()
it will run code synchronously bad practice
it will block the UI

*/



/*
 
Cross site scripting (XSS) - XSS is a vulnerability that allows an attacker 
                            to inject client-side scripts into a webpage in order 
                            to access important information directly,

    
SQL injection (SQi) - 
                        SQi is a method by which an attacker exploits vulnerabilities
                        in the way a database executes search queries.

                       Implement HTTPS and redirect all 
                       cross-site scripting attacks by implementing the x-xss-protection
                       use strong passwords that employ a combination of lowercase and uppercase letters


*/
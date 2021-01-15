/*

ASync Await

    If the async keyword is present in the method signature, 
    the compiler knows to interpret await as a C# keyword. 

    Conversely, if the async keyword is not present the compiler allows you to 
    name variables await if you so choose.

    -   Task with ContinueWith, exceptions thrown will not escape the task; 
    -   instead inspect properties of the Task when it completes, including the InnerExceptions property 
        of the AggregateException that the completed Task 
    -   await a method, you can use try/catch
    -   increased responsiveness but expense of increased complexity, higher memory usage
        and longer overall execution time.
    -   and state machine it uses adds a decent amount of overhead
    -   await keyword that does all the heavy lifting.
    -   async keyword is actually just a way to eliminate ambiguity for the compiler with regard to await.

    -   await KEYWORD DOES NOT BLOCK THE CURRENT THREAD

    -   blocks  execution of the current thread : 
        [ current thread is completely occupied during the following code.]

        -   System.Threading.Thread.Sleep(1000);

        -   var httpClient = new HttpClient();
            var myTask = httpClient.GetStringAsync("https://...");
            var myString = myTask.GetAwaiter().GetResult();     

            note : GetAwaiter().GetResult() BLOCKING CALL
                 : task.Result  BLOCKING CALL
                 : myTask.Wait(); BLOCKING CALL

    AWAIT FROM THE USER'S PERSPECTIVE
        -   await keyword, by contrast, IS NON-BLOCKING, 
            which means the CURRENT THREAD IS FREE TO DO OTHER things during the wait. 

        -   await frees the thread up to do other things means
            that it can remain responsive to additional user actions and input. 

    AWAIT FROM THE PERSPECTIVE OF THE CALLING METHOD
        -   



*/ 
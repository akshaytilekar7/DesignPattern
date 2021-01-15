/*
 
Task.Run 
    The Run method queues code to run on a different thread 

    async void OnButtonClick()
    {
        await Task.Run(() => // your code here // accept Action);
    }

    -   The current thread is released and the 
        code passed in is executed on a thread from the thread pool

     When execution is complete, in which thread does the rest of the calling method execute?
     ans
        -   await captures the current SynchronizationContext
            which includes information about the current thread
            and by default automatically returns to that thread when finished.

 */

/*

normal controller
    thread starvation
        -   lets say IIS has thread pool and it has 3 threads
        -   each thread is take req and prcoess it
        -   lets say 5 request come than 2 thread has to wait because no thread is free
        -   so use asyn controller   

async controller [avoid thread stravation]
    -   improve efficiency of thread pooling
    -   best way to serve multiple request
    -   improve performance
    -   here lets say one request come thread A assign to it and then this 
        thread immediatly come to thread pool as request is stll getting data from DB
    -   so in meantime again 1 thread come and same thread can procees the request
    -   any thread can handle any request and responce
    -   same thread can handle many req and respoce
    -   503 server busy
    -   <system.web> <processModel maxWorkerThread="2" maxIoThread="2">
    -   
 
*/


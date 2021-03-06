﻿/*
 
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
        -   each thread is take req and process it
        -   lets say 5 request come than 2 thread has to wait because no thread is free
        -   so use async controller   

async controller [avoid thread starvation]
    -   improve efficiency of thread pooling
    -   best way to serve multiple request
    -   improve performance
    -   here lets say one request come thread A assign to it and then this 
        thread immediately come to thread pool as request is still getting data from DB
    -   so in meantime again 1 thread come and same thread can process the request
    -   any thread can handle any request and response
    -   same thread can handle many req and response
    -   503 server busy
    -   <system.web> <processModel maxWorkerThread="2" maxIoThread="2">
    -   
 
*/

/*

Thread is used for creating thread in Windows.
Task represents some asynchronous operation and is part of the TPL, which has APIs for running tasks asynchronously and in parallel.

 There is no direct mechanism to return the result from a thread.
The task can return a result.

Task supports cancellation through the use of cancellation tokens. 

Threads can only have one task running at a time.
A task can have multiple processes happening at the same time. 

We can easily implement Asynchronous using ’async’ and ‘await’ keywords.
A new Thread()is not dealing with Thread pool thread, whereas Task does use thread pool thread.

A Task is a higher level concept than Thread.

_________

 Task is a future or a promise.
 Thread is a way of fulfilling that promise. 
    but not every Task needs a brand-new Thread

    If the value you are waiting for comes from the DB, 
    then there is no need for a thread to sit around and wait for the data
    when it can be servicing other requests. 
    Instead, the Task might register a callback to receive the value(s) when they're ready.

*/ 
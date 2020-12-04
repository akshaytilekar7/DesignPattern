/*
https://medium.com/@luukgruijs/understanding-creating-and-subscribing-to-observables-in-angular-426dbf0b04a3


Observables 
    -   observables are lazy collections of multiple values over time.
	-	listening to live stream, when you get data after some time 
    - 	async stream of data, which we want to hear and act upon it, used for Http Call
    -   provide support for passing messages between publishers and subscribers in app.
    -   Observables are declarative : you define a function for publishing values,
        but it is not executed until a consumer subscribes to it. 
    -   The subscribed consumer then receives notifications until the function 
        completes, or until they unsubscribe.
    -   Observables help you manage asynchronous data, such as data coming from a backend service. 
        To use observables, Angular uses a third-party library called Reactive Extensions (RxJS)
    -   service methods an observable we have to subscribe to it

Http and Observables
    we create services. 
    Service will call or make the Http request from Http Module.
    This HTTP request will hit the web API and return HTTP response. 
    This response that we are getting from the HTTP is nothing but the observable. 

    Now the observable needs to be cast to the particular type 
    and the Service will cast this observable data and return it to the subscribed component
    xomponents subscribe to the service and receive and operated the data accordingly.
    Reponse from server comes in form of observables.

    Make a request from Service.
    Get the observable and cast it.
    Subscribe the observable to the components.
    Store it to the local variables to make it useful in your component.


 Promise Vs Observables:- 
     as soon as a promise is made (egar), the execution takes place.
     whereas observables are lazy. means nothing happens until a subscription is made. 

     promises handle a single event wheras observable is a stream that allows passing of 1/more event.
     a callback is made for each event in an observable.

     promises always return only one value whearas observable returns multiple
     promise are not cancelable whereas observables are cancelable


2.  Template Reference Variable (syntax : #var)
     is a reference to a DOM element within a template. 

     <input #name placeholder="Your name">
     {{name.value}}
    Here the name refers to the input DOM element. 
    access any property of the inputDOM

3.  Pipes (pure(by default) and impure)
    impure-pipe works for every change in the component.
    An impure pipe is called for every change detection cycle no matter whether the value or parameters changes.

    pure-pipe works only when the component is loaded.
    a pure pipe is only called when angular detects a change in the value or the parameters passed to a pipe.
    
    @Pipe({
    name: 'sort',
    pure: false // true makes it pure and false makes it impure
    })

    custom pipe add in declaration array
        import {Pipe, PipeTransform} from '@angular/core';  
        @Pipe ({  
          name : 'sqrt'  
        })  
        export class SqrtPipe implements PipeTransform {  
          transform(val : number) : number {  
            return Math.sqrt(val);  
          }  
        }
        
        - use {{ 625 | sqrt}}

*/
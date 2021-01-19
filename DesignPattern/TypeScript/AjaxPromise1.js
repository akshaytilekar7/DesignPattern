/*
promise 
    -   is a future value
    3 states
        1.  fulfilled (resolve)
        2.  rejected (reject)
        3.  pending
    -   resolve only once, if set again wont affect anything
    -   eagar to run
    -   in call back they have a full control over our func()
        but in promise they gives us control/event listner
 
*/

let promiseToCleanRoom = new Promise(function (resolve, reject) {

    let isClean = true;
    if (isClean) {
        resolve('Clean');
    } else {
        reject('not Clean');
    }
});

promiseToCleanRoom
    .then(function (result) {
        console.log('then ' + result);
    })
    .catch(function () {
        console.log('catch ' + result);
    });

// "then" function will trigger only if the Promise gets resolved.
// "catch" function will only trigger only if the Promise gets rejected.
// "result" variable value : return value inside of resolve() / reject()

////////////////////

let cleanRoom = function () {
    return new Promise(function (resolve, reject) {
        resolve('I Clean the room');
    });
}

let removeGarbage = function (message) {
    return new Promise(function (resolve, reject) {
        resolve(message + ' , I threw away trash');
    });
}

let withIceCream = function (message) {
    return new Promise(function (resolve, reject) {
        resolve(message + ' , now I should get ice cream');
    });
}

cleanRoom().then(function (result) {  // I Clean the room
    return removeGarbage(result);
}).then(function (result) { // I cleaned the room, I threw away the trash
    return withIceCream(result);
}).then(function (result) { // I cleaned the room, I threw away the trash, so I got to eat some ice cream
    console.log(result + " so now I can sleep.");
});

//I cleaned the room, I threw away the trash, so I got to eat some ice cream so now I can sleep.

// Promise of cleanRoom returns a resolved message of "I cleaned the room"

//Promise.all & Promise.race

//all
Promise.all([mowLawn(), vacuumLivingRoom(), scrubBathtub()]).then(function () { console.log('all finished') });

//race : notify when first one is done
Promise.race([mowLawn(), vacuumLivingRoom(), scrubBathtub()]).then(function () { console.log('all finished') });


/*

deferred object
    -   object that can create a promise and change its state to resolved or rejected
    -   used if you write your own function and want to provide a promise to the calling code
    -   You are the PRODUCER of the value

promise
    -   promise about future value, attach callbacks to it to get that value
    -   promise was "given" to you and you are the RECEIVER of the future value
    -   cannot modify the state of the promise

https://www.youtube.com/watch?v=PoRJizFvM7s

*/














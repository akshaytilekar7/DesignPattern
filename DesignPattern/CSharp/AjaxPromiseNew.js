//https://www.youtube.com/watch?v=ay_qbDuIHNk

// dfd = 
//   is a proxy object
//  which we can attached callback based on def is rejected or selected

$ajax({
    url: '',
    content: '',
    data: {},
    success: (x) => { console.log(x) },
    fail: (x) => { console.log(x) }
});

// refactored : 
//  achieve decouple
//  callback allowed to added incrementally
//  success = done
//  complete -> call after success or fail
//  then -> takes 2 args : success/done and fail

var dfd = $ajax({
    url: '',
    content: '',
    data: {}
});

dfd.success(function (x) {
    console.log(x);
});

dfd.fail(function (x) {
    console.log(x);
});

dfd.success(function (x) {
    console.log(x + 1);
});

dfd.fail(function (x) {
    console.log(x + 1);
});

dfd.complete(function (x) {
    console.log(x);
});

dfd.then(
    function (x) {
        // success / done
    }, function (x) {
        // fail
    }
);

// from jq 1.5 later instead of returning dfd it returns Promise


// DEFERRED

var apiCall = function () {
    var dfd = $.Deferred();

    let m = Math.random();
    if (Math.floor(m * 100) % 2 === 0) {
        dfd.resolve(m);
    } else {
        dfd.reject(m);
    }
    return dfd; /////////////IMP
};

var outerDeferred = $.apiCall();
outerDeferred.then(
    function (m) { console.log('even' + m) },
    function (m) { console.log('not a even') }
);
outerDeferred.then(
    function (m) { console.log('even' + m) },
    function (m) { console.log('not a even') }
);


// better version of apiCall # dfd.promise()
// promise is readonly version of dfd object
// above code has one problem
// we can call dfd.resolve() or dfd.reject() OUTSIDE block apiCall() 
// api function scope should only responsible for resolve/reject
// so by returning dfd.promise(), outside apiCall we cant mock with dfd means 
// we cant do dfd.resolve or dfd.promise


apiCall = function () {
    var dfd = $.Deferred();

    let m = Math.random();
    if (Math.floor(m * 100) % 2 === 0) {
        dfd.resolve(m);
    } else {
        dfd.reject(m);
    }
    return dfd.promise(); /////////////IMP
};

$.when(apiCall1, apiCall2).then(function () { }, function () { });









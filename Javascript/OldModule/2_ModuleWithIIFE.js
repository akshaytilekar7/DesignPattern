// Module definition using IIFE
var UserAction = (function (dataService) {
    let a = 10;
    let b = 20;

    function privatefun() {
        console.log("private");
    }

    function getUser(id) {
        return {
            name: "Akshay",
            address: dataService.addressService.getAddressByUserId(id),
        };
    }

    function saveUser(user, callback) {
        var isSaveUser = dataService.userService.saveUser(user);
        if (isSaveUser) callback();
        return isSaveUser;
    }

    return {
        getUser: getUser,
        saveUser: saveUser,
        a: a,
    };
})({
    addressService: {
        getAddressByUserId: (id) => `Address of user ${id}`,
    },
    userService: {
        saveUser: (user) => true,
    },
});


var obj1 = UserAction;
var obj2 = UserAction;
console.log(UserAction.getUser(1)); // { name: 'Akshay', address: 'Address of user 1' }
console.log(UserAction.a); // 10
console.log(UserAction.b); // undefined (private)
console.log(obj1 === obj2); // I guess should be true
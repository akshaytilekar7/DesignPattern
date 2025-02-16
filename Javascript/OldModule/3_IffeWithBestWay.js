var UserAction = (function () {
    let dataService = null; // Initially null
    let a = 10;
    let b = 20;

    function privatefun() {
        console.log("private");
    }

    function getUser(id) {
        if (!dataService) throw new Error("dataService is not initialized!");
        return {
            name: "Akshay",
            address: dataService.addressService.getAddressByUserId(id),
        };
    }

    function saveUser(user, callback) {
        if (!dataService) throw new Error("dataService is not initialized!");
        var isSaveUser = dataService.userService.saveUser(user);
        if (isSaveUser) callback();
        return isSaveUser;
    }

    // Act as Ctor
    function initialize(service) {
        if (!dataService) {
            dataService = service;
        } else {
            console.warn("dataService is already initialized, cannot reassign!");
        }
    }

    return {
        getUser: getUser,
        saveUser: saveUser,
        initialize: initialize, // Expose initialization
        a: a,
    };
})();


// Use
// Define the data service object
const myDataService = {
    addressService: {
        getAddressByUserId: (id) => `Address of user ${id}`,
    },
    userService: {
        saveUser: (user) => true,
    },
};

// Pass it to UserAction
UserAction.initialize(myDataService);

var obj1 = UserAction;
var obj2 = UserAction;
// Now, we can use UserAction
console.log(obj1.getUser(1)); // { name: 'Akshay', address: 'Address of user 1' }
console.log(obj2.a); // 10

// Trying to reinitialize (it won’t work)
obj1.initialize({}); // Warning: dataService is already initialized
obj2.initialize({}); // Warning: dataService is already initialized

console.log(obj1 == obj2); // true


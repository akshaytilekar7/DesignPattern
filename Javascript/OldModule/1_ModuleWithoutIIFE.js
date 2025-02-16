// Module definition
var UserAction = function (dataService) {
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
};

const dataService = {
  addressService: {
    getAddressByUserId: (id) => `Address of user ${id}`,
  },
  userService: {
    saveUser: (user) => true,
  },
};

const userAction1 = UserAction(dataService);
const userAction2 = UserAction(dataService); // New instance

console.log(userAction1.getUser(1)); // { name: 'Akshay', address: 'Address of user 1' }
console.log(userAction2.a); // 10
console.log(userAction1 === userAction2); // false (Different instances)
// EVERY TIME WE GET NEW INSTANCE
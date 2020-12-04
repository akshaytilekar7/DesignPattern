/*

Module Design Patterns
    -   used to wrap a set of variables and functions together in a single scope.
    -   achieve encapsulation   :   data hiding an abstraction using this pattern
                                :   principle of least exposure
    -   Maintainability and Re-usability

*/

function EmployeeDetails() {
    var name = "Ted";
    var age = 30;
    var designation = "Developer";
    var salary = 10000;  // not exposed so its become private 

    var calculateBonus = function (amount) {
        salary = salary + amount;
    }

    return {
        name: name,
        age: age,
        designation: designation,
        calculateBonus: calculateBonus
    }
}

var newEmployee = EmployeeDetails();
var userName = newEmployee.calculateBonus(1000);
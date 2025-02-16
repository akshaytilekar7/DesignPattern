// FUNCTIONS IN JS

/*
    Static Methods
        -   methods are defined on the class itself, not on the instance.
        -   Shared logic across all instances
        -   cant call by instance of method
    
    Method getter 
        -   methods to access a property + No parameter
        -   when invoke no parameter 
        -   Computed properties or achive encapsulation

    Method setter
        -   special methods to set a property value with only 1 para.
        -   set name(value) {}
        -   Called like assigning to a property, not invoking a method.
        -   invoke like you are assinging to variable nt a fucntion    
        -   validation state and ecpasulation
        -   multiple getters and setters
*/

    class Utility {
        static add(a, b) {
            return a + b;
        }
    }
    console.log(Utility.add(5, 10)); // 15


class Person {
    constructor(firstName, lastName, age) {
        this._firstName = firstName;
        this._lastName = lastName;
        this._age = age;
    }

    get fullName() {
        return `${this._firstName} ${this._lastName}`;
    }

    set fullName(value) {
        const [firstName, lastName] = value.split(' ');
        this._firstName = firstName;
        this._lastName = lastName;
    }

    get age() {
        return this._age;
    }

    set age(value) {
        if (value < 0) {
            throw new Error('Age must be a positive number.');
        }
        this._age = value;
    }
}

const person = new Person('John', 'Doe', 30);

console.log(person.fullName); // John Doe
console.log(person.age);      // 30

// Using setters
person.fullName = 'Jane Smith';
person.age = 28;

console.log(person.fullName); // Jane Smith
console.log(person.age);      // 28


// Inside an object
const aircraft = {
    altitude: 2000,
    changeAltitude: function (value) {
        this.altitude += value;
        console.log(this.altitude);
    },
};
aircraft.changeAltitude(100);

// Inside a class
class Aircraft {
    constructor(altitude) {
        this.altitude = altitude;
    }
    changeAltitude(value) {
        this.altitude += value;
        console.log(this.altitude);
    }
}
const a1 = new Aircraft(2000);
a1.changeAltitude(100);


// PAIR GET and SET
class Passenger {
    internalName = '';
    constructor(name) { this.name = name; }

    set name(value) {
        if (!value) throw new Error('name must have a value');
        if (value.length < 1) throw new Error('name has few characters');
        this.internalName = value;
    }

    get name() { return this.internalName; }
}
const john = new Passenger('John');
john.internalName = 'Dan'; // not a good practice



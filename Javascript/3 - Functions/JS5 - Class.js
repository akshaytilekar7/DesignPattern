// OOPS IN JS - private varibale and methods

class FlightPlan {
    #internalDepartureTime = null; // private class member

    constructor(callsign = '', departure = '', destination = '') {
        this.callsign = callsign;
        this.departure = departure;
        this.destination = destination;
    }

    print() {
        this.#printInternal();
    }

    // private class method
    #printInternal() { 
        let info = `Flight ${this.callsign} departs from ${this.departure} and lands at ${this.destination}`;
        console.log(info);
    }

    get departureTime() {
        return this.#internalDepartureTime.toLocaleString();
    }

    set departureTime(date) {
        if (!date) throw new Error('Date can not be null');
        if (date - Date.now() < 0) throw new Error('Date is in the past');
        this.#internalDepartureTime = date;
    }
}

const obj = new FlightPlan('AF123456', 'Berlin', 'Paris');
obj.print();
obj.departureTime = new Date(2024, 1, 1, 18, 00);
console.log(obj.departureTime);

obj.#internalDepartureTime = Date.now(); // cant modified Error in console
obj.#printInternal(); // cant call private method Error in console

export default class User {
    firstName = "";
    lastName = "";
    birthdate = new Date();
    phone = "";

    constructor(first, last) {
        this.firstName = first;
        this.lastName = last;
    }

    format() {
        return `${this.firstName}, ${this.lastName}`;
    }
}

export function getTeam() {
    return [
        new User("Yash", "Raj"),
        new User("Akshay", "Tilekar"),
        new User("Pragati", "Nanaware"),
    ];
}

export function sortTeam(theTeam) {
    theTeam.sort((a, b) => a.firstName.localeCompare(b.firstName));
}

export let team = [
    new User("Yash", "Raj"),
    new User("Akshay", "Tilekar"),
    new User("Pragati", "Nanaware"),
];

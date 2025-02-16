import defaultOne, { capitalize, favoriteColors } from "./utils.js";

console.log(`${defaultOne.appName} v${defaultOne.version}`);

console.log(capitalize("Hello World"));

favoriteColors.forEach((c) => console.log(c));

// defaultOne - name can be anything
//            - not enclosed in {}


// { capitalize, favoriteColors } -- name must be same as its in respecice file ie capitalize in both file

console.log("-----------------------------------");

// 
import User, { getTeam, sortTeam } from "./auth/index.js";
const user = new User("Pragati", "Nanaware");
console.log(user.format());

const footballTeam1 = getTeam();
console.log('\nas it is :');
footballTeam1.forEach(t => console.log(t.format()));

console.log('\nsorted : ');
sortTeam(footballTeam1);
footballTeam1.forEach(t => console.log(t.format()));

footballTeam1.length = 0;
console.log(`Team Length: ${footballTeam1.length}`);

import { getTeam as getTeam2 } from "./auth/index.js";
const footballTeam2 = getTeam2();
console.log('\n NOT be already sorted as differet copy as its function not object: ');
footballTeam2.forEach(t => console.log(t.format()));
console.log(`Team Length: ${footballTeam2.length}`);


console.log("-----------------------------------");


import { team } from "./auth/index.js";
console.log('\nas it is :');
team.forEach(t => console.log(t.format()));

console.log('\nsorted : ');
sortTeam(team);
team.forEach(t => console.log(t.format()));

console.log('\nSorted as its maintain single copy for object: ');
import { team as sameTeam } from "./auth/index.js";
sameTeam.forEach(t => console.log(t.format()));




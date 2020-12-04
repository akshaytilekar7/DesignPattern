/*
 
Input    :  pass data from parent to child component
Output   :  pass data from child to parent component

1. We create the variable in parent.ts file which we want to pass to child component

2. In, parent component.html file we write the selector name of child component. Inside it, we pass the variable
  <app-child  [pName]="name"></app-child>
  name:- Variable we define in the parent component
  pName:- Used as a refernce, so that it can be used in child component.It can by of any name
3. In child component.ts file, we define the same  variable i.e pName that we pass in <app-child attribute and decorate it
   with @Input decorator so that angular can differntiate it with normal variable.
4. Now, we can use this pName variable wherever we want.

Output:- when we want to pass data from child to parent component

1. We create the variable in child.ts file which we want to pass to parent component
2. We use eventemitter class here to emit the event which will be captured by parent.
3. We will decorate the variable with @Output().
4. This event should be decalred in parent.html and same name variable should be decalred in parent.html file
   <app-child (childEvent)="message=$event" ></app-child>
   message:- variable that should be declared in parent
   $event:- output that will be passed from child 
5. We can use message wherever we want to print it's value.

*/
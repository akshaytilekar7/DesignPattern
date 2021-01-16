/*

You are not done when it works, you are done when it's right.

clean code matters

readable well wriiten
author of code
peer able to understand code

adding double developer never increses productivty

developer will not train the new developer 
our existing code will train them

clean code means no surprises

method name never be noun 
method name should be verb

every line of function should be at same level of abstraction


when to clean code 
    -   right code and test it
    -   clean it and test it    -   cleaning will take same time as development need
    

clean code
    -   smaller function 
    -   ALLOW TO READER TO ESCAPE EARLY FROM FUNCTION

clean code rule
    1.  function should be small
    2.  smaller than that

    main
        -  function do only one thing
        -   more function seems to more messy but its not true
            we have to give good name, that's it!
        -   large function is actually a class with bunch of variable and methods
            you can identity by extracting
        -   indent level of function max 1 or 2
        -   avoid nested structure
        -   parameter max 3 and best 0
        -   never pass boolean to function, it means we have if statement
            when we call FunName(3,4, true); // what does true means    
        -   output 

    principle of least surprise

        -   avoid switch statement
            coz  when we add new type then you have to change all existing switch statement
            -   use Polymorphism
                so when we add new type then only we have to add that new type : no change in existing code
                -   means we are achieving Open Closed Principle   

    -   independently deploy BL and UI
        
    side effect
        -   if we call a function and that function causes the system to change a state
        -   side effect function comes in pair : new and delete
        -   system crash : dut to many people open a same file

        

*/
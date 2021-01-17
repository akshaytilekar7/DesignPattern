/*

You are not done when it works, you are done when it's right.

clean code matters

readable well written
author of code
peer able to understand code

adding double developer never increases productivity

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

       
    comment
        -   some comment are good
        -   comment can lie but code don't
        -   every comment will show that we are fail to express code
        -   no one maintain a comment it will rot after some days
        -   don't comment always clean it
        -   if ( person.Age > 18 && person.Age < 60 ) => if(IsAdult())
        -   comment for regular expression 

    pair program
        -   5 hrs to original code then review - 

    TDD 
        -   is a discipline 
        -   should not allowed to write any production code 
            -   not compile is test failing 
            -   reduce debugging time
            -   fail and then pass : nice feeling
            -   you cannot write a code that is ard to test if we follow TDD
                coz we are write test case 1st

*/
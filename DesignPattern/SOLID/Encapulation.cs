/*

    Encapsulation 
        -   implementation hiding not information 
        -   


*/


//Check Reverse

/*
 
    developer are Authors
    each line read 10+ times

    Robert C Martin uncle bob
    
    chapter     -   namespace
    heading     -   class
    paragraph   -   method


    clean code
        -   self documentation
        -   watch for boundaries mean : integration between CSS - HTML - JS and C# - DB
            -   html in js string and js in html
            -   dynamic js from C#
            -   writing code in specific file gives : Cached + color code + syntax checked + separation of concern + avoid string parsing
                + can minified
        -   selecting tool
        -   ONE language per FILE


        code should be TED - Terse (clear) + expressive + does one thing

        DRY - don't repeat yourself
            avoid duplication - create maintenance problem

        Naming conventions
            - foundation of design
            - good name to method/class gives flexibility : don't need to read code inside method
            - SaveAndSendEmail => write 2 method means no And Or If in method Name
            - avoid abbreviation - RegUser
            - boolean naming : isOpen instead of open
            - naming symmetrical : on/disable => on/off

        Writing Condition if else

            bool isOpen;
            if(time > 9){
                isOpen = true;
            } else{
                isOpen = false;            
            }

            => bool isOpen = time > 9


        - Brains always think faster in positive terms
            avoid : if(!isNotLoggedIn) {}

            AVOID -VE condition

        - FAVOR EXPRESSIVE CODE OVER COMMENT
        - FAVOR POLYMORPHISM OVER SWITCH



        Method (should have 0 2 parameter)
            -   avoid Flag argument in method it means ur function is doing 2 things - so create 2 methods
            -   extract
                fail fast
                return early

            fail fast :
                1.  throw exception should be on top of function like guard clause
                2.  switch should have default case : with exception so BUG will catch in early stage
                
            return early
                1.  return as early as possible 


        class
            -   should have related methods

                






            




        



*/ 
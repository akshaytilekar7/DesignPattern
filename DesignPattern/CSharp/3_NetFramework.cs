/*

MSIL
    -   partially compile or half compile code
    -   why half?

    source code -> MISL (half compile code) -> run on jit -> Machine
    half code ?
        during runtime JIT configure info of OS, hardware
        and it can compile optimal code as per environment
    
GC
    -   perform on heap memory
    -   if there is not enough memory for new object then GC will run
    -   gen 0 1 2
    -   Not remove object if
            1.  root object 
            2.  any reference for that object

    -   gen 0 : youngest generation
        if gen 0 has memory then GC directly allocates memory for new object
        if not then check for gen 1 [longest lifetime]

GC has 2 phases
    -   marking phase
        -   list of live objects
    -   reallocating phase
        -   its update the reference object
    -   compating phase
        -   clears the memory from heap


*/ 
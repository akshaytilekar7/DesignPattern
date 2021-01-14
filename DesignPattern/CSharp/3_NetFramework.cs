/*

MSIL
    -   partially compile or half compile code
    -   why half?

    source code -> MISL (half compile code) -> run on jit -> Machine
    half code ?
        during runtime JIT configure iut of OS, hardware
        and it can compile optimal code as per environment
    

GC
    -   perform on heap memory
    -   no memory for new object then GC will run
    -   gen 0 1 2
    -   GC doesn't remove application root object and if there is any reference for that object
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
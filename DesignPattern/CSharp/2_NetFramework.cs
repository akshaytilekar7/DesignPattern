/*
Managed and Unmanaged Code
    -   code EXECUTED by CLR is managed code ]
    -   unmanaged code executed by OS directly 
    -   only managed code has : runtime provide services like GC, exception and type checking
    -   binary unit that contains the managed code which is called assembly
    -   manage code compile to MSIL and then machine code
    -   un-manage code directly compile to machine code

    C# compiler produces IL as part of an assembly’s output

    -   Windows starts up the CLR and passes the application to 
        the CLR for execution. 
    -   THE CLR LOADS THE EXECUTABLE ASSEMBLY, FINDS THE ENTRY POINT, 
        AND BEGINS ITS EXECUTION PROCESS
    -   An assembly won’t be loaded until the CLR needs access to the assembly’s code
    -   CLR must translate the IL to binary code that the operating system understands.
        This is the responsibility of the JIT compiler.
    -   JIT compiler operates at the method level
    -   CLR begins execution, the JIT compiler compiles the entry point (the Main method in C#)


JIT [compile MSIL code to machine language] 
    -  .NET own decision to choose following
    -   per file
    -   per method
    -   code fragment

    Normal JIT Compilation [per method]
        -   on demand and stored in memory
        -   methods are compiled when called at runtime.
        -   After execution this method is stored in the memory and it is commonly referred as “jitted”
        -   No further compilation is required for the same method.
        -   Subsequent method calls are accessible directly from the memory cache.

    Econo JIT Compilation [per method]
        -   on demand and NOT stored in memory
        -   compiles methods when called at runtime
        -   removes them from memory after execution.
         
    Pre-JIT Compilation
        -   NOT stored in memory
        -   compiles entire assembly instead of used methods
        -   implemented in Ngen.exe (Native Image Generator)
*/ 
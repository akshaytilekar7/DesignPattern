/*

.NET
    environment that facilitates Object Oriented Programming Model for multiple languages
    2 component
        CLR (Common Language Runtime) 
        BCL (Base Class Libraries)


    CLR [.NET Framework provides a runtime environment]
            -   GC [manged unused resource]
        -   Code access security [access right and | safe | authenticated ]
        -   IL to machine language
        -   In initial execution of a method, the CLR carries out the verifications (Types are verified; 
            subscripts are verified to be in range; unsafe casts and un-initialized variables are prevented)
        -   During compilation, a source code of any .NET-compliant language 
            is converted to MSIL by the compiler, and then 
            the IL code is converted to native code using the just-in-time (JIT) compiler during the runtime.
        -   locate,load and manage .NET objects on your behalf
        -   CLR activates objects, 
            performs security checks on them,
            lays them out in memory,
            executes them, 
            and finally garbage-collects them.
        -   controls the executing the .NET code.
        -   after compile we get MSIL code (not executable)
        -   MSIL is a portable assembly language.
        -   MSIL is an OS and H/W independent
        -   CLR converts IL into native machine code using JIT compiler.
        -   program needs to be executed, this MSIL or intermediate code is converted
            to binary executable code, called native code
        -   MAIN TASK ->  to transform the intermediate MSIL code in the executable code at runtime.
        -   Any program, that is compiled into pseudocode MSIL [], 
            can be run in any environment, that contains the CLR realization. 
            This provides the programs portability in the .NET Framework environment.

    JIT
        -   CLR only compiles code just before it executes

    Type loading
        -   Finds and loads assemblies and types

    BCL
        -   user defined (Assembly) and predefine class library (namespace)
        -   subset of FCL
        -   dealing with string and primitive types, database connection, IO operations.
        -   definition of different primitives, threads, graphic API-interfaces, 
            databases, input/output and so on.

    Assemblies 
        -   small unit of deployment (dll or exe)
        -   dll [reusable and not contain main()] 
            exe [reusable and contain main()]
        -   primary unit of deployment for .Net application
        -   Assemblies are the files with the extension *.dll or *.exe, 
            which contain the instructions, that are independent of the .NET language, and metadata of types. 
            These instructions are realized on the intermediate language (IL).
        -   assembly is designed to save the namespaces. Namespaces contain types.
            The types may be classes, delegates, interfaces, enumerations, structures.
        -   assembly may comprise any number of namespaces. Any namespace may contain any number of types 
            (classes, interfaces, structures, enumerations, delegates).
        -   assembly contains CIL-code (MSIL-code or IL-code) and metadata. 
            CIL-code is compiled for a specific platform only when it is accessed from the .NET.

    
    Manifest of assembly contains:
        -   info about identity of assembly, including textual name & version no.
        -   description of the assembly itself with the help of metadata
        -   about the current version of the assembly;
            about a culture (strings localization, graphic resources);
            a list of references to all external assemblies that are necessary for the proper functioning.
        -   if the assembly is public then it will contain the assembly’s public key.
            It is used to ensure that type exposed by the assembly resides within a unique namespace.
        -   list of other assemblies that the assembly depends upon.
        -   list of all types and resources exposed by the assembly


    see SourceCodeTransformation.jpg in this project

    Type of Assemblies 
        single-file assemblies;
        multi file assemblies.

    CTS
        -   cross-language integration.
        -   C# has int Data Type and VB.NET has Integer Data Type.
        -   so after compilation it uses the same structure as Int32 in CTS
    
    CLS 
        -   subset of CTS
        -   ensuring language interoperability.
        -   set of rules and restrictions 
            -   statement end with semicolon
            -   object create with new keyword


















 */ 
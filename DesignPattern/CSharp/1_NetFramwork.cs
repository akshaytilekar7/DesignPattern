/*

.NET
    environment that facilitates Object Oriented Programming Model for multiple languages
    2 component
        CLR (Common Language Runtime) 
        BCL (Base Class Libraries)


    CLR [provides a runtime environment]
        -   A]  GC [manged unused resource]
        -   B]  Code access security 
                [access right and | safe | authenticated ]
        -   C]  IL to machine language
            unsafe casts and un-initialized variables are prevented
        -   locate,load and manage .NET objects on your behalf

        -   source code -> MSIL -> machine code (ar run time)
        -   MAIN TASK ->  to transform the intermediate MSIL code in the executable code at runtime.

        -   Any program, that is compiled into pseudocode MSIL, 
            can be run in any environment, that contains the CLR realization. 
            This provides the programs portability in the .NET Framework environment.

    MISL 
        -   MSIL is an OS and H/W independent
        -   not executable
        -   portable assembly language.

    Type loading
        -   Finds and loads assemblies and types

    BCL
        -   user defined (Assembly) and predefine class library (namespace)
        -   subset of FCL
        -   dealing with string and primitive types, database connection, IO operations.
        -   definition of different primitives, threads, graphic API-interfaces, 
            databases, input/output and so on.

    Assemblies [contain MSIL instruction + metadata + manifest]
        -   small unit of deployment (dll or exe)
        -   dll [reusable and not contain main()] 
            exe [reusable and contain main()]
        -   AT COMPILE TIME METADATA IS CREATED WITH MSIL AND STORED IN A FILE CALLED ASSEMBLY MANIFEST
        -   assembly contains MSIL code and metadata.
        -   Assembly Manifest contains Metadata about .NET Assemblies
        -   primary unit of deployment for .Net application
            which contain the instructions, that are independent of the .NET language, and metadata of types. 
            These instructions are realized on the intermediate language (IL).
        -   assembly is designed to save the namespaces.
            Namespaces contain types.
            The types may be classes, delegates, interfaces, enumerations, structures.

    
    assembly Manifest contains:
        -   AT COMPILE TIME METADATA IS CREATED WITH MSIL AND STORED IN A FILE CALLED ASSEMBLY MANIFEST
        -   info about identity of assembly, including textual name & version no.
        -   about the current version of the assembly;
            about a culture (strings localization, graphic resources);
            a list of references to all external assemblies that are necessary for the proper functioning.
        -   if the assembly is public then it will contain the assembly’s public key.
            It is used to ensure that type exposed by the assembly resides within a unique namespace.
        -   list of other assemblies that the assembly depends upon.
        -   list of all types and resources exposed by the assembly
        -   using ILDasm, you can view the manifest information for any managed DLL.

    two types of Assembly:
        -   Private Assembly 
            -   used in single application
            -   stored in that application's install directory

        -   Shared Assembly 
            -   used by more than one application
            -   add the Assembly to the Global Assembly Cache (GAC)

        -   Satellite Assembly 
            -   only static objects like images and other non-executable files

    see SourceCodeTransformation.jpg in this project

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
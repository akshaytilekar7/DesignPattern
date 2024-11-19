# DesignPattern CSharp

### Aggregation
- one object contains or references another, but both can exist independently. It’s like a partnership rather than ownership.
- The lifetime of the contained object is independent of the containing object

 ### Delegation (Flexible Responsibility Sharing)
- one object hands off (or delegates) a responsibility to another object, which performs the actual task
- Instead of doing everything itself, an object delegates certain behaviours to helper objects, making the system modular and easier to maintain.



### Creational 
 - Focus on object creation mechanisms to ensure flexibility and reuse
 - Decouple instantiation from usage

### Structural
 - Deal with object composition and relationships to build flexible structures
 - Simplify interactions between objects or create scalable structures
 - Rather than extending functionality by creating subclasses (inheritance), object composition (creating complex objects by combining simpler objects) builds functionality by combining and reusing existing objects
 - not like inheritance as this  creates a fixed relationship at compile time
 - composition allows assembling objects dynamically at runtime, making the design more flexible and adaptable.
 - define how objects relate to one another, These relationships are not rigid (like in inheritance) but rely on flexible associations like aggregation (has-a relation [Car has-a Engine]) or delegation.
 - How should objects be composed or related to form a larger structure (static structures)
 - Object composition and relationships
 - Static structure

### Behavioral 
 - Address interaction and responsibility distribution among objects
 - Enable communication and responsibility-sharing between objects
 - Focus on the communication, interaction, and responsibility distribution between objects to implement dynamic behaviour.
 - How should objects communicate and collaborate to achieve a task?"
 - Object interactions and responsibility sharing
 - Dynamic behaviour

 C# Design Patterns
 - Singleton  
 - Repository and unit of work  
 - Factory and Abstract Factory   
 - Strategy  
 - State  
 - Decorator  
 - Chain of responsibility  
 - Lazy load  
 - Builder  
 - Command  
 - Observer  
 - Adapter
 - Command
 - Publisher Subscriber

 C# Important Topics
  - AsyncAwait
  - Finalize and Dispose
  - IEnumerable and List
  - Expressions
  - Passing Parameters with Ref and Out
  - SOLID principles
  - ExceptionHandling
  - IDisposable Best Practices
  - NInject Demo

SQL Important Topics
  - Table value parameter
  - ACID and Transactions



//1 Are strongly-typed functions as parameters possible in TypeScript

type NumberCallback = (n: number) => any;

class User {
    save(callback: NumberCallback): void {
        callback(42);
    }

    myMethod(a: string);
    myMethod(a: number, b: string);
    myMethod(a: number);
    myMethod(a: any, b?: string) {
        alert(a.toString());
    }
}

var numCallback: NumberCallback = (result: number): void => {
    console.log("numCallback: ", result.toString());
}

var foo = new User();
foo.save(numCallback);

//2 function overload (methods and ctor)
// allowed overloads but you can only 
// have one implementation and that implementation 
// must have a signature that is compatible with all overloads

class Foo {
    myMethod(a: string);
    myMethod(a: number);
    myMethod(a: number, b: string);
    myMethod(a: any, b?: string) {
        alert(a.toString());
    }
}


// 2 Explain when to use “declare” keyword in TypeScript or Declare vs. var
// var creates a new variable.
// declare is used to tell TypeScript that the variable has been created elsewhere. 

// If you use declare, nothing is added to the JavaScript that is generated - it is simply a hint to the compiler.

//For example, if you use an external script that defines var externalModule,
//you would use declare var externalModule to hint to the TypeScript compiler that externalModule has already been set up





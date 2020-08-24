using BuilderPattern.Builder;
using BuilderPattern.Director;
using System;

namespace BuilderPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Manufacturer newManufacturer = new Manufacturer();
            // LETS HAVE THE BUILDER CLASS READY
            IPhoneBuilder phoneBuilder = null;

            // NOW LET US CREATE AN ANDROID PHONE
            phoneBuilder = new AndroidPhoneBuilder();
            newManufacturer.ConstructInSequence(phoneBuilder);
            Console.WriteLine(phoneBuilder.Phone);

            Console.WriteLine();
            // NOW LET US CREATE A WINDOWS PHONE
            phoneBuilder = new WindowsPhoneBuilder();
            newManufacturer.ConstructInSequence(phoneBuilder);
            Console.WriteLine(phoneBuilder.Phone);

            Console.ReadKey();
        }
    }
}

// Builder - define construction process for individual part
// Director - takes those individual part, decide sequence
// Product - is final output

/*
 
 Creational pattern
 USE WHEN : construction process is very complex and do we need decoupling
 help us to separate construction of complex object from its representation
 so that same Construction process can create different representation
 
    SEPARATE THE CONSTRUCTION OF A COMPLEX OBJECT FROM ITS REPRESENTATION 
    SO THAT THE SAME CONSTRUCTION PROCESS CAN CREATE DIFFERENT REPRESENTATIONS. 

*/

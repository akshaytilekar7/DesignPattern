using System;
using System.Threading;

namespace DesignPattern
{
    public class DelegatesDemo
    {
        public static DbOperations X = new DbOperations();

        public virtual void Test()
        {

        }

        static void CallbackGetStatus1(int status)
        {
            Console.WriteLine("1 now we are done with adding record with id :" + status);
            Console.WriteLine("1 doing some operations which LEXICAL SCOPE IS WITH THIS CLASS");
        }
        static void CallbackGetStatus2(int status)
        {
            Console.WriteLine("2 now we are done with adding record with id :" + status);
            Console.WriteLine("2 doing some operations which LEXICAL SCOPE IS WITH THIS CLASS");
        }
    }


    public class DbOperations
    {
        public delegate void Sender(int currentStatus);
        // public Sender sender = null;  
        // PROBLEM IS WE CAN SET TO NULL // x.sender = null; to avoid this use event
        public event Sender sender = null;

        public void AddingHugeRecord(int noOfRecords)
        {
            //add
            for (int i = 0; i < noOfRecords; i++)
            {
                Thread.Sleep(3000);
                sender(i);
            }
        }
    }
}

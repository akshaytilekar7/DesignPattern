using System;
using System.Threading;

namespace DesignPattern
{
    public class DelegatesDemo
    {
        public static DbOperations X = new DbOperations();

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

        static void Main1(string[] args)
        {
            DbOperations obj = new DbOperations();
            obj.EventSender += CallbackGetStatus1;
            obj.EventSender += CallbackGetStatus2;
            //obj.EventSender = null; // NOT ALLOWED IN CASE OF EVEnt 

            obj.DelegateSender += CallbackGetStatus1;
            obj.DelegateSender += CallbackGetStatus2;
            obj.DelegateSender = null; // in case of delegate we can set to NULL 

            Thread t = new Thread(new ThreadStart(obj.AddingHugeRecord));
            t.Start();

        }
    }


    public class DbOperations
    {
        public delegate void Sender(int currentStatus);
        public Sender DelegateSender = null;
        // PROBLEM IS WE CAN SET TO NULL // x.sender = null; to avoid this use event
        public event Sender EventSender = null;

        public void AddingHugeRecord()
        {
            //add
            for (int i = 0; i < 5000; i++)
            {
                Thread.Sleep(3000);
                EventSender(i);
            }
        }

    }
}

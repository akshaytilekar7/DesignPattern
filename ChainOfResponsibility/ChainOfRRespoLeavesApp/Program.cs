using ChainOfRespoLeavesApp.ConcreteHandler;
using ChainOfRespoLeavesApp.Interface;
using System;

namespace ChainOfRespoLeavesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NewWay();

            Console.WriteLine();

            OldWay();

            Console.ReadLine();
        }

        private static void NewWay()
        {
            LeaveRequest request = new LeaveRequest { Employee = "john", LeaveDays = 34 };

            var handler = new LeaveRequestBuilder()
                .AddHandler(new Supervisor())
                .AddHandler(new ProjectManager())
                .AddHandler(new Hr())
                .Build();


            handler.HandleRequest(request);
            request.LeaveDays = 14;
            handler.HandleRequest(request);
            request.LeaveDays = 4;
            handler.HandleRequest(request);
        }
        private static void OldWay()
        {
            LeaveRequest request = new LeaveRequest { Employee = "john", LeaveDays = 34 };

            // As you can see this looks so bad manual chaning so builder pattern
            var supervisor = new Supervisor();
            var manager = new ProjectManager();
            var hr = new Hr();

            // set linking supervisor -- manager -- hr // 2
            supervisor.NextHandler = manager;
            manager.NextHandler = hr;

            supervisor.HandleRequest(request);
            request.LeaveDays = 14;
            supervisor.HandleRequest(request);
            request.LeaveDays = 4;
            supervisor.HandleRequest(request);
        }
    }
}

using ChainOfRespoLeavesApp.ConcreteHandler;
using ChainOfRespoLeavesApp.Interface;
using System;

namespace ChainOfRespoLeavesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LeaveRequest request = new LeaveRequest { Employee = "john", LeaveDays = 34 };

            ILeaveRequestHandler supervisor = new Supervisor();
            ILeaveRequestHandler manager = new ProjectManager();
            ILeaveRequestHandler hr = new Hr();


            // set linking supervisor -- manager -- hr // 2
            supervisor.NextHandler = manager;
            manager.NextHandler = hr;

            supervisor.HandleRequest(request);
            request.LeaveDays = 14;
            supervisor.HandleRequest(request);
            request.LeaveDays = 4;
            supervisor.HandleRequest(request);

            Console.ReadLine();
        }
    }
}

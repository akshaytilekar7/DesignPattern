using ChainOfRespoLeavesApp.Interface;
using System;

namespace ChainOfRespoLeavesApp.ConcreteHandler
{
    public class Hr : ILeaveRequestHandler
    {
        public ILeaveRequestHandler NextHandler { get; set; }

        public void HandleRequest(LeaveRequest request)
        {
            if (request.LeaveDays > 30)
            {
                Console.WriteLine("Leave request:- Employee: {0}, Leave days: {1} - approved by HR", request.Employee, request.LeaveDays);
            }
            else
            {
                NextHandler.HandleRequest(request);
            }
        }
    }
}
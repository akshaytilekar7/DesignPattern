using ChainOfRespoLeavesApp.Interface;
using System;

namespace ChainOfRespoLeavesApp.ConcreteHandler
{
    public class Hr : ILeaveRequest
    {
        public ILeaveRequest NextHandler { get; set; }

        public void HandleRequest(LeaveRequest request)
        {
            if (request.LeaveDays > 30)
            {
                Console.WriteLine("Leave request:- Employee: {0}, Leave days: {1} - approved by HR", request.Employee, request.LeaveDays);
                return;
            }
            NextHandler?.HandleRequest(request);
        }
    }
}
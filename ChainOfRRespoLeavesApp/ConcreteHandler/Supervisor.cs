﻿using ChainOfRespoLeavesApp.Interface;
using System;

namespace ChainOfRespoLeavesApp.ConcreteHandler
{
    public class Supervisor : ILeaveRequestHandler
    {
        public ILeaveRequestHandler NextHandler { get; set; }
        public void HandleRequest(LeaveRequest request)
        {
            if (request.LeaveDays <= 10)
                Console.WriteLine("Leave request:- Employee: {0}, Leave days: {1} - approved by supervisor", request.Employee, request.LeaveDays);
            else
                NextHandler.HandleRequest(request);
        }
    }
}
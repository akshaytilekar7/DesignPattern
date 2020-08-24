namespace ChainOfRespoLeavesApp.Interface
{
    public interface ILeaveRequestHandler
    {
        void HandleRequest(LeaveRequest request);
        ILeaveRequestHandler NextHandler { get; set; }
    }
}
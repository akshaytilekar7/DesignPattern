namespace ChainOfRespoLeavesApp.Interface
{
    public interface ILeaveRequest
    {
        void HandleRequest(LeaveRequest request);
        ILeaveRequest NextHandler { get; set; }
    }
}
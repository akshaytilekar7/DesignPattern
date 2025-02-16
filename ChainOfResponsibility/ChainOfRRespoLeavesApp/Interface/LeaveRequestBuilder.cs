
namespace ChainOfRespoLeavesApp.Interface
{
    internal class LeaveRequestBuilder
    {
        private ILeaveRequest head;
        private ILeaveRequest curr;

        public LeaveRequestBuilder AddHandler(ILeaveRequest handler)
        {
            if (head == null)
            {
                head = handler;
                curr = handler;
            }
            else
            {
                curr.NextHandler = handler;
                curr = handler;
            }

            return this; // Fluent interface
        }

        public ILeaveRequest Build()
        {
            return head;
        }
    }
}

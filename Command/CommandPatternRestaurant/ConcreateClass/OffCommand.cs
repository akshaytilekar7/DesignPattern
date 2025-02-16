using CommandPatternRestaurant.Interface;

namespace CommandPatternRestaurant.ConcreateClass
{
    class OffCommand : ICommand
    {
        OnCommand _tvOnCommand;
        public OffCommand(Tv tv)
        {
            _tvOnCommand = new OnCommand(tv);
        }
        public void Execute()
        {
            _tvOnCommand.UnExecute();
        }
        public void UnExecute()
        {
            _tvOnCommand.Execute();
        }
    }
}

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
            _tvOnCommand.Undo();
        }
        public void Undo()
        {
            _tvOnCommand.Execute();
        }
        public void Redo()
        {
            _tvOnCommand.Undo();
        }
    };
}

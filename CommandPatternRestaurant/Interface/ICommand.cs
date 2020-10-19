namespace CommandPatternRestaurant.Interface
{
    public interface ICommand
    {
        void Execute();
        void Undo();
        void Redo();
    };
}

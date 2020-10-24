namespace CommandPatternRestaurant.Interface
{
    public interface ICommand
    {
        void Execute(); // Redo
        void UnExecute(); // Undo
    };
}

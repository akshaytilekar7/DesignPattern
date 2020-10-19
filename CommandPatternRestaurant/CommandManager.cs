using CommandPatternRestaurant.Interface;
using System.Collections.Generic;

namespace CommandPatternRestaurant
{
    class CommandManager
    {
        Stack<ICommand> _undoStack;
        Stack<ICommand> _redoStack;
        public CommandManager()
        {
            _redoStack = new Stack<ICommand>();
            _undoStack = new Stack<ICommand>();
        }
        public void ExecuteCmd(ICommand command)
        {
            command.Execute();
            _undoStack.Push(command);
        }

        public void Undo()
        {
            if (_undoStack.Count <= 0)
                return;

            _undoStack.Peek().Undo();          // undo most recently executed command
            _redoStack.Push(_undoStack.Peek()); // add undone command to undo stack
            _undoStack.Pop();                  // remove top entry from undo stack
        }

        public void Redo()
        {
            if (_redoStack.Count <= 0)
                return;

            _redoStack.Peek().Redo();          // redo most recently executed command
            _undoStack.Push(_redoStack.Peek()); // add undone command to redo stack
            _redoStack.Pop();                  // remove top entry from redo stack
        }
    }
}

using System.Collections.Generic;

namespace CommandPattern
{
    public class ModifyPrice
    {
        public readonly List<ICommand> Commands;
        private ICommand _command;

        public ModifyPrice()
        {
            Commands = new List<ICommand>();
        }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void Invoke()
        {
            Commands.Add(_command);
            _command.ExecuteAction();
        }
    }
}

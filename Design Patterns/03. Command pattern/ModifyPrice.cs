namespace Command_pattern
{
    public class ModifyPrice // Invoker
    {
        private readonly List<ICommand> _commands;
        private ICommand _command;

        public ModifyPrice()
        {
            _commands = new List<ICommand>();
        }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void Invoke()
        {
            _commands.Add(_command);
            _command.Execute();
        }
    }
}

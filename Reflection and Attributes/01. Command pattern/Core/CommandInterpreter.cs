using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args) // receiver
        {
            string[] analyzer = args.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string commandName = analyzer[0];
            string[] commandArgs = new string[analyzer.Length - 1];

            for (int i = 1; i < analyzer.Length; i++)
            {
                commandArgs[i - 1] = analyzer[i];
            }

            Type commandType = Assembly
                .GetEntryAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name.Equals($"{commandName}Command"));

            ICommand command = (ICommand)Activator.CreateInstance(commandType);

            return command.Execute(commandArgs); // invoker
        }
    }
}

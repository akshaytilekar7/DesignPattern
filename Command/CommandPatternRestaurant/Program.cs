using CommandPatternRestaurant.Helper;
using System;

namespace CommandPatternRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Tv tv = new Tv();
            CommandManager commandManager = new CommandManager();
            ActionFactory actionFactory = new ActionFactory(tv);

            commandManager.ExecuteCmd(actionFactory.Get(Status.On));

            commandManager.ExecuteCmd(actionFactory.Get(Status.Switch, 1));

            commandManager.ExecuteCmd(actionFactory.Get(Status.Switch, 2));

            commandManager.ExecuteCmd(actionFactory.Get(Status.Switch, 3));

            Console.WriteLine("current channel: " + tv.GetChannel());
            Console.WriteLine("\t undoing...");
            commandManager.Undo();

            Console.WriteLine("current channel: " + tv.GetChannel());
            Console.WriteLine("\t undoing...");
            commandManager.Undo();

            Console.WriteLine("current channel: " + tv.GetChannel());
            Console.WriteLine("\t redoing...");
            commandManager.Redo();

            Console.WriteLine("current channel: " + tv.GetChannel());
            Console.WriteLine("\t redoing...");
            commandManager.Redo();

            Console.WriteLine("current channel: " + tv.GetChannel());

            var off = actionFactory.Get(Status.Off);
            off.Execute();

            Console.ReadLine();
        }
    }
}

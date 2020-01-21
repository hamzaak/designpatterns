using System;
using System.Collections.Generic;

namespace command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Commands (ON/OFF), to exit press X : ");
            string cmd = Console.ReadLine();

            Light lamp = new Light();
            ICommand switchUp = new FlipUpCommand(lamp);
            ICommand switchDown = new FlipDownCommand(lamp);

            Switch s = new Switch();

            while (cmd != "X")
            {
                switch (cmd)
                {
                    case "ON":
                        s.StoreAndExecute(switchUp);
                        break;
                    case "OFF":
                        s.StoreAndExecute(switchDown);
                        break;
                    default:
                        Console.WriteLine("Command \"ON\" or \"OFF\" or \"X\" is required.");
                        break;
                }
                cmd = Console.ReadLine();
            }
        }
    }

    public interface ICommand
    {
        void Execute();
    }

    public class Switch
    {
        private List<ICommand> _commands = new List<ICommand>();

        public void StoreAndExecute(ICommand command)
        {
            _commands.Add(command);
            command.Execute();
        }
    }

    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("The light is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("The light is off");
        }
    }

    public class FlipUpCommand : ICommand
    {
        private Light _light;
        public FlipUpCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.TurnOn();
        }
    }
    public class FlipDownCommand : ICommand
    {
        private Light _light;
        public FlipDownCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }
}

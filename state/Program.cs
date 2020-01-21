using System;

namespace state
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Bullethit(3);
            player.Bullethit(9);
            player.Bullethit(12);
 
            Console.ReadKey();
        }
    }

    public class Player
    {
        IState currentState;

        public Player()
        {
            this.currentState = new HealthyState();
        }

        public void Bullethit(int bullets)
        {
            Console.WriteLine($"Bullets hits to the player: {bullets}");
            if (bullets < 5)
                this.currentState = new HealthyState();
            if (bullets >= 5 && bullets < 10)
                this.currentState = new HurtState();
            if (bullets >= 10)
                this.currentState = new DeadState();

            currentState.ExecuteCommand(this);
        }
    }
    
    public interface IState
    {
        void ExecuteCommand(Player player);
    }
    
    public class HealthyState : IState
    {
        public void ExecuteCommand(Player player)
        {
            Console.WriteLine("The player is in Healthy State.");
        }
    }
    
    public class HurtState : IState
    {
        public void ExecuteCommand(Player player)
        {
            Console.WriteLine("The player is wounded. Please search health points");
        }
    }
    
    public class DeadState : IState
    {
        public void ExecuteCommand(Player player)
        {
            Console.WriteLine("The player is dead. Game Over.");
        }
    }
}

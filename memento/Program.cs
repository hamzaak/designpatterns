using System;
using System.Threading;

namespace memento
{
    class Program
    {
        static void Main(string[] args)
        {
            // player has completed level 1
            Player player = new Player();
            player.Level = 1;
            player.Score = 100;
            player.Health = "100%";
            Console.WriteLine("----------- Player info after completing level 1 ---------------------");
            player.DisplayPlayerInfo();
            // when player completes any level then create checkpoint for that level.
            CareTaker careTaker = new CareTaker();
            careTaker.LevelMarker = player.CreateMarker(player);

            // sleep is only added to show some delay..
            Thread.Sleep(2000);

            player.Level = 2;
            player.Score = 130;
            player.Health = "80%";
            Console.WriteLine("--------------- Player info in level 2 --------------------------------");
            player.DisplayPlayerInfo();

            // if players loses all the lifeline then restore the game from level 1
            player.RestoreLevel(careTaker.LevelMarker);
            Console.WriteLine("------------- Player info after restoring level 1 data ----------------");
            player.DisplayPlayerInfo();

            Console.ReadKey();
        }
    }

    public class Memento
    {
        public int Level;
        public int Score;
        public string Health;

        public Memento(int level, int score, string health)
        {
            this.Level = level;
            this.Score = score;
            this.Health = health;
        }
    }
    public class CareTaker
    {
        // store a checkpoint for already crossed level
        public Memento LevelMarker;
    }

    public class Player
    {
        public int Level;
        public int Score;
        public string Health;
        public int lifeline = 3;

        public Memento CreateMarker(Player player)
        {
            return new Memento(player.Level, player.Score, player.Health);
        }

        public void RestoreLevel(Memento playerMemento)
        {
            this.Level = playerMemento.Level;
            this.Score = playerMemento.Score;
            this.Health = playerMemento.Health;
            this.lifeline -= 1;
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"Level: {this.Level}");
            Console.WriteLine($"Score: {this.Score}");
            Console.WriteLine($"Health: {this.Health}");
            Console.WriteLine($"Lifeline left: {this.lifeline}");
        }
    }
}

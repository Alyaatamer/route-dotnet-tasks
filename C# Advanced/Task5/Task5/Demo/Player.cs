using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Player
    {

        public string Name { get; set; }
        public string Team { get; set; }

        public Player(string name, string teamName)
        {
            Name = name;
            Team = teamName;
        }

        public override string ToString()
        {
            return $"Player Name : {Name} ::: Player Team : {Team}";
        }

        public void Run(object? sender,LocationEventArgs locationEventArgs)
        {
            Ball? ball = sender as Ball;
            Console.WriteLine($"{this} Run ----------------> {ball},{locationEventArgs.Location}");
        }

    }
}

using System;
using Game.models;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human eric = new Human("Eric,",20,20,20,20);
            Human mitch = new Human("Mitch");
            Console.WriteLine(mitch.Health);
            eric.Attack(mitch);
            Console.WriteLine(mitch.Health);
        }
    }
}

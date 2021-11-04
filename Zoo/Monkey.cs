using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Monkey : Mammal
    {
        public double _height;

        public Monkey() : this("Ingen rank angiven", "Inget namn angivet", "Inget kön angivet", 0, "Ingen föda angivet", "Inget levnadsområde angivet", true, 0) { }

        public Monkey(string Rank, string Type, string Gender, int Age, string Diet, string LivingArea, bool IsWild, double Height) : base(Rank, Type, Gender, Age, Diet, LivingArea, IsWild)
        {
            this._height = Height;
        }

        public override void MakeSound()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Apan låter oooh ook ook ook!\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public virtual void Climb()
        {
            Console.WriteLine("Apan klättrar upp i trädet.");
        }

        public override void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Info för apa");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Rank:\t\t\t {_rank}");
            Console.WriteLine($"Vilt djur:\t\t {_isWild}");
            Console.WriteLine($"Vetenskapligt namn:\t {_sciName}");
            Console.WriteLine($"Kön:\t\t\t {_gender}");
            Console.WriteLine($"Ålder:\t\t\t {_age}");
            Console.WriteLine($"Föda:\t\t\t { _diet}");
            Console.WriteLine($"Levnadsområde:\t\t { _livingArea}");
            Console.WriteLine($"Höjd:\t\t\t {_height} meter");
        }
    }
}

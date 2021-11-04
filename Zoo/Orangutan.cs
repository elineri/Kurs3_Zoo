using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Orangutan : Monkey
    {
        public int _numOfSpecies = 0;

        public Orangutan() : this("Ingen rank angiven", "Inget namn angivet", "Inget kön angivet", 0, "Ingen föda angivet", "Inget levnadsområde angivet", true, 0, 0) { }

        public Orangutan(string Rank, string Type, string Gender, int Age, string Diet, string LivingArea, bool IsWild, double Height, int NumOfSpecies) : base(Rank, Type, Gender, Age, Diet, LivingArea, IsWild, Height)
        {
            this._numOfSpecies = NumOfSpecies;
        }

        public override void MakeSound()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Orangutangen låter oooh ook ook ook!\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public override void Climb()
        {
            Console.WriteLine("Orangutangen klättrar upp i trädet.");
        }

        public override void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Info för orangutang");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Vetenskapligt namn:\t {_sciName}");
            Console.WriteLine($"Kön:\t\t\t {_gender}");
            Console.WriteLine($"Ålder:\t\t\t {_age}");
            Console.WriteLine($"Föda:\t\t\t { _diet}");
            Console.WriteLine($"Levnadsområde:\t\t { _livingArea}");
            Console.WriteLine($"Höjd:\t\t\t {_height} meter");
            Console.WriteLine($"Antal arter:\t\t {_numOfSpecies}");
        }
    }
}

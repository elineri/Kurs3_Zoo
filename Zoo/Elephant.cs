using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Elephant : Mammal
    {
        public double _weight;

        public Elephant() : this("Ingen rank angiven", "Inget namn angivet", "Inget kön angivet", 0, "Ingen föda angivet", "Inget levnadsområde angivet", true, 0) { }

        public Elephant(string Rank, string SciName, string Gender, int Age, string Diet, string LivingArea, bool IsWild, double Weight) : base(Rank, SciName, Gender, Age, Diet, LivingArea, IsWild)
        {
            this._weight = Weight;
        }

        public override void MakeSound()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Elefanten låter bahruuuuuuhhhhaaaaa!\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void Jump()
        {
            Console.WriteLine("Elefanten försöker hoppa men det går inte...");
        }

        public override void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Info för Elefant");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Rank:\t\t\t {_rank}");
            Console.WriteLine($"Vilt djur:\t\t {_isWild}");
            Console.WriteLine($"Vetenskapligt namn:\t {_sciName}");
            Console.WriteLine($"Kön:\t\t\t {_gender}");
            Console.WriteLine($"Ålder:\t\t\t {_age}");
            Console.WriteLine($"Föda:\t\t\t { _diet}");
            Console.WriteLine($"Levnadsområde:\t\t { _livingArea}");
            Console.WriteLine($"Vikt:\t\t\t {_weight} kg");
        }
    }
}

// Elin Ericstam SUT21

using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Cow : Mammal
    {
        public string _colour;

        public Cow() : this("Ingen rank angiven", "Inget namn angivet", "Inget kön angivet", 0, "Ingen föda angivet", "Inget levnadsområde angivet", false, "Ingen färg angivet") { }

        public Cow(string Rank, string SciName, string Gender, int Age, string Diet, string LivingArea, bool IsWild, string Colour) 
                   : base(Rank, SciName, Gender, Age, Diet, LivingArea, IsWild)
        {
            this._colour = Colour;
        }

        public override void MakeSound()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Kon låter muuuuu...\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void LieDown()
        {
            Console.WriteLine("Kon lägger sig ner i gräset.");
        }

        public override void Eat()
        {
            Console.WriteLine("Kon äter " + _diet);
        }

        public override void Sleep()
        {
            Console.WriteLine("Kon sover\n");
        }

        public override void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Info för Ko");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Rank:\t\t\t {_rank}");
            Console.WriteLine($"Vilt djur:\t\t {_isWild}");
            Console.WriteLine($"Vetenskapligt namn:\t {_sciName}");
            Console.WriteLine($"Kön:\t\t\t {_gender}");
            Console.WriteLine($"Ålder:\t\t\t {_age}");
            Console.WriteLine($"Föda:\t\t\t { _diet}");
            Console.WriteLine($"Levnadsområde:\t\t { _livingArea}");
            Console.WriteLine($"Färg:\t\t\t {_colour}");
        }
    }
}

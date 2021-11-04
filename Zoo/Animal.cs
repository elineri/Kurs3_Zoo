using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Animal : Organism
    {
        public string _sciName;
        public string _gender;
        public int _age;
        public string _diet;
        public string _livingArea;

        public Animal() : this("Ingen rank angivet", "Inget namn angivet", "Inget kön angivet", 0, "Ingen föda angivet", "Inget levnadsområde angivet") { }

        public Animal(string Rank, string SciName, string Gender, int Age, string Diet, string LivingArea) : base (Rank)
        {
            this._sciName = SciName;
            this._gender = Gender;
            this._age = Age;
            this._diet = Diet;
            this._livingArea = LivingArea;
        }

        public virtual void MakeSound()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Djuret låter!\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void Eat()
        {
            Console.WriteLine("Djuret äter.\n");
        }

        public void Sleep()
        {
            Console.WriteLine("Djuret sover\n");
        }

        public virtual void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Info för Djur");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Vetenskapligt namn:\t {_sciName}");
            Console.WriteLine($"Kön:\t\t\t {_gender}");
            Console.WriteLine($"Ålder:\t\t\t {_age}");
            Console.WriteLine($"Föda:\t\t\t { _diet}");
            Console.WriteLine($"Levnadsområde:\t\t { _livingArea}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Mammal : Animal
    {
        public bool _isWild;

        public Mammal() : this("Ingen rank angivet", "Inget namn angivet", "Inget kön angivet", 0, "Ingen föda angivet", "Inget levnadsområde angivet", true) { }

        public Mammal(string Rank, string SciName, string Gender, int Age, string Diet, string LivingArea, bool IsWild) : base (Rank, SciName, Gender, Age, Diet, LivingArea)
        {
            this._isWild = IsWild;
        }
    }
}

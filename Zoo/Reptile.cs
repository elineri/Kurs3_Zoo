using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Reptile : Animal
    {
        public bool _hasLegs;
        public Reptile() : this("Ingen rank angivet", "Inget namn angivet", "Inget kön angivet", 0, "Ingen föda angivet", "Inget levnadsområde angivet", true) { }

        public Reptile(string Rank, string SciName, string Gender, int Age, string Diet, string LivingArea, bool HasLegs) : base(Rank, SciName, Gender, Age, Diet, LivingArea)
        {
            this._hasLegs = HasLegs;
        }
    }
}

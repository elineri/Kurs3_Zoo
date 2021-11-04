using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Plant : Organism
    {
        public bool _hasFlowers;

        public Plant() : this("Ingen rank angivet", false){ }

        public Plant(string Rank, bool HasFlowers) : base (Rank)
        {
            this._hasFlowers = HasFlowers;
        }
    }
}

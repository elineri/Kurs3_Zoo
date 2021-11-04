using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Plant : Organism
    {
        public bool _hasFlowers;

        public Plant() : this("No rank given", false){ }

        public Plant(string Rank, bool HasFlowers) : base (Rank)
        {
            this._hasFlowers = HasFlowers;
        }
    }
}

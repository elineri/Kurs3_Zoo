using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Organism
    {
        public string _rank;

        public Organism() : this("No rank given") { }

        public Organism(string Rank)
        {
            this._rank = Rank;
        }
    }
}

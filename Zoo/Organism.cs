﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Organism
    {
        public string _rank;

        public Organism() : this("Ingen rank angivet") { }

        public Organism(string Rank)
        {
            this._rank = Rank;
        }
    }
}

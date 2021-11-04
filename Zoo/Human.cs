// Elin Ericstam SUT21

using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Human : Mammal
    {
        public string _firstName;

        public Human() : this("Ingen rank angiven", "Inget namn angivet", "Inget kön angivet", 0, "Ingen föda angivet", "Inget levnadsområde angivet", true, "Ingen förnamn angivet") { }

        public Human(string Rank, string SciName, string Gender, int Age, string Diet, string LivingArea, bool IsWild, string FirstName) : base(Rank, SciName, Gender, Age, Diet, LivingArea, IsWild)
        {
            this._firstName = FirstName;
        }
    }
}

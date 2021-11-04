using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal("Rike", "Animalia", "Hona", 2, "Allätare", "Överallt");
            a1.PrintInfo();

            Elephant e1 = new Elephant("Familj", "Loxodonta", "Hona", 20, "Växtätare", "Savann", true, 5978.25);
            e1.PrintInfo();
            e1.MakeSound();

            Cow c1 = new Cow("Familj","Bos taurus", "Hona", 4, "Gräs", "Bondgård", false, "Brun");
            c1.PrintInfo();
            c1.MakeSound();

            Monkey m1 = new Monkey("Familj", "Cercopithecidae", "Hane", 20, "Växtätare", "Skogar", true, 5978.50);
            m1.PrintInfo();
            m1.Climb();
            m1.MakeSound();

            Gorilla g1 = new Gorilla("Släkte", "Gorilla", "Hane", 20, "Bambuskott och frukt", "Regnskog", true, 1.6, 40);
            g1.PrintInfo();
            g1.Climb();
            g1.MakeSound();

            Orangutan o1 = new Orangutan("Släkte", "Pongo", "Hona", 15, "Frukt och bär", "Regnskog", true, 1.3, 2);
            o1.PrintInfo();
            o1.MakeSound();

            Orangutan o2 = new Orangutan();
            o2.PrintInfo();
        }
    }
}

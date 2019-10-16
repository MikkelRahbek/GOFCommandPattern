using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class CoffeeMaker
    {
        void GrindBean()
        {
            Console.WriteLine("Grinding... ");
        }
        void MakeCoffee()
        {
            Console.WriteLine("Brewing the black gold");
        }
        void FillCup()
        {
            Console.WriteLine("Filling you a little (cup)");
        }
        void FillPitcher()
        {
            Console.WriteLine("Filling you a lot (pitcher)");
        }
        void CleanMachine()
        {
            Console.WriteLine("Cleaning dirty coffee machine");
        }
    }
}

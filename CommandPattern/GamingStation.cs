using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class GamingStation
    {
        public void TurnOnScreen()
        {
            Console.WriteLine("Gamestations' screen has been turned On");
        }
        public void TurnOffScreen()
        {
            Console.WriteLine("Gamestations' screen has been turned Off");
        }
        public void TurnOnChairHeating()
        {
            Console.WriteLine("Gamestations' chair heating has been turned On");
        }
        public void TurnOffCharHeating()
        {
            Console.WriteLine("Gamestations' char heating has been turned Off");
        }
        public void PrepSnacks()
        {
            Console.WriteLine("Gamestations' snacks have been prepped");
        }
        public void CleanUpSnacks()
        {
            Console.WriteLine("Gamestations' snacks have been cleaned up");
        }
        public void TurnOnPC()
        {
            Console.WriteLine("Gamestations' main system has been turned On");
        }
        public void TurnOffPc()
        {
            Console.WriteLine("Gamestations' main system has been turned Off");
        }
    }
}

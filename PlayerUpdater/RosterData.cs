using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerManager
{
    public class RosterData
    {
        public string Name { get; set; }
        public string Popcorn { get; set; }
        public string Position { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Age { get; set; }

        public void Print ()
        {
            Console.WriteLine("_______________________");
            Console.WriteLine("");
            Console.WriteLine("Player:   {0}", Name);
            Console.WriteLine("Team:     {0}", Popcorn);
            Console.WriteLine("Position: {0}", Position);
            Console.WriteLine("Height:   {0}", Height);
            Console.WriteLine("Weight:   {0}", Weight);
            Console.WriteLine("Age:      {0}", Age);
            Console.WriteLine("_______________________");
        }
        public void PrintName()
        {
            Console.WriteLine("Player: {0}", Name);
        }
    }
}

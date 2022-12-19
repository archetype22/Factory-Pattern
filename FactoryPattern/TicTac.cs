using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class TicTac : ISpaceship

    {
        public string Color { get; set; } = "silver";
        public string Glow { get; set; } = "blue";
        public void Fly()
        {
            Console.WriteLine("Building a new spaceship!");
            Console.WriteLine("01101000010011110000010110");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"The spaceship you chose, 'TicTac', is {Color} with a {Glow} glow." );
            Console.WriteLine();
            Console.WriteLine("This spaceship creates blackholes behind it as a method of propulsion! Keep your distance!");
        }

    }
}

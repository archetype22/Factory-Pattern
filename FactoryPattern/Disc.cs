using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Disc : ISpaceship
    {
        public string Color { get; set; } = "gray";
        public string Glow { get; set; } = "green";
        public void Fly()
        {
            Console.WriteLine("Building a new spaceship!");
            Console.WriteLine("0100101110010001011101011");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"The spaceship you chose, 'Disc', is {Color} with a {Glow} glow.");
            Console.WriteLine();
            Console.WriteLine("This spaceship uses the centrifugal force of 100000 Hamsters \n" +
                "running in a wheel as its method of propulsion! Don't worry, it's still fast!");

        }
    }
}

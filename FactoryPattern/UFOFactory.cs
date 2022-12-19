using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class UFOFactory
    {
        public static ISpaceship ChooseShape(string choice) 
        
        {
            switch (choice.ToLower()) 
            {
                case "tictac":
                    return new TicTac();
                case "disc":
                    return new Disc();
                default:
                    Console.WriteLine("Sorry, that shape is not recognized. Surely you meant 'Disc'. Here's a new Spaceship!");
                    return new Disc();
            }
        }
    }
}

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Spaceship Builder 3000!");
            Console.WriteLine("______________________________________");
            Console.WriteLine();
            Console.WriteLine("Please choose your shape, 'TicTac' or 'Disc'.");
            Console.WriteLine();
            var shapeChoice = Console.ReadLine();
            Console.WriteLine();
            ISpaceship ufoInstance = UFOFactory.ChooseShape(shapeChoice);
            ufoInstance.Fly();
        }
    }
}

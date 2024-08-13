namespace EquationSolver
{
    public class UserInteraction
    {
        public void Menu()
        {
            Console.WriteLine("Number of Unknowns: 1-4 possible");
            int input = int.Parse(Console.ReadLine()!);
            Console.ReadKey();
        }
    }
}

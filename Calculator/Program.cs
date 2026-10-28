namespace Calculator;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculator");

        var calculator = new Calculator();

        for (; ; )
        {
            PrintMenu();

            var figure = Console.ReadLine();
            if (!int.TryParse(figure, out var figureID))
            {
                Console.WriteLine("Invalid input");
                continue;
            }

            if (figureID == 0)
            {
                break;
            }

            if (figureID == 1)
            {
                Console.Write("Rectangle side a: ");
                var astr = Console.ReadLine();
                Console.Write("Rectangle side b: ");
                var bstr = Console.ReadLine();
                if (!double.TryParse(astr, out double a) || a <= 0 ||
                    !double.TryParse(bstr, out double b) || b <= 0)
                {
                    Console.WriteLine("Invalid parameters.");
                    continue;
                }

                Console.WriteLine($"Rectangle plot: {calculator.RectanglePlot(a, b):F2}");
            }
            else if (figureID == 2)
            {
                Console.Write("Circle radius: ");
                var rstr = Console.ReadLine();
                if (!double.TryParse(rstr, out double r) || r <= 0)
                {
                    Console.WriteLine("Invalid parameter.");
                    continue;
                }

                Console.WriteLine($"Circle plot: {calculator.CirclePlot(r):F2}");
            }
            else if (figureID == 3)
            {
                Console.Write("Sphere radius: ");
                var rstr = Console.ReadLine();
                if (!double.TryParse(rstr, out double r) || r <= 0)
                {
                    Console.WriteLine("Invalid parameter.");
                    continue;
                }

                Console.WriteLine($"Sphere volume: {calculator.SphereVolume(r):F2}");
            }
            else
            {
                Console.WriteLine("Unknown figure");
            }

            Console.WriteLine();
        }
    }

    static void PrintMenu()
    {
        Console.WriteLine("---------------------");
        Console.WriteLine("Figures:");
        Console.WriteLine("1. Rectangle");
        Console.WriteLine("2. Circle");
        Console.WriteLine("3. Sphere");
        Console.WriteLine("or enter 0 to exit");
        Console.WriteLine();
        Console.Write("Figure ID: ");
    }
}

//Program for Fibonacci sequence modded (summation of three values)

using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInt("Ingrese los términos que desee (mínimo 3): ");
    double a = 0;
    double b = 1;
    double c = 2;
    double summation = 0;
    //show the fibonacci sequence
    Console.Write($"{a,10:N0}{b,10:N0}{c,10:N0}");

    //if the user needs more terms then calculate fibonacci sequence
    for (int i = 3; i < n; i++)
    {
        double d = a + b + c;
        Console.Write($"{d,10:N0}");
        a = b;
        b = c;
        c = d;
        summation += d;
    }
    Console.WriteLine("");
    Console.WriteLine($"La sumatoria de la serie fibonacci es: {summation + 3}");

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?....: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Gracias por usar el programa! Game Over :)");
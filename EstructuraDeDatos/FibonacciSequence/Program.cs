//Program for Fibonacci sequence summation

using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInt("Ingrese los términos que desee: ");
    double a = 0;
    double b = 1;
    double summation = 0;
    //show the fibonacci sequence
    Console.Write($"{a:N0}\t{b:N0}\t");

    //if the user needs more terms then calculate fibonacci sequence
    for (int i = 2; i <= n; i++)
    {
        double c = a + b;
        Console.Write($"{c:N0}\t");
        a = b;
        b = c;
        summation += c;
    }
    Console.WriteLine("");
    Console.WriteLine($"La sumatoria de la serie fibonacci es: {summation + 1}");



    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?....: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Gracias por usar el programa! Game Over :)");
//program for taylor series calculation
using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var number = ConsoleExtension.GetInt("¿Cuántos términos desea?: ");
    var xvalue = ConsoleExtension.GetDouble("Digite el valor de x: ");
    var taylor = TaylorSequence(number, xvalue);

    Console.WriteLine($"f({xvalue}) = {taylor:N6}");
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?....: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Gracias por usar el programa! Game Over :)");

double TaylorSequence(int number, double xvalue)
{
    double summation = 0;
    for (int i = 0; i < number; i++)
    {
        summation += Math.Pow(xvalue, i) / MyMath.Factorial(i);
    }
    return summation;
}




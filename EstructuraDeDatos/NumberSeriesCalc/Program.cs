//program for number series summation and average value calculation
using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var numbersRequested = ConsoleExtension.GetInt("¿Cuántos números desea?: ");
    int summation = 0;
    float average = 0;
    for (int i = 1; i <= numbersRequested; i++)
    {
        Console.Write($"{i}\t"); // \t serves as tabulator to separate (visually) the strings.
        summation += i;
        
    }
    Console.WriteLine("");
    Console.WriteLine($"La suma de todos estos números es: {summation,20:N0}");
    average = summation / numbersRequested;
    Console.WriteLine($"Y el promedio es: {average,20:N0}");

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?....: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Gracias por usar el programa! Game Over :)");


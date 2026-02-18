using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar? [S]i, [N]o: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
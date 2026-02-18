/*
 If the client buys less than 5 units, he gets 10% discount.
 If the units bought are higher or equal to 5 but less than 10, the client gets 20% discount
 If the units bought is higher than 10, the client gets a 40% discount
 */
using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var desktopUnits = ConsoleExtension.GetInt("Número de escritorios: ");
    //decimal unitPrice = 650000; wrong, we need to have a float variable for discount, just initialized
    //var finalPrice = (decimal)desktopUnits * unitPrice;

    //lets do a method to get the value to pay in a better way
    var valueToPay = CalculateValue(desktopUnits);
    
    

    //cut the if statements we had to put them in the CalculateValue method
    
    //Show value to pay with the returned value from the CalculateValue() method
    Console.WriteLine($"El valor a pagar es: {valueToPay:C2}");


    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar? [S]i, [N]o: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

object CalculateValue(int desktopUnits)
{
    float discount;

    if (desktopUnits < 0)
    {
        Console.WriteLine("Número de escritorios inválido! debe ingresar 1 o más escritorios. Intente de nuevo.");
    }

    if (desktopUnits < 5)
    {
        //for representing percentages, specially with a float value, we have to do 0.1f (f stands for float)
        discount = 0.1f;
    }
    else if (desktopUnits < 10)
    {
        discount = 0.2f;
    }
    else //if (desktopUnits >= 10) don´t need this because the last condition remaining it´s more than 10 
    {
        discount = 0.4f;
    }

    //calculate final value to pay here, REMEMBER TO CAST VALUES
    return (decimal)desktopUnits * 650000M * (decimal)(1 - discount);
}

Console.WriteLine("Gracias por usar el programa! Game Over :)");
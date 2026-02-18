//Get student registration value with its credits and stratum.
using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var credits = ConsoleExtension.GetInt("Número de créditos: ");
    var creditValue = ConsoleExtension.GetDecimal("Valor de crédito: "); //REMEMBER: all values that represent money are defined with DECIMALS.
    var stratum = ConsoleExtension.GetInt("Estrato del estudiante: ");

    var registrationValue = RegistrationCalculation(credits, creditValue, stratum);
    var sudsidyValue = SubsidyCalculation(stratum);

    Console.WriteLine($"El costo de la matricula es: {registrationValue:C2}");
    Console.WriteLine($"El valor del subsidio es: {sudsidyValue:C2}");

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar? [S]i, [N]o: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

decimal RegistrationCalculation(int credits, decimal creditValue, int stratum)
{
    decimal value;

    if(credits <= 20) //if they take less than 20 credits, they get charged the normal value
    {
        value = credits * creditValue;
    }
    else //if they take more than 20 credits, they get their extra credits payed the double of their normal value
    {
        value = 20 * creditValue + (credits - 20) * creditValue * 2;
    }

    if (stratum == 1)
    {
        return value * 0.2m; //remember to cast
    } 

    //else if isnt neccessary because the ifs end in return, and if they are already returning a value, it would be nonsense if we made 
    if (stratum == 2)
    {
        return value * 0.5m;
    }
    
    if  (stratum == 3)
    {
        return value * 0.7m;
    }

    return value;
}

decimal SubsidyCalculation(int stratum)
{
    if (stratum == 1)
    {
        return 200000m;
    }

    if (stratum == 2)
    {
        return 100000m;
    }

    return 0;
}

Console.WriteLine("Gracias por usar el programa! Game Over :)");

//VOLVER A HACER ESTE EJERCICIO, TENGO QUE HACERLO POR MI MISMO.
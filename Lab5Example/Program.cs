// See https://aka.ms/new-console-template for more information

using Lab5Example;

Console.WriteLine("Hello, World!");

Console.WriteLine("Input number's month: ");

var month = Console.ReadLine();
try
{
    if (int.TryParse(month, out var number))
    {
        if (number < 1 || number > 12)
        {
            throw new InvalidMontExeption(number);
        }

        Console.WriteLine(new DateTime(2024, number, 2).ToString("dd.MM.yyyy"));
    }
    else
    {
        throw new Exception();
    }
}
catch (InvalidMontExeption ex)
{
    Console.WriteLine(ex.Message);
    return;
}
catch (Exception ex)
{
    Console.WriteLine("Undefined exeption");
    Console.WriteLine(ex.Message);
    return;
}

Console.WriteLine("End fdsfdsfsdfof program");




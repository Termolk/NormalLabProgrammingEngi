// See https://aka.ms/new-console-template for more information

using FourthPractice;

Console.WriteLine("Hello, World!");
Console.WriteLine("Ты торопишься? 1/0");
if (bool.TryParse(Console.ReadLine(), out var result))
{
    GoToUniversityBase goToUniv;

    if (result)
        goToUniv = new GoInRush();
    else
        goToUniv = new GoCalm();

    Console.WriteLine(goToUniv.BrushTeeth());
    Console.WriteLine(goToUniv.GoToMetro());
    Console.WriteLine(goToUniv.UseMetro());
    Console.WriteLine(goToUniv.GoFromMetro());
}
using Lab5Practice;

Console.WriteLine("Enter message:");
var message = Console.ReadLine();

Console.WriteLine("Enter Bad Word:");
var badWord = Console.ReadLine();
try
{
    if (message.Contains(badWord))
    {
        throw new BadErrorFinded("Bad word in message");
    }
}
catch (BadErrorFinded e)
{
    Console.WriteLine($"Внимание всем модератороам! {e.Message}");
}
finally
{
    Console.WriteLine(message);
}


/*
 * OUTPUT
   Enter message:
   Hello peach!
   Enter Bad Word:
   peach
   Внимание всем модератороам! Bad word in message
   Hello peach!
   
 */
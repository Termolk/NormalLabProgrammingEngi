namespace Lab6Practice;

public class StateCheckVisitor : IVisitor
{
    public void Visit(IComponent component)
    {
        try
        {
            if (component.GetState() == 0)
                Console.WriteLine("тревога!");
        }
        catch (Exception)
        {
            Console.WriteLine("тревога!");
        }
    }
}
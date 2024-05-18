namespace Lab6Practice;

public class ComponentA : IComponent
{
    public int GetState() => 1;

    public void Accept(IVisitor visitor) => visitor.Visit(this);
}
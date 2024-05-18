namespace Lab6Practice;

public class ComponentB : IComponent
{
    public int GetState() => 0;
    
    public void Accept(IVisitor visitor) => visitor.Visit(this);
}
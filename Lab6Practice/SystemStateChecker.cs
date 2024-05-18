namespace Lab6Practice;

public class SystemStateChecker
{
    private readonly List<IVisitable> _components;

    public SystemStateChecker()
    {
        _components = new List<IVisitable>
        {
            new ComponentA(),
            new ComponentB(),
        };
    }

    public void CheckState()
    {
        var visitor = new StateCheckVisitor();

        foreach (var component in _components)
        {
            component.Accept(visitor);
        }
    }
}
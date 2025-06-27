using nary_node1;

namespace node1;

public class NaryNodePrintVisitor<T> : IVisitor<NaryNode<T>>
{
    private readonly int _level = 0;
    public string NodeDisplay { get; private set; } = "";

    public NaryNodePrintVisitor(int level)
    {
        _level = level;
    }

    public void Visit(NaryNode<T> objectToVisit)
    {
        if (objectToVisit != null)
        {
            NodeDisplay = $"{new string(' ', _level)}{objectToVisit.Value}:\n";
        }
        else
        {
            NodeDisplay = $"\n";
        }
    }
}
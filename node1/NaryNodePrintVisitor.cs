using nary_node1;

namespace node1;

public class NaryNodePrintVisitor<T> : IVisitor<NaryNode<T>>
{
    public int Level { get; set; }
    public string NodeDisplay { get; private set; } = "";

    public NaryNodePrintVisitor(int level)
    {
        Level = level;
    }

    public NaryNodePrintVisitor()
    {
        
    }

    public void Visit(NaryNode<T> objectToVisit)
    {
        if (objectToVisit != null)
        {
            NodeDisplay = $"{new string(' ', Level)}{objectToVisit.Value}:\n";
        }
        else
        {
            NodeDisplay = $"\n";
        }
    }
}
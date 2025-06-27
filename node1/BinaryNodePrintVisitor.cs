using binary_node1;

namespace node1;

public class BinaryNodePrintVisitor<T> : IVisitor<BinaryNode<T>>
{
    private readonly int _level = 0;
    public string NodeDisplay { get; private set; } = "";

    public BinaryNodePrintVisitor(int level)
    {
        this._level = level;
    }

    public void Visit(BinaryNode<T>? objectToVisit)
    {
        if (objectToVisit != null)
        {
            NodeDisplay = $"{new string(' ', _level)}{objectToVisit.Value}:\n";
        }
        else
        {
            NodeDisplay = $"{new string(' ', _level)}None\n";
        }
    }
}
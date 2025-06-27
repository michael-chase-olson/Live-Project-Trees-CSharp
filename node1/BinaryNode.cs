using System.Text;
using node1;

namespace binary_node1;

public class BinaryNode<T>
{
    private BinaryNodePrintVisitor<T> _visitor;
    public T Value { get; set; } = default!;
    public BinaryNode<T>? LeftChild { get; private set; } = null;
    public BinaryNode<T>? RightChild { get; private set; } = null;

    public void AddLeft(BinaryNode<T> value)
    {
        LeftChild = value;
    }

    public void AddRight(BinaryNode<T> value)
    {
        RightChild = value;
    }

    override public string ToString()
    {
        return ToString(0, this);
    }

    private string ToString(int level, BinaryNode<T>? node)
    {
        _visitor = new BinaryNodePrintVisitor<T>(level);
        var sb = new StringBuilder();
        _visitor.Visit(node);
        sb.Append(_visitor.NodeDisplay);
        
        if (node == null || node.LeftChild == null && node.RightChild == null)
        {
            return sb.ToString();
        }
        
        sb.Append(ToString(level + 1, node.LeftChild));
        sb.Append(ToString(level + 1, node.RightChild));

        return sb.ToString();
    }
}
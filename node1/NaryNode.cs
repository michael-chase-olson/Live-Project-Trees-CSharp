using System.Text;
using node1;

namespace nary_node1;

public class NaryNode<T>
{
    public T Value { get; set; } = default!;
    public ICollection<NaryNode<T>> Children { get; set; } = new List<NaryNode<T>>();

    public void AddChild(NaryNode<T> child)
    {
        Children.Add(child);
    }

    public void AddChildren(ICollection<NaryNode<T>> childrenToAdd)
    {
        foreach (var child in childrenToAdd)
        {
            AddChild(child);
        }
    }

    public override string ToString()
    {
        return ToString(0, this);
    }

    private string ToString(int level, NaryNode<T> node)
    {
        var visitor = new NaryNodePrintVisitor<T>(level);
        var sb = new StringBuilder();
        visitor.Visit(node);
        sb.Append(visitor.NodeDisplay);

        foreach (var child in node.Children)
        {
            sb.Append(ToString(level + 1, child));
        }
        
        return sb.ToString();
    }
}
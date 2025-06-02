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
        return $"{Value}: {string.Join(" ", Children.Select(i => i.Value))}";
    }
}
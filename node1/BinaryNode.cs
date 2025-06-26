namespace binary_node1;

public class BinaryNode<T>
{
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

    public override string ToString()
    {
        return $"{Value}: {LeftChild?.Value?.ToString() ?? "null"} {RightChild?.Value?.ToString() ?? "null"}";
    }
}
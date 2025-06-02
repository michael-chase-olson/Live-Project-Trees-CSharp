namespace binary_node1;

public class BinaryNode<T>
{
    public T Value { get; set; } = default!;
    public BinaryNode<T>? LeftChild { get; set; } = null;
    public BinaryNode<T>? RightChild { get; set; } = null;

    public void AddLeft(T value)
    {
        LeftChild = new BinaryNode<T> { Value = value };
    }

    public void AddRight(T value)
    {
        RightChild = new BinaryNode<T> { Value = value };
    }

    public override string ToString()
    {
        return $"{Value}: {LeftChild?.Value?.ToString() ?? "null"} {RightChild?.Value?.ToString() ?? "null"}";
    }
}
namespace node1;

public interface IVisitor<in T> where T : new()
{
    void Visit(T objectToVisit);
}
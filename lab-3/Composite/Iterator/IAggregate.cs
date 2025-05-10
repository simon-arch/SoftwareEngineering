namespace Composite.Iterator
{
    public interface IAggregate<T>
    {
        IIterator<T> GetIterator(Func<T, IIterator<T>> iterator);
    }
}

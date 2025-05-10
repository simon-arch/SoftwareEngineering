namespace Composite.Iterator
{
    public interface IIterator<T>
    {
        bool MoveNext();
        T? Current { get; }
        void Reset();
    }
}

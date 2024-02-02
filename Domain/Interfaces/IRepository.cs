namespace Domain.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T item);
        T Edit(T item);
        void Delete(T item);
    }
}

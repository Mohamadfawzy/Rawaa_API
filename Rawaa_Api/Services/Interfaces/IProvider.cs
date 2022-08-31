
namespace Rawaa_Api.Services.Interfaces
{
    public interface IProvider<T> where T : class 
    {
        IList<T> List();
        T Find(int id);
        T Add(T entity);
        void Update(int id, T entity);
        void Delete(int id);
        List<T> Search(string term);
    }
}

using TejisApi.Models;

namespace TejisApi.Services;

public interface IService<T> where T : Entity
{
    List<T> Get();
    T Get(string Id);
    T Create(T entity);
    void Update(string Id, T entity);
    void Delete(string Id);
}

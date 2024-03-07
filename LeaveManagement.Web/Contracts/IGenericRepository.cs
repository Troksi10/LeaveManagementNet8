namespace LeaveManagement.Web.Contracts
{
    public interface IGenericRepository<T>
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task<bool> Exists(int id);
        Task<T> DeleteAsync(int id);
        Task<T> UpdateAsync(T entity);
        
    }
}

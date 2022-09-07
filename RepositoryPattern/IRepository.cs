using School.ClassLibrary.Models;

namespace School.School.API.RepositoryPattern
{
    public interface IRepository<T>
    {
        Task<T> GetSingleStudent(int id);
        Task<IEnumerable<T>> GetAllStudentsAsync();
        Task <T> UpdateStudent(int id, T entity);
        Task<T> DeleteStudentAsync(int id);
        Task<T> CreateStudent(T entity);
    }
}

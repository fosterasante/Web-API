using School.ClassLibrary.Models;
using School.School.API.RepositoryPattern;

namespace School.API.RepositoryPattern
{
    public class StaffRepository : IRepository<Staff>
    {
        public Task<Staff> CreateStudent(Staff entity)
        {
            throw new NotImplementedException();
        }

        public Task<Staff> DeleteStudentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Staff>> GetAllStudentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Staff> GetSingleStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Staff> UpdateStudent(int id, Staff entity)
        {
            throw new NotImplementedException();
        }
    }
}

using School.School.API.RepositoryPattern;

namespace School.API.RepositoryPattern
{
    public class AdminRepository : IRepository<AdminRepository>
    {
        public Task<AdminRepository> CreateStudent(AdminRepository entity)
        {
            throw new NotImplementedException();
        }

        public Task<AdminRepository> DeleteStudentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AdminRepository>> GetAllStudentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AdminRepository> GetSingleStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AdminRepository> UpdateStudent(int id, AdminRepository entity)
        {
            throw new NotImplementedException();
        }
    }
}
